using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SW_Cons__T_T_Asgnmnt
{
    public partial class ManageBilling : Form
    {

        private static int billNumberCounter = 1; // counter for generating unique bill no

        public DataTable PaymentDetails { get; set; }

        public void SetPaymentDetails(DataTable paymentDetails, string totAmount)
        {
            PaymentDetails = paymentDetails.Copy();
            PaymentGV.DataSource = PaymentDetails;
            TotAmount.Text = totAmount;
        }

        public ManageBilling()
        {
            InitializeComponent();

            
            CashTb.KeyPress += CashTb_KeyPress;
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void ManageBilling_Load(object sender, EventArgs e)
        {
           
        }

        private void PaymentGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void TotAmount_Click(object sender, EventArgs e)
        {
           
        }

        private void BalanceTb_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void CashTb_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void CashTb_TextChanged(object sender, EventArgs e)
        {
            UpdateBalance();
        }

        private void CashTb_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           if (e.KeyChar == (char)Keys.Enter)
            {
                UpdateBalance();
            }

        }

        private void UpdateBalance()
        {
            if (decimal.TryParse(CashTb.Text, out decimal cashAmount))
            {
                decimal totalAmount = decimal.Parse(TotAmount.Text);

                if (cashAmount >= totalAmount)
                {
                    decimal balance = totalAmount - cashAmount;
                    BalanceTb.Text = balance.ToString();
                }
                else
                {
                    BalanceTb.Text = "Cash Amount is less than Total Amount";
                }
            }
            else
            {
                BalanceTb.Text = "Invalid Input";
            }
        }

        private void printPreviewDialog3_Load(object sender, EventArgs e)
        {

        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

           
            string billNumber = GenerateBillNumber();


            /*  string printDetails = $"Bill Number: {billNumber}\r\n" +
                                    $"Total Amount: {TotAmount.Text}\r\n" +
                                    $"Cash Amount: {CashTb.Text}\r\n" +
                                    $"Balance: {BalanceTb.Text}\r\n\r\n"; */


            string printDetails = $"Bill Number: {billNumber}\r\n" +
                                  $"Total Amount: {TotAmount.Text}\r\n" +
                                  $"Cash Amount: {CashTb.Text}\r\n" +
                                  $"Balance: {BalanceTb.Text}\r\n\r\n"; 

               

                e.Graphics.DrawString(printDetails, new Font("Arial", 12), Brushes.Black, new Point(10, 10));

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // display print preview
            printPreviewDialog3.Document = printDocument3;
            printPreviewDialog3.ShowDialog();
        }

        private string GenerateBillNumber()
        {
            
            return $"BILL-{DateTime.Now:yyyyMMdd}-{billNumberCounter++}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
