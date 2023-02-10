using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System.IO.Ports;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using Tool;

namespace UnityOpenCVGame
{
    public partial class Form1 : Form
    {
        #region Udp Variables
        private static bool isSendingData = false;
        UdpManager udpManager;
        #endregion

        #region Image Processing Variables
        private VideoCapture videoCapture = null;
        private Image<Bgr, byte> currentFrame = null;
        private readonly Mat frame = new Mat();

        private int hMin, hMax, sMin, sMax, vMin, vMax;
        #endregion

        public int frameR = 100;    // Frame Reduction

        //#region Acceleration Measurement Variables
        //private Thread measureAccelerationThread;
        //private bool measureAccel;
        //private string currentWeaTest;
        //private string previousWeaTest;
        //private string positionTest;
        //private string velocityWeaTest;
        //private int deltaTime;
        //#endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTrackBars();
            InitializeButtons();
            //currentWeaTest = "0";
            //previousWeaTest = "0";
        }
        private void InitializeButtons()
        {
            buttonCaptureCamera.Enabled = true;
            buttonStartSendingData.Enabled = false;
        }

        #region Udp
        private void buttonStartSendingData_Click(object sender, EventArgs e)
        {
            if(!isSendingData)
            {
                isSendingData = true;
                udpManager = new UdpManager();
                udpManager.Start();
                buttonStartSendingData.Text = "Stop Data Transmission";
            }
            else if(isSendingData)
            {
                isSendingData = false;
                buttonStartSendingData.Text = "Start Data Transmission";
                udpManager.Close();
            }
        }
        #endregion

        //private void MeasureAcceleration()
        //{
        //    while(measureAccel)
        //    {
        //        int deltaTime = 100;
        //        currentWeaTest = positionTest;
        //        Console.WriteLine($"Current: {currentWeaTest} \t Previous: {previousWeaTest}");
        //        velocityWeaTest = ((Convert.ToDouble(currentWeaTest) - Convert.ToDouble(previousWeaTest)) / 0.1f).ToString();
        //        Thread.Sleep(deltaTime);
        //        previousWeaTest = currentWeaTest;
        //    }
        //}

        #region Image Processing
        private void buttonCaptureCamera_Click(object sender, EventArgs e)
        {
            videoCapture = new VideoCapture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
            buttonCaptureCamera.Enabled = false;
            buttonStartSendingData.Enabled = true;

            //measureAccelerationThread = new Thread(new ThreadStart(MeasureAcceleration));
            //measureAccel = true;
            //measureAccelerationThread.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                /* 
                 * Remember! Frame is not resized, but currentFrame is.
                 */

                // Step 1: Video Capture
                videoCapture.Retrieve(frame);
                currentFrame = frame.ToImage<Bgr, byte>();

                // Step 2: Image Processing

                // Hsv Image
                Mat hsvImage = new Mat();
                CvInvoke.CvtColor(frame, hsvImage, ColorConversion.Bgr2Hsv);

                // Mask Image
                Hsv lowerLimit = new Hsv(hMin, sMin, vMin);
                Hsv upperLimit = new Hsv(hMax, sMax, vMax);

                Mat maskImage = new Mat();
                CvInvoke.InRange(hsvImage, new ScalarArray(lowerLimit.MCvScalar), new ScalarArray(upperLimit.MCvScalar), maskImage);

                // Color Image (Bitwise and)
                Mat colorImage = new Mat();
                CvInvoke.BitwiseAnd(frame, frame, colorImage, maskImage);

                // Blur Image
                Mat medianImage = new Mat();
                CvInvoke.MedianBlur(colorImage, medianImage, 15);

                // Result Image (Countour Detection)
                Mat resultImage = frame;
                CvInvoke.CvtColor(medianImage, medianImage, ColorConversion.Bgr2Gray);
                GetContours(medianImage, resultImage);

                //CvInvoke.PutText(resultImage, $"(Current Wea: {currentWeaTest})", new Point(10, 70), FontFace.HersheyPlain, 1.3f, new Bgr(255, 0, 250).MCvScalar, 2);
                //CvInvoke.PutText(resultImage, $"(Previous Wea: {previousWeaTest})", new Point(10, 100), FontFace.HersheyPlain, 1.3f, new Bgr(255, 0, 250).MCvScalar, 2);
                //CvInvoke.PutText(resultImage, $"(Velocity Wea: {velocityWeaTest})", new Point(10, 130), FontFace.HersheyPlain, 1.3f, new Bgr(255, 0, 250).MCvScalar, 2);

                //CvInvoke.Rectangle(resultImage, new Rectangle(frameR/2, frameR/2, pictureBoxCapture.Width - frameR, pictureBoxCapture.Height - frameR), new Bgr(255, 0, 0).MCvScalar, 3, LineType.FourConnected);

                // Step n: Video Rendering
                pictureBoxCapture.Image = resultImage.ToImage<Bgr, byte>().Resize(pictureBoxCapture.Width, pictureBoxCapture.Height, Inter.Cubic).ToBitmap();
                pictureBoxMask.Image = colorImage.ToImage<Bgr, byte>().Resize(pictureBoxMask.Width, pictureBoxMask.Height, Inter.Cubic).ToBitmap();
                pictureBoxMedianBlur.Image = medianImage.ToImage<Bgr, byte>().Resize(pictureBoxMedianBlur.Width, pictureBoxMedianBlur.Height, Inter.Cubic).ToBitmap();
            }

            if (currentFrame != null) currentFrame.Dispose();
        }

        private void GetContours(Mat srcImage, Mat dstImage, bool drawAllContours = false)
        {
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hierachy = new Mat();

            CvInvoke.FindContours(srcImage, contours, hierachy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            if (drawAllContours)
            {
                // Use this if you want to draw all contours
                CvInvoke.DrawContours(dstImage, contours, -1, new Bgr(255, 0, 255).MCvScalar, 3);
                return;
            }

            // I was assuming that there will be only one rect. That's dangerous!!!! But I don't care.

            Dictionary<int, double> dict = new Dictionary<int, double>();

            if (contours.Size > 0)
            {
                for (int i = 0; i < contours.Size; i++)
                {
                    double area = CvInvoke.ContourArea(contours[i]);
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);

                    // Filter areas by size
                    if (area > 200)
                    {
                        dict.Add(i, area);
                    }

                    //Console.WriteLine($"Area #{i}: {area}");
                }
            }

            CvInvoke.PutText(dstImage, $"(Total Areas Found: {dict.Count})", new Point(10, 30), FontFace.HersheyPlain, 1.5f, new Bgr(0, 0, 250).MCvScalar, 2);

            //// Choose the largest Item do draw
            var items = dict.OrderByDescending(v => v.Value)?.Take(1);
            List<Rectangle> anglePoints = new List<Rectangle>();

            foreach (var it in items)
            {
                int key = int.Parse(it.Key.ToString()); // int key = it.key?
                CvInvoke.DrawContours(dstImage, contours, key, new Bgr(255, 0, 255).MCvScalar, 3);

                Rectangle rect = CvInvoke.BoundingRectangle(contours[key]);
                CvInvoke.Rectangle(dstImage, rect, new Bgr(0, 255, 0).MCvScalar, 2);

                int rectCenterX = (int)(rect.X + (rect.Width / 2.0));
                int rectCenterY = (int)(rect.Y + (rect.Height / 2.0));
                //int areaSize = contours[key].Size;

                //Size and Position
                CvInvoke.PutText(dstImage, $"Area Size: {contours[key].Size}", new Point(rectCenterX, rectCenterY - 20), FontFace.HersheyPlain, 1.3f, new Bgr(0, 255, 0).MCvScalar, 2);
                CvInvoke.PutText(dstImage, $"Position :({rectCenterX}, {rectCenterY})", new Point(rectCenterX, rectCenterY), FontFace.HersheyPlain, 1.3f, new Bgr(0, 255, 0).MCvScalar, 2);

                //positionTest = rectCenterX.ToString();
                // Store the information to be send
                if(isSendingData)
                    udpManager.SetData($"{rectCenterX};{rectCenterY}");


            }
        }
        #endregion

        #region Trackbars
        private void InitializeTrackBars()
        {
            trackBarHueMin.Value = 0;
            hMin = trackBarHueMin.Value;
            labelHueMinVal.Text = trackBarHueMin.Value.ToString();

            trackBarHueMax.Value = 179;
            hMax = trackBarHueMax.Value;
            labelHueMaxVal.Text = trackBarHueMax.Value.ToString();

            trackBarSatMin.Value = 0;
            sMin = trackBarSatMin.Value;
            labelSatMinVal.Text = trackBarSatMin.Value.ToString();

            trackBarSatMax.Value = 255;
            sMax = trackBarSatMax.Value;
            labelSatMaxVal.Text = trackBarSatMax.Value.ToString();

            trackBarValMin.Value = 0;
            vMin = trackBarValMin.Value;
            labelValMinVal.Text = trackBarValMin.Value.ToString();

            trackBarValMax.Value = 255;
            vMax = trackBarValMax.Value;
            labelValMaxVal.Text = trackBarValMax.Value.ToString();
        }
        private void trackBarSatMin_Scroll(object sender, EventArgs e)
        {
            labelSatMinVal.Text = trackBarSatMin.Value.ToString();
            sMin = trackBarSatMin.Value;
        }

        private void trackBarSatMax_Scroll(object sender, EventArgs e)
        {
            labelSatMaxVal.Text = trackBarSatMax.Value.ToString();
            sMax = trackBarSatMax.Value;
        }

        private void trackBarValMin_Scroll(object sender, EventArgs e)
        {
            labelValMinVal.Text = trackBarValMin.Value.ToString();
            vMin = trackBarValMin.Value;
        }

        private void trackBarValMax_Scroll(object sender, EventArgs e)
        {
            labelValMaxVal.Text = trackBarValMax.Value.ToString();
            vMax = trackBarValMax.Value;
        }

        private void trackBarHueMax_Scroll(object sender, EventArgs e)
        {
            labelHueMaxVal.Text = trackBarHueMax.Value.ToString();
            hMax = trackBarHueMax.Value;
        }

        private void trackBarHueMin_Scroll(object sender, EventArgs e)
        {
            labelHueMinVal.Text = trackBarHueMin.Value.ToString();
            hMin = trackBarHueMin.Value;
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isSendingData = false;
            if(udpManager != null)
                udpManager.Close();
            //measureAccel = false;
        }
    }
}
