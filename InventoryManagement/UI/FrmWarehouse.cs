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
    public partial class FrmWarehouse : Form
    {
        public FrmWarehouse()
        {
            InitializeComponent();
        }

        private void btnInsrt_Click(object sender, EventArgs e)
        {
            frmWarehouseInsert form = new frmWarehouseInsert();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            frmWarehouseUpdate frm = new frmWarehouseUpdate();

            frm.lblWarehouseID.Text = row.Cells["WarehouseID"].Value.ToString();
            frm.txtWarehouseName.Text = row.Cells["WarehouseName"].Value.ToString();
            frm.txtCity.Text = row.Cells["City"].Value.ToString();
            frm.txtContact.Text = row.Cells["ContactNumber"].Value.ToString();
            
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this row?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(row.Cells["WarehouseID"].Value);

                BolWarehouses bol = new BolWarehouses();
                bool status = bol.Delete(id);
                if (status)
                {
                    MessageBox.Show("Delete Data Sucessfully !");
                }
            }
        }

        private void btnGetAllWarehouses_Click(object sender, EventArgs e)
        {
            BolWarehouses bol = new BolWarehouses();
            DataTable dt = bol.GetAllWarehouses();

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGetWarehouseById_Click(object sender, EventArgs e)
        {
            GetWarehouseById frm = new GetWarehouseById();
            frm.ShowDialog();
        }
    }
}
