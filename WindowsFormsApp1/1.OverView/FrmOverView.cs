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

namespace WindowsFormsApp1._1.OverView
{
    public partial class FrmOverView : Form
    {
        public FrmOverView()
        {
            InitializeComponent();
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            //1. SqlConnection
            //2. SqlCommand
            //3. SqlDataReader
            //4. UI Control

            try
            {                                          //from 資料連接→屬性→連接字串
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                //implement a new connection.

                conn.Open(); 

                SqlCommand cmd = new SqlCommand("Select * from Products", conn);
                //implement a command and asign its contain and source(connection)

                SqlDataReader reader = cmd.ExecuteReader();
                //set a reader for "Slecet"

                listBox1.Items.Clear();

                while (reader.Read())
                {
                    string s = $"{reader["ProductName"],-40} - {reader["UnitPrice"]:C2}";
                    listBox1.Items.Add(s);
                }


                //reader.Read();
                ////read 1 row;
                //MessageBox.Show(reader["ProductName"].ToString());
                ////choose the info by indexer[] and show it

                conn.Close();

                MessageBox.Show("Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            practice fc = new practice();
            fc.Owner = this;
            fc.ShowDialog();
            
        }
    }
}
