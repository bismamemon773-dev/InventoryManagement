namespace InventoryManagement.UI
{
    partial class frmGetItemsByWarehouseId
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
            this.btnGetItemsByWarehouseId = new System.Windows.Forms.Button();
            this.txtWarehouseID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(593, 358);
            this.dataGridView1.TabIndex = 95;
            // 
            // btnGetItemsByWarehouseId
            // 
            this.btnGetItemsByWarehouseId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetItemsByWarehouseId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetItemsByWarehouseId.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetItemsByWarehouseId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetItemsByWarehouseId.Location = new System.Drawing.Point(388, 39);
            this.btnGetItemsByWarehouseId.Name = "btnGetItemsByWarehouseId";
            this.btnGetItemsByWarehouseId.Size = new System.Drawing.Size(229, 35);
            this.btnGetItemsByWarehouseId.TabIndex = 94;
            this.btnGetItemsByWarehouseId.Text = "GetItemsByWarehouseId";
            this.btnGetItemsByWarehouseId.UseVisualStyleBackColor = false;
            this.btnGetItemsByWarehouseId.Click += new System.EventHandler(this.btnGetItemsByWarehouseId_Click);
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.Location = new System.Drawing.Point(163, 17);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(212, 20);
            this.txtWarehouseID.TabIndex = 93;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(20, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(137, 20);
            this.lbl.TabIndex = 92;
            this.lbl.Text = "WareHouse ID: ";
            // 
            // frmGetItemsByWarehouseId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetItemsByWarehouseId);
            this.Controls.Add(this.txtWarehouseID);
            this.Controls.Add(this.lbl);
            this.Name = "frmGetItemsByWarehouseId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGetItemsByWarehouseId";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetItemsByWarehouseId;
        public System.Windows.Forms.TextBox txtWarehouseID;
        private System.Windows.Forms.Label lbl;
    }
}