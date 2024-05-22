using MySql.Data.MySqlClient;
namespace Formnoca
{
    public partial class Form1 : Form
    {
        //Declare MySqlCoonection for handling database connection
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=nocomdb;username=root;password=;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Sanitized data to remove white-space
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            //Check if username and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password");
            }
            try
            {
                //Open the connection string
                connection.Open();
                //Create a string that will handle query
                string loginquery = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                //Execute the command loginquery
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                //Sanitized query for sql injection
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);

                //Get row count
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Correct username and password");
                    Admin adminpage = new Admin();
                    adminpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and password");
                }

            }
            catch (Exception ex)
            {
                //Display any error  if occured
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
        }

        private void LinkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registercs signuppage = new registercs();
            signuppage.Show();
            this.Hide();
        }
    }
}
