namespace InventoryManagement.UI
{
    partial class FrmWarehouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCatID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsrt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetAllWarehouses = new System.Windows.Forms.Button();
            this.btnGetWarehouseById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 358);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(589, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 35);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(224, -22);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(384, 20);
            this.txtCatName.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, -24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Category Name: ";
            // 
            // TxtCatID
            // 
            this.TxtCatID.Location = new System.Drawing.Point(224, -62);
            this.TxtCatID.Name = "TxtCatID";
            this.TxtCatID.Size = new System.Drawing.Size(384, 20);
            this.TxtCatID.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, -64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Category ID: ";
            // 
            // btnInsrt
            // 
            this.btnInsrt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInsrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsrt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsrt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsrt.Location = new System.Drawing.Point(30, 24);
            this.btnInsrt.Name = "btnInsrt";
            this.btnInsrt.Size = new System.Drawing.Size(82, 35);
            this.btnInsrt.TabIndex = 58;
            this.btnInsrt.Text = "Insert";
            this.btnInsrt.UseVisualStyleBackColor = false;
            this.btnInsrt.Click += new System.EventHandler(this.btnInsrt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(677, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetAllWarehouses
            // 
            this.btnGetAllWarehouses.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetAllWarehouses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAllWarehouses.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllWarehouses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetAllWarehouses.Location = new System.Drawing.Point(555, 429);
            this.btnGetAllWarehouses.Name = "btnGetAllWarehouses";
            this.btnGetAllWarehouses.Size = new System.Drawing.Size(204, 35);
            this.btnGetAllWarehouses.TabIndex = 60;
            this.btnGetAllWarehouses.Text = "Get All Warehouses";
            this.btnGetAllWarehouses.UseVisualStyleBackColor = false;
            this.btnGetAllWarehouses.Click += new System.EventHandler(this.btnGetAllWarehouses_Click);
            // 
            // btnGetWarehouseById
            // 
            this.btnGetWarehouseById.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetWarehouseById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetWarehouseById.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWarehouseById.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetWarehouseById.Location = new System.Drawing.Point(345, 429);
            this.btnGetWarehouseById.Name = "btnGetWarehouseById";
            this.btnGetWarehouseById.Size = new System.Drawing.Size(204, 35);
            this.btnGetWarehouseById.TabIndex = 61;
            this.btnGetWarehouseById.Text = "Get Warehouse By ID";
            this.btnGetWarehouseById.UseVisualStyleBackColor = false;
            this.btnGetWarehouseById.Click += new System.EventHandler(this.btnGetWarehouseById_Click);
            // 
            // FrmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 483);
            this.Controls.Add(this.btnGetWarehouseById);
            this.Controls.Add(this.btnGetAllWarehouses);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsrt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCatID);
            this.Controls.Add(this.label2);
            this.Name = "FrmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWarehouse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCatID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsrt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetAllWarehouses;
        private System.Windows.Forms.Button btnGetWarehouseById;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}