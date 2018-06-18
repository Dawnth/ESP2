using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ESP2
{
    public partial class Clock_And_Timer : Form
    {

        #region [-------��������ʼ��-------]

        // stopwatch�ļ�ʱ���Ͷ�ʱ����ʵ��
        public Stopwatch sw_Clock = new Stopwatch();
        public Stopwatch sw_Timer = new Stopwatch();

        /// <summary>
        ///  ��ʱ����ʱ���Ժ������ 
        /// </summary>
        public long totalTimer_Milliseconds = 0;

        /// <summary>
        ///  ��ʱ���м�ʱ���Ժ������ 
        /// </summary>
        public long tempTimer_Milliseconds = 0;

        /// <summary>
        ///  ��ʱ���м�ʱ���Ժ������ 
        /// </summary>
        public long tempClock_Milliseconds = 0;

        public Clock_And_Timer()
        {
            InitializeComponent();
            // ��ʼ���ؼ�
            Clock_And_Timer_Clock_Initialize();
            Clock_And_Timer_Timer_Initialize();
        }

        // ��ʱ����ʼ��
        public void Clock_And_Timer_Clock_Initialize()
        {
            timer_Clock.Stop();
            sw_Clock.Stop();
            sw_Clock.Reset();
            button_Clock_Start.Text = "Start";
            label_Clock.Text = "00:00:00:0";
        }

        // ��ʱ����ʼ��
        public void Clock_And_Timer_Timer_Initialize()
        {
            timer_Timer.Stop();
            sw_Timer.Stop();
            sw_Timer.Reset();
            button_Timer_Start.Text = "Start";
            label_Timer.Text = "00:00:00:0";
            // ��ʼ��comboBox
            comboBox_Timer_Hours.SelectedIndex = 0;
            comboBox_Timer_Minutes.SelectedIndex = 0;
            comboBox_Timer_Seconds.SelectedIndex = 0;
            // ʹ��comboBox
            comboBox_Timer_Hours.Enabled = true;
            comboBox_Timer_Minutes.Enabled = true;
            comboBox_Timer_Seconds.Enabled = true;
        }
        #endregion

        #region [----------��ʱ��----------]

        // ��ʱ����ʾ����
        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            tempClock_Milliseconds = sw_Clock.ElapsedMilliseconds;
            if (tempClock_Milliseconds >= 359999990) // 99Сʱ59��59��990����
            {
                sw_Clock.Reset();
                sw_Clock.Start();
            }
            else
            {
                label_Clock.Text =
                                   (tempClock_Milliseconds / 1000 / 60 / 60 % 99).ToString("00") + ":" // Сʱ
                                 + (tempClock_Milliseconds / 1000 / 60 % 60).ToString("00") + ":" // ����
                                 + (tempClock_Milliseconds / 1000 % 60).ToString("00") + ":" // ��
                                 + (tempClock_Milliseconds % 1000 / 100).ToString("0") // ����
                                 ;
            }
        }

        // ��ʱ��������ť
        private void button_Clock_Start_Click(object sender, EventArgs e)
        {
            if (button_Clock_Start.Text == "Start")
            {
                button_Clock_Start.Text = "Stop";
                sw_Clock.Start();
                timer_Clock.Start();
            }
            else
            {
                button_Clock_Start.Text = "Start";
                sw_Clock.Stop();
                timer_Clock.Stop();
            }
            //mynowSystemseconds = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            //label3.Text = (mynowSystemseconds - myinitSystemseconds).ToString();
            //label4.Text = (mytimer / 10).ToString();
        }

        // ��ʱ�������ť
        private void button_Clock_Clear_Click(object sender, EventArgs e)
        {
            Clock_And_Timer_Clock_Initialize();
        }
        #endregion

        #region [----------��ʱ��----------]

        // ��ʱ����ʾ����
        private void timer_Timer_Tick(object sender, EventArgs e)
        {
            tempTimer_Milliseconds = totalTimer_Milliseconds - sw_Timer.ElapsedMilliseconds;
            if (tempTimer_Milliseconds <= 90)
            {
                Clock_And_Timer_Timer_Initialize();
                // ������ʾʱ�䵽
                MessageBox.Show("ʱ�䵽��");
            }
            else
            {
                label_Timer.Text =
                                   (tempTimer_Milliseconds / 1000 / 60 / 60 % 99).ToString("00") + ":" // Сʱ
                                 + (tempTimer_Milliseconds / 1000 / 60 % 60).ToString("00") + ":" // ����
                                 + (tempTimer_Milliseconds / 1000 % 60).ToString("00") + ":" // ��
                                 + (tempTimer_Milliseconds % 1000 / 100).ToString("0") // ����
                                 ;
            }
        }

        // ��ʱ��Сʱ����
        private void comboBox_Timer_Hours_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Timer.Text = comboBox_Timer_Hours.Text + ":" + comboBox_Timer_Minutes.Text + ":" + comboBox_Timer_Seconds.Text + ":0";
        }

        // ��ʱ����������
        private void comboBox_Timer_Minutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Timer.Text = comboBox_Timer_Hours.Text + ":" + comboBox_Timer_Minutes.Text + ":" + comboBox_Timer_Seconds.Text + ":0";
        }

        // ��ʱ����������
        private void comboBox_Timer_Seconds_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Timer.Text = comboBox_Timer_Hours.Text + ":" + comboBox_Timer_Minutes.Text + ":" + comboBox_Timer_Seconds.Text + ":0";
        }

        // ��ʱ��������ť
        private void button_Timer_Start_Click(object sender, EventArgs e)
        {
            if (comboBox_Timer_Hours.Text != "00" || comboBox_Timer_Minutes.Text != "00" || comboBox_Timer_Seconds.Text != "00")
            {
                if (button_Timer_Start.Text == "Start")
                {
                    // ��ö�ʱ����ʱ��
                    totalTimer_Milliseconds = Convert.ToInt64(comboBox_Timer_Hours.Text) * 60 * 60 * 1000 + Convert.ToInt64(comboBox_Timer_Minutes.Text) * 60 * 1000 + Convert.ToInt64(comboBox_Timer_Seconds.Text) * 1000;

                    button_Timer_Start.Text = "Stop";
                    sw_Timer.Start();
                    timer_Timer.Start();
                    // ��ֹcomboBox
                    comboBox_Timer_Hours.Enabled = false;
                    comboBox_Timer_Minutes.Enabled = false;
                    comboBox_Timer_Seconds.Enabled = false;
                }
                else
                {
                    button_Timer_Start.Text = "Start";
                    sw_Timer.Stop();
                    timer_Timer.Stop();
                }
            }
        }

        // ��ʱ�������ť
        private void button_Timer_Clear_Click(object sender, EventArgs e)
        {
            Clock_And_Timer_Timer_Initialize();
        }
        #endregion
    }
}