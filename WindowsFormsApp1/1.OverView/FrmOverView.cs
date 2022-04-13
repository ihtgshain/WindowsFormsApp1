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
            tabControl1.SelectedIndex = tabControl1.TabCount-1;
            //if(System.Environment.OSVersion.Version.Major >=6)
            //{
            //    Set
            //}
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

        private void button5_Click(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(nwDataSet1.Customers);
            dataGridView2.DataSource = nwDataSet1.Customers;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.FillByUnitPrice(nwDataSet1.Products,30);
            dataGridView2.DataSource = nwDataSet1.Products;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.MyInsertProducts("IceCream", true);
            //productsTableAdapter1.MyInsertProducts(DateTime.Now.ToString(), true);
        }


        private void button8_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Update(nwDataSet1.Products);
        }

        //==============BindingSource=============================
        private void button13_Click(object sender, EventArgs e)
        {
            categoriesTableAdapter1.Fill(nwDataSet1.Categories);
            bindingSource1.DataSource = nwDataSet1.Categories;
            dataGridView3.DataSource = bindingSource1;

            textBox1.DataBindings.Add("Text", bindingSource1, "CategoryName");  //dataBindings
            pictureBox1.DataBindings.Add("Image", bindingSource1, "Picture", true);  
            bindingNavigator1.BindingSource = bindingSource1;  //BindSource
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //bindingSource1.Position -= 1;
            bindingSource1.MovePrevious();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //bindingSource1.Position += 1;
            bindingSource1.MoveNext();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //bindingSource1.Position = 0;
            bindingSource1.MoveFirst();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //bindingSource1.Position = bindingSource1.Count - 1;
            bindingSource1.MoveLast();
        }


        private void dataGridView3_CurrentCellChanged(object sender, EventArgs e)
        {
            label2.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmTool fT = new FrmTool();
            fT.Show();
            //自動做表單 ： 其它視窗→資料來源→nwDataSet
        }

        //============================0413 DataSet details=============================

        private void button16_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(nwDataSet1.Products);
            customersTableAdapter1.Fill(nwDataSet1.Customers);
            categoriesTableAdapter1.Fill(nwDataSet1.Categories);

            dataGridView4.DataSource = nwDataSet1.Products;
            dataGridView5.DataSource = nwDataSet1.Customers;
            dataGridView6.DataSource = nwDataSet1.Categories;
            //================ListBox==================

            listBox2.Items.Clear();
            for(int i = 0; i < nwDataSet1.Tables.Count; i++)
            {
                DataTable table = nwDataSet1.Tables[i];
                listBox2.Items.Add(table.TableName);  //listBox2.Items.Add(nwDataSet1.Tables[i].TableName);

                //to get column schema
                string s = "";
                for(int column =0;column < table.Columns.Count; column++)
                {
                    DataColumn columns = table.Columns[column];
                    s += columns.ColumnName+"  ";
                }
                listBox2.Items.Add(s);

                //to get rom info
                for(int row = 0;row < table.Rows.Count; row++)
                {
                    listBox2.Items.Add(table.Rows[row][0]);  //index 0 stands for rows' ID.
                }

                listBox2.Items.Add("===========================================================");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {   //weak type (complier cant protect the code(string)
            MessageBox.Show(nwDataSet1.Products.Rows[0][1].ToString());  //nwDataSet1.Products = DataTable
            MessageBox.Show(nwDataSet1.Products.Rows[0]["ProductName"].ToString());  //string index

            //strong type (complier can check the code)
            MessageBox.Show(nwDataSet1.Products[0].ProductName);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            nwDataSet1.Products.WriteXml("Products.xml", XmlWriteMode.WriteSchema);  //save to debug file
        }

        private void button18_Click(object sender, EventArgs e)  
        {
            nwDataSet1.Products.Clear();  //read before Load, or clear it;
            nwDataSet1.Products.ReadXml("Products.xml");
            dataGridView4.DataSource = nwDataSet1.Products;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1Collapsed = !splitContainer2.Panel1Collapsed; //collapsed
        }
    }
}
