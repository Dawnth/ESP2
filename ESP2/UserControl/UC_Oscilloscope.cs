using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ESP2
{
    public partial class UC_Oscilloscope : UserControl
    {
        /****************************
         * Anthony's Oscilloscope
         * ������Ұ�ȵ�״̬����ͼ
         * --------------------------
         * ��ƣ�Ұ��
         * ������Ұ��
         * �׷���bbs.bccn.net
         * For evaluations ONLY, NOT for commercial!
         * �������⡢������ѧϰ������������ҵ��;��
         * ���߾ܾ��е���˽�Է�����ʹ�����������κη��ɻ�������Σ�
         * 
         * ת���뱣��������Ϣ
         * *************************/

        #region ** ˽�г�Ա **
        //˽�г�Ա������
        private int range = 100;    //���������ɵ����ֵ
        private int interval = 2000; //��ʱ�����
        private int[] val;//Chart ֵ����
        private int currentValue = 0;//��ǰֵ
        private int w, h;//������С
        private Timer tmrRefresh;//��ʱ��

        //˽�г�Ա����ͼ
        private ChartMode chartMode = ChartMode.Histogram;    //��ͼ��ʽ
        private int iOffset = 0;//ƽ��ƫ����
        private bool gridShiftting = true;//�����Ƿ�ƽ��
        private int gridShifttingIncrement = 1;//����ƽ�Ƽ��
        private int gridWidth = 10;//������
        private int gridHeight = 10;//����߶�

        private Pen penChart = new Pen(Color.Lime);
        private Pen penGrid = new Pen(Color.Green);
        private Graphics graph;

        #endregion

        #region ** ˽�з��� **
        //˽�з�������������
        private void DrawGrids(ref Graphics g, int offset)
        {
            //�����������Ʊ�Ե��
            float div;
            float pos = 0F;
            //�Ȼ� ��ֱ ����
            //�����ٻ�һ����
            div = (float)w / (float)gridWidth + 1;
            for (int i = 0; i < (int)div; i++)
            {
                pos += gridWidth;
                g.DrawLine(penGrid, pos - offset, 0, pos - offset, h);
            }
            //�� ˮƽ ����
            div = (float)h / (float)gridHeight;
            pos = 0F;
            for (int i = 0; i < (int)div; i++)
            {
                pos += gridHeight;
                g.DrawLine(penGrid, 0, pos, w, pos);
            }
        }

        //˽�з���������ͼ��
        private void DrawChart(ref Graphics g, Pen p, ref int[] val)
        {
            //�� 0 �� w ����
            int len = w;
            //���ݻ��Ʒ�ʽ
            if (chartMode == UC_Oscilloscope.ChartMode.Histogram)
            {
                for (int i = 0; i < len; i++)
                {
                    g.DrawLine(p, i, h - val[i], i, h);
                }
                g.DrawLine(p, len, h - val[len - 1], len, h);
            }
            else
            {
                len--;
                for (int i = 0; i < len; i++)
                {
                    g.DrawLine(p, i, h - val[i], i + 1, h - val[i + 1]);
                }
                len++;
                g.DrawLine(p, len - 1, h - val[len - 2], len, h - val[len - 1]);
            }
        }


        //˽�з��������ط��� 
        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
            //��˫���壬��ֹ��˸
            DoubleBuffered = true;
            h = base.ClientSize.Height - 1;
            w = base.ClientSize.Width - 1;
            val = new int[w];
            //���� Timer
            tmrRefresh = new Timer();
            tmrRefresh.Interval = interval;
            tmrRefresh.Enabled = true;
            tmrRefresh.Tick += new EventHandler(tmrRefresh_Tick);
        }
        //�����С
        protected override void OnResize(EventArgs e)
        {
            h = base.ClientSize.Height;
            w = base.ClientSize.Width;
            Array.Resize(ref val, w);
            Invalidate();
        }
        //��ͼ
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            graph = e.Graphics;
            DrawGrids(ref graph, iOffset);
            DrawChart(ref graph, penChart, ref  val);
        }

        //��ʱ������
        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            //��������ƫ��
            //ֻ�������������ƶ��Ŵ���
            if (gridShiftting)
            {
                iOffset += gridShifttingIncrement;
                iOffset %= gridWidth;
            }
            //����ͼ�Σ��������ƣ�
            //����������������ڻ�ͼ��ͬʱ�ƶ���
            //���ڻ�ͼ���ƶ����򵱻��汻�ڵ���OnPaint���¼�������ʱ�޷�����
            int len = w;
            for (int i = 0; i < len; i++)
            {
                //�ж�����Խ��
                if (i < len - 1)
                {
                    val[i] = val[i + 1];
                }
                else
                {
                    val[len - 1] = currentValue;
                    //break;
                }
            }
            //val[len] = currentValue;
            Invalidate();
        }

        #endregion

        #region ** ������Ա **
        /// <summary>
        /// ����ͼ��ʾ��ʽö�١�
        /// </summary>
        public enum ChartMode
        {
            /// <summary>
            /// ֱ��ͼ
            /// </summary>
            Histogram = 0,    //ֱ��ͼ
            /// <summary>
            /// ����ͼ
            /// </summary>
            Waveform        //����ͼ
        }
        #endregion

        #region ** �������� **
        //������Ա������
        [Browsable(true)]
        /// <summary>
        /// ����ֵ��Χ����ͼʱ�����ݴ�ֵ���� Value ֵ��
        /// </summary>
        [Category("����"), Description("����ֵ��Χ����ͼʱ�����ݴ�ֵ���� Value ֵ��"), DefaultValue(100)]
        public int Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
            }
        }
        /// <summary>
        /// ��ǰֵ��
        /// </summary>
        [Category("����"), Description("��ǰֵ��"), DefaultValue(0)]
        public int Value
        {
            get
            {
                return currentValue;
            }
            set
            {
                //Լ�� value
                if (value > range)
                {
                    value = range;
                }
                if (value < 0)
                {
                    value = 0;
                }
                //���� Range �������� value
                //������С���
                value = (int)((float)value / (float)range * (float)h);
                currentValue = value;
            }
        }
        /// <summary>
        /// ����ͼˢ�¼����
        /// </summary>
        [Category("����"), Description("����ͼˢ�¼����"), DefaultValue(500)]
        public int Interval
        {
            get
            {
                return interval;
            }
            set
            {
                interval = value;
                if (tmrRefresh != null)
                {
                    tmrRefresh.Interval = interval;
                }
            }
        }
        /// <summary>
        /// ָʾ�����Ƿ�������¡�
        /// </summary>
        [Category("����"), Description("ָʾ�����Ƿ�������¡�"), DefaultValue(true)]
        public new bool Enabled
        {
            get
            {
                if (tmrRefresh != null)
                {
                    return tmrRefresh.Enabled;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (tmrRefresh != null)
                {
                    tmrRefresh.Enabled = value;
                }
            }
        }
        /// <summary>
        /// ��ʾ��ʽ��
        /// </summary>
        [Category("���"), Description("������ʾ��ʽ��"), DefaultValue(typeof(UC_Oscilloscope.ChartMode), "Histogram")]
        public ChartMode Mode
        {
            get
            {
                return chartMode;
            }
            set
            {
                chartMode = value;
            }
        }
        /// <summary>
        /// ����ÿ�θ���ʱ����ƽ�Ƶľ��롣
        /// </summary>
        [Category("���"), Description("����ÿ�θ���ʱ����ƽ�Ƶľ��롣"), DefaultValue(1)]
        public int ShifttingIncrement
        {
            get
            {
                return gridShifttingIncrement;
            }
            set
            {
                gridShifttingIncrement = value;
                if (gridShifttingIncrement < 0)
                {
                    gridShifttingIncrement = 0;
                }
            }
        }
        /// <summary>
        /// ָʾ�����Ƿ�ÿ�θ���ʱ����ƽ�ơ�
        /// </summary>
        [Category("���"), Description("ָʾ�����Ƿ�ÿ�θ���ʱ����ƽ�ơ�"), DefaultValue(true)]
        public bool GridShiftting
        {
            get
            {
                return gridShiftting;
            }
            set
            {
                gridShiftting = value;
            }
        }
        /// <summary>
        /// �����ȡ�
        /// </summary>
        [Category("���"), Description("�����ȡ�"), DefaultValue(10)]
        public int GridWidth
        {
            get
            {
                return gridWidth;
            }
            set
            {
                gridWidth = value;
                Invalidate();
            }
        }
        /// <summary>
        /// ����߶ȡ�
        /// </summary>
        [Category("���"), Description("����߶ȡ�"), DefaultValue(10)]
        public int GridHeight
        {
            get
            {
                return gridHeight;
            }
            set
            {
                gridHeight = value;
                Invalidate();
            }
        }
        /// <summary>
        /// ������ɫ��
        /// </summary>
        [Category("���"), Description("������ɫ��"), DefaultValue(typeof(Color), "Green")]
        public Color GridColor
        {
            get
            {
                return penGrid.Color;
            }
            set
            {
                penGrid.Color = value;
            }
        }
        /// <summary>
        /// ������ɫ��
        /// </summary>
        [Category("���"), Description("������ɫ��"), DefaultValue(typeof(Color), "Lime")]
        public override Color ForeColor
        {
            get
            {
                return penChart.Color;
            }
            set
            {
                penChart.Color = value;
            }
        }
        #endregion

        #region ** �������� **
        /// <summary>
        /// ������ʱ�����¡�����ִ�������
        /// </summary>
        /// <returns>ִ�������true �ɹ���false ʧ�ܡ�</returns>
        public bool Start()
        {
            try
            {
                if (tmrRefresh != null)
                {
                    tmrRefresh.Enabled = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// ֹͣ��ʱ�����¡�����ִ�������
        /// </summary>
        /// <returns>ִ�������true �ɹ���false ʧ�ܡ�</returns>
        public bool Stop()
        {
            try
            {
                if (tmrRefresh != null)
                {
                    tmrRefresh.Enabled = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// �����ʷ״̬��¼��
        /// </summary>
        public void Clear()
        {
            if (val != null)
            {
                //û��
                //val.Initialize();
                Array.Resize(ref val, 0);
                Array.Resize(ref val, w);
                currentValue = 0;
            }
        }
        #endregion
    }
}
