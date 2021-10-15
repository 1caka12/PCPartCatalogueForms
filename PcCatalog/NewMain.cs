using System;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;

namespace PcCatalog
{
    public partial class NewMain : Form
    {
        private static DataGridViewButtonColumn buttonColumn;
        private static List<double> selectedProductsPrice;
        private static List<string> selectedProductsName;
        private static List<int> selectedProductsId;
        private static string currentProduct;
       
        
        NewCart newCart = new();
        public NewMain()
        {
            InitializeComponent();
        }

        private void NewMain_Load(object sender, EventArgs e)
        { 
           
        }
        

       //
       //Buttons for products
       //
        private void processorMenuItem_Click(object sender, EventArgs e)
        {
            currentProduct = "cpu";
            if(shopCostPanel.Visible==false)
               OpenMenu("shop");
                 
            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("cpu");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);        
        }

        private void graphicsCardsMenuItem_Click(object sender, EventArgs e)
        {
            currentProduct = "gpu";
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("gpu");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);

        }

        private void hardDrivesMenuItem_Click(object sender, EventArgs e)
        {
            currentProduct = "hdd";
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("hdd");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }

        private void motherboardsMenuItem_Click(object sender, EventArgs e)
        {
            currentProduct = "mobo";
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

           productSalesDataGrid.DataSource = Utilities.ProductsDataTable("mobo");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }

        private void powerSuppliesMenuItem_Click(object sender, EventArgs e)
        {
            currentProduct = "psu";
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

           productSalesDataGrid.DataSource = Utilities.ProductsDataTable("psu");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }

        private void ramMenuItem_Click(object sender, EventArgs e)
        {
            currentProduct = "ram";
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("ram");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }

        private void ssdMenuItem_Click(object sender, EventArgs e)
        {
            currentProduct = "ssd";
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

           productSalesDataGrid.DataSource = Utilities.ProductsDataTable("ssd");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }
        //
        //
        //

        private void exitButton_Click(object sender, EventArgs e)
        {
            if(shopCostPanel.Visible == true)
               ExitMenu("shop");
        }
        private void OpenMenu(string menu)
        {
            exitButton.Visible = true;
            productSalesDataGrid.Visible = true;
            if (menu == "shop")
            {
                shopCostPanel.Visible = true;
                toCartButton.Visible = true;             
            }
        }
        private void ExitMenu(string menu)
        {
            exitButton.Visible = false;
            productSalesDataGrid.Visible = false;
            if (menu == "shop")
            {
                shopCostPanel.Visible = false;
                toCartButton.Visible = false;           
            }
        }

        private void productSalesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = productSalesDataGrid.Rows[rowIndex];
            
            if (e.ColumnIndex == productSalesDataGrid.Columns["buttonColumn"].Index)
            {
                double price = double.Parse(row.Cells[2].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                costLabel.Text = Utilities.DisplayPrice(price, "add");
                selectedProductsPrice.Add(price);
                selectedProductsName.Add(name);
                selectedProductsId.Add(Utilities.GetProductId(currentProduct,name,price));

                productSalesDataGrid.Rows.Remove(row);           
            }
            
        }
    
        private void productStrip_Click(object sender, EventArgs e)
        {                                            
            if (productSalesDataGrid.Columns["buttonColumn"] == null)
            {
                buttonColumn = new();
                {
                    buttonColumn.Name = "buttonColumn";
                    buttonColumn.HeaderText = "";
                    buttonColumn.Text = "Add";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    buttonColumn.FlatStyle = FlatStyle.Standard;
                }
                productSalesDataGrid.Columns.Insert(0, buttonColumn);
                selectedProductsName = new();
                selectedProductsPrice = new();
                selectedProductsId = new();            
            }          
            
        }
      
        private void toCartButton_Click(object sender, EventArgs e)
        {
            newCart.Show();
        }
        public static List<string> SelectedProductsNameList
        {
            get { return selectedProductsName; }
            set { selectedProductsName = value; }
        }

        public static List<double> SelectedProductsPriceList
        {
            get { return selectedProductsPrice; }
            set { selectedProductsPrice = value; }
        }

        public static List<int> SelectedProductsIDList
        {
            get { return selectedProductsId; }
            set { selectedProductsId = value; }
        }
    }
        
}
