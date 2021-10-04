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
        private DataGridViewCheckBoxCell checkBoxCell;
        private DataGridViewCheckBoxColumn checkBoxColumn = new();
        static double totalPrice = .0;

        public NewMain()
        {
            InitializeComponent();
        }

        private void NewMain_Load(object sender, EventArgs e)
        {
            checkBoxColumn = new();
            checkBoxColumn.Name = "SelectProduct";
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            checkBoxColumn.FillWeight = 10;
            productSalesDataGrid.Columns.Insert(0, checkBoxColumn);
            checkBoxColumn.Visible = false;            
            //checkBoxColumn.ReadOnly = true;
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

                if (checkBoxColumn.Visible == false)
                    checkBoxColumn.Visible = true;
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

                if (checkBoxColumn.Visible == true)
                    checkBoxColumn.Visible = false;
            }
        }

        private void productSalesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                checkBoxCell = (DataGridViewCheckBoxCell)productSalesDataGrid.Rows[productSalesDataGrid.CurrentRow.Index].Cells[0];             
                DataGridViewRow row = productSalesDataGrid.Rows[e.RowIndex];

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
                //MySqlConnection connection =  Utilities.Connection();
                if(checkBoxCell.Value.Equals(true))
                {
                    string item = row.Cells[1].Value.ToString();
                    double price = double.Parse(row.Cells[2].Value.ToString());
                    costLabel.Text = DisplayPrice(price);
                }

            }
        }
        public static string DisplayPrice(double currentProductPrice)
        {           
            totalPrice += currentProductPrice;
            return Math.Round(totalPrice, 2).ToString();
            
        }


    }
        
}
