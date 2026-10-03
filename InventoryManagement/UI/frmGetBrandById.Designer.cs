namespace InventoryManagement.UI
{
    partial class frmGetBrandById
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
            this.btnGetBrandById = new System.Windows.Forms.Button();
            this.txtBrandID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(369, 358);
            this.dataGridView1.TabIndex = 86;
            // 
            // btnGetBrandById
            // 
            this.btnGetBrandById.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetBrandById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBrandById.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBrandById.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetBrandById.Location = new System.Drawing.Point(202, 56);
            this.btnGetBrandById.Name = "btnGetBrandById";
            this.btnGetBrandById.Size = new System.Drawing.Size(204, 35);
            this.btnGetBrandById.TabIndex = 85;
            this.btnGetBrandById.Text = "Get Brand By ID";
            this.btnGetBrandById.UseVisualStyleBackColor = false;
            this.btnGetBrandById.Click += new System.EventHandler(this.btnGetBrandById_Click);
            // 
            // txtBrandID
            // 
            this.txtBrandID.Location = new System.Drawing.Point(168, 21);
            this.txtBrandID.Name = "txtBrandID";
            this.txtBrandID.Size = new System.Drawing.Size(238, 20);
            this.txtBrandID.TabIndex = 84;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(33, 19);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(86, 20);
            this.lbl.TabIndex = 83;
            this.lbl.Text = "Brand ID:";
            // 
            // frmGetBrandById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetBrandById);
            this.Controls.Add(this.txtBrandID);
            this.Controls.Add(this.lbl);
            this.Name = "frmGetBrandById";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGetBrandById";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetBrandById;
        public System.Windows.Forms.TextBox txtBrandID;
        private System.Windows.Forms.Label lbl;
    }
}