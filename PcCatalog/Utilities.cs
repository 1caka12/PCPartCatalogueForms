using System;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace PcCatalog
{
    class Utilities
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
        public static MySqlConnection ConnectionOpen()
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public static string DisplayPrice(double currentProductPrice,string command)
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

        public static int GetIdOfProduct(string product,double price)
        {
            MySqlConnection connection = ConnectionOpen();
            string productIdQuery = $"SELECT product_id FROM sys.{product} WHERE item={product} AND {product}_price={price}";
            MySqlCommand command = new(productIdQuery, connection);
            int id = int.Parse(command.ExecuteScalar().ToString());
            connection.Close();
            return id;
        }

        public static void RemoveSelectedProducts(List<string> product, DataGridView grid)
        {
            for(int i = 0; i < grid.Rows.Count;i++)
            {
                for(int k = 0; k < product.Count;k++)
                {
                    if(product[k] == grid.Rows[i].Cells[1].Value.ToString())
                    {
                        grid.Rows.Remove(grid.Rows[i]);
                    }
                }
            }   
        }

        public static void CheckForAddedItems(List<string> product,DataGridView grid)
        {
            if (product.Count > 0)
            {
                RemoveSelectedProducts(product, grid);
            }
        }
        
        public static bool ClientChecker(string firstName, string lastName, string phoneNum, int customerIdCount)
        {
            string currentFirstName, currentLastName, currentPhoneNum;
            if (customerIdCount == 0)
            { return false; }

            MySqlConnection connection = ConnectionOpen();
            MySqlCommand command = new();

            string firstNameString = $"SELECT first_name FROM sys.customers WHERE customer_id = {customerIdCount}";
            command = new(firstNameString, connection);
            currentFirstName = command.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            string lastNameString = $"SELECT last_name FROM sys.customers WHERE customer_id = {customerIdCount}";
            command = new(lastNameString, connection);
            currentLastName = command.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            string phoneString = $"SELECT phone FROM sys.customers WHERE customer_id = {customerIdCount}";
            command = new(phoneString, connection);
            currentPhoneNum = command.ExecuteScalar().ToString();
            connection.Close();

            if (currentFirstName == firstName && currentLastName == lastName && currentPhoneNum == phoneNum)
            { return true; }
            else
            { return ClientChecker(firstName, lastName, phoneNum, customerIdCount - 1); }
        }

        public static void AddNewClient(string firstName,string lastName,string phoneNum)
        {
            MySqlConnection connection = new();
            MySqlCommand command = new();
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

        public static void AddToReport()
        {

        }

        public static int GetCustomerCount()
        {
            MySqlConnection connection = ConnectionOpen();
            string customerIdQuery = $"SELECT COUNT(*) FROM sys.customers";
            MySqlCommand command = new(customerIdQuery, connection);
            int customerIdCount = int.Parse(command.ExecuteScalar().ToString());
            return customerIdCount;
        }
    }
}
