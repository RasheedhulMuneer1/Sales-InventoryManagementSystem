using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace SW_Cons__T_T_Asgnmnt
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageProducts prod = new ManageProducts();
            prod.Show();
            this.Hide();
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers();
            users.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ManageCategories Cat = new ManageCategories();
            Cat.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ManageCustomers Cust = new ManageCustomers();
            Cust.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManageOrders Orders = new ManageOrders();
            Orders.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ViewCategories viewCategories = new ViewCategories();
            viewCategories.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
            SalesPortal salesportal = new SalesPortal();
            salesportal.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
