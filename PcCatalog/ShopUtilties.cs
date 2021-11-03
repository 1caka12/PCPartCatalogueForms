using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace PcCatalog
{
    class ShopUtilities
    {
        public static double price;
        public static DataTable ProductsDataTable(string product)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string productQuery = $"SELECT item, {product}_price FROM sys.{product} WHERE status = '1'";

            using (MySqlCommand command = new MySqlCommand(productQuery, connection))
            {
                command.CommandType = CommandType.Text;
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    using (DataTable ProductsDataTable = new DataTable())
                    {
                        adapter.Fill(ProductsDataTable);
                        connection.Close();
                        return ProductsDataTable;
                    }
                }
            }
        }
        public static void RemoveSelectedProducts(List<string> product, DataGridView grid)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                for (int k = 0; k < product.Count; k++)
                {
                    if (product[k] == grid.Rows[i].Cells[1].Value.ToString())
                    {
                        grid.Rows.Remove(grid.Rows[i]);
                    }
                }
            }
        }

        public static void CheckForAddedItems(List<string> product, DataGridView grid)
        {
            if (product.Count > 0)
            {
                RemoveSelectedProducts(product, grid);
            }
        }

        public static bool CustomerChecker(string currentFirstName, string currentLastName, string currentPhoneNum, int customerIdCount)
        {
            string firstName, lastName, phoneNum;
            if (customerIdCount == 0)
            { return false; }

            MySqlConnection connection = Utilities.ConnectionOpen();
            MySqlCommand command = new();

            firstName = Utilities.GetCustomerFirstName(customerIdCount);
            lastName = Utilities.GetCustomerLastName(customerIdCount);
            phoneNum = Utilities.GetCustomerPhone(customerIdCount);

            if (currentFirstName == firstName && currentLastName == lastName && currentPhoneNum == phoneNum)
            { return true; }
            else
            { return CustomerChecker(currentFirstName, currentLastName, currentPhoneNum, customerIdCount - 1); }
        }

        public static void AddNewCustomer(string firstName, string lastName, string phoneNum)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();
            MySqlCommand command = new();
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
        public static string DisplayPrice(double currentProductPrice, string command)
        {
            if (command == "add")
            {
                price += currentProductPrice;
                return Math.Abs(Math.Round(price, 2)).ToString();
            }
            else
            {
                price -= currentProductPrice;
                return Math.Abs(Math.Round(price, 2)).ToString();
            }
        }
    }
}
