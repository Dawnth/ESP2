using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ESP2
{    
    //1：只能输入类似这样的字符：-123456.789；1234.789；
    //2：在输入的字符串中不能存在两个点符：12456.78//正确；12.456.78//不正确；
    //3：如果表示负数可以在字符串的最前面加一个减号“-”，也只能加到弟一个字符的位置；
    //4：可以用复制粘帖功能和菜单功能，但是只对能正确格式的字符串有效，比如：12.34可以，Abc不可以；
    //5：只是得到一个字符串，还可以在这个基础上再改进自己所需的，比如添加对十六进制的支持等。
    /// <summary>
    /// NumTextBox 的摘要说明。
    /// </summary>
    public partial class UC_TextBox : TextBox
    {
        public const int WM_CONTEXTMENU = 0x007b; // 右键菜单消息 
        public const int WM_CHAR = 0x0102;        // 输入字符消息（键盘输入的，输入法输入的好像不是这个消息）
        public const int WM_CUT = 0x0300;         // 程序发送此消息给一个编辑框或combobox来删除当前选择的文本
        public const int WM_COPY = 0x0301;        // 程序发送此消息给一个编辑框或combobox来复制当前选择的文本到剪贴板
        public const int WM_PASTE = 0x0302;       // 程序发送此消息给editcontrol或combobox从剪贴板中得到数据
        public const int WM_CLEAR = 0x0303;       // 程序发送此消息给editcontrol或combobox清除当前选择的内容；
        public const int WM_UNDO = 0x0304;        // 程序发送此消息给editcontrol或combobox撤消最后一次操作

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
                    bool isSign = ((int)m.WParam == 45); // 负号的输入
                    bool isNum = ((int)m.WParam >= 48) && ((int)m.WParam <= 57); // 数字的输入
                    bool isBack = (int)m.WParam == (int)Keys.Back; // 退格
                    bool isDelete = (int)m.WParam == (int)Keys.Delete; // 实际上这是一个"."键
                    bool isCtr = ((int)m.WParam == 24) || ((int)m.WParam == 22) || ((int)m.WParam == 26) || ((int)m.WParam == 3);

                    // 判断小数点后位数
                    if (isDelete)
                    {
                        if (this.Text.Length > 0) // 输入的第一个字符为非"."
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
                    IDataObject iData = Clipboard.GetDataObject();// 取剪贴板对象

                    if (iData.GetDataPresent(DataFormats.Text)) // 判断是否是Text
                    {
                        string str = (string)iData.GetData(DataFormats.Text); // 取数据
                        if (MatchNumber(str))
                        {
                            base.WndProc(ref m);
                            break;
                        }
                    }
                    m.Result = (IntPtr)0; // 不可以粘贴
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


        #region --按键相关--

        //// 以下代码并没使用，留作参考，代码来源于互联网
        //// 连接地址 http://blog.csdn.net/jzz870519/article/details/5796876
        //public static void keyPressXS(KeyPressEventArgs e, TextBox textBox)
        //{
        //    if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
        //    {
        //        e.Handled = false;       //让操作生效   
        //        int j = 0;
        //        int k = 0;
        //        bool flag = false;
        //        if (textBox.Text.Length == 0)
        //        {
        //            if (e.KeyChar == '.')
        //            {
        //                e.Handled = true;             //让操作失效   
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
        //                    e.Handled = true;             //让操作失效   
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
        //                            e.Handled = true;             ////让操作失效   
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
        //// 来自网络
        //private void this_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
        //    {
        //        e.Handled = false;          //让操作生效     
        //        int j = 0;                  //记录小数点个数  
        //        int k = 0;                  //记录小数位数  
        //        int dotloc = -1;            //记录小数点位置  
        //        bool flag = false;          //如果有小数点就让flag值为true  
        //        //  
        //        //去除首位是0的判断，因为我们不知道用户的意图，或许ta下次要在小数点前面输入数字。  

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
        //                        e.Handled = true;    //输入“.”，选取部分没有“.”操作失效  
        //                }
        //            }

        //            //此处控制没有小数点时添加小数点是否满足两位小数的情况  
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
        //                if (this.SelectionStart > this.Text.IndexOf('.') && this.SelectedText.Length == 0 && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)      //如果已经有两位小数，光标在小数点右边，  
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
