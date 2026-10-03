namespace InventoryManagement.UI
{
    partial class frmBrands
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
            this.btnGetBrandById = new System.Windows.Forms.Button();
            this.btnGetAllBrands = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsrt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetBrandById
            // 
            this.btnGetBrandById.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetBrandById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBrandById.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBrandById.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetBrandById.Location = new System.Drawing.Point(342, 431);
            this.btnGetBrandById.Name = "btnGetBrandById";
            this.btnGetBrandById.Size = new System.Drawing.Size(204, 35);
            this.btnGetBrandById.TabIndex = 67;
            this.btnGetBrandById.Text = "Get Brand By ID";
            this.btnGetBrandById.UseVisualStyleBackColor = false;
            this.btnGetBrandById.Click += new System.EventHandler(this.btnGetBrandById_Click);
            // 
            // btnGetAllBrands
            // 
            this.btnGetAllBrands.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetAllBrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAllBrands.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllBrands.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetAllBrands.Location = new System.Drawing.Point(552, 431);
            this.btnGetAllBrands.Name = "btnGetAllBrands";
            this.btnGetAllBrands.Size = new System.Drawing.Size(204, 35);
            this.btnGetAllBrands.TabIndex = 66;
            this.btnGetAllBrands.Text = "Get All Brands";
            this.btnGetAllBrands.UseVisualStyleBackColor = false;
            this.btnGetAllBrands.Click += new System.EventHandler(this.btnGetAllBrands_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(674, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 65;
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
            this.btnInsrt.Location = new System.Drawing.Point(27, 26);
            this.btnInsrt.Name = "btnInsrt";
            this.btnInsrt.Size = new System.Drawing.Size(82, 35);
            this.btnInsrt.TabIndex = 64;
            this.btnInsrt.Text = "Insert";
            this.btnInsrt.UseVisualStyleBackColor = false;
            this.btnInsrt.Click += new System.EventHandler(this.btnInsrt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 358);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(586, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 35);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 489);
            this.Controls.Add(this.btnGetBrandById);
            this.Controls.Add(this.btnGetAllBrands);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsrt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmBrands";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrands";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetBrandById;
        private System.Windows.Forms.Button btnGetAllBrands;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsrt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
    }
}