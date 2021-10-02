using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PcCatalog
{
    public partial class Main : Form
    {
        private BudgetAdd budgetAdd = new BudgetAdd();
        public Main()
        {        
            InitializeComponent();        
        }
        private void ShopButtonMain_Click(object sender, EventArgs e)
        {           
            budgetAdd.Show();
      
            this.Hide();
        }
        private void LogInAdmin_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new();
            connection.ConnectionString = "server = localhost; user = root; database = sys; port = 3306; password = root";

            string usernameQuery = "SELECT Count(*) FROM sys.admin WHERE username = @username AND password = @password";
            using (MySqlCommand command = new MySqlCommand(usernameQuery, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@username", UserAdmin.Text);
                command.Parameters.AddWithValue("@password", PassAdmin.Text);

                int result = Convert.ToInt32(command.ExecuteScalar());
                if (result > 0)
                {
                    AdminScreen adminScreen = new();
                    adminScreen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection mySqlConnection = new(connectionString);
            mySqlConnection.Open();

            string query = $"TRUNCATE TABLE purchase";
            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();
            mySqlConnection.Close();
            Application.Exit();
            
        }
        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminPanel.Show();
        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void processorsCPUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void powerSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
