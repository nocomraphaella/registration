using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Formnoca
{
    public partial class registercs : Form
    {
        private MySqlConnection connection;
        public registercs()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=nocomdb;username=root;password=;");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }

        private void BtnRegisterAccount_Click(object sender, EventArgs e)
        {
            //Declare Variable for inputs
            string name = txtname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            //Check if name, username and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter both name, username and password");
            }
            try
            {
                //Register account code
                connection.Open();
                string registerquery = "INSERT INTO users (name, username, password) VALUES (@name, @username, @password)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                //Get row affected 
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Registered  Successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to Register Account!");
                }

            }
            catch (Exception ex)
            {
                // Display any error  if occured
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //Close connection whether there is a error or not 
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            txtname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void registercs_Load(object sender, EventArgs e)
        {

        }
    }
}
