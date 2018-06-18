using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace ESP2
{
    class SerialPortReceive
    {
        // 找到指令标识符
        public static bool gsb_StartByteFoundFlag = false;

        // 读取参数接收数据计数
        public static int gsi_GetAllCommandCounter_Receive = 0;
        // 发送参数接收数据计数
        public static int gsi_GetAllCommandCounter_Send = 0;

        // 存放一条完整指令的变量
        public static string gss_SaveIntactCommand = "";

        // 串口从变频板接收参数的接收指令处理过程
        public static void SerialPortReceiveProcess(MainForm fm, string mySingle)
        {
        }
    }
}
