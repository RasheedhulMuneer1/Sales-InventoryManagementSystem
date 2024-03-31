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
    public partial class ViewCategories : Form
    {
        public ViewCategories()
        {
            InitializeComponent();

           // method to display categories list
            displaycategorieslist();
        }

        private void displaycategorieslist()
        {
            {

            }



            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("    CategoryID         Category" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     01                Cereals" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     02                Bakery" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     03                Produce" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     04                Diary" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     05                Meet & Seafood" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     06                Frozon Foods" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     07                Beverages" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     08                Snacks" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     09                HouseHold & Cleaning" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     10                Personal Care" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     11                Health & Wellness" + Environment.NewLine);
            richTextBox1.AppendText("" + Environment.NewLine);
            richTextBox1.AppendText("     12                Baby Care" + Environment.NewLine);   
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ViewCategories_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
