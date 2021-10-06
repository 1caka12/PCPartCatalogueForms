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
        private static DataGridViewButtonCell buttonCell;
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
            if(shopCostPanel.Visible==false)
               OpenMenu("shop");
                 
            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("cpu");
        }

        private void graphicsCardsMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("gpu");
        }

        private void hardDrivesMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("hdd");
        }

        private void motherboardsMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

           productSalesDataGrid.DataSource = Utilities.ProductsDataTable("mobo");
        }

        private void powerSuppliesMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

           productSalesDataGrid.DataSource = Utilities.ProductsDataTable("psu");
        }

        private void ramMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            productSalesDataGrid.DataSource = Utilities.ProductsDataTable("ram");
        }

        private void ssdMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

           productSalesDataGrid.DataSource = Utilities.ProductsDataTable("ssd");
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
           
            //buttonCell = (DataGridViewButtonCell)productSalesDataGrid.Rows[productSalesDataGrid.CurrentRow.Index].Cells[0];
            if(e.ColumnIndex == productSalesDataGrid.Columns["buttonColumn"].Index)
            {

            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            //double price = .0;
            double curPrice = .0;
            foreach (DataGridViewRow row in productSalesDataGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    double price = double.Parse(row.Cells[2].Value.ToString());
                    curPrice += price;                 
                    //price += price;
                    costLabel.Text = curPrice.ToString();

                    //costLabel.Text = Utilities.DisplayPrice(price, "add");
                    row.Cells[0].Value = false;
                }
                
                //curPrice = 0;
            }

        }

        private void productStrip_Click(object sender, EventArgs e)
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
            buttonCell = new();
            
            if (productSalesDataGrid.Columns["buttonColumn"] == null)
            {
                productSalesDataGrid.Columns.Insert(0, buttonColumn);
                productSalesDataGrid.CellContentClick += productSalesDataGrid_CellContentClick;

            }
        }
    }
        
}
