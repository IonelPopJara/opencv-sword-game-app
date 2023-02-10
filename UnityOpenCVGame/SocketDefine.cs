using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Tool
{
    class SocketDefine
    {
        public const int port = 8078;
        public const string ip = "127.0.0.1";
    }
    class UdpManager
    {
        UdpClient m_udpClient;
        IPEndPoint m_clientIpEndPoint;
        Thread m_connectThread;
        byte[] m_result = new byte[1024];

        bool m_isStartSend;

        string data;

        public void SetData(string _data)
        {
            data = _data;
        }

        public void Start()
        {
            m_isStartSend = false;
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(SocketDefine.ip), SocketDefine.port);
            m_udpClient = new UdpClient(ipEnd);

            m_clientIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            Console.WriteLine("Waiting for connection data");
            m_connectThread = new Thread(new ThreadStart(Receive));
            m_connectThread.Start();

            // How much time it will pass between sending information
            System.Timers.Timer t = new System.Timers.Timer(10);
            t.Elapsed += new System.Timers.ElapsedEventHandler(SendToClient);
            t.AutoReset = true;
            t.Enabled = true;
        }

        public void SendToClient(object source, System.Timers.ElapsedEventArgs e)
        {
            if(m_isStartSend)
            {
                Send(data);
            }
        }

        public void Send(string data)
        {
            try
            {
                Console.WriteLine("Send to " + m_clientIpEndPoint + " " + data);
                NetBufferWriter writer = new NetBufferWriter();
                writer.WriteString(data);
                m_udpClient.Send(writer.Finish(), writer.finishLength, m_clientIpEndPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Send error   " + ex.Message);
            }
        }

        public void Receive()
        {
            while(true)
            {
                try
                {
                    m_result = new byte[1024];
                    m_result = m_udpClient.Receive(ref m_clientIpEndPoint);
                    NetBufferReader reader = new NetBufferReader(m_result);
                    string data = reader.ReadString();
                    Console.WriteLine(m_clientIpEndPoint + "Data Content: {0}", data);
                    m_isStartSend = true;
                } catch (Exception ex)
                {
                    Console.Write("Receive error    " + ex.Message);
                    Close();
                }
            }
        }

        public void Close()
        {
            m_isStartSend = false;

            if(m_connectThread != null)
            {
                m_connectThread.Interrupt();
                m_connectThread.Abort();
            }

            if(m_udpClient != null)
            {
                m_udpClient.Close();
                m_udpClient.Dispose();
            }

            Console.WriteLine("Disconnect");
        }
    }
    class NetBufferReader
    {
        MemoryStream m_stream = null;
        BinaryReader m_reader = null;

        ushort m_dataLength;

        public NetBufferReader(byte[] data)
        {
            if(data != null)
            {
                m_stream = new MemoryStream(data);
                m_reader = new BinaryReader(m_stream);

                m_dataLength = ReadUShort();
            }
        }

        public byte ReadByte()
        {
            return m_reader.ReadByte();
        }

        public int ReadInt()
        {
            return m_reader.ReadInt32();
        }

        public uint ReadUInt()
        {
            return m_reader.ReadUInt32();
        }

        public short ReadShort()
        {
            return m_reader.ReadInt16();
        }

        public ushort ReadUShort()
        {
            return m_reader.ReadUInt16();
        }

        public long ReadLong()
        {
            return m_reader.ReadInt64();
        }

        public ulong ReadULong()
        {
            return m_reader.ReadUInt64();
        }

        public float ReadFloat()
        {
            byte[] temp = BitConverter.GetBytes(m_reader.ReadSingle());
            Array.Reverse(temp);
            return BitConverter.ToSingle(temp, 0);
        }

        public double ReadDouble()
        {
            byte[] temp = BitConverter.GetBytes(m_reader.ReadDouble());
            Array.Reverse(temp);
            return BitConverter.ToDouble(temp, 0);
        }

        public string ReadString()
        {
            ushort len = ReadUShort();
            byte[] buffer = new byte[len];
            buffer = m_reader.ReadBytes(len);
            return Encoding.UTF8.GetString(buffer);
        }

        public byte[] ReadBytes()
        {
            int len = ReadInt();
            return m_reader.ReadBytes(len);
        }

        public void Close()
        {
            if(m_reader != null)
            {
                m_reader.Close();
            }
            if(m_stream != null)
            {
                m_stream.Close();
            }
            m_reader = null;
            m_stream = null;
        }
    }

    class NetBufferWriter
    {
        MemoryStream m_stream = null;
        BinaryWriter m_writer = null;

        int m_finishLength;
        public int finishLength
        {
            get { return m_finishLength; }
        }

        public NetBufferWriter()
        {
            m_finishLength = 0;
            m_stream = new MemoryStream();
            m_writer = new BinaryWriter(m_stream);
        }

        public void WriteByte(byte v)
        {
            m_writer.Write(v);
        }

        public void WriteInt(int v)
        {
            m_writer.Write(v);
        }

        public void WriteUInt(uint v)
        {
            m_writer.Write(v);
        }

        public void WriteShort(short v)
        {
            m_writer.Write(v);
        }

        public void WriteUShort(ushort v)
        {
            m_writer.Write(v);
        }

        public void WriteLong(long v)
        {
            m_writer.Write(v);
        }

        public void WriteULong(ulong v)
        {
            m_writer.Write(v);
        }
        
        public void WriteFloat(float v)
        {
            byte[] temp = BitConverter.GetBytes(v);
            Array.Reverse(temp);
            m_writer.Write(BitConverter.ToSingle(temp, 0));
        }

        public void WriteDouble(double v)
        {
            byte[] temp = BitConverter.GetBytes(v);
            Array.Reverse(temp);
            m_writer.Write(BitConverter.ToDouble(temp, 0));
        }

        public void WriteString(string v)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(v);
            m_writer.Write((ushort)bytes.Length);
            m_writer.Write(bytes);
        }

        public void WriteBytes(byte[] v)
        {
            m_writer.Write(v.Length);
            m_writer.Write(v);
        }

        public byte[] ToBytes()
        {
            m_writer.Flush();
            return m_stream.ToArray();
        }

        public void Close()
        {
            m_writer.Close();
            m_stream.Close();
            m_writer = null;
            m_stream = null;
        }

        /// <summary>
        /// Encapsulate the written data stream into a new data stream (existing data lenght + existing data)
        /// Data conversion, network transmission requires two parts of data, one is the data length, the other is the main data
        /// </summary>
        public byte[] Finish()
        {
            byte[] message = ToBytes();
            MemoryStream ms = new MemoryStream();
            ms.Position = 0;
            BinaryWriter writer = new BinaryWriter(ms);
            writer.Write((ushort)message.Length);
            writer.Write(message);
            writer.Flush();
            byte[] result = ms.ToArray();
            m_finishLength = result.Length;
            return result;
        }
    }
}
