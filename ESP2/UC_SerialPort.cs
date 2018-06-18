using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace ESP2
{
    class UC_SerialPort
    {
        // 串口数据记录
        public static string gss_SerialPort_ReceiveData = "";

        // 串口接收标志
        public static bool gsb_SerialPort_IsReceive = false;
        public static bool gsb_SerialPort_IsOpen = false;

        // 串口端口号
        public static string gss_SerialPort_PortName = "COM1";
        // 串口波特率
        public static int gsi_SerialPort_BaudRate = 9600;
        // 串口校验位
        public static Parity gsp_SerialPort_Parity = Parity.None;
        // 串口数据位
        public static int gsp_SerialPort_DataBits = 8;
        // 串口停止位
        public static StopBits gsp_SerialPort_StopBits = StopBits.One;

        // 等待接收所有指令的计数
        public static int gsi_WaitForAllCommandCounter = 0;
        // 等待接收所有指令的计数最大值
        public static int gsi_WaitForAllCommandCounter_Max = 2;

        /**************************************************************/
        /*************************** 串口类 ***************************/
        /**************************************************************/
        /// <summary>
        /// 定义了一个委托类型
        /// </summary>
        public delegate void WhenGetNew();

        /// <summary>
        /// 串口封装类
        /// </summary>
        public class PortDataDisplay
        {
            /// <summary>
            /// 系统串口类
            /// </summary>
            public SerialPort serialPort = new SerialPort(gss_SerialPort_PortName, gsi_SerialPort_BaudRate, gsp_SerialPort_Parity, gsp_SerialPort_DataBits, gsp_SerialPort_StopBits);
            /// <summary>
            /// 解析得到数据后触发事件
            /// </summary>
            public event WhenGetNew whenGetNew;
            /// <summary>
            /// 处理线程
            /// </summary>
            private SerialDataReceivedEventHandler threadCallHandler;
            /// <summary>
            /// 对外的数据类型定义
            /// </summary>
            public string dataSrc = "";
            /// <summary>
            /// 准备关闭串口=true
            /// </summary>
            private bool m_IsTryToClosePort = false;
            /// <summary>
            /// true表示正在接收数据
            /// </summary>
            private bool m_IsReceiving = false;


            /// <summary>
            /// 初始化
            /// </summary>
            public PortDataDisplay()
            {
            }

            /// <summary>
            /// 有参数的构造函数
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
            /// 开始工作
            /// </summary>
            public void ConnectDeveice()
            {
                //0.注册事件
                serialPort.DataReceived -= OnSerialPortDataCome;
                serialPort.DataReceived += OnSerialPortDataCome;
                //1.再设置一下串口参数
                if (this.serialPort.IsOpen == false)
                {
                    this.serialPort.ReadBufferSize = 1000;
                    this.serialPort.ReceivedBytesThreshold = 1;//数据达到赋值数量的时候才就要触发事件
                    //2.打开串口开始工作
                    m_IsTryToClosePort = false;
                    this.serialPort.Open();
                }
            }

            /// <summary>
            /// 结束工作
            /// </summary>
            public void DisconnectDeveice() // 关键和核心！！！
            {
                m_IsTryToClosePort = true;
                while (m_IsReceiving)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
                serialPort.Close();
            }

            /// <summary>
            /// 当通知到有数据达到时处理（读取，与分析）
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void OnSerialPortDataCome(object sender, SerialDataReceivedEventArgs e)
            {
                if (m_IsTryToClosePort) // 关键！！！
                {
                    // 如果正在尝试关闭串口就退出
                    return;
                }

                m_IsReceiving = true; // 关键！！！

                try
                {
                    if (threadCallHandler == null)
                    {
                        threadCallHandler = new SerialDataReceivedEventHandler(OnSerialPortDataCome);
                    }
                    //定义存储接收数据的数组为1
                    byte[] result = new byte[1];
                    //定义接收字符串存储的数组、启示位置、长度
                    serialPort.Read(result, 0, result.Length);
                    // ASCII码
                    foreach (byte basc in result)
                    {
                        dataSrc = ((char)ulong.Parse(basc.ToString(), System.Globalization.NumberStyles.HexNumber - 10)).ToString();//减10，能得出正确的结果！！！
                    }
                    if (dataSrc != "" && this.whenGetNew != null)
                    {
                        this.whenGetNew();
                    }
                }
                finally // 放在finally里面比较好。
                {
                    m_IsReceiving = false; // 关键！！！
                }
            }
        }
    }
}
