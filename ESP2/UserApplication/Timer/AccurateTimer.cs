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

        //私有对象      
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpm_Frequency);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        private long m_StartTime, m_StopTime;
        private long m_Freq;

        ///   <summary>      
        ///   初始化类的新实例。      
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
        ///   开始执行计时。      
        ///   </summary>      
        public void Start()
        {
            Thread.Sleep(0);
            QueryPerformanceCounter(out m_StartTime);
        }

        ///   <summary>      
        ///   停止计时。      
        ///   </summary>      
        public void Stop()
        {
            QueryPerformanceCounter(out m_StopTime);
        }

        ///   <summary>      
        ///   获取计时后得到的计时时间。（单位为秒）      
        ///   </summary>      
        public double DurationSecs
        {
            get
            {
                //   判断是否执行了开始和结束      
                if (m_StartTime == 0 || m_StopTime == 0)
                {
                    throw new InvalidOperationException("Must execute 'Start'!");
                }
                return (double)(m_StopTime - m_StartTime) / (double)m_Freq;
            }
        }

        ///   <summary>      
        ///   获取计时后的计时时间。（单位为毫秒）      
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

        // 精确的时间测试程序段
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
