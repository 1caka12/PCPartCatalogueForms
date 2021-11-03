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
        private static DataRow dtRow;
        private static Dictionary<string,string> productType = new();

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
        public static DataTable AdminProductsDataTable(string product)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string productQuery = $"SELECT * FROM sys.{product}";

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

        public static int GetProductId(string database,string product,string price)
        {
            MySqlConnection connection = ConnectionOpen();

            string productIdQuery = $"SELECT product_id FROM sys.{database} WHERE item='{product}' AND {database}_price={price}";
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
        
        public static bool CustomerChecker(string currentFirstName, string currentLastName, string currentPhoneNum, int customerIdCount)
        {
            string firstName, lastName, phoneNum;
            if (customerIdCount == 0)
            { return false; }

            MySqlConnection connection = ConnectionOpen();
            MySqlCommand command = new();

            firstName = GetCustomerFirstName(customerIdCount);
            lastName = GetCustomerLastName(customerIdCount);
            phoneNum = GetCustomerPhone(customerIdCount);
            
            if (currentFirstName == firstName && currentLastName == lastName && currentPhoneNum == phoneNum)
            { return true; }
            else
            { return CustomerChecker(currentFirstName, currentLastName, currentPhoneNum, customerIdCount - 1); }
        }

        public static void AddNewCustomer(string firstName,string lastName,string phoneNum)
        {
            MySqlConnection connection = ConnectionOpen();
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

        public static void PurchaseReport(int userID,int productID,string product,DateTime time,double productPrice,string productType)
        {
            MySqlConnection connection = ConnectionOpen();
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
            productParam.Value = product;

            MySqlParameter timeParam = new();
            timeParam.ParameterName = "@date";
            timeParam.Value = time;

            MySqlParameter priceParam = new();
            priceParam.ParameterName = "@price";
            priceParam.Value = productPrice;

            MySqlParameter removedParam = new();// if the product is removed from the entire database
            removedParam.ParameterName = "@removed";
            removedParam.Value = "0";

            MySqlParameter productTypeParam = new();
            productTypeParam.ParameterName = "@type";
            productTypeParam.Value = productType;

            MySqlCommand reportInsertion = new(report, connection);
            reportInsertion.Parameters.Add(customerParam);
            reportInsertion.Parameters.Add(productIdParam);
            reportInsertion.Parameters.Add(timeParam);
            reportInsertion.Parameters.Add(productParam);
            reportInsertion.Parameters.Add(priceParam);
            reportInsertion.Parameters.Add(removedParam);

            MySqlDataReader reader = reportInsertion.ExecuteReader();
            connection.Close();
        }

        public static void AddProductToDataBase(string model,string price,string status,string query)
        {
            MySqlConnection connection = ConnectionOpen();

            MySqlParameter itemParameter = new();
            itemParameter.ParameterName = "@item";
            itemParameter.Value = model;

            MySqlParameter priceParameter = new();
            priceParameter.ParameterName = "@price";
            priceParameter.Value = price;

            MySqlParameter statusParameter = new();
            statusParameter.ParameterName = "@status";
            statusParameter.Value = status;

            MySqlCommand command = new(query, connection);
            command.Parameters.Add(itemParameter);
            command.Parameters.Add(priceParameter);
            command.Parameters.Add(statusParameter);

            MySqlDataReader reader = command.ExecuteReader();
            connection.Close();

           

            MessageBox.Show("New product saved!");
        }
        public static void CorrectionToDataBase(string model,string price,string status,string query)
        {
            MySqlConnection connection = ConnectionOpen();

            MySqlParameter itemParameter = new();
            itemParameter.ParameterName = "@item";
            itemParameter.Value = model;

            MySqlParameter priceParameter = new();
            priceParameter.ParameterName = "@price";
            priceParameter.Value = price;

            MySqlParameter statusParameter = new();
            statusParameter.ParameterName = "@status";
            statusParameter.Value = status;

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Add(itemParameter);
            command.Parameters.Add(priceParameter);
            command.Parameters.Add(statusParameter);

            MySqlDataReader reader = command.ExecuteReader();
            connection.Close();

            MessageBox.Show("Correction made successfully!");
        }
        public static void RemoveProductFromDataBase(string model,string query)
        {
            MySqlConnection connection = ConnectionOpen();

            MySqlParameter itemParameter = new();
            itemParameter.ParameterName = "@item";
            itemParameter.Value = model;

            MySqlCommand command = new (query, connection);
            command.Parameters.Add(itemParameter);           

            MySqlDataReader reader = command.ExecuteReader();
            MessageBox.Show("Item successfully removed!");

            connection.Close();

            CheckForBoughtProducts(model);
        }
        private static void CheckForBoughtProducts(string model)
        {
            MySqlConnection connection = ConnectionOpen();

            string countQuery = $"SELECT COUNT(*) FROM sys.report WHERE product ='{model}'";
            MySqlCommand command = new(countQuery, connection);
            int count = int.Parse(command.ExecuteScalar().ToString());

            connection.Close();

            if (count > 0)
            {
                connection.Open();

                string removedUpdate = $"UPDATE sys.report SET removed = '1' WHERE product ='{model}'";
                MySqlCommand recordCommand = new(removedUpdate, connection);
                MySqlDataReader reader = recordCommand.ExecuteReader();

                connection.Close();
            }
        }

        public static List<string> RepeatedProductsInReport()
        {
            MySqlConnection connnection = ConnectionOpen();

            string duplicateProductsInQuery = $"SELECT product FROM sys.report GROUP BY product HAVING COUNT(product)>1";
            MySqlCommand command = new(duplicateProductsInQuery, connnection);
            MySqlDataReader reader = command.ExecuteReader();

            List<string> repeatedProductsList = new();

            while (reader.Read())
            {
                repeatedProductsList.Add(reader[0].ToString());
            }
            connnection.Close();

            return repeatedProductsList;
        }
        public static List<string> IndividualProductsInReport()
        {
            MySqlConnection connection = ConnectionOpen();

            string individualItemsInQuery = $"SELECT product FROM sys.report GROUP BY product HAVING COUNT(product)=1"; 
            MySqlCommand command = new(individualItemsInQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<string> individualItemsList = new();

            while (reader.Read())
            {
                individualItemsList.Add(reader[0].ToString());
            }
            connection.Close();
            return individualItemsList;
        }
        public static List<string> SpecificRepeatedProductsInReport(string productType)
        {
            MySqlConnection connection = ConnectionOpen();

            string specificProductsInQuery = $"SELECT product FROM sys.report WHERE type = '{productType}' GROUP BY product HAVING COUNT(product)>1;";
            MySqlCommand command = new(specificProductsInQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<string> specificProductsList = new();

            while (reader.Read())
            {
                specificProductsList.Add(reader[0].ToString());
            }
            connection.Close();
            return specificProductsList;
        }
        public static List<string> SpecificIndividualProductsInReport(string productType)
        {
            MySqlConnection connection = ConnectionOpen();

            string specificProductsInQuery = $"SELECT product FROM sys.report WHERE type = '{productType}' GROUP BY product HAVING COUNT(product)=1;";
            MySqlCommand command = new(specificProductsInQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<string> specificProductsList = new();

            while (reader.Read())
            {
                specificProductsList.Add(reader[0].ToString());
            }
            connection.Close();
            return specificProductsList;
        }

        private static double TotalIncomePerProduct(List<string> repeatedItemList,int productIndex)
        {
            MySqlConnection connection = ConnectionOpen();
            double productPrice = .0;

            string itemPriceQuery= $"SELECT price FROM sys.report WHERE product ='{repeatedItemList[productIndex]}'"; // gets the price of the duplicate item
            MySqlCommand command = new(itemPriceQuery, connection);
            productPrice = double.Parse(command.ExecuteScalar().ToString());
            connection.Close();

            return productPrice;
        }

        private static int TotalOrdersPerProduct(List<string> repeatedItemList, int productIndex)
        {
            MySqlConnection connection = ConnectionOpen();

            string ordersQuery = $"SELECT COUNT(*) FROM sys.report WHERE product = '{repeatedItemList[productIndex]}'";
            MySqlCommand command = new(ordersQuery,connection);
            int orders = int.Parse(command.ExecuteScalar().ToString());
            connection.Close();

            return orders;
        }
        
        private static string GetProductType(List<string>productsList,int productIndex)
        {
            MySqlConnection connection = ConnectionOpen();
            string productTypeQuery = $"SELECT type FROM sys.report WHERE product ='{productsList[productIndex]}'";
            MySqlCommand command = new(productTypeQuery, connection);
            string productType = command.ExecuteScalar().ToString();
            return productType;
        }
        public static DataTable ProductsReport(List<string> productsList,DataTable productsReportTable)
        {                       
            for (int i = 0; i< productsList.Count; i++)
            {
                double productPrice =TotalIncomePerProduct(productsList, i);
                int orders = TotalOrdersPerProduct(productsList, i);
                string productType = GetProductType(productsList, i);

                double total = productPrice * orders;

                dtRow = productsReportTable.NewRow();
                dtRow["product"] = productsList[i];
                dtRow["price"] = productPrice;
                dtRow["orders"] = orders;
                dtRow["total"] = total;
                dtRow["productType"] = productType;
                productsReportTable.Rows.Add(dtRow);
            }
            return productsReportTable;
        }

        public static DataTable CustomerPurchasesReport(DataTable customersReportTable)
        {
            int count = GetCustomerCount();
            string firstName, lastName, customer;
            
            for(int i = 1; i <= count; i++)
            {
                firstName = GetCustomerFirstName(i);
                lastName = GetCustomerLastName(i);
                customer = firstName + " " + lastName;
                double total = TotalSumPerCustomer(i);
                int orderCount = TotalOrdersPerCustomer(i);

                dtRow = customersReportTable.NewRow();
                dtRow["customer"] = customer;
                dtRow["orders"] = orderCount;
                dtRow["total"] = total;
                customersReportTable.Rows.Add(dtRow);
            }
            return customersReportTable;
            
        }
        public static double TotalSumPerCustomer(int customerId)
        {
            MySqlConnection connection = ConnectionOpen();
            string purchasesQuery = $"SELECT SUM(price) FROM sys.report WHERE customer_id = {customerId}";
            MySqlCommand command = new(purchasesQuery, connection);
            double total = double.Parse(command.ExecuteScalar().ToString());
            return total;
        }
        public static int TotalOrdersPerCustomer(int customerId)
        {
            MySqlConnection connection = ConnectionOpen();
            string ordersQuery = $"SELECT COUNT(*) FROM sys.report WHERE customer_id = {customerId}";
            MySqlCommand command = new(ordersQuery, connection);
            int orders = int.Parse(command.ExecuteScalar().ToString());
            return orders;
        }

        
        
       
    }

}
