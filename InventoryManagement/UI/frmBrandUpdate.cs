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
    public partial class frmBrandUpdate : Form
    {
        public frmBrandUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.BrandID = Convert.ToInt32( lblBrandID.Text);
            brand.BrandName = txtBrandName.Text;
            brand.Country = txtCountry.Text;

            BolBrands bol = new BolBrands();
            bool status = bol.UpdateBrand(brand);

            if (status)
            {
                MessageBox.Show("Update data Successfully !");
            }
            else
            {
                MessageBox.Show("Invalid data !");
            }
            txtBrandName.Clear();
            txtCountry.Clear();
        }
    }
}
