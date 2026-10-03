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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void btnInsrt_Click(object sender, EventArgs e)
        {
            frmItemInsert insert = new frmItemInsert();
            insert.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            
            frmItemUpdate update = new frmItemUpdate();
            update.lblItemID.Text = row.Cells["ItemID"].Value.ToString();
            update.txtItemName.Text = row.Cells["ItemName"].Value.ToString();
            update.txtBrandID.Text = row.Cells["BrandID"].Value.ToString();
            update.txtWarehouseID.Text = row.Cells["WarehouseID"].Value.ToString();
            update.txtPurxhasePrice.Text = row.Cells["PurchasePrice"].Value.ToString();
            update.txtSalePrice.Text = row.Cells["SalePrice"].Value.ToString();
            update.txtStock.Text = row.Cells["Stock"].Value.ToString();
            update.txtDes.Text = row.Cells["Description"].Value.ToString();


            update.ShowDialog();
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

                int id = Convert.ToInt32(row.Cells["ItemID"].Value);

                BolItems bol = new BolItems();
                bool status = bol.DeleteItem(id);
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

        private void btnGetAllItems_Click(object sender, EventArgs e)
        {
            BolItems item = new BolItems();
            DataTable dt = item.GetAllItems();

            dataGridView1.DataSource = dt;
        }

        private void btnGetItemById_Click(object sender, EventArgs e)
        {
            frmitemGetItemById itemid = new frmitemGetItemById();
            itemid.ShowDialog();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearchItem.Text;

            BolItems item = new BolItems();
            DataTable dt = item.SearchItems(search);

            dataGridView1.DataSource = dt;
        }

        private void btnGetItemsByBrandId_Click(object sender, EventArgs e)
        {
            frmGetItemsByBrandId GetItemBrandID = new frmGetItemsByBrandId();
            GetItemBrandID.ShowDialog();
        }

        private void btnGetItemsByWarehouseId_Click(object sender, EventArgs e)
        {
            frmGetItemsByWarehouseId GetItemWarehouseID = new frmGetItemsByWarehouseId();
            GetItemWarehouseID.ShowDialog();
        }

        private void btnGetItemsAboveSalePrice_Click(object sender, EventArgs e)
        {
            frmGetItemsAboveSalePrice GetItemSalePrice = new frmGetItemsAboveSalePrice();
            GetItemSalePrice.ShowDialog();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            frmUpdateStock GetItemStock = new frmUpdateStock();
            GetItemStock.ShowDialog();
        }

        private void btnUpdateSalePrice_Click(object sender, EventArgs e)
        {
            frmUpdateSalePrice salePrice = new frmUpdateSalePrice();
            salePrice.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
        }
    }
}
