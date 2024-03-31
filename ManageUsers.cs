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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maras\OneDrive\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
       
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + unameTb.Text + "', '" + FnameTb.Text + "', '" + PasswordTb.Text + "', '" + PhoneTb.Text + "')", Con);
                cmd.Parameters.AddWithValue("@Username", unameTb.Text);
                cmd.Parameters.AddWithValue("@FullName", FnameTb.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTb.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                populate();

            }
            catch
            {

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PhoneTb.Text == ""){
                MessageBox.Show("Enter the users Phone Number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where UPhone = '" + PhoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate(); 
            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < UsersGV.Rows.Count)
            {
                DataGridViewRow selectedRow = UsersGV.Rows[e.RowIndex];

                if (selectedRow != null && selectedRow.Cells.Count > 0)
                {
                    unameTb.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    FnameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    PasswordTb.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                    PhoneTb.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname = '"+ unameTb.Text + "', Ufullname='"+FnameTb.Text+"', Upassword='"+ PasswordTb.Text + "' where UPhone = '"+ PhoneTb.Text +"'", Con);
                cmd.Parameters.AddWithValue("@Username", unameTb.Text);
                cmd.Parameters.AddWithValue("@FullName", FnameTb.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTb.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Upddated");
                Con.Close();
                populate();

            }
            catch
            {

            }
        }
    }
}
