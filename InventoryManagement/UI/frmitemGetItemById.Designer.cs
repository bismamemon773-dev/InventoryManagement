namespace InventoryManagement.UI
{
    partial class frmitemGetItemById
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
            this.btnGetItemById = new System.Windows.Forms.Button();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(682, 358);
            this.dataGridView1.TabIndex = 90;
            // 
            // btnGetItemById
            // 
            this.btnGetItemById.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetItemById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetItemById.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetItemById.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetItemById.Location = new System.Drawing.Point(450, 29);
            this.btnGetItemById.Name = "btnGetItemById";
            this.btnGetItemById.Size = new System.Drawing.Size(254, 35);
            this.btnGetItemById.TabIndex = 89;
            this.btnGetItemById.Text = "Get Item By ID";
            this.btnGetItemById.UseVisualStyleBackColor = false;
            this.btnGetItemById.Click += new System.EventHandler(this.btnGetItemById_Click);
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(112, 17);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(218, 20);
            this.txtItemID.TabIndex = 88;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(18, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(74, 20);
            this.lbl.TabIndex = 87;
            this.lbl.Text = "Item ID:";
            // 
            // frmitemGetItemById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetItemById);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lbl);
            this.Name = "frmitemGetItemById";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmitemGetItemById";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetItemById;
        public System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lbl;
    }
}