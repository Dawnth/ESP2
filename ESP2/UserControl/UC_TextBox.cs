using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ESP2
{    
    //1��ֻ�����������������ַ���-123456.789��1234.789��
    //2����������ַ����в��ܴ������������12456.78//��ȷ��12.456.78//����ȷ��
    //3�������ʾ�����������ַ�������ǰ���һ�����š�-����Ҳֻ�ܼӵ���һ���ַ���λ�ã�
    //4�������ø���ճ�����ܺͲ˵����ܣ�����ֻ������ȷ��ʽ���ַ�����Ч�����磺12.34���ԣ�Abc�����ԣ�
    //5��ֻ�ǵõ�һ���ַ�����������������������ٸĽ��Լ�����ģ�������Ӷ�ʮ�����Ƶ�֧�ֵȡ�
    /// <summary>
    /// NumTextBox ��ժҪ˵����
    /// </summary>
    public partial class UC_TextBox : TextBox
    {
        public const int WM_CONTEXTMENU = 0x007b; // �Ҽ��˵���Ϣ 
        public const int WM_CHAR = 0x0102;        // �����ַ���Ϣ����������ģ����뷨����ĺ����������Ϣ��
        public const int WM_CUT = 0x0300;         // �����ʹ���Ϣ��һ���༭���combobox��ɾ����ǰѡ����ı�
        public const int WM_COPY = 0x0301;        // �����ʹ���Ϣ��һ���༭���combobox�����Ƶ�ǰѡ����ı���������
        public const int WM_PASTE = 0x0302;       // �����ʹ���Ϣ��editcontrol��combobox�Ӽ������еõ�����
        public const int WM_CLEAR = 0x0303;       // �����ʹ���Ϣ��editcontrol��combobox�����ǰѡ������ݣ�
        public const int WM_UNDO = 0x0304;        // �����ʹ���Ϣ��editcontrol��combobox�������һ�β���

        public UC_TextBox()
        {
            //InitializeComponent();
            this.MaxLength = 5;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_CHAR:
                    System.Console.WriteLine(m.WParam);
                    bool isSign = ((int)m.WParam == 45); // ���ŵ�����
                    bool isNum = ((int)m.WParam >= 48) && ((int)m.WParam <= 57); // ���ֵ�����
                    bool isBack = (int)m.WParam == (int)Keys.Back; // �˸�
                    bool isDelete = (int)m.WParam == (int)Keys.Delete; // ʵ��������һ��"."��
                    bool isCtr = ((int)m.WParam == 24) || ((int)m.WParam == 22) || ((int)m.WParam == 26) || ((int)m.WParam == 3);

                    // �ж�С�����λ��
                    if (isDelete)
                    {
                        if (this.Text.Length > 0) // ����ĵ�һ���ַ�Ϊ��"."
                        {
                            if (this.Text.IndexOf(".") < 0)
                            {
                                base.WndProc(ref m);
                            }
                        }
                    }
                    if (isNum || isBack || isCtr)
                    {
                        base.WndProc(ref m);
                    }
                    if (isSign)
                    {
                        if (this.SelectionStart != 0)
                        {
                            break;
                        }
                        base.WndProc(ref m);
                        break;
                    }
                    if ((int)m.WParam == 1)
                    {
                        this.SelectAll();
                    }
                    break;
                case WM_PASTE:
                    IDataObject iData = Clipboard.GetDataObject();// ȡ���������

                    if (iData.GetDataPresent(DataFormats.Text)) // �ж��Ƿ���Text
                    {
                        string str = (string)iData.GetData(DataFormats.Text); // ȡ����
                        if (MatchNumber(str))
                        {
                            base.WndProc(ref m);
                            break;
                        }
                    }
                    m.Result = (IntPtr)0; // ������ճ��
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        private bool MatchNumber(string ClipboardText)
        {
            int index = 0;
            string strNum = "-0.123456789";

            index = ClipboardText.IndexOf(strNum[0]);
            if (index >= 0)
            {
                if (index > 0)
                {
                    return false;
                }
                index = this.SelectionStart;
                if (index > 0)
                {
                    return false;
                }
            }

            index = ClipboardText.IndexOf(strNum[2]);
            if (index != -1)
            {
                index = this.Text.IndexOf(strNum[2]);
                if (index != -1)
                {
                    return false;
                }
            }

            for (int i = 0; i < ClipboardText.Length; i++)
            {
                index = strNum.IndexOf(ClipboardText[i]);
                if (index < 0)
                {
                    return false;
                }
            }
            return true;
        }


        #region --�������--

        //// ���´��벢ûʹ�ã������ο���������Դ�ڻ�����
        //// ���ӵ�ַ http://blog.csdn.net/jzz870519/article/details/5796876
        //public static void keyPressXS(KeyPressEventArgs e, TextBox textBox)
        //{
        //    if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
        //    {
        //        e.Handled = false;       //�ò�����Ч   
        //        int j = 0;
        //        int k = 0;
        //        bool flag = false;
        //        if (textBox.Text.Length == 0)
        //        {
        //            if (e.KeyChar == '.')
        //            {
        //                e.Handled = true;             //�ò���ʧЧ   
        //            }
        //        }
        //        for (int i = 0; i < textBox.Text.Length; i++)
        //        {
        //            if (textBox.Text[i] == '.')
        //            {
        //                j++;
        //                flag = true;
        //            }
        //            if (flag)
        //            {
        //                if (char.IsNumber(textBox.Text[i]) && e.KeyChar != (char)Keys.Back)
        //                {
        //                    k++;
        //                }
        //            }
        //            if (j >= 1)
        //            {
        //                if (e.KeyChar == '.')
        //                {
        //                    e.Handled = true;             //�ò���ʧЧ   
        //                }
        //            }
        //            if (k == 2)
        //            {
        //                if (char.IsNumber(textBox.Text[i]) && e.KeyChar != (char)Keys.Back)
        //                {
        //                    if (textBox.Text.Length - textBox.SelectionStart < 3)
        //                    {
        //                        if (textBox.SelectedText != textBox.Text)
        //                        {
        //                            e.Handled = true;             ////�ò���ʧЧ   
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}
        //// ��������
        //private void this_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
        //    {
        //        e.Handled = false;          //�ò�����Ч     
        //        int j = 0;                  //��¼С�������  
        //        int k = 0;                  //��¼С��λ��  
        //        int dotloc = -1;            //��¼С����λ��  
        //        bool flag = false;          //�����С�������flagֵΪtrue  
        //        //  
        //        //ȥ����λ��0���жϣ���Ϊ���ǲ�֪���û�����ͼ������ta�´�Ҫ��С����ǰ���������֡�  

        //        if (this.Text.Length == 0)
        //        {
        //            if (e.KeyChar == '.')
        //            {
        //                e.Handled = true;
        //            }
        //        }
        //        //  
        //        for (int i = 0; i < this.Text.Length; i++)
        //        {
        //            if (this.Text[i] == '.')
        //            {
        //                j++;
        //                flag = true;
        //                dotloc = i;
        //            }

        //            if (flag)
        //            {
        //                if (char.IsNumber(this.Text[i]) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
        //                {
        //                    k++;
        //                }
        //            }

        //            if (j >= 1)
        //            {
        //                if (e.KeyChar == '.')
        //                {
        //                    if (this.SelectedText.IndexOf('.') == -1)
        //                        e.Handled = true;    //���롰.����ѡȡ����û�С�.������ʧЧ  
        //                }
        //            }

        //            //�˴�����û��С����ʱ���С�����Ƿ�������λС�������  
        //            if (!flag)
        //            {
        //                if (e.KeyChar == '.')
        //                {
        //                    if (this.Text.Length - this.SelectionStart - this.SelectedText.Length > 2)        //the condition also can be instead of "textBox1.Text.Substring(textBox1.SelectionStart).Length-textBox1.SelectionLength>2"   
        //                        e.Handled = true;
        //                }
        //            }

        //            if (k == 2)
        //            {
        //                if (this.SelectionStart > this.Text.IndexOf('.') && this.SelectedText.Length == 0 && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)      //����Ѿ�����λС���������С�����ұߣ�  
        //                    e.Handled = true;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}

        #endregion

    }
}
