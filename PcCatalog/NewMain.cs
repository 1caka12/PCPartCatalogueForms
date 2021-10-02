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
        
        public NewMain()
        {
            InitializeComponent();
        }

        private void NewMain_Load(object sender, EventArgs e)
        {
            
        }
        private void OpenMenu(string menu)
        {
            exitButton.Visible = true;
            productSalesDataGrid.Visible = true;
            if(menu == "shop")
            {
                shopCostPanel.Visible = true;
                toCartButton.Visible = true;
            }
        }
        private void ExitMenu(string menu)
        {
            exitButton.Visible = false;
            productSalesDataGrid.Visible = false;
            if(menu =="shop")
            {
                shopCostPanel.Visible = false;
                toCartButton.Visible = false;
            }
        }

       //
       //Buttons for products
       //
        private void processorMenuItem_Click(object sender, EventArgs e)
        {
            if(shopCostPanel.Visible==false)
               OpenMenu("shop");
                 
            productSalesDataGrid.DataSource = Utilities.Connection("cpu");          
        }

        private void graphicsCardsMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            productSalesDataGrid.DataSource = Utilities.Connection("gpu");
        }

        private void hardDrivesMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            productSalesDataGrid.DataSource = Utilities.Connection("hdd");
        }

        private void motherboardsMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

           productSalesDataGrid.DataSource = Utilities.Connection("mobo");
        }

        private void powerSuppliesMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

           productSalesDataGrid.DataSource = Utilities.Connection("psu");
        }

        private void ramMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            productSalesDataGrid.DataSource = Utilities.Connection("ram");
        }

        private void ssdMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

           productSalesDataGrid.DataSource = Utilities.Connection("ssd");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if(shopCostPanel.Visible == true)
               ExitMenu("shop");
        }
        //
        //
        //
        
        
    }
        
}
