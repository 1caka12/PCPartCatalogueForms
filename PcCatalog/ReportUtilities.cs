using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace PcCatalog
{
    class ReportUtilities
    {
        private static DataRow dtRow;
        public static void PurchaseReport(int userID, int productID, string product, DateTime time, double productPrice, string productType)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();
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

        public static List<string> RepeatedProductsInReport()
        {
            MySqlConnection connnection = Utilities.ConnectionOpen();

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
            MySqlConnection connection = Utilities.ConnectionOpen();

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
            MySqlConnection connection = Utilities.ConnectionOpen();

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
            MySqlConnection connection = Utilities.ConnectionOpen();

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

        private static double TotalIncomePerProduct(List<string> repeatedItemList, int productIndex)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();
            double productPrice = .0;

            string itemPriceQuery = $"SELECT price FROM sys.report WHERE product ='{repeatedItemList[productIndex]}'"; // gets the price of the duplicate item
            MySqlCommand command = new(itemPriceQuery, connection);
            productPrice = double.Parse(command.ExecuteScalar().ToString());
            connection.Close();

            return productPrice;
        }

        private static int TotalOrdersPerProduct(List<string> repeatedItemList, int productIndex)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();

            string ordersQuery = $"SELECT COUNT(*) FROM sys.report WHERE product = '{repeatedItemList[productIndex]}'";
            MySqlCommand command = new(ordersQuery, connection);
            int orders = int.Parse(command.ExecuteScalar().ToString());
            connection.Close();

            return orders;
        }

        private static string GetProductType(List<string> productsList, int productIndex)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();
            string productTypeQuery = $"SELECT type FROM sys.report WHERE product ='{productsList[productIndex]}'";
            MySqlCommand command = new(productTypeQuery, connection);
            string productType = command.ExecuteScalar().ToString();
            return productType;
        }
        public static DataTable ProductsReport(List<string> productsList, DataTable productsReportTable)
        {
            for (int i = 0; i < productsList.Count; i++)
            {
                double productPrice = TotalIncomePerProduct(productsList, i);
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
            int count = Utilities.GetCustomerCount();
            string firstName, lastName, customer;

            for (int i = 1; i <= count; i++)
            {
                firstName = Utilities.GetCustomerFirstName(i);
                lastName = Utilities.GetCustomerLastName(i);
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
            MySqlConnection connection = Utilities.ConnectionOpen();
            string purchasesQuery = $"SELECT SUM(price) FROM sys.report WHERE customer_id = {customerId}";
            MySqlCommand command = new(purchasesQuery, connection);
            double total = double.Parse(command.ExecuteScalar().ToString());
            return total;
        }
        public static int TotalOrdersPerCustomer(int customerId)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();
            string ordersQuery = $"SELECT COUNT(*) FROM sys.report WHERE customer_id = {customerId}";
            MySqlCommand command = new(ordersQuery, connection);
            int orders = int.Parse(command.ExecuteScalar().ToString());
            return orders;
        }
    }
}
