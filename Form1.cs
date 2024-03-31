using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SW_Cons__T_T_Asgnmnt
{
    public partial class Form1 : Form
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maras\OneDrive\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
           
            PasswordTb.isPassword = !checkBox1.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
            UnameTb.Text = "";

            
            PasswordTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "SELECT COUNT (*) FROM UserTbl WHERE Uname = @username AND Upassword = @password";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@username", UnameTb.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTb.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    HomeForm homeForm = new HomeForm();
                    homeForm.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
                    }
            finally 
            { Con.Close(); 
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UnameTb_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
