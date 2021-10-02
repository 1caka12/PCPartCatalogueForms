using MySql.Data.MySqlClient;
using System.Data;

namespace PcCatalog
{
    class Utilities
    {
        public static DataTable Connection(string product)
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
                        return dataTable;
                        //ListItems.DataSource = dataTable;// fill first datagrid
                    }
                }
            }
        }
    }
}
