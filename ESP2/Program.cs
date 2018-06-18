using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ESP2
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            // 调试其他窗口
            //Application.Run(new Clock_And_Timer());
        }
    }
}