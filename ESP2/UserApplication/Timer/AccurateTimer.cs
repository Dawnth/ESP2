using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace ESP2
{
    class AccurateTimer
    {

        //˽�ж���      
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpm_Frequency);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        private long m_StartTime, m_StopTime;
        private long m_Freq;

        ///   <summary>      
        ///   ��ʼ�������ʵ����      
        ///   </summary>      
        public AccurateTimer()
        {
            this.m_StartTime = 0;
            this.m_StopTime = 0;

            if (QueryPerformanceFrequency(out m_Freq) == false)
            {
                throw new Win32Exception();
            }
        }

        ///   <summary>      
        ///   ��ʼִ�м�ʱ��      
        ///   </summary>      
        public void Start()
        {
            Thread.Sleep(0);
            QueryPerformanceCounter(out m_StartTime);
        }

        ///   <summary>      
        ///   ֹͣ��ʱ��      
        ///   </summary>      
        public void Stop()
        {
            QueryPerformanceCounter(out m_StopTime);
        }

        ///   <summary>      
        ///   ��ȡ��ʱ��õ��ļ�ʱʱ�䡣����λΪ�룩      
        ///   </summary>      
        public double DurationSecs
        {
            get
            {
                //   �ж��Ƿ�ִ���˿�ʼ�ͽ���      
                if (m_StartTime == 0 || m_StopTime == 0)
                {
                    throw new InvalidOperationException("Must execute 'Start'!");
                }
                return (double)(m_StopTime - m_StartTime) / (double)m_Freq;
            }
        }

        ///   <summary>      
        ///   ��ȡ��ʱ��ļ�ʱʱ�䡣����λΪ���룩      
        ///   </summary>      
        public float DurationMsel
        {
            get
            {
                if (m_StartTime == 0 || m_StopTime == 0)
                {
                    throw new InvalidOperationException("Must execute 'End'!");
                }
                return float.Parse((this.DurationSecs * 1000).ToString("##0.###"));
            }
        }

        // ��ȷ��ʱ����Գ����
        //ESP2.AccurateTimer accurateTimer = new ESP2.AccurateTimer();
        //accurateTimer.Start();

        //for (int i = 0; i <= 99999; ++i)
        //{
        //    int realProgress = (int)((float)i / (float)10000 * 100);

        //}

        //accurateTimer.Stop();

        //textBox1.AppendText("Use time: {" + accurateTimer.DurationMsel + "}ms" + "\r\n");
        //Console.WriteLine("Use time: {0}ms", accurateTimer.DurationMsel);
        //Console.ReadLine();
    }
}
