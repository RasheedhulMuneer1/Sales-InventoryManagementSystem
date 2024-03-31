using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SW_Cons__T_T_Asgnmnt
{
    public partial class ViewOrders : Form
    {
        private int rowIndexToPrint = 0;
        private DataGridViewRow selectedOrder;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maras\OneDrive\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        public ViewOrders()
        {
            InitializeComponent();

            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument2_PrintPage);
        }

        public void UpdateDataGridView(DataTable dataTable)
        {
           // dataGridView1.DataSource = dataTable;
        }

        void populateorders()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedOrder = OrdersGv.Rows[e.RowIndex];
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (selectedOrder != null)
            {
                e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
                e.Graphics.DrawString("Order Id:" + GetStringCellValue(selectedOrder.Cells[0]), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 100));
                e.Graphics.DrawString("Customer Id:" + GetStringCellValue(selectedOrder.Cells[1]), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 133));
                e.Graphics.DrawString("Customer Name:" + GetStringCellValue(selectedOrder.Cells[2]), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 166));
                e.Graphics.DrawString("Order Date:" + GetStringCellValue(selectedOrder.Cells[3]), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 199));
                e.Graphics.DrawString("Total Amount Rs:" + GetStringCellValue(selectedOrder.Cells[4]), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 232));
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private string GetStringCellValue(DataGridViewCell cell)
        {
            return cell.Value?.ToString() ?? string.Empty;
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateorders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders = new ManageOrders();
            manageOrders.Show();
            this.Hide();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPrintAll_Click(object sender, EventArgs e)
        {
          
        }
    }
}
