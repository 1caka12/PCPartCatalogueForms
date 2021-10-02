using System;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using PcCatalog;
using System.Data;

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
     
        private void processorMenuItem_Click(object sender, EventArgs e)
        {
            if(shopCostPanel.Visible==false)
               OpenMenu("shop");

            DataTable dataTable = Utilities.Connection("cpu");
            productSalesDataGrid.DataSource = dataTable;
        }

        private void graphicsCardsMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            DataTable dataTable = Utilities.Connection("gpu");
            productSalesDataGrid.DataSource = dataTable;
        }

        private void hardDrivesMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            DataTable dataTable = Utilities.Connection("hdd");
            productSalesDataGrid.DataSource = dataTable;
        }

        private void motherboardsMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            DataTable dataTable = Utilities.Connection("mobo");
            productSalesDataGrid.DataSource = dataTable;
        }

        private void powerSuppliesMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            DataTable dataTable = Utilities.Connection("psu");
            productSalesDataGrid.DataSource = dataTable;
        }

        private void ramMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            DataTable dataTable = Utilities.Connection("ram");
            productSalesDataGrid.DataSource = dataTable;
        }

        private void ssdMenuItem_Click(object sender, EventArgs e)
        {
            if (shopCostPanel.Visible == false)
                OpenMenu("shop");

            DataTable dataTable = Utilities.Connection("ssd");
            productSalesDataGrid.DataSource = dataTable;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if(shopCostPanel.Visible == true)
               ExitMenu("shop");
        }
    }
        
}
