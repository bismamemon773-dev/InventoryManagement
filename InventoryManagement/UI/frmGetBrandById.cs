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
    public partial class frmGetBrandById : Form
    {
        public frmGetBrandById()
        {
            InitializeComponent();
        }

        private void btnGetBrandById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBrandID.Text);

            BolBrands brand = new BolBrands();
            DataTable dt = brand.GetBrandById(id);

            dataGridView1.DataSource = dt;

        }
    }
}
