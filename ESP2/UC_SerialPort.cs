using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace ESP2
{
    class UC_SerialPort
    {
        // �������ݼ�¼
        public static string gss_SerialPort_ReceiveData = "";

        // ���ڽ��ձ�־
        public static bool gsb_SerialPort_IsReceive = false;
        public static bool gsb_SerialPort_IsOpen = false;

        // ���ڶ˿ں�
        public static string gss_SerialPort_PortName = "COM1";
        // ���ڲ�����
        public static int gsi_SerialPort_BaudRate = 9600;
        // ����У��λ
        public static Parity gsp_SerialPort_Parity = Parity.None;
        // ��������λ
        public static int gsp_SerialPort_DataBits = 8;
        // ����ֹͣλ
        public static StopBits gsp_SerialPort_StopBits = StopBits.One;

        // �ȴ���������ָ��ļ���
        public static int gsi_WaitForAllCommandCounter = 0;
        // �ȴ���������ָ��ļ������ֵ
        public static int gsi_WaitForAllCommandCounter_Max = 2;

        /**************************************************************/
        /*************************** ������ ***************************/
        /**************************************************************/
        /// <summary>
        /// ������һ��ί������
        /// </summary>
        public delegate void WhenGetNew();

        /// <summary>
        /// ���ڷ�װ��
        /// </summary>
        public class PortDataDisplay
        {
            /// <summary>
            /// ϵͳ������
            /// </summary>
            public SerialPort serialPort = new SerialPort(gss_SerialPort_PortName, gsi_SerialPort_BaudRate, gsp_SerialPort_Parity, gsp_SerialPort_DataBits, gsp_SerialPort_StopBits);
            /// <summary>
            /// �����õ����ݺ󴥷��¼�
            /// </summary>
            public event WhenGetNew whenGetNew;
            /// <summary>
            /// �����߳�
            /// </summary>
            private SerialDataReceivedEventHandler threadCallHandler;
            /// <summary>
            /// ������������Ͷ���
            /// </summary>
            public string dataSrc = "";
            /// <summary>
            /// ׼���رմ���=true
            /// </summary>
            private bool m_IsTryToClosePort = false;
            /// <summary>
            /// true��ʾ���ڽ�������
            /// </summary>
            private bool m_IsReceiving = false;


            /// <summary>
            /// ��ʼ��
            /// </summary>
            public PortDataDisplay()
            {
            }

            /// <summary>
            /// �в����Ĺ��캯��
            /// </summary>
            //public PortDataDisplay(string portname, int baudrate, Parity parity,int databits,StopBits stopbits)
            //{
            //    serialPortSet(portname, baudrate, parity, databits, stopbits);
            //}

            public void serialPortSet(string portname, int baudrate, Parity parity,int databits,StopBits stopbits)
            {
                if (serialPort.IsOpen == false)
                {
                    serialPort.PortName = portname;
                    serialPort.BaudRate = baudrate;
                    serialPort.Parity = parity;
                    serialPort.DataBits = databits;
                    serialPort.StopBits = stopbits;
                }
            }

            /// <summary>
            /// ��ʼ����
            /// </summary>
            public void ConnectDeveice()
            {
                //0.ע���¼�
                serialPort.DataReceived -= OnSerialPortDataCome;
                serialPort.DataReceived += OnSerialPortDataCome;
                //1.������һ�´��ڲ���
                if (this.serialPort.IsOpen == false)
                {
                    this.serialPort.ReadBufferSize = 1000;
                    this.serialPort.ReceivedBytesThreshold = 1;//���ݴﵽ��ֵ������ʱ��ž�Ҫ�����¼�
                    //2.�򿪴��ڿ�ʼ����
                    m_IsTryToClosePort = false;
                    this.serialPort.Open();
                }
            }

            /// <summary>
            /// ��������
            /// </summary>
            public void DisconnectDeveice() // �ؼ��ͺ��ģ�����
            {
                m_IsTryToClosePort = true;
                while (m_IsReceiving)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
                serialPort.Close();
            }

            /// <summary>
            /// ��֪ͨ�������ݴﵽʱ������ȡ���������
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void OnSerialPortDataCome(object sender, SerialDataReceivedEventArgs e)
            {
                if (m_IsTryToClosePort) // �ؼ�������
                {
                    // ������ڳ��Թرմ��ھ��˳�
                    return;
                }

                m_IsReceiving = true; // �ؼ�������

                try
                {
                    if (threadCallHandler == null)
                    {
                        threadCallHandler = new SerialDataReceivedEventHandler(OnSerialPortDataCome);
                    }
                    //����洢�������ݵ�����Ϊ1
                    byte[] result = new byte[1];
                    //��������ַ����洢�����顢��ʾλ�á�����
                    serialPort.Read(result, 0, result.Length);
                    // ASCII��
                    foreach (byte basc in result)
                    {
                        dataSrc = ((char)ulong.Parse(basc.ToString(), System.Globalization.NumberStyles.HexNumber - 10)).ToString();//��10���ܵó���ȷ�Ľ��������
                    }
                    if (dataSrc != "" && this.whenGetNew != null)
                    {
                        this.whenGetNew();
                    }
                }
                finally // ����finally����ȽϺá�
                {
                    m_IsReceiving = false; // �ؼ�������
                }
            }
        }
    }
}
