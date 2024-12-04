namespace BambinoProj
{
    partial class mainWin
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productWin = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductWin = new System.Windows.Forms.ToolStripMenuItem();
            this.addTypeProductwin = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מאפיינימוצרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.מידענוסףלמוצרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.miniToolStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miniToolStrip.Location = new System.Drawing.Point(781, 2);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1141, 33);
            this.miniToolStrip.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productWin,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productWin
            // 
            this.productWin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductWin,
            this.addTypeProductwin,
            this.מידענוסףלמוצרToolStripMenuItem});
            this.productWin.Name = "productWin";
            this.productWin.Size = new System.Drawing.Size(88, 29);
            this.productWin.Text = "מוצרים ";
            // 
            // addProductWin
            // 
            this.addProductWin.Name = "addProductWin";
            this.addProductWin.Size = new System.Drawing.Size(297, 34);
            this.addProductWin.Text = "הוספת מוצר";
            this.addProductWin.Click += new System.EventHandler(this.הוספתמוצרToolStripMenuItem_Click);
            // 
            // addTypeProductwin
            // 
            this.addTypeProductwin.Name = "addTypeProductwin";
            this.addTypeProductwin.Size = new System.Drawing.Size(297, 34);
            this.addTypeProductwin.Text = "הוספת קטגוריית המוצר";
            this.addTypeProductwin.Click += new System.EventHandler(this.updateProductwin_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.מאפיינימוצרToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // מאפיינימוצרToolStripMenuItem
            // 
            this.מאפיינימוצרToolStripMenuItem.Name = "מאפיינימוצרToolStripMenuItem";
            this.מאפיינימוצרToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.מאפיינימוצרToolStripMenuItem.Text = "מאפייני מוצר";
            this.מאפיינימוצרToolStripMenuItem.Click += new System.EventHandler(this.מאפיינימוצרToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.menuStrip1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1141, 540);
            this.mainPanel.TabIndex = 1;
            // 
            // מידענוסףלמוצרToolStripMenuItem
            // 
            this.מידענוסףלמוצרToolStripMenuItem.Name = "מידענוסףלמוצרToolStripMenuItem";
            this.מידענוסףלמוצרToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.מידענוסףלמוצרToolStripMenuItem.Text = "מידע נוסף למוצר ";
            this.מידענוסףלמוצרToolStripMenuItem.Click += new System.EventHandler(this.מידענוסףלמוצרToolStripMenuItem_Click);
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 540);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainWin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productWin;
        private System.Windows.Forms.ToolStripMenuItem addProductWin;
        private System.Windows.Forms.ToolStripMenuItem addTypeProductwin;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מאפיינימוצרToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem מידענוסףלמוצרToolStripMenuItem;
    }
}

