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
            tabControl1.SelectedIndex = 1;
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            //1. SqlConnection
            //2. SqlCommand
            //3. SqlDataReader
            //4. UI Control

            SqlConnection conn = null;

            try
            {                                          //from 資料連接→屬性→連接字串
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                //implement a new connection.
                
                //conn.ConnectionString = ("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

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

                //MessageBox.Show("Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conn != null)
                    conn.Close();
            }
        }
        //=======================disConnected=========================
        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            //1. SqlConnection
            //2. SqlDataAdapter
            //3. DataSet
            //4. UI Control

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Products",conn);
            //adapt DB from Sql to C# with the query

            DataSet ds = new DataSet();

            adapter.Fill(ds);//SqlCommand => SqlDataReader => while(Read()) =>Close;

            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Categories", conn);
            DataSet ds = new DataSet();
            dataGridView1.AllowUserToAddRows = false;
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Products where UnitPrice > 30", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(nwDataSet1.Products);
            dataGridView2.DataSource = nwDataSet1.Products;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            categoriesTableAdapter1.Fill(nwDataSet1.Categories);
            dataGridView2.DataSource = nwDataSet1.Categories;
        }
    }
}
