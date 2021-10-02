using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace PcCatalog
{
    public partial class Cart : Form
    {
        Shop shop = new();

        private static double boughtProductPrice = .0;
        private DataGridViewRow row;
        private string fName, lName, phone;
        public Cart()
        {
            InitializeComponent();

            Bought_Products.DataSource = Shop.BoughtProducts;

            Connection();
            CartPriceLabel.Text = Cost().ToString();

            LeaveShopPanel.Visible = false;
        }

        private void Back1_Button_Click(object sender, EventArgs e)
        {
            shop.Show();

            this.Hide();
        }

        private void Bought_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = Bought_Products.Rows[e.RowIndex];
                int rowIndex = Bought_Products.CurrentCell.RowIndex;

                Shop.Price -= boughtProductPrice;
                CartPriceLabel.Text = Math.Round(Shop.Price, 2).ToString();
                Bought_Products.Rows.RemoveAt(rowIndex);
            }

        }

        private void DataGridSource(object sender, EventArgs e)
        {
            Bought_Products.DataSource = EditPurchase._EditGrid;
        }

        private static double Cost()
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT SUM(price) FROM sys.purchase";
            MySqlCommand command = new(query, connection);
            double sum = double.Parse(command.ExecuteScalar().ToString());
            connection.Close();
            return Math.Abs(Math.Round(sum, 2));
        }
        private void Connection()
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string productQuery = $"SELECT item, price FROM sys.purchase";

            using (MySqlCommand command = new MySqlCommand(productQuery, connection))
            {
                command.CommandType = CommandType.Text;
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        adapter.Fill(dataTable);
                        Bought_Products.DataSource = dataTable;// fill first datagrid
                    }
                }
            }

            connection.Close();
        }

        private void Cart_FormClosed(object sender, FormClosedEventArgs e)
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

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;
            string phoneNum = PhoneNumberBox.Text;
            // row = Bought_Products.Rows[Bought_Products.RowCount-1];

            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new(connectionString);
            connection.Open();

            string customerIdString = $"SELECT COUNT(*) FROM sys.customers";
            MySqlCommand command = new(customerIdString, connection);
            int customerIdCount = int.Parse(command.ExecuteScalar().ToString());
            connection.Close();

           

            if (ClientChecker(firstName,lastName,phoneNum, customerIdCount) == false)
            {
                connection.Open();
                string customerInfo = "INSERT INTO sys.customers(first_name,last_name,phone) VALUES (@first,@last,@phone)";

                MySqlParameter firstNameParam = new();
                firstNameParam.ParameterName = "@first";
                firstNameParam.Value = firstName;

                MySqlParameter lastNameParam = new();
                lastNameParam.ParameterName = "@last";
                lastNameParam.Value = lastName;

                MySqlParameter phoneParameter = new();
                phoneParameter.ParameterName = "@phone";
                phoneParameter.Value = phoneNum;

                command = new(customerInfo, connection);
                command.Parameters.Add(firstNameParam);
                command.Parameters.Add(lastNameParam);
                command.Parameters.Add(phoneParameter);

                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }

            connection.Open();
            string userIDString = $"SELECT customer_id FROM sys.customers WHERE first_name = '{firstName}' AND phone ='{phoneNum}' AND last_name ='{lastName}'";
            MySqlCommand userIdCommand = new(userIDString, connection);
            int userID = Convert.ToInt32(userIdCommand.ExecuteScalar()); // for report
            connection.Close();
                       
            DateTime time = DateTime.Now;
            int counter = 0;

            for(int i = 0; i<Bought_Products.RowCount-1;i++)
            {
                connection.Open();
                counter++;
                string item = ItemScalar(counter);
                int productID = ProductIdScalar(item);
                double productPrice = PriceScalar(item);

                string report = "INSERT INTO sys.report(customer_id,product_id,product,date,price,removed) " +
                    "VALUES (@customer,@productid,@product,@date,@price,@removed)";

                MySqlParameter customerParam = new();
                customerParam.ParameterName = "@customer";
                customerParam.Value = userID;

                MySqlParameter productIdParam = new();
                productIdParam.ParameterName = "@productid";
                productIdParam.Value = productID;

                MySqlParameter productParam = new();
                productParam.ParameterName = "@product";
                productParam.Value = item;

                MySqlParameter timeParam = new();
                timeParam.ParameterName = "@date";
                timeParam.Value = time;

                MySqlParameter priceParam = new();
                priceParam.ParameterName = "@price";
                priceParam.Value = productPrice;

                MySqlParameter removedParam = new();
                removedParam.ParameterName = "@removed";
                removedParam.Value = "0";

                MySqlCommand reportInsertion = new(report, connection);
                reportInsertion.Parameters.Add(customerParam);
                reportInsertion.Parameters.Add(productIdParam);
                reportInsertion.Parameters.Add(timeParam);
                reportInsertion.Parameters.Add(productParam);
                reportInsertion.Parameters.Add(priceParam);
                reportInsertion.Parameters.Add(removedParam);

                MySqlDataReader reader1 = reportInsertion.ExecuteReader();
                connection.Close();
            }
            connection.Open();
            string query = $"TRUNCATE TABLE purchase";
            MySqlCommand truncateCommand = new MySqlCommand(query, connection);
            MySqlDataReader reader2 = truncateCommand.ExecuteReader();
            connection.Close();

            PersonalInfoPanel.Visible = false;
            LeaveShopPanel.Visible = true;

        }
        private string ItemScalar(int counter)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new(connectionString);
            connection.Open();
            string itemString = $"SELECT item FROM sys.purchase WHERE id = {counter}";
            MySqlCommand itemCommand = new(itemString, connection);
            string item = itemCommand.ExecuteScalar().ToString(); //type of item -i3
            connection.Close();
            return item;
        }
        private int ProductIdScalar(string item)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new(connectionString);
            connection.Open();
            string productIDString = $"SELECT product_id FROM sys.purchase WHERE item ='{item}'";
            MySqlCommand productIdCommand = new(productIDString, connection);
            int productID = Convert.ToInt32(productIdCommand.ExecuteScalar());
            connection.Close();
            return productID;
        }

        private double PriceScalar(string item)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new(connectionString);
            connection.Open();
            string productPriceString = $"SELECT price FROM sys.purchase WHERE item = '{item}'";
            MySqlCommand productPriceCommand = new(productPriceString, connection);
            double productPrice = Convert.ToInt32(productPriceCommand.ExecuteScalar());
            connection.Close();
            return productPrice;
        }
        
        private void LeaveButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new(connectionString);
            connection.Open();
            string truncate = $"TRUNCATE TABLE purchase";
            MySqlCommand truncateCommand = new MySqlCommand(truncate, connection);
            MySqlDataReader reader2 = truncateCommand.ExecuteReader();
            connection.Close();
            Application.Exit();
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new(connectionString);
            connection.Open();
            string truncate = $"TRUNCATE TABLE purchase";
            MySqlCommand truncateCommand = new MySqlCommand(truncate, connection);
            MySqlDataReader reader2 = truncateCommand.ExecuteReader();
            connection.Close();

            this.Hide();
            BudgetAdd budget = new();
            budget.Show();
        }

        private bool ClientChecker(string firstName,string lastName,string phoneNum,int customerIdCount)
        {         
            if(customerIdCount == 0)
            { return false; }
            
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new(connectionString);
            connection.Open();
            
            MySqlCommand command = new MySqlCommand();
                    
            string firstNameString = $"SELECT first_name FROM sys.customers WHERE customer_id = {customerIdCount}";
            command = new(firstNameString, connection);
            fName = command.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            string lastNameString = $"SELECT last_name FROM sys.customers WHERE customer_id = {customerIdCount}";
            command = new(lastNameString, connection);
            lName = command.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            string phoneString = $"SELECT phone FROM sys.customers WHERE customer_id = {customerIdCount}";
            command = new(phoneString, connection);
            phone = command.ExecuteScalar().ToString();
            connection.Close();

            if (firstName == fName && lastName == lName && phoneNum == phone)
            {  return true ; }
            else { return ClientChecker(firstName,lastName,phoneNum, customerIdCount - 1); }              
                  
        }
    }
}
/*  DataGridViewButtonColumn buttonColumn = new();
            buttonColumn.HeaderText = "";
            buttonColumn.Width = 60;
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;           
            
            Bought_Products.Columns.Insert(1, buttonColumn);   */ 