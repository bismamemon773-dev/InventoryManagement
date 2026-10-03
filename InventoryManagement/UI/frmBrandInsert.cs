using InventoryManagement.BOL;
using InventoryManagement.DAL;
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
    public partial class frmBrandInsert : Form
    {
        public frmBrandInsert()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.BrandName = txtBrandName.Text;
            brand.Country = txtCountry.Text;

            BolBrands bol = new BolBrands();
            bool status = bol.InsertBrand(brand);

            if (status)
            {
                MessageBox.Show("Insert data Successfully !");
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
