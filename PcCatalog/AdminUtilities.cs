using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PcCatalog
{
    class AdminUtilities
    {
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
        public static void AddProductToDataBase(string model, string price, string status, string query)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();

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
        public static void CorrectionToDataBase(string model, string price, string status, string query)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();

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
        public static void RemoveProductFromDataBase(string model, string query)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();

            MySqlParameter itemParameter = new();
            itemParameter.ParameterName = "@item";
            itemParameter.Value = model;

            MySqlCommand command = new(query, connection);
            command.Parameters.Add(itemParameter);

            MySqlDataReader reader = command.ExecuteReader();
            MessageBox.Show("Item successfully removed!");

            connection.Close();

            CheckForBoughtProducts(model);
        }
        private static void CheckForBoughtProducts(string model)
        {
            MySqlConnection connection = Utilities.ConnectionOpen();

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
    }
}
