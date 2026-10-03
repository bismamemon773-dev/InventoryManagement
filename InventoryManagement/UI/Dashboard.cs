using InventoryManagement.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void frmWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWarehouse frm = new FrmWarehouse();
            frm.ShowDialog();
        }

        private void frmBrandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrands brand = new frmBrands();
            brand.ShowDialog();
        }

        private void frmItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItems item = new frmItems();
            item.ShowDialog();
        }
    }
}
