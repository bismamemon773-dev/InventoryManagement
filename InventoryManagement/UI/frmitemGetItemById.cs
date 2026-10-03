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
    public partial class frmitemGetItemById : Form
    {
        public frmitemGetItemById()
        {
            InitializeComponent();
        }

        private void btnGetItemById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtItemID.Text);

            BolItems item = new BolItems();
            DataTable dt = item.GetItemById(id);

            dataGridView1.DataSource = dt;
        }
    }
}
