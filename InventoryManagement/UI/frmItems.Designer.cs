namespace InventoryManagement.UI
{
    partial class frmItems
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
            this.btnGetAllItems = new System.Windows.Forms.Button();
            this.btnGetItemById = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsrt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.btnGetItemsByBrandId = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnGetItemsAboveSalePrice = new System.Windows.Forms.Button();
            this.btnUpdateSalePrice = new System.Windows.Forms.Button();
            this.btnGetItemsByWarehouseId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetAllItems
            // 
            this.btnGetAllItems.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetAllItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAllItems.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllItems.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetAllItems.Location = new System.Drawing.Point(553, 481);
            this.btnGetAllItems.Name = "btnGetAllItems";
            this.btnGetAllItems.Size = new System.Drawing.Size(204, 35);
            this.btnGetAllItems.TabIndex = 73;
            this.btnGetAllItems.Text = "Get All Items";
            this.btnGetAllItems.UseVisualStyleBackColor = false;
            this.btnGetAllItems.Click += new System.EventHandler(this.btnGetAllItems_Click);
            // 
            // btnGetItemById
            // 
            this.btnGetItemById.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetItemById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetItemById.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetItemById.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetItemById.Location = new System.Drawing.Point(343, 481);
            this.btnGetItemById.Name = "btnGetItemById";
            this.btnGetItemById.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetItemById.Size = new System.Drawing.Size(204, 35);
            this.btnGetItemById.TabIndex = 72;
            this.btnGetItemById.Text = "GetI tem By Id";
            this.btnGetItemById.UseVisualStyleBackColor = false;
            this.btnGetItemById.Click += new System.EventHandler(this.btnGetItemById_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(675, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsrt
            // 
            this.btnInsrt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInsrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsrt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsrt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsrt.Location = new System.Drawing.Point(28, 29);
            this.btnInsrt.Name = "btnInsrt";
            this.btnInsrt.Size = new System.Drawing.Size(82, 35);
            this.btnInsrt.TabIndex = 70;
            this.btnInsrt.Text = "Insert";
            this.btnInsrt.UseVisualStyleBackColor = false;
            this.btnInsrt.Click += new System.EventHandler(this.btnInsrt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 358);
            this.dataGridView1.TabIndex = 69;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(587, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 35);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = "Search Items :";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(169, 91);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(238, 20);
            this.txtSearchItem.TabIndex = 106;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // btnGetItemsByBrandId
            // 
            this.btnGetItemsByBrandId.BackColor = System.Drawing.Color.Silver;
            this.btnGetItemsByBrandId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetItemsByBrandId.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetItemsByBrandId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetItemsByBrandId.Location = new System.Drawing.Point(29, 543);
            this.btnGetItemsByBrandId.Name = "btnGetItemsByBrandId";
            this.btnGetItemsByBrandId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetItemsByBrandId.Size = new System.Drawing.Size(236, 35);
            this.btnGetItemsByBrandId.TabIndex = 108;
            this.btnGetItemsByBrandId.Text = "GetItemsByBrandId";
            this.btnGetItemsByBrandId.UseVisualStyleBackColor = false;
            this.btnGetItemsByBrandId.Click += new System.EventHandler(this.btnGetItemsByBrandId_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateStock.Location = new System.Drawing.Point(29, 584);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateStock.Size = new System.Drawing.Size(236, 35);
            this.btnUpdateStock.TabIndex = 110;
            this.btnUpdateStock.Text = "UpdateStock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnGetItemsAboveSalePrice
            // 
            this.btnGetItemsAboveSalePrice.BackColor = System.Drawing.Color.Silver;
            this.btnGetItemsAboveSalePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetItemsAboveSalePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetItemsAboveSalePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetItemsAboveSalePrice.Location = new System.Drawing.Point(521, 543);
            this.btnGetItemsAboveSalePrice.Name = "btnGetItemsAboveSalePrice";
            this.btnGetItemsAboveSalePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetItemsAboveSalePrice.Size = new System.Drawing.Size(236, 35);
            this.btnGetItemsAboveSalePrice.TabIndex = 111;
            this.btnGetItemsAboveSalePrice.Text = "GetItemsAboveSalePrice";
            this.btnGetItemsAboveSalePrice.UseVisualStyleBackColor = false;
            this.btnGetItemsAboveSalePrice.Click += new System.EventHandler(this.btnGetItemsAboveSalePrice_Click);
            // 
            // btnUpdateSalePrice
            // 
            this.btnUpdateSalePrice.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateSalePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSalePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSalePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateSalePrice.Location = new System.Drawing.Point(271, 584);
            this.btnUpdateSalePrice.Name = "btnUpdateSalePrice";
            this.btnUpdateSalePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateSalePrice.Size = new System.Drawing.Size(236, 35);
            this.btnUpdateSalePrice.TabIndex = 112;
            this.btnUpdateSalePrice.Text = "UpdateSalePrice";
            this.btnUpdateSalePrice.UseVisualStyleBackColor = false;
            this.btnUpdateSalePrice.Click += new System.EventHandler(this.btnUpdateSalePrice_Click);
            // 
            // btnGetItemsByWarehouseId
            // 
            this.btnGetItemsByWarehouseId.BackColor = System.Drawing.Color.Silver;
            this.btnGetItemsByWarehouseId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetItemsByWarehouseId.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetItemsByWarehouseId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetItemsByWarehouseId.Location = new System.Drawing.Point(271, 543);
            this.btnGetItemsByWarehouseId.Name = "btnGetItemsByWarehouseId";
            this.btnGetItemsByWarehouseId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetItemsByWarehouseId.Size = new System.Drawing.Size(236, 35);
            this.btnGetItemsByWarehouseId.TabIndex = 113;
            this.btnGetItemsByWarehouseId.Text = "GetItemsByWarehouseId";
            this.btnGetItemsByWarehouseId.UseVisualStyleBackColor = false;
            this.btnGetItemsByWarehouseId.Click += new System.EventHandler(this.btnGetItemsByWarehouseId_Click);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 648);
            this.Controls.Add(this.btnGetItemsByWarehouseId);
            this.Controls.Add(this.btnUpdateSalePrice);
            this.Controls.Add(this.btnGetItemsAboveSalePrice);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnGetItemsByBrandId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.btnGetAllItems);
            this.Controls.Add(this.btnGetItemById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsrt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItems";
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllItems;
        private System.Windows.Forms.Button btnGetItemById;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsrt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Button btnGetItemsByBrandId;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnGetItemsAboveSalePrice;
        private System.Windows.Forms.Button btnUpdateSalePrice;
        private System.Windows.Forms.Button btnGetItemsByWarehouseId;
    }
}