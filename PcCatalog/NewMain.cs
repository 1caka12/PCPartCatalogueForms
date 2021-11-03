﻿using System;
using System.Windows.Forms;
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
        private static List<string> selectedProductType;
        private static string currentProductType;
        private static string changeToDataBase;
        private static string changeToDataBaseQuery;
        private static string mode;
        private DataTable salesCustomersTable;
        //private DataRow dtRow;
        private DataColumn dtColumn;
       
        
        NewCart newCart = new();
        public NewMain()
        {
            InitializeComponent();
        }

        private void NewMain_Load(object sender, EventArgs e)
        {
            if (ProductComboBox.Items.Count == 0)
            {
                ProductComboBox.Items.Add("Processors(CPU)");
                ProductComboBox.Items.Add("Graphics Cards(GPU)");
                ProductComboBox.Items.Add("Hard Drives(HDD)");
                ProductComboBox.Items.Add("Motherboards(MOBO)");
                ProductComboBox.Items.Add("Power Supplies(PSU)");
                ProductComboBox.Items.Add("Ram");
                ProductComboBox.Items.Add("Solid State Drives(SSD)");
            }
            salesCustomersTable = new();
        }
        

       
       //Buttons for products on the client side
       //
        private void processorMenuItem_Click(object sender, EventArgs e)
        {
            currentProductType = "cpu";
            if(shopCostPanel.Visible==false)
               MenuAction("shop",true);
                 
            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("cpu");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);        
        }

        private void graphicsCardsMenuItem_Click(object sender, EventArgs e)
        {
            currentProductType = "gpu";
            if (shopCostPanel.Visible == false)
                MenuAction("shop",true);

            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("gpu");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);

        }

        private void hardDrivesMenuItem_Click(object sender, EventArgs e)
        {
            currentProductType = "hdd";
            if (shopCostPanel.Visible == false)
                MenuAction("shop",true);

            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("hdd");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }

        private void motherboardsMenuItem_Click(object sender, EventArgs e)
        {
            currentProductType = "mobo";
            if (shopCostPanel.Visible == false)
                MenuAction("shop",true);

           productSalesDataGrid.DataSource = Utilities.ProductsDataTable("mobo");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }

        private void powerSuppliesMenuItem_Click(object sender, EventArgs e)
        {
            currentProductType = "psu";
            if (shopCostPanel.Visible == false)
                MenuAction("shop",true);

           productSalesDataGrid.DataSource = Utilities.ProductsDataTable("psu");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }

        private void ramMenuItem_Click(object sender, EventArgs e)
        {
            currentProductType = "ram";
            if (shopCostPanel.Visible == false)
                MenuAction("shop",true);

            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("ram");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }

        private void ssdMenuItem_Click(object sender, EventArgs e)
        {
            currentProductType = "ssd";
            if (shopCostPanel.Visible == false)
                MenuAction("shop",true);

           productSalesDataGrid.DataSource = Utilities.ProductsDataTable("ssd");
            Utilities.CheckForAddedItems(selectedProductsName, productSalesDataGrid);
        }
        //Buttons for products on the client side
      
        

        // Shop         
        private void exitButton_Click(object sender, EventArgs e)
        {
            if(shopCostPanel.Visible == true)
              MenuAction("shop",false);
        }
        
        private void MenuAction(string menu,bool closeOrOpen)
        {
            if(menu == "shop")
            {
                shopCostPanel.Visible = closeOrOpen;
                toCartButton.Visible = closeOrOpen;
                exitButton.Visible = closeOrOpen;
                productSalesDataGrid.Visible = closeOrOpen;

                if (closeOrOpen == false)
                {
                    productSalesDataGrid.DataSource = null;
                    productSalesDataGrid.Columns.Remove(buttonColumn);                
                    selectedProductsId.Clear();
                    selectedProductsName.Clear();
                    selectedProductsPrice.Clear();     
                }
            }          
            else if(menu == "admin")
            {
                ProductsPanel.Visible = closeOrOpen;
                AdminDataBaseEditorPanel.Visible = closeOrOpen;
                productSalesDataGrid.Visible = closeOrOpen;                              
                if (closeOrOpen == false)
                {
                    ModelBox.Text = "";
                    PriceBox.Text = "";
                    StatusBox.Text = "";
                }
            }         
            else if(menu == "salesReport")
            {
                ProductsPanel.Visible = closeOrOpen;
                productSalesDataGrid.Visible = closeOrOpen;

                if (closeOrOpen == false)
                {
                    salesCustomersTable.Clear();
                    productSalesDataGrid.DataSource = null;
                }
                if (closeOrOpen == true)
                    salesCustomersTable = new("Sales Report");
            }
            else if(menu == "customersReport")
            {
                productSalesDataGrid.Visible = closeOrOpen;

                if (closeOrOpen == false)
                {
                    salesCustomersTable.Clear();
                    productSalesDataGrid.DataSource = null;
                }
                if (closeOrOpen == true)
                    salesCustomersTable = new("Customers Report");
            }
        }

        private void productSalesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mode != "admin")
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
                    selectedProductsId.Add(Utilities.GetProductId(currentProductType, name, price.ToString()));
                    selectedProductType.Add(currentProductType);

                    productSalesDataGrid.Rows.Remove(row);
                }
            }          
        }
    
        private void productStrip_Click(object sender, EventArgs e)
        {
            if (AdminDataBaseEditorPanel.Visible == true)          
                 MenuAction("admin", false);
            if (salesCustomersTable.Columns.Contains("product"))
                MenuAction("salesReport", false);
            if (salesCustomersTable.Columns.Contains("customer"))
                MenuAction("customersReport", false);

            MenuAction("shop", true);

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
                selectedProductType = new();
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

        public static List<string> SelectedProductTypeList
        {
            get { return selectedProductType; }
            set { selectedProductType = value; }
        }
        // Shop

        // Admin
        private void adminMenu_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == true)
                MenuAction("shop", false);
            if (salesCustomersTable.Columns.Contains("product"))
                MenuAction("salesReport", false);
            if (salesCustomersTable.Columns.Contains("customer"))
                MenuAction("customersReport", false);

            MenuAction("admin", true);
            mode = "admin";

            if (ProductComboBox.Items.Contains("All"))
            {
                ProductComboBox.Items.Remove("All");
            }
        }
        private void NewProductButton_Click(object sender, EventArgs e)
        {
            changeToDataBase = "addProduct";
            changeToDataBaseQuery = $"INSERT INTO sys.{currentProductType} (item,{currentProductType}_price,status) VALUES (@item,@price,@status)";
            SaveCancelPanel.Visible = true;
            ModelBox.ReadOnly = false;
            PriceBox.ReadOnly = false;
            StatusBox.ReadOnly = false;

            CorrectionButton.Visible = false;
            RemoveProductButton.Visible = false;
        }

        private void CorrectionButton_Click(object sender, EventArgs e)
        {
            changeToDataBase = "addCorrection";
            SaveCancelPanel.Visible = true;

            ModelBox.ReadOnly = false;
            PriceBox.ReadOnly = false;
            StatusBox.ReadOnly = false;

            NewProductButton.Visible = false;
            RemoveProductButton.Visible = false;
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            string product = ModelBox.Text;
            string price = PriceBox.Text;
            int productId = Utilities.GetProductId(currentProductType, product, price);
            
            changeToDataBase = "remove";

            changeToDataBaseQuery = $"DELETE FROM sys.{currentProductType} WHERE product_id={productId}";

            SaveCancelPanel.Visible = true;
            MessageBox.Show("Deleting this product will permamently remove it from the Database! " +
                "To proceed with the changes press the 'Save' button below.", "Deleting Product?", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            NewProductButton.Visible = false;
            CorrectionButton.Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string model = ModelBox.Text;
            string price = PriceBox.Text;
            string status = StatusBox.Text;

            if (changeToDataBase == "addProduct") 
                Utilities.AddProductToDataBase(model, price, status, changeToDataBaseQuery);
            else if(changeToDataBase == "addCorrection")
            {
                if (!ModelBox.Text.Equals("") && !PriceBox.Text.Equals("") && !StatusBox.Text.Equals(""))
                {                                    
                    int productId = Utilities.GetProductId(currentProductType, model, price);
                    changeToDataBaseQuery = $"UPDATE sys.{currentProductType} SET item = @item, {currentProductType}_price = @price, status = @status WHERE product_id = {productId}";

                    Utilities.CorrectionToDataBase(model, price, status, changeToDataBaseQuery);
                }
                else
                {
                    MessageBox.Show("Select an item");
                }
            }
            else if(changeToDataBase == "remove")           
                Utilities.RemoveProductFromDataBase(model, changeToDataBaseQuery);

            ModelBox.ReadOnly = true;
            PriceBox.ReadOnly = true;
            StatusBox.ReadOnly = true;
            ModelBox.Text = "";
            PriceBox.Text = "";
            StatusBox.Text = "";

            NewProductButton.Visible = true;
            CorrectionButton.Visible = true;
            RemoveProductButton.Visible = true;

            SaveCancelPanel.Visible = false;
        }
    
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ModelBox.Text = "";
            PriceBox.Text = "";
            StatusBox.Text = "";
            SaveCancelPanel.Visible = false;
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {         
            if (mode == "admin")
            {
                switch (ProductComboBox.Text)
                {
                    case "Processors(CPU)":
                        currentProductType = "cpu";
                        productSalesDataGrid.DataSource = Utilities.AdminProductsDataTable("cpu");
                        break;
                    case "Graphics Cards(GPU)":
                        currentProductType = "gpu";
                        productSalesDataGrid.DataSource = Utilities.AdminProductsDataTable("gpu");
                        break;
                    case "Hard Drives(HDD)":
                        currentProductType = "hdd";
                        productSalesDataGrid.DataSource = Utilities.AdminProductsDataTable("hdd");
                        break;
                    case "Motherboards(MOBO)":
                        currentProductType = "mobo";
                        productSalesDataGrid.DataSource = Utilities.AdminProductsDataTable("mobo");
                        break;
                    case "Power Supplies(PSU)":
                        currentProductType = "psu";
                        productSalesDataGrid.DataSource = Utilities.AdminProductsDataTable("psu");
                        break;
                    case "Ram":
                        currentProductType = "ram";
                        productSalesDataGrid.DataSource = Utilities.AdminProductsDataTable("ram");
                        break;
                    case "Solid State Drives(SSD)":
                        currentProductType = "ssd";
                        productSalesDataGrid.DataSource = Utilities.AdminProductsDataTable("ssd");
                        break;
                }
            }
            if(mode == "salesReport")
            {
                
                if (IsTableNull(salesCustomersTable) == false)
                    salesCustomersTable.Clear();

                switch (ProductComboBox.Text)
                {
                    case "Processors(CPU)":                                
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificRepeatedProductsInReport("cpu"), salesCustomersTable));
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificIndividualProductsInReport("cpu"), salesCustomersTable));
                        productSalesDataGrid.DataSource = salesCustomersTable;
                        break;
                    case "Graphics Cards(GPU)":
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificRepeatedProductsInReport("gpu"), salesCustomersTable));
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificIndividualProductsInReport("gpu"), salesCustomersTable));

                        productSalesDataGrid.DataSource = salesCustomersTable;
                        break;
                    case "Hard Drives(HDD)":
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificRepeatedProductsInReport("hdd"), salesCustomersTable));
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificIndividualProductsInReport("hdd"), salesCustomersTable));

                        productSalesDataGrid.DataSource = salesCustomersTable;
                        break;
                    case "Motherboards(MOBO)":;
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificRepeatedProductsInReport("mobo"), salesCustomersTable));
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificIndividualProductsInReport("mobo"), salesCustomersTable));

                        productSalesDataGrid.DataSource = salesCustomersTable;
                        break;
                    case "Power Supplies(PSU)":
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificRepeatedProductsInReport("psu"), salesCustomersTable));
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificIndividualProductsInReport("psu"), salesCustomersTable));

                        productSalesDataGrid.DataSource = salesCustomersTable;
                        break;
                    case "Ram":
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificRepeatedProductsInReport("ram"), salesCustomersTable));
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificIndividualProductsInReport("ram"), salesCustomersTable));

                        productSalesDataGrid.DataSource = salesCustomersTable;
                        break;
                    case "Solid State Drives(SSD)":
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificRepeatedProductsInReport("ssd"), salesCustomersTable));
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.SpecificIndividualProductsInReport("ssd"), salesCustomersTable));

                        productSalesDataGrid.DataSource = salesCustomersTable;
                        break;
                    case "All":                     
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.RepeatedProductsInReport(), salesCustomersTable));
                        salesCustomersTable.Merge(Utilities.ProductsReport(Utilities.IndividualProductsInReport(), salesCustomersTable));

                        productSalesDataGrid.DataSource = salesCustomersTable;
                        break;
                }
            }
        }

        private void productSalesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new();
            if (mode == "admin")
            {
                if (e.RowIndex > -1)
                {
                    int rowIndex = e.RowIndex;
                    row = productSalesDataGrid.Rows[rowIndex];                  

                    string item = row.Cells[1].Value.ToString();
                    string price = row.Cells[2].Value.ToString();
                    string status = row.Cells[3].Value.ToString();

                    ModelBox.Text = item;
                    PriceBox.Text = price;
                    StatusBox.Text = status;
                }
            }
        }
        //Admin

        //Report
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == true)
                MenuAction("shop", false);

            if (AdminDataBaseEditorPanel.Visible == true)
                MenuAction("admin", false);

            if (salesCustomersTable != null)
                MenuAction("customersReport", false);
                     
            MenuAction("salesReport", true);
            mode = "salesReport";
                     
            if(!salesCustomersTable.Columns.Contains("product"))
            {              
                dtColumn = new();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "product";
                dtColumn.Caption = "Product";
                dtColumn.ReadOnly = false;
                dtColumn.Unique = false;
                salesCustomersTable.Columns.Add(dtColumn);

                dtColumn = new();
                dtColumn.DataType = typeof(double);
                dtColumn.ColumnName = "price";
                dtColumn.Caption = "Price";
                dtColumn.ReadOnly = false;
                dtColumn.Unique = false;
                salesCustomersTable.Columns.Add(dtColumn);

                dtColumn = new();
                dtColumn.DataType = typeof(int);
                dtColumn.ColumnName = "orders";
                dtColumn.Caption = "Orders";
                dtColumn.ReadOnly = false;
                dtColumn.Unique = false;
                salesCustomersTable.Columns.Add(dtColumn);

                dtColumn = new();
                dtColumn.DataType = typeof(double);
                dtColumn.ColumnName = "total";
                dtColumn.Caption = "Total";
                dtColumn.ReadOnly = false;
                dtColumn.Unique = false;
                salesCustomersTable.Columns.Add(dtColumn);

                dtColumn = new();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "productType";
                dtColumn.Caption = "Product Type";
                dtColumn.ReadOnly = false;
                dtColumn.Unique = false;             
                salesCustomersTable.Columns.Add(dtColumn);
             
                ProductsPanel.Visible = true;                            
            }
            if(!ProductComboBox.Items.Contains("All"))
            {
                ProductComboBox.Items.Add("All");
            }
        }
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == true)
                MenuAction("shop", false);

            if (AdminDataBaseEditorPanel.Visible == true)
                MenuAction("admin", false);

            if (salesCustomersTable != null)
                MenuAction("salesReport", false);

            MenuAction("customersReport", true);
           
            if (!salesCustomersTable.Columns.Contains("customer"))
            {
                dtColumn = new();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "customer";
                dtColumn.Caption = "Customer";
                dtColumn.ReadOnly = false;
                dtColumn.Unique = false;
                salesCustomersTable.Columns.Add(dtColumn);

                dtColumn = new();
                dtColumn.DataType = typeof(int);
                dtColumn.ColumnName = "orders";
                dtColumn.Caption = "Orders";
                dtColumn.ReadOnly = false;
                dtColumn.Unique = false;
                salesCustomersTable.Columns.Add(dtColumn);

                dtColumn = new();
                dtColumn.DataType = typeof(double);
                dtColumn.ColumnName = "total";
                dtColumn.Caption = "Total";
                dtColumn.ReadOnly = false;
                dtColumn.Unique = false;
                salesCustomersTable.Columns.Add(dtColumn);

                productSalesDataGrid.Visible = true;
                salesCustomersTable.Merge(Utilities.CustomerPurchasesReport(salesCustomersTable));
                productSalesDataGrid.DataSource = salesCustomersTable;
            }          
           
        }

        private static bool IsTableNull(DataTable dtTable)
        {
            if (dtTable == null)
                return true;
            else
                return false;
        }
    }
        
}

