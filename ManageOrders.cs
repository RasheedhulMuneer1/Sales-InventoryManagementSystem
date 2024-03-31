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
using System.Drawing.Printing;

namespace SW_Cons__T_T_Asgnmnt
{
    public partial class ManageOrders : Form
    {
        DataTable table = new DataTable(); 
        public ManageOrders()
        {
            InitializeComponent();


            // Initialize DataTable and set up columns
            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("TotalPrice", typeof(int));
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersGV.Rows.Count)
            {
                DataGridViewRow selectedRow = CustomersGV.Rows[e.RowIndex];

                if (selectedRow != null && selectedRow.Cells.Count > 0)
                {
                    CustId.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    CustName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;

                    
                }
            }
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


        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (QtyTb.Text == "")
            {
                MessageBox.Show("Enter the quantity of products");
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


        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QtyTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        public void TotAmount_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "" || CustName.Text == "" || TotAmount.Text == "")
            {
                MessageBox.Show("Fill the data correctly");
            }
            else
            {
                try
                {
                    Con.Open();

                   // generate a unique order id
                    SqlCommand getIdCmd = new SqlCommand("SELECT ISNULL(MAX(CAST(OrderId AS INT)), 0) + 1 FROM OrderTbl", Con);
                    int orderId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                   
                    OrderIdTb.Text = orderId.ToString();

                    SqlCommand cmd = new SqlCommand("INSERT INTO OrderTbl (OrderId, CustId, CustName, OrderDate, TotAmt) VALUES (@OrderId, @CustId, @CustName, @OrderDate, @TotAmt)", Con);
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.Parameters.AddWithValue("@CustId", CustId.Text);
                    cmd.Parameters.AddWithValue("@CustName", CustName.Text);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TotAmt", TotAmount.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }





        private void CustName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.UpdateDataGridView(table); //pass the DataTable from ManageOrders 
            view.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void OrderIdTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (OrderGv.Rows.Count == 0)
            {
                MessageBox.Show("No selected items to print.");
                return;
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
          
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void orderdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateproducts();
            fillcategory();
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                string Myquery = "Select * from ProductTbl where ProdCat = '" + SearchCombo.SelectedValue.ToString() + "'";
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
    }
}