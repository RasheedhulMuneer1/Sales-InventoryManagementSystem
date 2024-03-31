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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maras\OneDrive\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CategoriesGV.Rows.Count)
            {
                DataGridViewRow selectedRow = CategoriesGV.Rows[e.RowIndex];

                if (selectedRow != null && selectedRow.Cells.Count > 0)
                {
                    CategoryIdTb.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    CategoryNameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                   

                }
            }
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTbl values('" + CategoryIdTb.Text + "', '" + CategoryNameTb.Text + "')", Con);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
                Con.Close();
                populate();

            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                if (CategoryIdTb.Text == "")
                {
                    MessageBox.Show("Enter the Category Id");
                }
                else
                {
                    Con.Open();
                    string myquery = "delete from CategoryTbl where CatId = '" + CategoryIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Deleted");
                    Con.Close();
                    populate();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    Con.Open();
            
                    SqlCommand cmd = new SqlCommand("update CategoryTbl set CatName = '" + CategoryNameTb.Text + "' where CatId = '" + CategoryIdTb.Text + "'", Con);

                    
                    MessageBox.Show("Category Successfully Upddated");
                    Con.Close();
                    populate();

                }
                catch
                {

                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void CategoryIdTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CategoryNameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}





