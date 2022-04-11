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
    public partial class practice : Form
    {
        public practice()
        {
            InitializeComponent();
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from employees", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                FrmOverView fP = (FrmOverView)this.Owner;
                fP.listBox1.Items.Clear();
                listBox1.Items.Clear();

                while (reader.Read())
                {
                    string s = $"{reader["LastName"]} - {reader["FirstName"]}";
                    fP.listBox1.Items.Add(s);
                    listBox1.Items.Add(s);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
