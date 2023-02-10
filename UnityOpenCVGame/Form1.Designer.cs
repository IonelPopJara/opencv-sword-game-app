
namespace UnityOpenCVGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCaptureCamera = new System.Windows.Forms.Button();
            this.groupBoxColorMaskTrackBars = new System.Windows.Forms.GroupBox();
            this.labelValMaxVal = new System.Windows.Forms.Label();
            this.labelValMax = new System.Windows.Forms.Label();
            this.trackBarValMax = new System.Windows.Forms.TrackBar();
            this.labelValMinVal = new System.Windows.Forms.Label();
            this.labelValMin = new System.Windows.Forms.Label();
            this.trackBarValMin = new System.Windows.Forms.TrackBar();
            this.labelSatMaxVal = new System.Windows.Forms.Label();
            this.labelSatMax = new System.Windows.Forms.Label();
            this.trackBarSatMax = new System.Windows.Forms.TrackBar();
            this.labelSatMinVal = new System.Windows.Forms.Label();
            this.labelSatMin = new System.Windows.Forms.Label();
            this.trackBarSatMin = new System.Windows.Forms.TrackBar();
            this.labelHueMaxVal = new System.Windows.Forms.Label();
            this.labelHueMax = new System.Windows.Forms.Label();
            this.trackBarHueMax = new System.Windows.Forms.TrackBar();
            this.labelHueMinVal = new System.Windows.Forms.Label();
            this.labelHueMin = new System.Windows.Forms.Label();
            this.trackBarHueMin = new System.Windows.Forms.TrackBar();
            this.pictureBoxCapture = new System.Windows.Forms.PictureBox();
            this.pictureBoxMask = new System.Windows.Forms.PictureBox();
            this.pictureBoxMedianBlur = new System.Windows.Forms.PictureBox();
            this.buttonStartSendingData = new System.Windows.Forms.Button();
            this.groupBoxColorDetection = new System.Windows.Forms.GroupBox();
            this.groupBoxCamera = new System.Windows.Forms.GroupBox();
            this.groupBoxBlur = new System.Windows.Forms.GroupBox();
            this.groupBoxColorMaskTrackBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSatMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSatMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedianBlur)).BeginInit();
            this.groupBoxColorDetection.SuspendLayout();
            this.groupBoxCamera.SuspendLayout();
            this.groupBoxBlur.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCaptureCamera
            // 
            this.buttonCaptureCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCaptureCamera.Location = new System.Drawing.Point(1186, 31);
            this.buttonCaptureCamera.Name = "buttonCaptureCamera";
            this.buttonCaptureCamera.Size = new System.Drawing.Size(170, 50);
            this.buttonCaptureCamera.TabIndex = 17;
            this.buttonCaptureCamera.Text = "Capture Camera";
            this.buttonCaptureCamera.UseVisualStyleBackColor = true;
            this.buttonCaptureCamera.Click += new System.EventHandler(this.buttonCaptureCamera_Click);
            // 
            // groupBoxColorMaskTrackBars
            // 
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelValMaxVal);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelValMax);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.trackBarValMax);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelValMinVal);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelValMin);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.trackBarValMin);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelSatMaxVal);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelSatMax);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.trackBarSatMax);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelSatMinVal);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelSatMin);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.trackBarSatMin);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelHueMaxVal);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelHueMax);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.trackBarHueMax);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelHueMinVal);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.labelHueMin);
            this.groupBoxColorMaskTrackBars.Controls.Add(this.trackBarHueMin);
            this.groupBoxColorMaskTrackBars.Location = new System.Drawing.Point(1042, 147);
            this.groupBoxColorMaskTrackBars.Name = "groupBoxColorMaskTrackBars";
            this.groupBoxColorMaskTrackBars.Size = new System.Drawing.Size(459, 387);
            this.groupBoxColorMaskTrackBars.TabIndex = 18;
            this.groupBoxColorMaskTrackBars.TabStop = false;
            this.groupBoxColorMaskTrackBars.Text = "Color Mask Track Bars";
            // 
            // labelValMaxVal
            // 
            this.labelValMaxVal.AutoSize = true;
            this.labelValMaxVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelValMaxVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelValMaxVal.Location = new System.Drawing.Point(410, 340);
            this.labelValMaxVal.Name = "labelValMaxVal";
            this.labelValMaxVal.Size = new System.Drawing.Size(24, 15);
            this.labelValMaxVal.TabIndex = 29;
            this.labelValMaxVal.Text = "Val";
            // 
            // labelValMax
            // 
            this.labelValMax.AutoSize = true;
            this.labelValMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValMax.Location = new System.Drawing.Point(15, 339);
            this.labelValMax.Name = "labelValMax";
            this.labelValMax.Size = new System.Drawing.Size(57, 17);
            this.labelValMax.TabIndex = 28;
            this.labelValMax.Text = "Val Max";
            // 
            // trackBarValMax
            // 
            this.trackBarValMax.Location = new System.Drawing.Point(83, 325);
            this.trackBarValMax.Maximum = 255;
            this.trackBarValMax.Name = "trackBarValMax";
            this.trackBarValMax.Size = new System.Drawing.Size(316, 45);
            this.trackBarValMax.TabIndex = 27;
            this.trackBarValMax.Value = 255;
            this.trackBarValMax.Scroll += new System.EventHandler(this.trackBarValMax_Scroll);
            // 
            // labelValMinVal
            // 
            this.labelValMinVal.AutoSize = true;
            this.labelValMinVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelValMinVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelValMinVal.Location = new System.Drawing.Point(410, 281);
            this.labelValMinVal.Name = "labelValMinVal";
            this.labelValMinVal.Size = new System.Drawing.Size(24, 15);
            this.labelValMinVal.TabIndex = 26;
            this.labelValMinVal.Text = "Val";
            // 
            // labelValMin
            // 
            this.labelValMin.AutoSize = true;
            this.labelValMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValMin.Location = new System.Drawing.Point(15, 280);
            this.labelValMin.Name = "labelValMin";
            this.labelValMin.Size = new System.Drawing.Size(54, 17);
            this.labelValMin.TabIndex = 25;
            this.labelValMin.Text = "Val Min";
            // 
            // trackBarValMin
            // 
            this.trackBarValMin.Location = new System.Drawing.Point(83, 266);
            this.trackBarValMin.Maximum = 255;
            this.trackBarValMin.Name = "trackBarValMin";
            this.trackBarValMin.Size = new System.Drawing.Size(316, 45);
            this.trackBarValMin.TabIndex = 24;
            this.trackBarValMin.Scroll += new System.EventHandler(this.trackBarValMin_Scroll);
            // 
            // labelSatMaxVal
            // 
            this.labelSatMaxVal.AutoSize = true;
            this.labelSatMaxVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSatMaxVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSatMaxVal.Location = new System.Drawing.Point(410, 222);
            this.labelSatMaxVal.Name = "labelSatMaxVal";
            this.labelSatMaxVal.Size = new System.Drawing.Size(24, 15);
            this.labelSatMaxVal.TabIndex = 23;
            this.labelSatMaxVal.Text = "Val";
            // 
            // labelSatMax
            // 
            this.labelSatMax.AutoSize = true;
            this.labelSatMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSatMax.Location = new System.Drawing.Point(15, 221);
            this.labelSatMax.Name = "labelSatMax";
            this.labelSatMax.Size = new System.Drawing.Size(58, 17);
            this.labelSatMax.TabIndex = 22;
            this.labelSatMax.Text = "Sat Max";
            // 
            // trackBarSatMax
            // 
            this.trackBarSatMax.Location = new System.Drawing.Point(83, 207);
            this.trackBarSatMax.Maximum = 255;
            this.trackBarSatMax.Name = "trackBarSatMax";
            this.trackBarSatMax.Size = new System.Drawing.Size(316, 45);
            this.trackBarSatMax.TabIndex = 21;
            this.trackBarSatMax.Value = 255;
            this.trackBarSatMax.Scroll += new System.EventHandler(this.trackBarSatMax_Scroll);
            // 
            // labelSatMinVal
            // 
            this.labelSatMinVal.AutoSize = true;
            this.labelSatMinVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSatMinVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSatMinVal.Location = new System.Drawing.Point(410, 163);
            this.labelSatMinVal.Name = "labelSatMinVal";
            this.labelSatMinVal.Size = new System.Drawing.Size(24, 15);
            this.labelSatMinVal.TabIndex = 20;
            this.labelSatMinVal.Text = "Val";
            // 
            // labelSatMin
            // 
            this.labelSatMin.AutoSize = true;
            this.labelSatMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSatMin.Location = new System.Drawing.Point(15, 162);
            this.labelSatMin.Name = "labelSatMin";
            this.labelSatMin.Size = new System.Drawing.Size(55, 17);
            this.labelSatMin.TabIndex = 19;
            this.labelSatMin.Text = "Sat Min";
            // 
            // trackBarSatMin
            // 
            this.trackBarSatMin.Location = new System.Drawing.Point(83, 148);
            this.trackBarSatMin.Maximum = 255;
            this.trackBarSatMin.Name = "trackBarSatMin";
            this.trackBarSatMin.Size = new System.Drawing.Size(316, 45);
            this.trackBarSatMin.TabIndex = 18;
            this.trackBarSatMin.Scroll += new System.EventHandler(this.trackBarSatMin_Scroll);
            // 
            // labelHueMaxVal
            // 
            this.labelHueMaxVal.AutoSize = true;
            this.labelHueMaxVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHueMaxVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHueMaxVal.Location = new System.Drawing.Point(410, 104);
            this.labelHueMaxVal.Name = "labelHueMaxVal";
            this.labelHueMaxVal.Size = new System.Drawing.Size(24, 15);
            this.labelHueMaxVal.TabIndex = 17;
            this.labelHueMaxVal.Text = "Val";
            // 
            // labelHueMax
            // 
            this.labelHueMax.AutoSize = true;
            this.labelHueMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHueMax.Location = new System.Drawing.Point(15, 103);
            this.labelHueMax.Name = "labelHueMax";
            this.labelHueMax.Size = new System.Drawing.Size(63, 17);
            this.labelHueMax.TabIndex = 16;
            this.labelHueMax.Text = "Hue Max";
            // 
            // trackBarHueMax
            // 
            this.trackBarHueMax.Location = new System.Drawing.Point(83, 89);
            this.trackBarHueMax.Maximum = 179;
            this.trackBarHueMax.Name = "trackBarHueMax";
            this.trackBarHueMax.Size = new System.Drawing.Size(316, 45);
            this.trackBarHueMax.TabIndex = 15;
            this.trackBarHueMax.Value = 179;
            this.trackBarHueMax.Scroll += new System.EventHandler(this.trackBarHueMax_Scroll);
            // 
            // labelHueMinVal
            // 
            this.labelHueMinVal.AutoSize = true;
            this.labelHueMinVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHueMinVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHueMinVal.Location = new System.Drawing.Point(410, 45);
            this.labelHueMinVal.Name = "labelHueMinVal";
            this.labelHueMinVal.Size = new System.Drawing.Size(24, 15);
            this.labelHueMinVal.TabIndex = 14;
            this.labelHueMinVal.Text = "Val";
            // 
            // labelHueMin
            // 
            this.labelHueMin.AutoSize = true;
            this.labelHueMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHueMin.Location = new System.Drawing.Point(15, 44);
            this.labelHueMin.Name = "labelHueMin";
            this.labelHueMin.Size = new System.Drawing.Size(60, 17);
            this.labelHueMin.TabIndex = 13;
            this.labelHueMin.Text = "Hue Min";
            // 
            // trackBarHueMin
            // 
            this.trackBarHueMin.Location = new System.Drawing.Point(84, 30);
            this.trackBarHueMin.Maximum = 179;
            this.trackBarHueMin.Name = "trackBarHueMin";
            this.trackBarHueMin.Size = new System.Drawing.Size(316, 45);
            this.trackBarHueMin.TabIndex = 12;
            this.trackBarHueMin.Scroll += new System.EventHandler(this.trackBarHueMin_Scroll);
            // 
            // pictureBoxCapture
            // 
            this.pictureBoxCapture.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxCapture.Name = "pictureBoxCapture";
            this.pictureBoxCapture.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxCapture.TabIndex = 19;
            this.pictureBoxCapture.TabStop = false;
            // 
            // pictureBoxMask
            // 
            this.pictureBoxMask.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxMask.Name = "pictureBoxMask";
            this.pictureBoxMask.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxMask.TabIndex = 20;
            this.pictureBoxMask.TabStop = false;
            // 
            // pictureBoxMedianBlur
            // 
            this.pictureBoxMedianBlur.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxMedianBlur.Name = "pictureBoxMedianBlur";
            this.pictureBoxMedianBlur.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxMedianBlur.TabIndex = 21;
            this.pictureBoxMedianBlur.TabStop = false;
            // 
            // buttonStartSendingData
            // 
            this.buttonStartSendingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSendingData.Location = new System.Drawing.Point(1186, 87);
            this.buttonStartSendingData.Name = "buttonStartSendingData";
            this.buttonStartSendingData.Size = new System.Drawing.Size(170, 50);
            this.buttonStartSendingData.TabIndex = 23;
            this.buttonStartSendingData.Text = "Begin Data Transmission";
            this.buttonStartSendingData.UseVisualStyleBackColor = true;
            this.buttonStartSendingData.Click += new System.EventHandler(this.buttonStartSendingData_Click);
            // 
            // groupBoxColorDetection
            // 
            this.groupBoxColorDetection.Controls.Add(this.pictureBoxMask);
            this.groupBoxColorDetection.Location = new System.Drawing.Point(674, 12);
            this.groupBoxColorDetection.Name = "groupBoxColorDetection";
            this.groupBoxColorDetection.Size = new System.Drawing.Size(339, 269);
            this.groupBoxColorDetection.TabIndex = 24;
            this.groupBoxColorDetection.TabStop = false;
            this.groupBoxColorDetection.Text = "Color Detection";
            // 
            // groupBoxCamera
            // 
            this.groupBoxCamera.Controls.Add(this.pictureBoxCapture);
            this.groupBoxCamera.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCamera.Name = "groupBoxCamera";
            this.groupBoxCamera.Size = new System.Drawing.Size(656, 549);
            this.groupBoxCamera.TabIndex = 25;
            this.groupBoxCamera.TabStop = false;
            this.groupBoxCamera.Text = "Camera";
            // 
            // groupBoxBlur
            // 
            this.groupBoxBlur.Controls.Add(this.pictureBoxMedianBlur);
            this.groupBoxBlur.Location = new System.Drawing.Point(674, 287);
            this.groupBoxBlur.Name = "groupBoxBlur";
            this.groupBoxBlur.Size = new System.Drawing.Size(339, 274);
            this.groupBoxBlur.TabIndex = 26;
            this.groupBoxBlur.TabStop = false;
            this.groupBoxBlur.Text = "Median Blur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 619);
            this.Controls.Add(this.groupBoxBlur);
            this.Controls.Add(this.groupBoxCamera);
            this.Controls.Add(this.groupBoxColorDetection);
            this.Controls.Add(this.groupBoxColorMaskTrackBars);
            this.Controls.Add(this.buttonStartSendingData);
            this.Controls.Add(this.buttonCaptureCamera);
            this.Name = "Form1";
            this.Text = "Mults Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxColorMaskTrackBars.ResumeLayout(false);
            this.groupBoxColorMaskTrackBars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSatMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSatMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedianBlur)).EndInit();
            this.groupBoxColorDetection.ResumeLayout(false);
            this.groupBoxCamera.ResumeLayout(false);
            this.groupBoxBlur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCaptureCamera;
        private System.Windows.Forms.GroupBox groupBoxColorMaskTrackBars;
        private System.Windows.Forms.Label labelValMaxVal;
        private System.Windows.Forms.Label labelValMax;
        private System.Windows.Forms.TrackBar trackBarValMax;
        private System.Windows.Forms.Label labelValMinVal;
        private System.Windows.Forms.Label labelValMin;
        private System.Windows.Forms.TrackBar trackBarValMin;
        private System.Windows.Forms.Label labelSatMaxVal;
        private System.Windows.Forms.Label labelSatMax;
        private System.Windows.Forms.TrackBar trackBarSatMax;
        private System.Windows.Forms.Label labelSatMinVal;
        private System.Windows.Forms.Label labelSatMin;
        private System.Windows.Forms.TrackBar trackBarSatMin;
        private System.Windows.Forms.Label labelHueMaxVal;
        private System.Windows.Forms.Label labelHueMax;
        private System.Windows.Forms.TrackBar trackBarHueMax;
        private System.Windows.Forms.Label labelHueMinVal;
        private System.Windows.Forms.Label labelHueMin;
        private System.Windows.Forms.TrackBar trackBarHueMin;
        private System.Windows.Forms.PictureBox pictureBoxCapture;
        private System.Windows.Forms.PictureBox pictureBoxMask;
        private System.Windows.Forms.PictureBox pictureBoxMedianBlur;
        private System.Windows.Forms.Button buttonStartSendingData;
        private System.Windows.Forms.GroupBox groupBoxColorDetection;
        private System.Windows.Forms.GroupBox groupBoxCamera;
        private System.Windows.Forms.GroupBox groupBoxBlur;
    }
}

