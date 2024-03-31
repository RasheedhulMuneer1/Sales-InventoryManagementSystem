using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Cons__T_T_Asgnmnt
{
    public partial class ManagePayment : Form
    {
        public ManagePayment()
        {
            InitializeComponent();
        }

        private void ManagePayment_Load(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaymentGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void ShowPaymentDetails(DataTable orderTable, string totalAmount)
        {
            PaymentGV.DataSource = orderTable.Copy();
            TotAmount.Text = totalAmount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            ManageBilling manageBilling = new ManageBilling();
            manageBilling.SetPaymentDetails(PaymentGV.DataSource as DataTable, TotAmount.Text);
            manageBilling.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaymentGV.Columns[1].Width += 150;
            
            DataGridViewPrinter.PrintDataGridView(PaymentGV, e);

            PaymentGV.Columns[1].Width -= 150;

            // preview and printing the TotAmount separately
            Font font = new Font("Arial", 12, FontStyle.Regular);
            float yPos = 200;
            e.Graphics.DrawString("Total Amount: " + TotAmount.Text, font, Brushes.Black, new PointF(100, yPos));
        }

        private void TotAmount_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
