using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ESP2
{
    public partial class UC_ListView : ListView
    {
        //public UC_ListView()
        //{
        //    InitializeComponent();
        //}
        // �Զ���ؼ�
        public NumericUpDown UC_NumericUpDown;

        public UC_ListView()
        {
            // �Զ���numericUpDown�ؼ�myNumUD
            UC_NumericUpDown = new NumericUpDown();
            // ����numericUpDown�����
            UC_NumericUpDown.BorderStyle = BorderStyle.None;
            // myNumUD.Multiline = false;
            UC_NumericUpDown.Visible = false;
            // myNumUD.Maximum = 65535;
            UC_NumericUpDown.Minimum = -4294967295;
            UC_NumericUpDown.Maximum = 4294967295;
            // С��λΪ2λ
            UC_NumericUpDown.DecimalPlaces = 2;
            // ����Ϊ0.25  1
            UC_NumericUpDown.Increment = 0.25M;
            this.GridLines = true;
            this.FullRowSelect = true;
            this.Controls.Add(UC_NumericUpDown);
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            this.UC_NumericUpDown.Visible = false;
            base.OnSelectedIndexChanged(e);
        }

        // ˫��
        protected override void OnDoubleClick(EventArgs e)
        {
            Point tmpPoint = this.PointToClient(Cursor.Position);
            ListViewItem.ListViewSubItem subitem = this.HitTest(tmpPoint).SubItem;
            ListViewItem item = this.HitTest(tmpPoint).Item;
            if (subitem != null)
            {
                if (item.SubItems[0].Equals(subitem))
                {
                }
                else if (item.SubItems[1].Equals(subitem))
                {
                }
                else if (item.SubItems[2].Equals(subitem))
                {
                }
                //��ѡ�е��ǵ�4��subitemʱִ��EditItem����
                else if (item.SubItems[3].Equals(subitem))
                {
                    EditItem(subitem);
                }
            }

            base.OnDoubleClick(e);
        }

        // ����myNumUD��״̬
        private void EditItem(ListViewItem.ListViewSubItem subItem)
        {
            // �ж�Item�Ƿ�Ϊ��
            if (this.SelectedItems.Count <= 0)
            {
                return;
            }
            Rectangle _rect = subItem.Bounds;
            // ��������
            _rect.X = _rect.X + 5;
            _rect.Width = _rect.Width - 6; 
            // ��subItem�����Ը���myNumUD
            // ����myNumUD����������
            UC_NumericUpDown.Bounds = _rect;
            UC_NumericUpDown.BringToFront();
            UC_NumericUpDown.Text = subItem.Text;
            UC_NumericUpDown.Select(0, 100);
            // ����¼�
            UC_NumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(UC_NumericUpDown_KeyDown);
            UC_NumericUpDown.Leave += new EventHandler(tb_Leave);
            UC_NumericUpDown.TextChanged += new EventHandler(UC_NumericUpDown_TextChanged);
            UC_NumericUpDown.Visible = true;
            UC_NumericUpDown.Tag = subItem;
            UC_NumericUpDown.Select();
        }

        // ������enter��ʱִ��tb_Leave����
        private void UC_NumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tb_Leave(sender, e);
            }
        }

        // ��������ɣ�myNumUD���ٻ�ý���ʱ��ʹ��Ŀɼ���Ϊfalse������ִ��myNumUD_TextChanged����
        private void tb_Leave(object sender, EventArgs e)
        {
            //myNumUD.TextChanged -= new EventHandler(myNumUD_TextChanged);
            if ((sender as NumericUpDown).Tag is ListViewItem.ListViewSubItem)
            {
                if (this.UC_NumericUpDown.Text == "")
                {
                    (this.UC_NumericUpDown.Tag as ListViewItem.ListViewSubItem).Text = "00";
                }
                else
                {
                    (this.UC_NumericUpDown.Tag as ListViewItem.ListViewSubItem).Text = this.UC_NumericUpDown.Value.ToString("0.00");
                }
            }
            UC_NumericUpDown.Visible = false;
        }
        
        // myNumUD���ݸı�ʱ������ֵ��ֵ��listView.listViewSubItem.Text
        public void UC_NumericUpDown_TextChanged(object sender, EventArgs e)
        {
            //// Ŀǰ����textchange���¼��ǲ���Ҫ�ģ�ֻ��Ҫһ��leave�¼�����
            //if ((sender as NumericUpDown).Tag is ListViewItem.ListViewSubItem)
            //{
            //    if (this.myNumUD.Text == "")
            //    {
            //        (this.myNumUD.Tag as ListViewItem.ListViewSubItem).Text = "00";
            //    }
            //    else
            //    {
            //        (this.myNumUD.Tag as ListViewItem.ListViewSubItem).Text = this.myNumUD.Text;
            //    }
            //}
        }

        //// ���ֶ���������ôû�����ס�����Ӧ������sytemcommand��
        //// ��д��Ϣ�¼���ûʲô�ð�����ע�͵���һһ�����õ�
        //protected override void WndProc(ref   Message m)
        //{
        //    if (m.Msg == 0x115 || m.Msg == 0x114)
        //    {
        //        this.myNumUD.Visible = false;
        //    }
        //    base.WndProc(ref   m);
        //}

    }
}
