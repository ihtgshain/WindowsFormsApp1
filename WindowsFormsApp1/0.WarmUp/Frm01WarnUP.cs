using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm01WarnUP : Form
    {
        bool cBool = true;
        bool haveDelecated = false;

        public Frm01WarnUP()
        {
            InitializeComponent();
            btnHello.Click += new EventHandler(helloHi);
            btnHi.Click += new EventHandler(helloHi);
        }

        void helloHi(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string name = txtName.Text;
            MessageBox.Show(btn.Text + txtName.Text+" Do you want to drink MilkTea?");
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            
            label1.BackColor = cBool? Color.White:Color.Red;
            label1.ForeColor = cBool? Color.Red: Color.White;
            cBool = !cBool;
            btnHi.Visible = btnHello.Visible = !btnHello.Visible;
        }

        private void btnDelecate_Click(object sender, EventArgs e)
        {
            if (haveDelecated)
                return;
            haveDelecated = true;
            btnDelecated.Click += BtnDelecated_Click;
            btnDelecated.Click += aaa;
        }

        private void BtnDelecated_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnDelecated");
        }
        private void aaa(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
        }

        private void btnNF_Click(object sender, EventArgs e)
        {
            Frm01WarnUP f = new Frm01WarnUP();
            f.Show();
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            //static property
            MessageBox.Show(SystemInformation.ComputerName);

            //instance property
            btnHello.Text = "XXX";
            btnHi.Text = "YYY";

            //SystemInformation.ComputerName = "XXX";
            //錯誤 CS0200  無法指派為屬性或索引子 'SystemInformation.ComputerName'-- 其為唯讀

            string s = SystemInformation.ComputerName;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //static method
            File.Copy("a.txt", "a1.txt", true);

            //instance method
            FileInfo f1 = new FileInfo("b.txt");
            f1.CopyTo("b1.txt",true);
            MessageBox.Show(f1.FullName + "\n" + f1.Extension + "\n" + f1.CreationTime);
        }

        private void btnHelloForm_Click(object sender, EventArgs e)
        {
            //Demo1:
            //Form1.text = "Hello, " + txtName.Text;

            //Demo2:
            //Form1 f1 = new Form1();
            //f1.Text = "Hello, " + txtName.Text;
            //Text = "Hello, "+txtName.Text;
            this.Text = "Hello, "+this.txtName.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close();
            this.Close();
        }
    }
}
