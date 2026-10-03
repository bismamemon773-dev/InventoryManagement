namespace InventoryManagement.UI
{
    partial class GetWarehouseById
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtWarehouseID = new System.Windows.Forms.TextBox();
            this.btnGetWarehouseById = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(25, 34);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(129, 20);
            this.lbl.TabIndex = 79;
            this.lbl.Text = "Warehouse ID:";
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.Location = new System.Drawing.Point(160, 36);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(238, 20);
            this.txtWarehouseID.TabIndex = 80;
            // 
            // btnGetWarehouseById
            // 
            this.btnGetWarehouseById.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetWarehouseById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetWarehouseById.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWarehouseById.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetWarehouseById.Location = new System.Drawing.Point(194, 71);
            this.btnGetWarehouseById.Name = "btnGetWarehouseById";
            this.btnGetWarehouseById.Size = new System.Drawing.Size(204, 35);
            this.btnGetWarehouseById.TabIndex = 81;
            this.btnGetWarehouseById.Text = "Get Warehouse By ID";
            this.btnGetWarehouseById.UseVisualStyleBackColor = false;
            this.btnGetWarehouseById.Click += new System.EventHandler(this.btnGetWarehouseById_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(369, 358);
            this.dataGridView1.TabIndex = 82;
            // 
            // GetWarehouseById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetWarehouseById);
            this.Controls.Add(this.txtWarehouseID);
            this.Controls.Add(this.lbl);
            this.Name = "GetWarehouseById";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetWarehouseById";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox txtWarehouseID;
        private System.Windows.Forms.Button btnGetWarehouseById;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}