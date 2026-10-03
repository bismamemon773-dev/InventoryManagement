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
    public partial class frmGetItemsAboveSalePrice : Form
    {
        public frmGetItemsAboveSalePrice()
        {
            InitializeComponent();
        }

        private void btnGetItemsAboveSalePrice_Click(object sender, EventArgs e)
        {

            int Price = Convert.ToInt32(txtPrice.Text);

            BolItems item = new BolItems();
            DataTable dt = item.GetItemsAboveSalePrice(Price);

            dataGridView1.DataSource = dt;
        }
    }
}
