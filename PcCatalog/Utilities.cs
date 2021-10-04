using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PcCatalog
{
    class Utilities
    {
       public static string price;
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
                    using (DataTable dataTable = new DataTable())
                    {
                        adapter.Fill(dataTable);
                        connection.Close();
                        return dataTable;
                        //ListItems.DataSource = dataTable;// fill first datagrid
                        
                    }
                }
            }           
        }
        public static MySqlConnection Connection()
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public static string DisplayPrice(double currentProductPrice)
        {
            double totalPrice = .0;
            totalPrice += currentProductPrice;
            price = Math.Round(totalPrice, 2).ToString();
            return price;
        }
        /*
        public enum Products
        {
            cpu,
            gpu,
            hdd,
            mobo,
            psu,
            ram,
            ssd
        }*/
    }
}
