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
    public partial class frmBrands : Form
    {
        public frmBrands()
        {
            InitializeComponent();
        }

        private void btnInsrt_Click(object sender, EventArgs e)
        {
            frmBrandInsert insert = new frmBrandInsert();
            insert.ShowDialog();
        }

        private void btnGetBrandById_Click(object sender, EventArgs e)
        {
            frmGetBrandById brandid = new frmGetBrandById();
            brandid.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            frmBrandUpdate update = new frmBrandUpdate();
            update.lblBrandID.Text =  row.Cells["BrandID"].Value.ToString();
            update.txtBrandName.Text = row.Cells["BrandName"].Value.ToString();
            update.txtCountry.Text = row.Cells["Country"].Value.ToString();
            
            update.ShowDialog();
        }

        private void btnGetAllBrands_Click(object sender, EventArgs e)
        {
            BolBrands brand = new BolBrands();
            DataTable dt = brand.GetAllBrands();

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a first row");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32( row.Cells["BrandID"].Value);

                BolBrands bol = new BolBrands();
                bool status = bol.DeleteBrand(id);
                if (status)
                {
                    MessageBox.Show("Delete row Sucessfully !");
                }
                else
                {
                    MessageBox.Show("Invalid data!");
                }
            }
                            



        }
    }
}
