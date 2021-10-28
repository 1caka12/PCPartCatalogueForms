using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PcCatalog
{
    public partial class AdminScreen : Form
    {
      
        private string query;
        private string product;
        private string saveChange;
        private DataGridViewRow row;
        private DataTable salesTable;
        private DataColumn dtColumn;
        private DataRow dtRow;
        private static AdminScreen admin = new();
        
        
        public AdminScreen()
        {
            InitializeComponent();
            panel1.Visible = false;

            ItemComboBox.Items.Add("Processors(CPU)");
            ItemComboBox.Items.Add("Graphics Cards(GPU)");
            ItemComboBox.Items.Add("Hard Drives(HDD)");
            ItemComboBox.Items.Add("Motherboards(MOBO)");
            ItemComboBox.Items.Add("Power Supplies(PSU)");
            ItemComboBox.Items.Add("Ram");
            ItemComboBox.Items.Add("Solid State Drives(SSD)");        
        }
        
        private void Connection(string item)
        {
            if (SalesPanel.Visible == true)
            {
                string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                
                string productQuery = $"SELECT * FROM sys.{item}";

                using (MySqlCommand command = new MySqlCommand(productQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            adapter.Fill(dataTable);
                            ListItems.DataSource = dataTable;// fill first datagrid
                        }
                    }
                }
                connection.Close();
                WhipeText();
                panel1.Visible = false;
                product = item;
            }
        }
       
        private void NewProduct_Click(object sender, EventArgs e)
        {
            saveChange = "new";
            query = $"INSERT INTO sys.{product} (item,{product}_price,status) VALUES (@item,@price,@status)";
            panel1.Visible = true;
        }

        private void CorrectionButton_Click(object sender, EventArgs e)
        {
            saveChange = "correction";
            panel1.Visible = true;


        }
        private void ProductRemove_Click(object sender, EventArgs e)
        {
            saveChange = "remove";
            query = $"DELETE FROM sys.{product} WHERE item = @item";
            panel1.Visible = true;
            MessageBox.Show("Deleting this product will permamently remove it from the Database! " +
                "To proceed with the changes press the 'Save' button below.", "Deleting Product?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();

            this.Hide();
        }

        private void AdminScreen_FormClosed(object sender, FormClosedEventArgs e)
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

        private void ListItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var columnIndex = 0; // index of the checkBoxCell

            if (e.ColumnIndex == columnIndex) // if the changed value is in the checkBoxColumn
            {
                var isChecked = (bool)ListItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value; // checks the value of the checkbox(true or false)
                if (isChecked)
                {
                    foreach (DataGridViewRow row in ListItems.Rows)
                    {
                        if (row.Index != e.RowIndex) // checks for every row which isn't the selected one
                        {
                            row.Cells[columnIndex].Value = !isChecked; // deselects all other cells
                        }
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            WhipeText();
            panel1.Visible = false;            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveChange == "new")
            {
                SaveChanges(saveChange, query);
            }
            else if (saveChange == "correction")
            {
                if (!ModelBox.Text.Equals("") && !PriceBox.Text.Equals("") && !StatusBox.Text.Equals(""))
                {
                    string itemDB = row.Cells[0].Value.ToString();
                    query = $"UPDATE sys.{product} SET item = @item, {product}_price = @price, status = @status WHERE product_id = {itemDB}";

                    SaveChanges(saveChange, query);
                }
                else
                {
                    MessageBox.Show("Select an item");
                }
            }
            else if (saveChange == "remove")
            {
                SaveChanges(saveChange, query);
            }
        }
        private void SaveChanges(string buttonType, string query)
        {
            string model = ModelBox.Text;
            string price = PriceBox.Text;
            string status = StatusBox.Text;

            if (buttonType == "new")
            {
                string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

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

                //whipe text\\
                WhipeText();

                MessageBox.Show("New product saved!");

            }
            else if (buttonType == "correction")
            {
                string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

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
            else if (buttonType == "remove")
            {
                string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                          
                MySqlParameter itemParameter = new();
                itemParameter.ParameterName = "@item";
                itemParameter.Value = model;

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.Add(itemParameter);
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Item successfully removed!");

                connection.Close();

                CheckForRecords(model);
            }
        }
        private void CheckForRecords(string model)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string countString = $"SELECT COUNT(*) FROM sys.report WHERE product ='{model}'";

            MySqlCommand command = new(countString, connection);
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
        private void ListItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {         
                int rowIndex = e.RowIndex;
                row = ListItems.Rows[rowIndex];

                string item = row.Cells[1].Value.ToString();
                string price = row.Cells[2].Value.ToString();
                string status = row.Cells[3].Value.ToString();

                ModelBox.Text = item;
                PriceBox.Text = price;
                StatusBox.Text = status;          
            }
        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ItemComboBox.Text)
            {
                case "Processors(CPU)":
                    Connection("cpu");
                    break;
                case "Graphics Cards(GPU)":
                    Connection("gpu");
                    break;
                case "Hard Drives(HDD)":
                    Connection("hdd");
                    break;
                case "Motherboards(MOBO)":
                    Connection("mobo");
                    break;
                case "Power Supplies(PSU)":
                    Connection("psu");
                    break;
                case "Ram":
                    Connection("ram");
                    break;
                case "Solid State Drives(SSD)":
                    Connection("ssd");
                    break;
            }
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            
            if (SalesPanel.Visible == true )
            {
                salesTable = new("Customers");
                if (!salesTable.Columns.Contains("product"))
                {
                    SalesPanel.Visible = false;
                   
                    dtColumn = new();
                    dtColumn.DataType = typeof(string);
                    dtColumn.ColumnName = "product";
                    dtColumn.Caption = "Product";
                    dtColumn.ReadOnly = false;
                    dtColumn.Unique = false;
                    salesTable.Columns.Add(dtColumn);

                    dtColumn = new();
                    dtColumn.DataType = typeof(double);
                    dtColumn.ColumnName = "price";
                    dtColumn.Caption = "Price";
                    dtColumn.ReadOnly = false;
                    dtColumn.Unique = false;
                    salesTable.Columns.Add(dtColumn);

                    dtColumn = new();
                    dtColumn.DataType = typeof(int);
                    dtColumn.ColumnName = "orders";
                    dtColumn.Caption = "Orders";
                    dtColumn.ReadOnly = false;
                    dtColumn.Unique = false;
                    salesTable.Columns.Add(dtColumn);

                    dtColumn = new();
                    dtColumn.DataType = typeof(double);
                    dtColumn.ColumnName = "total";
                    dtColumn.Caption = "Total";
                    dtColumn.ReadOnly = false;
                    dtColumn.Unique = false;
                    salesTable.Columns.Add(dtColumn);
                }
                

                string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string purchasesString = "SELECT COUNT(*) FROM sys.report";
                MySqlCommand command = new(purchasesString, connection);
                //int purchases = int.Parse(command.ExecuteScalar().ToString());
                connection.Close();

                connection.Open();
                string duplicateItemString = $"SELECT product FROM sys.report GROUP BY product HAVING COUNT(product)>1";
                command = new(duplicateItemString, connection);
                MySqlDataReader reader = command.ExecuteReader();


                List<string> result = new List<string>();

                while (reader.Read())
                {
                    result.Add(reader[0].ToString());
                }
                connection.Close();

               
                for (int i = 0; i < result.Count; i++)
                {
                    connection.Open();
                    string itemPriceString = $"SELECT price FROM sys.report WHERE product ='{result[i]}'"; // gets the price of the duplicate item
                    command = new(itemPriceString, connection);
                    double itemPrice = double.Parse(command.ExecuteScalar().ToString());
                    connection.Close();

                    connection.Open();
                    string orderString = $"SELECT COUNT(*) FROM sys.report WHERE product = '{result[i]}'"; //gets the number of orders of the duplicates
                    command = new(orderString, connection);
                    int orders = int.Parse(command.ExecuteScalar().ToString());
                    connection.Close();

                    double total = orders * itemPrice; // the total money spend on an item

                    dtRow = salesTable.NewRow();
                    dtRow["product"] = result[i];
                    dtRow["price"] = itemPrice;
                    dtRow["orders"] = orders;
                    dtRow["total"] = total;
                    salesTable.Rows.Add(dtRow);

                    /*connection.Open();
                    string idString = $"SELECT product_id FROM sys.report WHERE product ='{result[i]}'";
                    command = new(idString, connection);
                    int id = int.Parse(command.ExecuteScalar().ToString());
                    connection.Close();

                    //dupeItem.Add(id);     */            
                }
                connection.Open();
                string idCheckString = $"SELECT product_id FROM sys.report GROUP BY product HAVING COUNT(product)=1";
                command = new(idCheckString, connection);
                reader = command.ExecuteReader();
                List<int> nonDupeId = new();

                while (reader.Read())
                {
                    nonDupeId.Add(int.Parse(reader[0].ToString()));
                }
                connection.Close();


                for (int k = 0; k < nonDupeId.Count; k++)
                {
                    connection.Open();
                    string itemString = $"SELECT product FROM sys.report WHERE product_id ='{nonDupeId[k]}'"; // gets the price of the duplicate item
                    command = new(itemString, connection);
                    string item = command.ExecuteScalar().ToString();
                    connection.Close();

                    connection.Open();
                    string itemPriceString = $"SELECT price FROM sys.report WHERE product_id ='{nonDupeId[k]}'"; // gets the price of the duplicate item
                    command = new(itemPriceString, connection);
                    double itemPrice = double.Parse(command.ExecuteScalar().ToString());
                    connection.Close();

                    connection.Open();
                    string orderString = $"SELECT COUNT(*) FROM sys.report WHERE product_id = '{nonDupeId[k]}'"; //gets the number of orders of the duplicates
                    command = new(orderString, connection);
                    int orders = int.Parse(command.ExecuteScalar().ToString());
                    connection.Close();
                    dtRow = salesTable.NewRow();
                    dtRow["product"] = item;
                    dtRow["price"] = itemPrice;
                    dtRow["orders"] = orders;
                    dtRow["total"] = itemPrice;
                    salesTable.Rows.Add(dtRow);
                }

                ListItems.DataSource = salesTable;
            }
            else
            { 
                SalesPanel.Visible = true;
                ListItems.DataSource = null; 
                ListItems.Rows.Clear();
                ListItems.Columns.Clear();
                salesTable = null;               
            }
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {

            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string customerCount = "SELECT COUNT(*) FROM sys.customers";
            MySqlCommand command = new(customerCount, connection);
            int count = int.Parse(command.ExecuteScalar().ToString());

            if (SalesPanel.Visible == true)
            {
                salesTable = new("Customers");
                if (!salesTable.Columns.Contains("product"))
                {
                    SalesPanel.Visible = false;

                    dtColumn = new();
                    dtColumn.DataType = typeof(string);
                    dtColumn.ColumnName = "client";
                    dtColumn.Caption = "Client";
                    dtColumn.ReadOnly = false;
                    dtColumn.Unique = false;
                    salesTable.Columns.Add(dtColumn);

                    dtColumn = new();
                    dtColumn.DataType = typeof(int);
                    dtColumn.ColumnName = "orders";
                    dtColumn.Caption = "Orders";
                    dtColumn.ReadOnly = false;
                    dtColumn.Unique = false;
                    salesTable.Columns.Add(dtColumn);

                    dtColumn = new();
                    dtColumn.DataType = typeof(double);
                    dtColumn.ColumnName = "total";
                    dtColumn.Caption = "Total";
                    dtColumn.ReadOnly = false;
                    dtColumn.Unique = false;
                    salesTable.Columns.Add(dtColumn);
                }

                for (int i = 1; i <= count; i++)
                {
                    string clientStringfName = $"SELECT first_name FROM sys.customers WHERE customer_id ={i}";
                    command = new(clientStringfName, connection);
                    string clientFirstName = command.ExecuteScalar().ToString();

                    string clientStringlName = $"SELECT last_name FROM sys.customers WHERE customer_id = {i}";
                    command = new(clientStringlName, connection);
                    string clientLastName = command.ExecuteScalar().ToString();

                    string client = clientFirstName + " " + clientLastName;

                    string purchasesString = $"SELECT SUM(price) FROM sys.report WHERE customer_id = {i}";
                    command = new(purchasesString, connection);
                    double total = double.Parse(command.ExecuteScalar().ToString());

                    string orderString = $"SELECT COUNT(*) FROM sys.report WHERE customer_id={i}";
                    command = new(orderString, connection);
                    int orders = int.Parse(command.ExecuteScalar().ToString());

                    dtRow = salesTable.NewRow();
                    dtRow["client"] = client;
                    dtRow["orders"] = orders;
                    dtRow["total"] = total;
                    salesTable.Rows.Add(dtRow);                 
                }
                ListItems.DataSource = salesTable;
            }
            else
            {
                SalesPanel.Visible = true;
                ListItems.DataSource = null;
                ListItems.Rows.Clear();
                ListItems.Columns.Clear();
                salesTable = null;
            }
            connection.Close();

        }

        private void WhipeText()
        {
            ModelBox.Text = "";
            PriceBox.Text = "";
            StatusBox.Text = "";
        }

        public static ComboBox ItemCombo
        {
           get { return admin.ItemComboBox;  }
           set { admin.ItemComboBox = value; }
        }
    }

    


 }


/*
if (checkBoxCell.Value.Equals(true))
{
    int status = int.Parse(row.Cells[4].Value.ToString());
    string item = row.Cells[2].Value.ToString();

    string product = ModelBox.Text;
    string price = PriceBox.Text;
    string stat = StatusBox.Text;
    if (status == 0) //to set the status to active if it's inactive
    {
        try
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = $"UPDATE sys.{product} SET status = @status WHERE item = '{item}'";

            MySqlParameter statusParameter = new();
            statusParameter.ParameterName = "@status";
            statusParameter.Value = 1;

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Add(statusParameter);

            MySqlDataReader reader = command.ExecuteReader();
            connection.Close();
            MessageBox.Show("Status successfully changed to active");
            checkBoxCell.Value = false;
        }
        catch
        {
            MessageBox.Show("Status wasn't successfully changed to active");

        }
    }
    else
    {
        try
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = $"UPDATE sys.{product} SET status = @status WHERE item = '{item}'";

            MySqlParameter itemParameter = new();
            itemParameter.ParameterName = "@status";
            itemParameter.Value = 0;

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Add(itemParameter);

            MySqlDataReader reader1 = command.ExecuteReader();
            connection.Close();
            MessageBox.Show("Status successfully changed to inactive");
            checkBoxCell.Value = false;
        }
        catch
        {
            MessageBox.Show("Status wasn't successfully changed to inactive");
        }
    }
}*/

/*
               connection.Open();
               string duplicateItemsString = $"SELECT product FROM sys.report WHERE product = '{result[i]}' GROUP BY product HAVING COUNT(product)>1 "; //gets the duplicate product
               command = new(duplicateItemsString, connection);
               string item = command.ExecuteScalar().ToString();
               connection.Close();*/

/*
       private void Cpu_Button_Click(object sender, EventArgs e)
       {
           Connection("cpu");
           product = "cpu";
           if (checkBoxColumn.Visible == true)
           {
               checkBoxColumn.Visible = false;
               panel1.Visible = false;
           }
       }

       private void Ram_Button_Click(object sender, EventArgs e)
       {
           Connection("ram");
           product = "ram";
           if (checkBoxColumn.Visible == true)
           {
               checkBoxColumn.Visible = false;
               panel1.Visible = false;
           }
       }

       private void Psu_Button_Click(object sender, EventArgs e)
       {
           Connection("psu");
           product = "psu";
           if (checkBoxColumn.Visible == true)
           {
               checkBoxColumn.Visible = false;
               panel1.Visible = false;
           }

       }

       private void Mobo_Button_Click(object sender, EventArgs e)
       {
           Connection("mobo");
           product = "mobo";
           if (checkBoxColumn.Visible == true)
           {
               checkBoxColumn.Visible = false;
               panel1.Visible = false;
           }
       }

       private void Hdd_Button_Click(object sender, EventArgs e)
       {
           Connection("hdd");
           product = "hdd";
           if (checkBoxColumn.Visible == true)
           {
               checkBoxColumn.Visible = false;
               panel1.Visible = false;
           }
       }

       private void Gpu_Button_Click(object sender, EventArgs e)
       {
           Connection("gpu");
           product = "gpu";
           if (checkBoxColumn.Visible == true)
           {
               checkBoxColumn.Visible = false;
               panel1.Visible = false;
           }
       }

       private void Ssd_Button_Click(object sender, EventArgs e)
       {
           Connection("ssd");
           product = "ssd";
           if (checkBoxColumn.Visible == true)
           {
               checkBoxColumn.Visible = false;
               panel1.Visible = false;
           }
       }*/

/* private void ListItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
 { 
     if (e.RowIndex > -1)
     {
         //checkBoxCell = (DataGridViewCheckBoxCell)ListItems.Rows[ListItems.CurrentRow.Index].Cells[0];
         int rowIndex = e.RowIndex;

         row = ListItems.Rows[rowIndex];

         if (checkBoxCell.Value == null)
         {
             checkBoxCell.Value = false;
         }

         switch (checkBoxCell.Value.ToString())
         {
             case "True":
                 checkBoxCell.Value = false;
                 break;
             case "False":
                 checkBoxCell.Value = true;
                 break;
         }

         string item = row.Cells[2].Value.ToString();
         string price = row.Cells[3].Value.ToString();
         string status = row.Cells[4].Value.ToString();

         ModelBox.Text = item;
         PriceBox.Text = price;
         StatusBox.Text = status;
           if (checkBoxCell.Value.Equals(true))
           {
               ModelBox.Text = item;
               PriceBox.Text = price;
               StatusBox.Text = status;
           }
           else
           {
               ModelBox.Text = "";
               PriceBox.Text = "";
               StatusBox.Text = "";
           }

     }
 }*/
