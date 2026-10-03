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
    public partial class GetWarehouseById : Form
    {
        public GetWarehouseById()
        {
            InitializeComponent();
        }

        private void btnGetWarehouseById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtWarehouseID.Text);

            BolWarehouses bol = new BolWarehouses();
            DataTable dt = bol.GetWarehouseById(id);

            dataGridView1.DataSource = dt;
        }
    }
}
