using InventoryManagement.BOL;
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
    public partial class frmUpdateSalePrice : Form
    {
        public frmUpdateSalePrice()
        {
            InitializeComponent();
        }

        private void btnUpdateSalePrice_Click(object sender, EventArgs e)
        {
            int itemid = Convert.ToInt32(txtItemID.Text);
            int saleprice = Convert.ToInt32(txtSalePrice.Text);

            BolItems item = new BolItems();
           bool status = item.UpdateSalePrice(itemid, saleprice);

            if (status)
            {
                MessageBox.Show("Update Sale Price Sucessfuly!");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }

            txtItemID.Clear();
            txtSalePrice.Clear();

        }
    }
}
