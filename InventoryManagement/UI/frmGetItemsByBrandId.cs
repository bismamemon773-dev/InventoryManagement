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
    public partial class frmGetItemsByBrandId : Form
    {
        public frmGetItemsByBrandId()
        {
            InitializeComponent();
        }

        private void btnGetBrandById_Click(object sender, EventArgs e)
        {
            int brandid = Convert.ToInt32(txtBrandID.Text);

            BolItems item = new BolItems();
            DataTable dt = item.GetItemsByBrandId(brandid);

            dataGridView1.DataSource = dt;
        }
    }
}
