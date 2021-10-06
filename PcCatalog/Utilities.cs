using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            MySqlConnection connection = Connection();
            string productIdQuery = $"SELECT product_id FROM sys.{product} WHERE item={product} AND {product}_price={price}";
            MySqlCommand command = new(productIdQuery, connection);
            int id = int.Parse(command.ExecuteScalar().ToString());
            return id;
        }
        
        
    }
}
