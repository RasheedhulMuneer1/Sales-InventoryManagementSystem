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
using Bunifu.Framework.UI;


namespace SW_Cons__T_T_Asgnmnt
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
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
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
        }



        void populate()
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

        void filterbycategory()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from ProductTbl where ProdCat = '"+ SearchCombo.SelectedValue.ToString()+"'";
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

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + ProdIdTb.Text + "','" + ProdNameTb.Text + "','" + QtyTb.Text + "','" + PriceTb.Text + "','" + DescriptionTb.Text + "','" + CatCombo.SelectedValue.ToString() + "')", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
              
            }
        }

       
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProdName = '" + ProdNameTb.Text + "', ProdQty = " + QtyTb.Text + ", ProdPrice = " + PriceTb.Text + ", ProdDesc = '" + DescriptionTb.Text + "', ProdCat = '" + CatCombo.SelectedValue.ToString() + "' where ProdId = " + ProdIdTb.Text + "", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
               
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (ProdIdTb.Text == "")
            {
                MessageBox.Show("Enter the Product Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "delete from ProductTbl where ProdId = " + ProdIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Deleted");
                    Con.Close();
                    populate();
                }
                catch
                {
                    
                }
            }
        }

        private void ProdIdTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
                if (e.RowIndex >= 0 && e.RowIndex < ProductsGV.Rows.Count)
                {
                    DataGridViewRow selectedRow = ProductsGV.Rows[e.RowIndex];

                    if (selectedRow != null && selectedRow.Cells.Count > 0)
                    {
                        ProdIdTb.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                        ProdNameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                        QtyTb.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                        PriceTb.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                        DescriptionTb.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                        CatCombo.SelectedValue = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;

                    ProductsGV.Columns[1].Width = 300;
                    }
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
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

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
