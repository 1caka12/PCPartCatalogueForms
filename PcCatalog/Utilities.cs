using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace PcCatalog
{
    class Utilities
    {                           
        public static MySqlConnection ConnectionOpen()
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        
        public static int GetProductId(string database,string product,string price)
        {
            MySqlConnection connection = ConnectionOpen();

            string productIdQuery = $"SELECT product_id FROM sys.{database} WHERE item='{product}' AND {database}_price={price}";
            MySqlCommand command = new(productIdQuery, connection);
            int id = int.Parse(command.ExecuteScalar().ToString());
            connection.Close();
            return id;
        }
     
        public static string GetCustomerFirstName(int customerId)
        {
            MySqlConnection connection = ConnectionOpen();


            string firstNameQuery = $"SELECT first_name FROM sys.customers WHERE customer_id = {customerId}";
            MySqlCommand command = new(firstNameQuery, connection);
            string firstName = command.ExecuteScalar().ToString();
            connection.Close();
            return firstName;
        }

        public static string GetCustomerLastName(int customerId)
        {
            MySqlConnection connection = ConnectionOpen();

            string lastNameQuery = $"SELECT last_name FROM sys.customers WHERE customer_id = {customerId}";
            MySqlCommand command = new(lastNameQuery, connection);
            string lastName = command.ExecuteScalar().ToString();
            connection.Close();
            return lastName;
        }
        public static string GetCustomerPhone(int customerId)
        {
            MySqlConnection connection = ConnectionOpen();

            string phoneQuery = $"SELECT phone FROM sys.customers WHERE customer_id = {customerId}";
            MySqlCommand command = new(phoneQuery, connection);
            string phoneNum = command.ExecuteScalar().ToString();
            connection.Close();

            return phoneNum;
        }
        public static int GetCustomerCount()
        {
            MySqlConnection connection = ConnectionOpen();
            string customerIdQuery = $"SELECT COUNT(*) FROM sys.customers";
            MySqlCommand command = new(customerIdQuery, connection);
            int customerIdCount = int.Parse(command.ExecuteScalar().ToString());
            return customerIdCount;
        }

        public static int GetCustomerId(string firstName,string lastName,string phoneNum)
        {
            MySqlConnection connection = ConnectionOpen();
            string userIDString = $"SELECT customer_id FROM sys.customers WHERE first_name = '{firstName}' AND phone ='{phoneNum}' AND last_name ='{lastName}'";
            MySqlCommand userIdCommand = new(userIDString, connection);
            int userID = int.Parse(userIdCommand.ExecuteScalar().ToString()); // for report
            connection.Close();
            return userID;
        }

        public static int GetProductCount(string product)
        {
            MySqlConnection connection = ConnectionOpen();
            string productCountQuery = $"SELECT COUNT(*) FROM sys.{product} WHERE status = '1'";
            MySqlCommand command = new(productCountQuery,connection);
            int productCount = int.Parse(command.ExecuteScalar().ToString());
            return productCount;
        }
        public static List<string> ProductIdList(string product)
        {         
            MySqlConnection connection = ConnectionOpen();
            List<string> idList = new();

            string idQuery = $"SELECT product_id FROM sys.{product} WHERE status = '1'";
            MySqlCommand command = new(idQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                idList.Add(reader[0].ToString());
            }
            connection.Close();
            return idList;
        }
         
    }

}
