using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace PcCatalog
{
    public partial class Shop : Form
    {
        private static double productPrice = .0; // gets the price from the label
        private static double totalPrice = .0; // used for calculating the price 

        private static DataTable boughtProducts = new(); // stores the info about the bought products
                                                         //public static double boughtProductPrice = .0; // stores the price of a product

        // EditPurchase editPurchase = new EditPurchase();

        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn(); // a checkBoxColumn for the ListItems Grid
        private static DataGridViewCheckBoxCell checkBoxCell; // instance of the checkBoxCell for ListItems Grid 

        DataGridViewCheckBoxColumn checkBoxColumnEditGrid = new DataGridViewCheckBoxColumn(); // a checkBoxColumn for the EditGrid
        private static DataGridViewCheckBoxCell checkBoxCellEditGrid; //instance of the checkBoxCell for EditGrid

        private static double price = .0; //to save the changes made to the total cost; goes to cart.cs
        private static string product; // saves the type of product
        int id = 0;
        private static AdminScreen admin = new();
        public Shop()
        {

            InitializeComponent();
            //properties of the checkboxcolum for ListItems
            checkBoxColumn.Name = "SelectProduct";
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            checkBoxColumn.FillWeight = 10;
            ListItems.Columns.Insert(0, checkBoxColumn);

            //properties of the checkboxcolum for EditGrid
            checkBoxColumnEditGrid.Name = "SelectProduct";
            checkBoxColumnEditGrid.HeaderText = "";
            checkBoxColumnEditGrid.Width = 50;
            checkBoxColumnEditGrid.ReadOnly = false;
            checkBoxColumnEditGrid.FillWeight = 10;
            EditGrid.Columns.Insert(0, checkBoxColumnEditGrid);

            Budget_Label.Text = BudgetAdd.Budget; // getting the budget from budget
            EditGrid.Visible = false;
            EditGrid.ReadOnly = true;
            this.EditGrid.AllowUserToAddRows = false;

            ItemComboBox.Items.Add("Processors(CPU)");
            ItemComboBox.Items.Add("Graphics Cards(GPU)");
            ItemComboBox.Items.Add("Hard Drives(HDD)");
            ItemComboBox.Items.Add("Motherboards(MOBO)");
            ItemComboBox.Items.Add("Power Supplies(PSU)");
            ItemComboBox.Items.Add("Ram");
            ItemComboBox.Items.Add("Solid State Drives(SSD)");

         
        }
        private void Cpu_Button_Click(object sender, EventArgs e)
        {
            Connection("cpu");
            product = "cpu";
        }

        private void Gpu_Button_Click(object sender, EventArgs e)
        {

            Connection("gpu");
            product = "gpu";

        }
        private void Hdd_Button_Click(object sender, EventArgs e)
        {

            product = "hdd";
            Connection("hdd");
        }

        private void Mobo_Button_Click(object sender, EventArgs e)
        {

            product = "mobo";
            Connection("mobo");
        }

        private void Psu_Button_Click(object sender, EventArgs e)
        {

            product = "psu";
            Connection("psu");
        }

        private void Ram_Button_Click(object sender, EventArgs e)
        {
            product = "ram";
            Connection("ram");
        }
        private void Ssd_Button_Click(object sender, EventArgs e)
        {

            product = "ssd";
            Connection("ssd");
        }
        private void ListItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                checkBoxCell = (DataGridViewCheckBoxCell)ListItems.Rows[ListItems.CurrentRow.Index].Cells[0];
                int rowIndex = e.RowIndex;
                DataGridViewRow row = ListItems.Rows[rowIndex];


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

                string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
                MySqlConnection mySqlConnection = new(connectionString);
                mySqlConnection.Open();

                if (checkBoxCell.Value.Equals(true))
                {
                    productPrice = double.Parse(row.Cells[2].Value.ToString());

                    string item = row.Cells[1].Value.ToString();
                    double price = double.Parse(row.Cells[2].Value.ToString());

                    string productIdString = $"SELECT product_id FROM {product} WHERE item = '{item}' ";
                    MySqlCommand productIdCommand = new(productIdString, mySqlConnection);
                    int productId = Convert.ToInt32(productIdCommand.ExecuteScalar());

                    mySqlConnection.Close();

                    mySqlConnection.Open();
                    string query = $"INSERT INTO sys.purchase (item,price,product_id) VALUES(@item,@price,@productid)";
                    MySqlParameter itemParameter = new();
                    itemParameter.ParameterName = "@item";
                    itemParameter.Value = item;

                    MySqlParameter priceParameter = new();
                    priceParameter.ParameterName = "@price";
                    priceParameter.Value = price;

                    MySqlParameter idParameter = new();
                    idParameter.ParameterName = "@productid";
                    idParameter.Value = productId;

                    MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                    command.Parameters.Add(itemParameter);
                    command.Parameters.Add(priceParameter);
                    command.Parameters.Add(idParameter);

                    MySqlDataReader reader = command.ExecuteReader();
                    mySqlConnection.Close();


                    double currentProductPrice = PriceCalculation(); // a local variable used to only calculate the price per product 
                    BudgetCalculation(currentProductPrice);
                   /* currentProductPrice += productPrice; // calculating the price
                    totalPrice += currentProductPrice;  // adding the calculated price to the global variable
                    priceLabel.Text = Math.Abs(Math.Round(totalPrice, 2)).ToString(); // setting the label for the total price using the global variable

                    double budget = double.Parse(Budget_Label.Text); // getting the budget from the budget label
                    price = double.Parse(priceLabel.Text); // getting the price from the the price label

                    budget -= currentProductPrice; // calculating how much budget is left
                    Budget_Label.Text = Math.Round(budget, 2).ToString(); // displaying the left budget*/

                }
                else if (checkBoxCell.Value.Equals(false)) // item uncheck
                {
                    //mySqlConnection.Open();
                    if (totalPrice > 0)
                    {
                        string product = row.Cells[1].Value.ToString();
                        string productRemove = "DELETE FROM sys.purchase WHERE item = @item";
                        MySqlParameter itemParameter = new();
                        itemParameter.ParameterName = "@item";
                        itemParameter.Value = product;

                        MySqlCommand command = new MySqlCommand(productRemove, mySqlConnection);
                        command.Parameters.Add(itemParameter);

                        MySqlDataReader reader = command.ExecuteReader();

                        productPrice = double.Parse(row.Cells[2].Value.ToString()); // gets the value of the current product
                        totalPrice -= productPrice; // after removing product, remove the cost of the product

                        priceLabel.Text = Math.Abs(Math.Round(totalPrice, 2)).ToString(); // displaying price after change

                        double editedBudget = double.Parse(Budget_Label.Text); //getting the budget from the label 
                        editedBudget += productPrice; // returning the sum from the removed products;

                        Budget_Label.Text = Math.Round(editedBudget, 2).ToString(); // displaying the restored budget
                    }
                }
                mySqlConnection.Close();
            }
        }
   
        private void Cart_Button_Click(object sender, EventArgs e)
        {
            Cart cart = new();
            cart.Show();

            this.Hide();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            BudgetAdd budgetAdd = new();
            budgetAdd.Show();

            this.Hide();

            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection mySqlConnection = new(connectionString);
            mySqlConnection.Open();

            string query = $"TRUNCATE TABLE purchase";
            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();
            mySqlConnection.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string productQuery = $"SELECT item,price FROM sys.purchase";

            using (MySqlCommand command = new MySqlCommand(productQuery, connection))
            {
                command.CommandType = CommandType.Text;
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        adapter.Fill(dataTable);
                        EditGrid.DataSource = dataTable;// fill first datagrid
                    }
                }
            }
            connection.Close();
            ReturnToListItems.Visible = true;
            ListItems.Visible = false;
            EditGrid.Visible = true;

        }

        private void Connection(string product)
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
                        ListItems.DataSource = dataTable;// fill first datagrid
                    }
                }
            }


        }

        private void Shop_FormClosed(object sender, FormClosedEventArgs e)
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

        private void RemoveBoughtProducts_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
                MySqlConnection connection = new(connectionString);
                connection.Open();

                string query = $"TRUNCATE TABLE purchase";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
                int error = 0;
                priceLabel.Text = "0";
                Budget_Label.Text = BudgetAdd.Budget;
                productPrice = 0;
                totalPrice = 0;
                price = 0;
                
                foreach (DataGridViewColumn column in ListItems.Columns)
                {
                    try
                    {
                        checkBoxCell.Value = false;
                    }
                    catch
                    {
                        MessageBox.Show("Select at least one product");
                        error++;
                    }
                }
                if (error == 0)
                    MessageBox.Show("Successfully removed all items!");
            }
            catch
            {
                MessageBox.Show("Item removal unsuccessful.");
            }
        }

        private void ReturnToListItems_Click(object sender, EventArgs e)
        {
            Connection(product);
            ListItems.Visible = true;
            EditGrid.Visible = false;
            ReturnToListItems.Visible = false;
        }
        private void EditGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          // int rows = RowCount();
          // List<int> ids = new List<int>();
          //
          // for(int i = 0; i<rows;i++)
          // {
          //
          // }
            if (e.RowIndex > -1)
            {
                checkBoxCellEditGrid = (DataGridViewCheckBoxCell)EditGrid.Rows[EditGrid.CurrentRow.Index].Cells[0];

                int rowIndex = e.RowIndex;

                DataGridViewRow row = EditGrid.Rows[rowIndex];

                double budget = double.Parse(Budget_Label.Text);

                string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";

                MySqlConnection connection = new(connectionString);
                connection.Open();

               if (checkBoxCellEditGrid.Value == null)
                {
                    checkBoxCellEditGrid.Value = false;
                }

                switch (checkBoxCellEditGrid.Value.ToString())
                {
                    case "True":
                        checkBoxCellEditGrid.Value = false;
                        break;
                    case "False":
                        checkBoxCellEditGrid.Value = true;
                        break;
                }
                if (checkBoxCellEditGrid.Value.Equals(true))
                {
                    string product = row.Cells[1].Value.ToString();
                    string idString = $"SELECT product_id FROM sys.purchase WHERE item = '{product}'";
                    MySqlCommand idCommand = new(idString, connection);
                    id = int.Parse(idCommand.ExecuteScalar().ToString());
                    connection.Close();

                    connection.Open();
                  
                    string productRemove = "DELETE FROM sys.purchase WHERE item = @item";
                    MySqlParameter itemParameter = new();
                    itemParameter.ParameterName = "@item";
                    itemParameter.Value = product;

                    MySqlCommand command = new MySqlCommand(productRemove, connection);
                    command.Parameters.Add(itemParameter);

                    MySqlDataReader reader = command.ExecuteReader();
                    double currentPrice = double.Parse(priceLabel.Text);

                    double price = double.Parse(row.Cells[2].Value.ToString());
                    currentPrice = double.Parse(priceLabel.Text); //??
                    currentPrice -= price;
                    priceLabel.Text = Math.Abs(Math.Round(currentPrice, 2)).ToString();

                    budget += price;
                    Budget_Label.Text = Math.Abs(Math.Round(budget, 2)).ToString();
                    connection.Close();
                    productPrice = 0;
                    totalPrice = 0;
                    connection.Open();

                    int counter = 0;
                    counter++;
                    string idDrop = "ALTER TABLE sys.purchase DROP COLUMN id, DROP PRIMARY KEY";
                    MySqlCommand idDropCommand = new(idDrop, connection);
                    reader = idDropCommand.ExecuteReader();
                    connection.Close();
                    connection.Open();
                    string idField = "ALTER TABLE sys.purchase ADD COLUMN id INT NOT NULL AUTO_INCREMENT AFTER price,ADD PRIMARY KEY(id)";
                    MySqlCommand idFieldCommand = new(idField, connection);
                    reader = idFieldCommand.ExecuteReader();
                    connection.Close();
                   // for (int i = 0; i<rows; i++)
                   // {
                   //    connection.Open();
                   //    
                   // }
                }
                else if (checkBoxCellEditGrid.Value.Equals(false))
                {
                    
                    string item = row.Cells[1].Value.ToString();
                    string cost = row.Cells[2].Value.ToString();
                   
                    string productReturn = "INSERT INTO sys.purchase (product_id,item,price) VALUES (@id,@item, @cost)";

                    MySqlParameter idParameter = new();
                    idParameter.ParameterName = "@id";
                    idParameter.Value = id;

                    MySqlParameter itemParameter = new();
                    itemParameter.ParameterName = "@item";
                    itemParameter.Value = item;

                    MySqlParameter costParameter = new();
                    costParameter.ParameterName = "@cost";
                    costParameter.Value = cost;

                    
                    MySqlCommand command = new MySqlCommand(productReturn, connection);
                    command.Parameters.Add(itemParameter);
                    command.Parameters.Add(costParameter);
                    command.Parameters.Add(idParameter);
                    MySqlDataReader reader = command.ExecuteReader();

                    double price = double.Parse(row.Cells[2].Value.ToString());
                    double currentPrice = double.Parse(priceLabel.Text);
                    currentPrice += price;

                    priceLabel.Text = Math.Abs(Math.Round(currentPrice, 2)).ToString();
                    budget = double.Parse(Budget_Label.Text);
                    budget -= price;
                    Budget_Label.Text = Math.Round(budget, 2).ToString();
                }
            }
        }

        private static int RowCount()
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new(connectionString);
            connection.Open();

            string rowCountQuery = "SELECT COUNT(*) FROM sys.purchase";
            MySqlCommand rowCountCommand = new(rowCountQuery, connection);
            int rows = int.Parse(rowCountCommand.ExecuteScalar().ToString());
            connection.Close();
            return rows;
        }
        private static int IdQuery(string product)
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new(connectionString);
            connection.Open();
            string idQuery = $"SELECT id FROM sys.purchase WHERE item = {product}";

            MySqlCommand idCommand = new(idQuery, connection);
            int id = int.Parse(idCommand.ExecuteScalar().ToString());
            connection.Close();
            return id;
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

        public static double Price
        {
            get { return price; }
            set { price = value; }
        }

        public static DataTable BoughtProducts
        {
            get { return boughtProducts; }
            set { boughtProducts = value; }
        }

        private double PriceCalculation()
        {
            double currentProductPrice = .0; // a local variable used to only calculate the price per product 
            currentProductPrice += productPrice; // calculating the price
            totalPrice += currentProductPrice;  // adding the calculated price to the global variable
            priceLabel.Text = Math.Abs(Math.Round(totalPrice, 2)).ToString(); // setting the label for the total price using the global variable

            return currentProductPrice;
        }
        private double BudgetCalculation(double currentProductPrice)
        {
            double budget = double.Parse(Budget_Label.Text); // getting the budget from the budget label
            price = double.Parse(priceLabel.Text); // getting the price from the the price label
            budget -= currentProductPrice; // calculating how much budget is left
            Budget_Label.Text = Math.Round(budget, 2).ToString(); // displaying the left budget

            return budget;
        }











        /*
private void listView1_SelectedIndexChanged(object sender, EventArgs e)
{

   string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
   MySqlConnection connection = new MySqlConnection(connectionString);
   connection.Open();
   string productQuery = "SELECT * FROM sys.cpu";
   using (MySqlCommand command = new MySqlCommand(productQuery, connection))
   {
       command.CommandType = CommandType.Text;
       using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
       {
           DataTable dt = new();
           adapter.Fill(dt);

           foreach (DataRow row in dt.Rows)
           {
               ListViewItem item = new ListViewItem(row["cpu_price"].ToString());
               ListViewItem item2 = new ListViewItem(row["model"].ToString());
               listView1.Items.Add(item);
           }
           listView1.View = View.List;
       }
   }
}*/
    }
    }

/*
string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
MySqlConnection connection = new MySqlConnection(connectionString);
connection.Open();
string productQuery = "SELECT * FROM sys.cpu";
using (MySqlCommand command = new MySqlCommand(productQuery, connection))
{
    command.CommandType = CommandType.Text;
    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
    {
        using (DataTable dataTable = new DataTable())
        {
            adapter.Fill(dataTable);
            ListItems.DataSource = dataTable;
        }
    }
}*/
/*
if (rowIndex != -1 && columnIndex != -1)
{
    /*
    if(columnIndex==1 && rowIndex==1)
    {
        priceLabel.Text = "11";
    }
    else if(columnIndex == 0 && rowIndex ==0)
    {
        priceLabel.Text = "00";
    }
    else if(columnIndex == 1 && rowIndex ==0)
    {
        priceLabel.Text = "10";
    }
    else if(columnIndex == 0 && rowIndex ==1)
    {
        priceLabel.Text = "01";
    }*/
// MessageBox.Show(ListItems.CurrentCell.Value.ToString());
/*
                switch (columnIndex)
                {
                    case i:
                        priceLabel.Text = row.Cells[1].Value.ToString();     //ListItems.CurrentCell.Value.ToString();
                        break;

                    case 1:
                        priceLabel.Text = row.Cells[1].Value.ToString();
                        break;
                }*/
/*
            DataColumn = new DataColumn();
            DataColumn.DataType = Type.GetType("System.String");
            DataColumn.ColumnName = "Items";
            DataColumn.ReadOnly = true;
            DataColumn.Unique = true;         
            boughtProducts.Columns.Add(DataColumn);

            DataColumn = new DataColumn();
            DataColumn.DataType = Type.GetType("System.Double");
            DataColumn.ColumnName = "Price";
            DataColumn.ReadOnly = true;
            DataColumn.Unique = true;         
            boughtProducts.Columns.Add(DataColumn);*/
/*
                DataRow = boughtProducts.NewRow();
                DataRow["Items"] = row.Cells[1].Value.ToString();
                DataRow["Price"] = double.Parse(row.Cells[2].Value.ToString());
                boughtProducts.Rows.Add(DataRow);
                */
// if (!boughtProducts.Columns.Contains("Items") && !boughtProducts.Columns.Contains("Price"))
// {
//     boughtProducts.Columns.Add("Items", typeof(string));
//     boughtProducts.Columns["Items"].ReadOnly = true;
//
//     boughtProducts.Columns.Add("Price", typeof(double));
//     boughtProducts.Columns["Price"].ReadOnly = true;
// }

/*
   
 */