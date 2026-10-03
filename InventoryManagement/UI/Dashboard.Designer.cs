namespace InventoryManagement
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmBrandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmWarehouseToolStripMenuItem,
            this.frmBrandsToolStripMenuItem,
            this.frmItemsToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // frmWarehouseToolStripMenuItem
            // 
            this.frmWarehouseToolStripMenuItem.Name = "frmWarehouseToolStripMenuItem";
            this.frmWarehouseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.frmWarehouseToolStripMenuItem.Text = "FrmWarehouse";
            this.frmWarehouseToolStripMenuItem.Click += new System.EventHandler(this.frmWarehouseToolStripMenuItem_Click);
            // 
            // frmBrandsToolStripMenuItem
            // 
            this.frmBrandsToolStripMenuItem.Name = "frmBrandsToolStripMenuItem";
            this.frmBrandsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.frmBrandsToolStripMenuItem.Text = "FrmBrands";
            this.frmBrandsToolStripMenuItem.Click += new System.EventHandler(this.frmBrandsToolStripMenuItem_Click);
            // 
            // frmItemsToolStripMenuItem
            // 
            this.frmItemsToolStripMenuItem.Name = "frmItemsToolStripMenuItem";
            this.frmItemsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.frmItemsToolStripMenuItem.Text = "FrmItems";
            this.frmItemsToolStripMenuItem.Click += new System.EventHandler(this.frmItemsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 380);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmBrandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmItemsToolStripMenuItem;
    }
}

