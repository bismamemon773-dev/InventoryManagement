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
    public partial class frmGetItemsByWarehouseId : Form
    {
        public frmGetItemsByWarehouseId()
        {
            InitializeComponent();
        }

        private void btnGetItemsByWarehouseId_Click(object sender, EventArgs e)
        {
            int warehouseid = Convert.ToInt32(txtWarehouseID.Text);

            BolItems item = new BolItems();
            DataTable dt = item.GetItemsByWarehouseId(warehouseid);

            dataGridView1.DataSource = dt;
        }
    }
}
