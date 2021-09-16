
namespace SkelleySkeleton
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.mnuProducts = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenuItems = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbxWitch = new System.Windows.Forms.PictureBox();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mnuProducts.SuspendLayout();
            this.pnlMenuItems.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuProducts
            // 
            this.mnuProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(177)))), ((int)(((byte)(46)))));
            this.mnuProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuProducts.Location = new System.Drawing.Point(0, 0);
            this.mnuProducts.Name = "mnuProducts";
            this.mnuProducts.Size = new System.Drawing.Size(779, 24);
            this.mnuProducts.TabIndex = 3;
            this.mnuProducts.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Close";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // pnlMenuItems
            // 
            this.pnlMenuItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(177)))), ((int)(((byte)(46)))));
            this.pnlMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenuItems.Controls.Add(this.dataGridView1);
            this.pnlMenuItems.Controls.Add(this.btnAdd);
            this.pnlMenuItems.Controls.Add(this.lblItems);
            this.pnlMenuItems.Location = new System.Drawing.Point(12, 37);
            this.pnlMenuItems.Name = "pnlMenuItems";
            this.pnlMenuItems.Size = new System.Drawing.Size(427, 496);
            this.pnlMenuItems.TabIndex = 4;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(177)))), ((int)(((byte)(46)))));
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSettings.Controls.Add(this.lblSettings);
            this.pnlSettings.Controls.Add(this.pbxWitch);
            this.pnlSettings.Location = new System.Drawing.Point(445, 37);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(322, 259);
            this.pnlSettings.TabIndex = 5;
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(177)))), ((int)(((byte)(46)))));
            this.pnlCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCart.Controls.Add(this.btnCheckout);
            this.pnlCart.Controls.Add(this.btnRemove);
            this.pnlCart.Controls.Add(this.lblCart);
            this.pnlCart.Controls.Add(this.btnCancel);
            this.pnlCart.Location = new System.Drawing.Point(445, 302);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(322, 231);
            this.pnlCart.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbxWitch
            // 
            this.pbxWitch.BackColor = System.Drawing.Color.Transparent;
            this.pbxWitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxWitch.BackgroundImage")));
            this.pbxWitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxWitch.Location = new System.Drawing.Point(182, 138);
            this.pbxWitch.Name = "pbxWitch";
            this.pbxWitch.Size = new System.Drawing.Size(138, 119);
            this.pbxWitch.TabIndex = 1;
            this.pbxWitch.TabStop = false;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(3, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Padding = new System.Windows.Forms.Padding(5);
            this.lblSettings.Size = new System.Drawing.Size(86, 28);
            this.lblSettings.TabIndex = 7;
            this.lblSettings.Text = "Settings";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.Transparent;
            this.lblItems.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(3, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Padding = new System.Windows.Forms.Padding(5);
            this.lblItems.Size = new System.Drawing.Size(112, 28);
            this.lblItems.TabIndex = 8;
            this.lblItems.Text = "Menu Items";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.BackColor = System.Drawing.Color.Transparent;
            this.lblCart.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(3, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Padding = new System.Windows.Forms.Padding(5);
            this.lblCart.Size = new System.Drawing.Size(97, 28);
            this.lblCart.TabIndex = 8;
            this.lblCart.Text = "Your Cart";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(3, 192);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 32);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(93, 192);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(84, 32);
            this.btnCheckout.TabIndex = 10;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 457);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(177)))), ((int)(((byte)(46)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 411);
            this.dataGridView1.TabIndex = 12;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(779, 545);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlMenuItems);
            this.Controls.Add(this.mnuProducts);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.mnuProducts.ResumeLayout(false);
            this.mnuProducts.PerformLayout();
            this.pnlMenuItems.ResumeLayout(false);
            this.pnlMenuItems.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProducts;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenuItems;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbxWitch;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}