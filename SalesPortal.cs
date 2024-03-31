using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Cons__T_T_Asgnmnt
{
    public partial class SalesPortal : Form
    {

        DataTable table = new DataTable();
        public SalesPortal()
        {
            InitializeComponent();
            // Initialize DataTable and set up columns
            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("TotalPrice", typeof(int));

           

            button1.Click += button1_Click;
        }


       
        

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maras\OneDrive\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void fillcategory()
        {
            try
            {
                string query = "select * from CategoryTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr;

                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //CatCombo.ValueMember = "CatName";
                //CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
        void updateproduct()
        {

            int id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);

            if (newQty < 0)
            {
                MessageBox.Show("Operation failed");
            }
            else
            {
                Con.Open();
                string query = "update ProductTbl set ProdQty = " + newQty + "where ProdId = " + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateproducts();
            }
        }

        void populateproducts()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }


        private void SalesPortal_Load(object sender, EventArgs e)
        {
          
            populateproducts();
            fillcategory();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int flag = 0;

        int num = 0;
        int uprice, totprice, qty;
        string product;
        int stock;

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductsGV.Rows.Count)
            {
                DataGridViewRow selectedRow = ProductsGV.Rows[e.RowIndex];

                if (selectedRow != null && selectedRow.Cells.Count > 0)
                {
                    product = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    stock = Convert.ToInt32(selectedRow.Cells[2].Value?.ToString() ?? "0");
                    uprice = Convert.ToInt32(selectedRow.Cells[3].Value?.ToString() ?? "0");
                    flag = 1;
                }
                else
                {
                    product = string.Empty;
                    uprice = 0;
                    flag = 0;
                }
                ProductsGV.Columns[1].Width = 300;
            }
        }

        private void OrderIdTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CustId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CustName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void orderdate_ValueChanged(object sender, EventArgs e)
        {

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open(); // open the connection

                
                SqlCommand getBillNoCmd = new SqlCommand("SELECT ISNULL(MAX(CAST(BillNo AS INT)), 0) + 1 FROM BillTbl", Con);
                int billNo = Convert.ToInt32(getBillNoCmd.ExecuteScalar());

                
                BillnoTb.Text = billNo.ToString();

                MessageBox.Show("Product Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close(); // close the connection
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (OrderGv.Rows.Count == 0)
            {
                MessageBox.Show("Add products to the order before proceeding to payment.");
                return;
            }


            ManagePayment managePaymentForm = new ManagePayment();
            managePaymentForm.ShowPaymentDetails(table, TotAmount.Text);
            managePaymentForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void QtyTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sum = 0;
            if (QtyTb.Text == "")
            {
              // Message.Box();
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the product");
            }
            else if (Convert.ToInt32(QtyTb.Text) > stock)
                MessageBox.Show("No enough stock available");
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;


                table.Rows.Add(num, product, qty, uprice, totprice);


                OrderGv.DataSource = table;


                sum = table.AsEnumerable().Sum(row => row.Field<int>("TotalPrice"));
                TotAmount.Text = sum.ToString();


                QtyTb.Text = "";
                flag = 0;
            }
        }

        

        private void BillnoTb_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TotAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
