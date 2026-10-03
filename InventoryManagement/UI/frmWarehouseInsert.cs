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
    public partial class frmWarehouseInsert : Form
    {
        public frmWarehouseInsert()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WareHouse warehouse = new WareHouse();
            warehouse.WarehouseName = txtWarehouseName.Text;
            warehouse.City = txtCity.Text;
            warehouse.ContactNumber = txtContact.Text;
            BolWarehouses BOL = new BolWarehouses();
            bool status = BOL.Insert(warehouse);
            if (status)
            {
                MessageBox.Show("Insert data successfully !");
            }
            else
            {
                MessageBox.Show("Invalid Data !");
            }
            txtWarehouseName.Clear(); txtCity.Clear(); txtContact.Clear();
        }

    }
}
