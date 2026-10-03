using InventoryManagement.BOL;
using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI
{
    public partial class frmItemUpdate : Form
    {
        public frmItemUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.ItemID = Convert.ToInt32( lblItemID.Text);
            item.ItemName = txtItemName.Text;
            item.BrandID = Convert.ToInt32(txtBrandID.Text);
            item.WarehouseID = Convert.ToInt32(txtWarehouseID.Text);
            item.PurchasePrice = Convert.ToInt32(txtPurxhasePrice.Text);
            item.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
            item.Stock = Convert.ToDecimal(txtStock.Text);
            item.Description = txtDes.Text;

            BolItems Bol = new BolItems();
            bool status = Bol.UpateItem(item);
            if (status)
            {
                MessageBox.Show("Update data successfully !");
            }
            else
            {
                MessageBox.Show("Invalid data !");
            }

        }
    }
}
