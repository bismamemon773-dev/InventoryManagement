namespace InventoryManagement.UI
{
    partial class frmUpdateSalePrice
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
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateSalePrice = new System.Windows.Forms.Button();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(143, 61);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(238, 20);
            this.txtSalePrice.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "Sale Price : ";
            // 
            // btnUpdateSalePrice
            // 
            this.btnUpdateSalePrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateSalePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSalePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSalePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateSalePrice.Location = new System.Drawing.Point(152, 102);
            this.btnUpdateSalePrice.Name = "btnUpdateSalePrice";
            this.btnUpdateSalePrice.Size = new System.Drawing.Size(229, 35);
            this.btnUpdateSalePrice.TabIndex = 107;
            this.btnUpdateSalePrice.Text = "UpdateSalePrice";
            this.btnUpdateSalePrice.UseVisualStyleBackColor = false;
            this.btnUpdateSalePrice.Click += new System.EventHandler(this.btnUpdateSalePrice_Click);
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(143, 20);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(238, 20);
            this.txtItemID.TabIndex = 105;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(32, 18);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(79, 20);
            this.lbl.TabIndex = 108;
            this.lbl.Text = "Item ID :";
            // 
            // frmUpdateSalePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 159);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateSalePrice);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lbl);
            this.Name = "frmUpdateSalePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateSalePrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateSalePrice;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtItemID;
    }
}