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
    public partial class frmUpdateStock : Form
    {
        public frmUpdateStock()
        {
            InitializeComponent();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            int itemid = Convert.ToInt32(txtItemID.Text);
            int stock = Convert.ToInt32(txtStock.Text);

            BolItems item = new BolItems();
            bool status = item.UpdateStock(itemid,stock);

            if (status)
            {
                MessageBox.Show("Update Stock Sucessfuly!");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
            txtItemID.Clear();
            txtStock.Clear();
        }
    }
}
