namespace BambinoProj.Forms
{
    partial class characteristicsProductWin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.keyNametxtbox = new RJCodeAdvance.RJControls.RJTextBox();
            this.KeyDescriptiontxtbox = new RJCodeAdvance.RJControls.RJTextBox();
            this.keyDGV = new System.Windows.Forms.DataGridView();
            this.keyNameLabel = new Krypton.Toolkit.KryptonLabel();
            this.keyDescriptionLabel = new Krypton.Toolkit.KryptonLabel();
            this.addKeyBTN = new RJCodeAdvance.RJControls.RJButton();
            this.keyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodExtraKeysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.keyDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodExtraKeysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // keyNametxtbox
            // 
            this.keyNametxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyNametxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.keyNametxtbox.BorderColor = System.Drawing.Color.Black;
            this.keyNametxtbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.keyNametxtbox.BorderRadius = 0;
            this.keyNametxtbox.BorderSize = 2;
            this.keyNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyNametxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keyNametxtbox.Location = new System.Drawing.Point(552, 219);
            this.keyNametxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.keyNametxtbox.Multiline = false;
            this.keyNametxtbox.Name = "keyNametxtbox";
            this.keyNametxtbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.keyNametxtbox.PasswordChar = false;
            this.keyNametxtbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.keyNametxtbox.PlaceholderText = "";
            this.keyNametxtbox.Size = new System.Drawing.Size(210, 39);
            this.keyNametxtbox.TabIndex = 0;
            this.keyNametxtbox.Texts = "";
            this.keyNametxtbox.UnderlinedStyle = false;
            // 
            // KeyDescriptiontxtbox
            // 
            this.KeyDescriptiontxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyDescriptiontxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.KeyDescriptiontxtbox.BorderColor = System.Drawing.Color.Black;
            this.KeyDescriptiontxtbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.KeyDescriptiontxtbox.BorderRadius = 0;
            this.KeyDescriptiontxtbox.BorderSize = 2;
            this.KeyDescriptiontxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyDescriptiontxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyDescriptiontxtbox.Location = new System.Drawing.Point(552, 323);
            this.KeyDescriptiontxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.KeyDescriptiontxtbox.Multiline = false;
            this.KeyDescriptiontxtbox.Name = "KeyDescriptiontxtbox";
            this.KeyDescriptiontxtbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.KeyDescriptiontxtbox.PasswordChar = false;
            this.KeyDescriptiontxtbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.KeyDescriptiontxtbox.PlaceholderText = "";
            this.KeyDescriptiontxtbox.Size = new System.Drawing.Size(210, 39);
            this.KeyDescriptiontxtbox.TabIndex = 1;
            this.KeyDescriptiontxtbox.Texts = "";
            this.KeyDescriptiontxtbox.UnderlinedStyle = false;
            // 
            // keyDGV
            // 
            this.keyDGV.AllowUserToAddRows = false;
            this.keyDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.keyDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.keyDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyDGV.AutoGenerateColumns = false;
            this.keyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.keyDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.keyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keyDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyNameDataGridViewTextBoxColumn,
            this.keyDescriptionDataGridViewTextBoxColumn});
            this.keyDGV.DataSource = this.prodExtraKeysBindingSource;
            this.keyDGV.Location = new System.Drawing.Point(24, 43);
            this.keyDGV.Name = "keyDGV";
            this.keyDGV.ReadOnly = true;
            this.keyDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keyDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.keyDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.keyDGV.RowHeadersWidth = 62;
            this.keyDGV.RowTemplate.Height = 28;
            this.keyDGV.Size = new System.Drawing.Size(480, 411);
            this.keyDGV.TabIndex = 2;
            this.keyDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.keyDGV_CellContentClick);
            // 
            // keyNameLabel
            // 
            this.keyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyNameLabel.Location = new System.Drawing.Point(847, 229);
            this.keyNameLabel.Name = "keyNameLabel";
            this.keyNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keyNameLabel.Size = new System.Drawing.Size(108, 29);
            this.keyNameLabel.TabIndex = 3;
            this.keyNameLabel.Values.Text = "שם המאפיין";
            // 
            // keyDescriptionLabel
            // 
            this.keyDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyDescriptionLabel.Location = new System.Drawing.Point(785, 323);
            this.keyDescriptionLabel.Name = "keyDescriptionLabel";
            this.keyDescriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keyDescriptionLabel.Size = new System.Drawing.Size(170, 29);
            this.keyDescriptionLabel.TabIndex = 4;
            this.keyDescriptionLabel.Values.Text = "תיאור מאפיין המוצר ";
            this.keyDescriptionLabel.Click += new System.EventHandler(this.keyDescriptionLabel_Click);
            // 
            // addKeyBTN
            // 
            this.addKeyBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addKeyBTN.BackColor = System.Drawing.Color.OliveDrab;
            this.addKeyBTN.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.addKeyBTN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addKeyBTN.BorderRadius = 0;
            this.addKeyBTN.BorderSize = 0;
            this.addKeyBTN.FlatAppearance.BorderSize = 0;
            this.addKeyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addKeyBTN.ForeColor = System.Drawing.Color.White;
            this.addKeyBTN.Location = new System.Drawing.Point(583, 425);
            this.addKeyBTN.Name = "addKeyBTN";
            this.addKeyBTN.Size = new System.Drawing.Size(105, 29);
            this.addKeyBTN.TabIndex = 5;
            this.addKeyBTN.Text = "הוסף מאפיין";
            this.addKeyBTN.TextColor = System.Drawing.Color.White;
            this.addKeyBTN.UseVisualStyleBackColor = false;
            this.addKeyBTN.Click += new System.EventHandler(this.addKeyBTN_Click);
            // 
            // keyNameDataGridViewTextBoxColumn
            // 
            this.keyNameDataGridViewTextBoxColumn.DataPropertyName = "KeyName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.keyNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.keyNameDataGridViewTextBoxColumn.HeaderText = "מאפיין מוצר";
            this.keyNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.keyNameDataGridViewTextBoxColumn.Name = "keyNameDataGridViewTextBoxColumn";
            this.keyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyDescriptionDataGridViewTextBoxColumn
            // 
            this.keyDescriptionDataGridViewTextBoxColumn.DataPropertyName = "KeyDescription";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.keyDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.keyDescriptionDataGridViewTextBoxColumn.HeaderText = "תיאור המאפיין";
            this.keyDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.keyDescriptionDataGridViewTextBoxColumn.Name = "keyDescriptionDataGridViewTextBoxColumn";
            this.keyDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodExtraKeysBindingSource
            // 
            this.prodExtraKeysBindingSource.DataSource = typeof(BambinoProj.prodExtraKeys);
            // 
            // characteristicsProductWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(964, 496);
            this.Controls.Add(this.addKeyBTN);
            this.Controls.Add(this.keyDescriptionLabel);
            this.Controls.Add(this.keyNameLabel);
            this.Controls.Add(this.keyDGV);
            this.Controls.Add(this.KeyDescriptiontxtbox);
            this.Controls.Add(this.keyNametxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "characteristicsProductWin";
            this.Text = "characteristicsProductWin";
            this.Load += new System.EventHandler(this.characteristicsProductWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodExtraKeysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox keyNametxtbox;
        private RJCodeAdvance.RJControls.RJTextBox KeyDescriptiontxtbox;
        private System.Windows.Forms.DataGridView keyDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prodExtraKeysBindingSource;
        private Krypton.Toolkit.KryptonLabel keyNameLabel;
        private Krypton.Toolkit.KryptonLabel keyDescriptionLabel;
        private RJCodeAdvance.RJControls.RJButton addKeyBTN;
    }
}