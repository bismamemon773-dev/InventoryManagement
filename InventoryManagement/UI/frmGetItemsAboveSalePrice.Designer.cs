namespace InventoryManagement.UI
{
    partial class frmGetItemsAboveSalePrice
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
            this.btnGetItemsAboveSalePrice = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(593, 358);
            this.dataGridView1.TabIndex = 99;
            // 
            // btnGetItemsAboveSalePrice
            // 
            this.btnGetItemsAboveSalePrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetItemsAboveSalePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetItemsAboveSalePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetItemsAboveSalePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetItemsAboveSalePrice.Location = new System.Drawing.Point(391, 44);
            this.btnGetItemsAboveSalePrice.Name = "btnGetItemsAboveSalePrice";
            this.btnGetItemsAboveSalePrice.Size = new System.Drawing.Size(229, 35);
            this.btnGetItemsAboveSalePrice.TabIndex = 98;
            this.btnGetItemsAboveSalePrice.Text = "GetItemsAboveSalePrice ";
            this.btnGetItemsAboveSalePrice.UseVisualStyleBackColor = false;
            this.btnGetItemsAboveSalePrice.Click += new System.EventHandler(this.btnGetItemsAboveSalePrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(102, 20);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(238, 20);
            this.txtPrice.TabIndex = 97;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(23, 20);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(64, 20);
            this.lbl.TabIndex = 96;
            this.lbl.Text = "Price : ";
            // 
            // frmGetItemsAboveSalePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 467);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetItemsAboveSalePrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbl);
            this.Name = "frmGetItemsAboveSalePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGetItemsAboveSalePrice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetItemsAboveSalePrice;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbl;
    }
}