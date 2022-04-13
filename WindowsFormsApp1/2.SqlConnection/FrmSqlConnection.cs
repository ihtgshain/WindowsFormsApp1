using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Properties;
//using System.Configuration;

namespace Starter

{
    public partial class FrmSqlConnection : Form
    {
        public FrmSqlConnection()
        {
            InitializeComponent();

            tabPage1.BackColor = Settings.Default.MyBackColor;
        }

        private void button1_Click(object sender, EventArgs e)//window log in
        {
            //1. SqlConnection
            //2. SqlCommand
            //3. SqlDataReader
            //4. UI Control

            string connStr = "Data source=.;Initial Catalog=Northwind;Integrated Security=true";
            try
            {   //syntax surge Close() and Dispose();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Products", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader.Read())
                    {
                        string s = $"{reader["ProductName"],-30} - {reader["UnitPrice"]:C2}";
                        listBox1.Items.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)//Sql log in
        {
            string connStr = "Data source=.;Initial Catalog=Northwind;User Id=sa;Password=sa";
            
            try
            {    
                using(SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Products", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader.Read())
                    {
                        string s = $"{reader["ProductName"],-30} - {reader["UnitPrice"]:C2}";
                        listBox1.Items.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string connStr = "Data source=.;Initial Catalog=Northwind;Integrated Security=true";
            SqlConnection conn = null;
            try
            {   //syntax surge
                using (conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    MessageBox.Show(conn.State.ToString());
                    SqlCommand cmd = new SqlCommand("Select * from Products", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader.Read())
                    {
                        string s = $"{reader["ProductName"],-30} - {reader["UnitPrice"]:C2}";
                        listBox1.Items.Add(s);
                    }
                }
                MessageBox.Show(conn.State.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connStr = Settings.Default.MyNWConnection;

            try
            {   //syntax surge
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Products", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader.Read())
                    {
                        string s = $"{reader["ProductName"],-30} - {reader["UnitPrice"]:C2}";
                        listBox1.Items.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {   //Copy from App.config  add.name
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
           
            try
            {   //syntax surge
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Products", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader.Read())
                    {
                        string s = $"{reader["ProductName"],-30} - {reader["UnitPrice"]:C2}";
                        listBox1.Items.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            //textbook page 16 可自行建一個自定class做為加密方式，目前使用MS預設的，因此其它人也可解密
        }

        private void button59_Click(object sender, EventArgs e)
        {
            //textbook page 16
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Settings is a Class ; Default is its Property
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.MyBackColor = tabPage1.BackColor = colorDialog1.Color;
                Settings.Default.Save();
            }
        }
    }
}
