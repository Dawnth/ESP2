using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace ESP2
{
    class SerialPortReceive
    {
        // �ҵ�ָ���ʶ��
        public static bool gsb_StartByteFoundFlag = false;

        // ��ȡ�����������ݼ���
        public static int gsi_GetAllCommandCounter_Receive = 0;
        // ���Ͳ����������ݼ���
        public static int gsi_GetAllCommandCounter_Send = 0;

        // ���һ������ָ��ı���
        public static string gss_SaveIntactCommand = "";

        // ���ڴӱ�Ƶ����ղ����Ľ���ָ������
        public static void SerialPortReceiveProcess(MainForm fm, string mySingle)
        {
        }
    }
}
