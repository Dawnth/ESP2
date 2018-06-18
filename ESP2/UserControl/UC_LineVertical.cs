using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ESP2
{
    public partial class UC_LineVertical : UserControl
    {
        public UC_LineVertical()
        {
            InitializeComponent();
        }
        private void UC_LineVertical_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            Rectangle r = this.ClientRectangle;



            Pen darkPen = new Pen(SystemColors.ControlDark, 1);

            Pen lightPen = new Pen(Color.White);



            //�ð�ɫ���������Ե

            g.DrawLine(darkPen, r.Left, r.Top, r.Left, r.Bottom);



            //����ɫ�������ұ�Ե
            g.DrawLine(lightPen, r.Left + 1, r.Top, r.Left + 1, r.Bottom);

        }
    }
}
