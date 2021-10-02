using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace PcCatalog
{
    public partial class EditPurchase : Form
    {
        public EditPurchase()
        {
            InitializeComponent();
            Connection();
        }

        private void EditGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        
          //  DataGridViewRow row = EditGrid.Rows[e.RowIndex];
          //  int rowIndex = EditGrid.CurrentCell.RowIndex;
          ////  Shop.boughtProductPrice = double.Parse(row.Cells[1].Value.ToString());
          //  EditGrid.Rows.RemoveAt(rowIndex);// removes selected item
          //
          //  string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
          //  MySqlConnection connection = new MySqlConnection(connectionString);
          //  connection.Open();
          //  string product = row.Cells[1].Value.ToString();
          //  string productRemove = "DELETE FROM sys.purchase WHERE item = @item";
          //  MySqlParameter itemParameter = new();
          //  itemParameter.ParameterName = "@item";
          //  itemParameter.Value = product;
          //
          //  MySqlCommand command = new MySqlCommand(productRemove, connection);
          //  command.Parameters.Add(itemParameter);
          //
          //  MySqlDataReader reader = command.ExecuteReader();
          //
          //  connection.Close();
          

        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
           // double refund = .0;
           // refund += Shop.boughtProductPrice;
           //
           // double priceNew = double.Parse(priceLabel.Text);
           // priceNew -= refund;
           // priceLabel.Text = priceNew.ToString();
           // this.Hide();
        }
        public static DataGridView _EditGrid
        { get; set; }

        public static double _boughtProductPrice
        { get; set; }

        private void Connection()
        {
            string connectionString = "server=localhost;user=root;database=sys;port=3306;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string productQuery = "SELECT item, price FROM sys.purchase";

            using (MySqlCommand command = new MySqlCommand(productQuery, connection))
            {
                command.CommandType = CommandType.Text;
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    using (DataTable DataTable = new DataTable())
                    {
                        adapter.Fill(DataTable);
                        EditGrid.DataSource = DataTable;// fill first datagrid
                    }
                }
            }


            connection.Close();
        }

        private void EditPurchase_FormClosed(object sender, EventArgs e)
        {

        }

        private void EditGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


/*
      


        double totalPrice = Shop.totalPrice;
            totalPrice -= boughtProductPrice;
            shop.priceLabel.Text = Math.Round(totalPrice, 2).ToString();
            
            double budget = double.Parse(shop.Budget_Label.Text);
            budget += boughtProductPrice;
            shop.Budget_Label.Text = Math.Round(budget, 2).ToString();
*/
// string price = shop.priceLabel.Text + "test";

//shop.priceLabel.Text = price.ToString();

// checkBoxColumn.Name = "SelectProduct";
// checkBoxColumn.HeaderText = "";
// checkBoxColumn.Width = 50;
// checkBoxColumn.ReadOnly = false;
// checkBoxColumn.FillWeight = 10;
// EditGrid.Columns.Insert(0, checkBoxColumn);
// EditGrid.DataSource = Shop.boughtProducts;
//  private double refund = 0;
//double priceLabel = .0;