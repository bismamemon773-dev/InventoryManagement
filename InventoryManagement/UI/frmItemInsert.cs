using InventoryManagement.BOL;
using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI
{
    public partial class frmItemInsert : Form
    {
        public frmItemInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.ItemName = txtItemName.Text;
            item.BrandID = Convert.ToInt32(txtBrandID.Text);
            item.WarehouseID = Convert.ToInt32(txtWarehouseID.Text);
            item.PurchasePrice = Convert.ToInt32(txtPurxhasePrice.Text);
            item.SalePrice = Convert.ToInt32(txtSalePrice.Text);
            item.Stock = Convert.ToInt32(txtStock.Text);
            item.Description = txtDes.Text;

            BolItems Bol = new BolItems();
            bool status = Bol.InsertItem(item);
            if (status)
            {
                MessageBox.Show("Insert data successfully !");
            }
            else
            {
                MessageBox.Show("Invalid data !");
            }
        
        }
    }
}
