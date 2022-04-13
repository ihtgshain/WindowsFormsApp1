using Starter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1._1.OverView;

namespace WindowsFormsApp1
{

    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]//part1 解決傳統的Windows Forms在高解析度（High DPI）設定下，所引發的文字模糊問題
        private static extern bool SetProcessDPIAware();//part2 解決傳統的Windows Forms在高解析度（High DPI）設定下，所引發的文字模糊問題
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (System.Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }//part3 解決傳統的Windows Forms在高解析度（High DPI）設定下，所引發的文字模糊問題

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmOverView());
            Application.Run(new FrmSqlConnection());
        }
    }
}
