using System;
using System.Windows.Forms;

namespace PcCatalog
{
    public partial class NewCart : Form
    {
        private static DataGridViewColumn dataGridViewColumn;
        private static DataGridViewButtonColumn buttonColumn;
        private static NewCart newCart = new();
        private static int displayQuantity = 0;
        private static double currentTotal = 0;
        public NewCart()
        {
            InitializeComponent();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {

        }

        private void NewCart_Load(object sender, EventArgs e)
        {
            if (boughtProductsDataGrid.Columns["productColumn"] == null)
            {
                dataGridViewColumn = new DataGridViewTextBoxColumn();
                {
                    dataGridViewColumn.Name = "productColumn";
                    dataGridViewColumn.HeaderText = "Product";
                    dataGridViewColumn.DataPropertyName = "Product";
                    dataGridViewColumn.ReadOnly = true;
                }
                boughtProductsDataGrid.Columns.Insert(0, dataGridViewColumn);

                dataGridViewColumn = new DataGridViewTextBoxColumn();
                {
                    dataGridViewColumn.Name = "priceColumn";
                    dataGridViewColumn.HeaderText = "Price";
                    dataGridViewColumn.DataPropertyName = "Price";
                    dataGridViewColumn.ReadOnly = true;
                }
                boughtProductsDataGrid.Columns.Insert(1, dataGridViewColumn);             
                
                dataGridViewColumn = new DataGridViewTextBoxColumn();
                {
                    dataGridViewColumn.Name = "quantityColumn";
                    dataGridViewColumn.HeaderText = "Quantity";
                    dataGridViewColumn.ReadOnly = true;                    
                }
                boughtProductsDataGrid.Columns.Insert(2, dataGridViewColumn);
              
                buttonColumn = new();
                {
                    buttonColumn.Name = "buyMore";
                    buttonColumn.HeaderText = "";
                    buttonColumn.Text = "+";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    buttonColumn.FlatStyle = FlatStyle.Standard;
                    
                }
                boughtProductsDataGrid.Columns.Insert(3, buttonColumn);
                
                buttonColumn = new();
                {
                    buttonColumn.Name = "buyLess";
                    buttonColumn.HeaderText = "";
                    buttonColumn.Text = "-";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    buttonColumn.FlatStyle = FlatStyle.Standard;
                   
                }
                boughtProductsDataGrid.Columns.Insert(4, buttonColumn);

                double sumOfProducts = .0;
                for(int i = 0; i < NewMain.SelectedProductsNameList.Count;i++)
                {
                    boughtProductsDataGrid.Rows.Add(NewMain.SelectedProductsNameList[i],
                        NewMain.SelectedProductsPriceList[i],"1");

                    sumOfProducts += NewMain.SelectedProductsPriceList[i];                  
                }
                CartPriceLabel.Text = sumOfProducts.ToString();
                currentTotal = sumOfProducts;
            }
        }
       

        private void boughtProductsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = boughtProductsDataGrid.Rows[rowIndex];                   
            int productQuantity = 0;
            double totalSum = .0;
            double productPrice = .0;
            if(e.ColumnIndex == boughtProductsDataGrid.Columns["buyMore"].Index)
            {
                //For display purpose- to display the quantity of bought products
                displayQuantity = int.Parse(row.Cells[2].Value.ToString());
                displayQuantity++;
                row.Cells[2].Value = displayQuantity;
                //for calculation purpose - to calculate the actual sum
                productQuantity++;
                productPrice = double.Parse(row.Cells[1].Value.ToString());
                totalSum = productPrice * productQuantity;               
                CartPriceLabel.Text = (totalSum+currentTotal).ToString();
                currentTotal += totalSum;
            }
            else if(e.ColumnIndex == boughtProductsDataGrid.Columns["buyLess"].Index)
            {
                            
                if (productQuantity <= 0)
                {
                    displayQuantity = int.Parse(row.Cells[2].Value.ToString());
                    displayQuantity--;
                    row.Cells[2].Value = displayQuantity;
             
                    productQuantity--;
                    productPrice = double.Parse(row.Cells[1].Value.ToString());
                    totalSum = productPrice * productQuantity;
                    CartPriceLabel.Text = (currentTotal+totalSum).ToString();
                    currentTotal += totalSum;
                }
                if(displayQuantity == 0)
                {
                    boughtProductsDataGrid.Rows.Remove(row);
                }
                
                
            }           
        }
        public static DataGridView BoughtProductsDataGrid
        {
            get { return newCart.boughtProductsDataGrid; }
            set { newCart.boughtProductsDataGrid = value; }
        }
    }
}
/*for (int i = 0; i < NewCart.BoughtProductsDataGrid.Rows.Count; i++)
                {
                    if (NewCart.BoughtProductsDataGrid.Rows[i].Cells[i].Value.ToString() == name)
                    {
                        NewCart.BoughtProductsDataGrid.Rows.Add();
                    }
                    else
                    {
                        NewCart.BoughtProductsDataGrid.Rows.Add(name, price,1);
                    }
                }
 */