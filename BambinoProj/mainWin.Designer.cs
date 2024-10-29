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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWin));
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.productsTAB = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton2 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton3 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab2 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.ID = new RJCodeAdvance.RJControls.RJTextBox();
            this.סוג = new RJCodeAdvance.RJControls.RJTextBox();
            this.גודל = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = true;
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.productsTAB,
            this.kryptonRibbonTab2,
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedTab = this.productsTAB;
            this.kryptonRibbon1.Size = new System.Drawing.Size(845, 201);
            this.kryptonRibbon1.TabIndex = 0;
            this.kryptonRibbon1.SelectedTabChanged += new System.EventHandler(this.kryptonRibbon1_SelectedTabChanged);
            // 
            // productsTAB
            // 
            this.productsTAB.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.productsTAB.Text = "מוצרים";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.DialogBoxLauncherClick += new System.EventHandler(this.kryptonRibbonGroup1_DialogBoxLauncherClick);
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton1,
            this.kryptonRibbonGroupButton2,
            this.kryptonRibbonGroupButton3});
            // 
            // kryptonRibbonGroupButton1
            // 
            this.kryptonRibbonGroupButton1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton1.ImageLarge")));
            this.kryptonRibbonGroupButton1.TextLine1 = "הוספת מוצר ";
            this.kryptonRibbonGroupButton1.Click += new System.EventHandler(this.kryptonRibbonGroupButton1_Click);
            // 
            // kryptonRibbonGroupButton2
            // 
            this.kryptonRibbonGroupButton2.Click += new System.EventHandler(this.kryptonRibbonGroupButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(859, 304);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(194, 61);
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.Cyan;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Rounding = 5F;
            this.kryptonButton1.StateNormal.Border.Width = 1;
            this.kryptonButton1.StateNormal.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateNormal.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonButton1.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton1.StateNormal.Content.ShortText.ColorAngle = 33F;
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ID.BorderColor = System.Drawing.SystemColors.Control;
            this.ID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ID.BorderRadius = 0;
            this.ID.BorderSize = 2;
            this.ID.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID.Location = new System.Drawing.Point(629, 233);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Multiline = false;
            this.ID.Name = "ID";
            this.ID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ID.PasswordChar = false;
            this.ID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ID.PlaceholderText = "";
            this.ID.Size = new System.Drawing.Size(180, 39);
            this.ID.TabIndex = 3;
            this.ID.Texts = "ID";
            this.ID.UnderlinedStyle = false;
            this.ID.UseWaitCursor = true;
            this.ID._TextChanged += new System.EventHandler(this.ID__TextChanged);
            // 
            // סוג
            // 
            this.סוג.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.סוג.BackColor = System.Drawing.SystemColors.MenuBar;
            this.סוג.BorderColor = System.Drawing.SystemColors.Control;
            this.סוג.BorderFocusColor = System.Drawing.Color.HotPink;
            this.סוג.BorderRadius = 0;
            this.סוג.BorderSize = 2;
            this.סוג.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.סוג.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.סוג.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.סוג.Location = new System.Drawing.Point(629, 280);
            this.סוג.Margin = new System.Windows.Forms.Padding(4);
            this.סוג.Multiline = false;
            this.סוג.Name = "סוג";
            this.סוג.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.סוג.PasswordChar = false;
            this.סוג.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.סוג.PlaceholderText = "";
            this.סוג.Size = new System.Drawing.Size(180, 39);
            this.סוג.TabIndex = 4;
            this.סוג.Texts = "סוג מוצר";
            this.סוג.UnderlinedStyle = false;
            this.סוג.UseWaitCursor = true;
            this.סוג._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // גודל
            // 
            this.גודל.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.גודל.BackColor = System.Drawing.SystemColors.MenuBar;
            this.גודל.BorderColor = System.Drawing.SystemColors.Control;
            this.גודל.BorderFocusColor = System.Drawing.Color.HotPink;
            this.גודל.BorderRadius = 0;
            this.גודל.BorderSize = 2;
            this.גודל.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.גודל.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.גודל.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.גודל.Location = new System.Drawing.Point(629, 327);
            this.גודל.Margin = new System.Windows.Forms.Padding(4);
            this.גודל.Multiline = false;
            this.גודל.Name = "גודל";
            this.גודל.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.גודל.PasswordChar = false;
            this.גודל.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.גודל.PlaceholderText = "";
            this.גודל.Size = new System.Drawing.Size(180, 39);
            this.גודל.TabIndex = 5;
            this.גודל.Texts = "גודל";
            this.גודל.UnderlinedStyle = false;
            this.גודל.UseWaitCursor = true;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rjTextBox1.BorderColor = System.Drawing.SystemColors.Control;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(629, 374);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(180, 39);
            this.rjTextBox1.TabIndex = 6;
            this.rjTextBox1.Texts = "מיקום";
            this.rjTextBox1.UnderlinedStyle = false;
            this.rjTextBox1.UseWaitCursor = true;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(106, 268);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroup1_Panel_Paint);
            this.kryptonGroup1.Size = new System.Drawing.Size(247, 145);
            this.kryptonGroup1.TabIndex = 7;
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(507, 216);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(178, 29);
            this.kryptonCheckBox1.TabIndex = 8;
            this.kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            this.kryptonCheckBox1.CheckedChanged += new System.EventHandler(this.kryptonCheckBox1_CheckedChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 540);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.גודל);
            this.Controls.Add(this.סוג);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "mainWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.mainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Ribbon.KryptonRibbonTab productsTAB;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private RJCodeAdvance.RJControls.RJTextBox ID;
        private RJCodeAdvance.RJControls.RJTextBox סוג;
        private RJCodeAdvance.RJControls.RJTextBox גודל;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
    }
}

