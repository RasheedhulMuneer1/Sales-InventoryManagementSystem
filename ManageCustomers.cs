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
using Bunifu.Framework.UI;

namespace SW_Cons__T_T_Asgnmnt
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maras\OneDrive\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values(@CustomerId, @CustomerName, @CustomerPhone)", Con);
                cmd.Parameters.AddWithValue("@CustomerId", CustIdTb.Text);
                cmd.Parameters.AddWithValue("@CustomerName", CustNameTb.Text);
                cmd.Parameters.AddWithValue("@CustomerPhone", CustPhoneTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CustIdTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            {
                if (CustIdTb.Text == "")
                {
                    MessageBox.Show("Enter the Customer Id");
                }
                else
                {
                    Con.Open();
                    string myquery = "delete from CustomerTbl where Custid = '" + CustIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Deleted");
                    Con.Close();
                    populate();
                }
            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            {
                if (e.RowIndex >= 0 && e.RowIndex < CustomersGV.Rows.Count)
                {
                    DataGridViewRow selectedRow = CustomersGV.Rows[e.RowIndex];

                    if (selectedRow != null && selectedRow.Cells.Count > 0)
                    {
                        CustIdTb.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                        CustNameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                        CustPhoneTb.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                        Con.Open();

                        SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTbl where CustId = " + CustIdTb.Text + "", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        OrderLabel.Text = dt.Rows[0][0].ToString();
                        SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotAmt) from OrderTbl where CustId = " + CustIdTb.Text + "", Con);

                       
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        AmountLabel.Text = dt1.Rows[0][0].ToString();
                        SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from OrderTbl where CustId = " + CustIdTb.Text + "", Con);


                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        DateLabel.Text = dt2.Rows[0][0].ToString();
                        Con.Close();

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName = '" + CustNameTb.Text + "', CustPhone = '" + CustPhoneTb.Text + "' where CustId = '" + CustIdTb.Text + "'", Con);


                    MessageBox.Show("Customer Successfully Upddated");
                    Con.Close();
                    populate();

                }
                catch
                {

                }
            }

        }

        private void CustNameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
    }
    
    
