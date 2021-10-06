using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcCatalog
{
    public partial class NewCart : Form
    {
        private static DataGridViewColumn dataGridViewColumn;
        private static DataGridViewButtonColumn buttonColumn;
        
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
                dataGridViewColumn = new();
                {
                    dataGridViewColumn.Name = "productColumn";
                    dataGridViewColumn.HeaderText = "Product";
                   
                }
                boughtProductsDataGrid.Columns.Insert(0, dataGridViewColumn);

                dataGridViewColumn = new();
                {
                    dataGridViewColumn.Name = "priceColumn";
                    dataGridViewColumn.HeaderText = "Price";
                }
                boughtProductsDataGrid.Columns.Insert(1, dataGridViewColumn);

                dataGridViewColumn = new();
                {
                    dataGridViewColumn.Name = "quantityColumn";
                    dataGridViewColumn.HeaderText = "Quantity";
                }
                boughtProductsDataGrid.Columns.Insert(2, dataGridViewColumn);
                /*
                buttonColumn = new();
                {
                    buttonColumn.Name = "buyMore";
                    buttonColumn.HeaderText = "";
                    buttonColumn.Text = "+";                    
                }
                boughtProductsDataGrid.Columns.Insert(3, dataGridViewColumn);*/
                /*
                buttonColumn = new();
                {
                    buttonColumn.Name = "buyLess";
                    buttonColumn.HeaderText = "";
                    buttonColumn.Text = "-";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    buttonColumn.FlatStyle = FlatStyle.Standard;
                }
                boughtProductsDataGrid.Columns.Insert(4, dataGridViewColumn);*/
            }
        }
    }
}
