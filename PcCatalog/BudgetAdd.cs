using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PcCatalog
{
    public partial class BudgetAdd : Form
    {
        private static string budget;
        public BudgetAdd()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            budget = BudgetBox.Text;
            if (BudgetBox.Text == "")
            {
                MessageBox.Show("Cannot be blank! Set a budget!");
            }
            else
            {
                //open shop
                Shop shop = new();
                shop.Show();

                this.Hide();
            }
        }

        private void BudgetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
           
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
      
        private void BackButton_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();
            this.Hide();
        }

        private void BudgetAdd_FormClosed(object sender, FormClosedEventArgs e)
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

        public static string Budget
        {
            get{ return budget; }
            set{ budget = value; }
        }
    }
}
