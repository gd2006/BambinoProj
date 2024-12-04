namespace BambinoProj.Forms.ProductForms
{
    partial class addExtraData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductExtreData = new System.Windows.Forms.DataGridView();
            this.productExtraDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addTypeOfProduct = new System.Windows.Forms.Label();
            this.addNameOfProduct = new System.Windows.Forms.Label();
            this.ProductKeyCBX = new System.Windows.Forms.ComboBox();
            this.prodExtraKeysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeId = new System.Windows.Forms.Label();
            this.addPriceToProduct = new System.Windows.Forms.Label();
            this.productIdNameCBX = new System.Windows.Forms.ComboBox();
            this.productTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtboxProductvalue = new RJCodeAdvance.RJControls.RJTextBox();
            this.addExtraDataBTN = new RJCodeAdvance.RJControls.RJButton();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductExtreData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtraDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodExtraKeysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductExtreData
            // 
            this.dgvProductExtreData.AllowUserToAddRows = false;
            this.dgvProductExtreData.AllowUserToDeleteRows = false;
            this.dgvProductExtreData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductExtreData.AutoGenerateColumns = false;
            this.dgvProductExtreData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductExtreData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductExtreData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductExtreData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.keyIDDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dgvProductExtreData.DataSource = this.productExtraDataBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductExtreData.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductExtreData.Location = new System.Drawing.Point(42, 78);
            this.dgvProductExtreData.Name = "dgvProductExtreData";
            this.dgvProductExtreData.ReadOnly = true;
            this.dgvProductExtreData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProductExtreData.RowHeadersVisible = false;
            this.dgvProductExtreData.RowHeadersWidth = 62;
            this.dgvProductExtreData.RowTemplate.Height = 28;
            this.dgvProductExtreData.Size = new System.Drawing.Size(491, 437);
            this.dgvProductExtreData.TabIndex = 30;
            this.dgvProductExtreData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductData_CellContentClick);
            // 
            // productExtraDataBindingSource
            // 
            this.productExtraDataBindingSource.DataSource = typeof(BambinoProj.productExtraData);
            // 
            // addTypeOfProduct
            // 
            this.addTypeOfProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTypeOfProduct.AutoSize = true;
            this.addTypeOfProduct.Location = new System.Drawing.Point(737, 188);
            this.addTypeOfProduct.Name = "addTypeOfProduct";
            this.addTypeOfProduct.Size = new System.Drawing.Size(0, 20);
            this.addTypeOfProduct.TabIndex = 25;
            this.addTypeOfProduct.Click += new System.EventHandler(this.addTypeOfProduct_Click);
            // 
            // addNameOfProduct
            // 
            this.addNameOfProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNameOfProduct.AutoSize = true;
            this.addNameOfProduct.Location = new System.Drawing.Point(791, 112);
            this.addNameOfProduct.Name = "addNameOfProduct";
            this.addNameOfProduct.Size = new System.Drawing.Size(75, 20);
            this.addNameOfProduct.TabIndex = 24;
            this.addNameOfProduct.Text = "שם המוצר";
            this.addNameOfProduct.Click += new System.EventHandler(this.addNameOfProduct_Click);
            // 
            // ProductKeyCBX
            // 
            this.ProductKeyCBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductKeyCBX.DataSource = this.prodExtraKeysBindingSource;
            this.ProductKeyCBX.DisplayMember = "KeyName";
            this.ProductKeyCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductKeyCBX.FormattingEnabled = true;
            this.ProductKeyCBX.Location = new System.Drawing.Point(592, 180);
            this.ProductKeyCBX.Name = "ProductKeyCBX";
            this.ProductKeyCBX.Size = new System.Drawing.Size(138, 28);
            this.ProductKeyCBX.TabIndex = 22;
            this.ProductKeyCBX.SelectedIndexChanged += new System.EventHandler(this.cmboboxProductTypes_SelectedIndexChanged);
            // 
            // prodExtraKeysBindingSource
            // 
            this.prodExtraKeysBindingSource.DataSource = typeof(BambinoProj.prodExtraKeys);
            // 
            // typeId
            // 
            this.typeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeId.AutoSize = true;
            this.typeId.Location = new System.Drawing.Point(771, 258);
            this.typeId.Name = "typeId";
            this.typeId.Size = new System.Drawing.Size(95, 20);
            this.typeId.TabIndex = 21;
            this.typeId.Text = "ערך המאפיין";
            this.typeId.Click += new System.EventHandler(this.typeId_Click);
            // 
            // addPriceToProduct
            // 
            this.addPriceToProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPriceToProduct.AutoSize = true;
            this.addPriceToProduct.Location = new System.Drawing.Point(812, 180);
            this.addPriceToProduct.Name = "addPriceToProduct";
            this.addPriceToProduct.Size = new System.Drawing.Size(54, 20);
            this.addPriceToProduct.TabIndex = 20;
            this.addPriceToProduct.Text = "מאפיין";
            this.addPriceToProduct.Click += new System.EventHandler(this.addPriceToProduct_Click);
            // 
            // productIdNameCBX
            // 
            this.productIdNameCBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productIdNameCBX.DataSource = this.productTBLBindingSource;
            this.productIdNameCBX.DisplayMember = "prodName";
            this.productIdNameCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productIdNameCBX.FormattingEnabled = true;
            this.productIdNameCBX.Location = new System.Drawing.Point(592, 109);
            this.productIdNameCBX.Name = "productIdNameCBX";
            this.productIdNameCBX.Size = new System.Drawing.Size(138, 28);
            this.productIdNameCBX.TabIndex = 31;
            this.productIdNameCBX.ValueMember = "Id";
            // 
            // productTBLBindingSource
            // 
            this.productTBLBindingSource.DataSource = typeof(BambinoProj.productTBL);
            // 
            // txtboxProductvalue
            // 
            this.txtboxProductvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxProductvalue.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxProductvalue.BorderColor = System.Drawing.Color.Black;
            this.txtboxProductvalue.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtboxProductvalue.BorderRadius = 0;
            this.txtboxProductvalue.BorderSize = 2;
            this.txtboxProductvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxProductvalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxProductvalue.Location = new System.Drawing.Point(594, 248);
            this.txtboxProductvalue.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxProductvalue.Multiline = false;
            this.txtboxProductvalue.Name = "txtboxProductvalue";
            this.txtboxProductvalue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtboxProductvalue.PasswordChar = false;
            this.txtboxProductvalue.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtboxProductvalue.PlaceholderText = "";
            this.txtboxProductvalue.Size = new System.Drawing.Size(139, 39);
            this.txtboxProductvalue.TabIndex = 26;
            this.txtboxProductvalue.Texts = "";
            this.txtboxProductvalue.UnderlinedStyle = false;
            this.txtboxProductvalue._TextChanged += new System.EventHandler(this.txtboxProductPrice__TextChanged);
            // 
            // addExtraDataBTN
            // 
            this.addExtraDataBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addExtraDataBTN.BackColor = System.Drawing.Color.Olive;
            this.addExtraDataBTN.BackgroundColor = System.Drawing.Color.Olive;
            this.addExtraDataBTN.BorderColor = System.Drawing.Color.Transparent;
            this.addExtraDataBTN.BorderRadius = 0;
            this.addExtraDataBTN.BorderSize = 2;
            this.addExtraDataBTN.FlatAppearance.BorderSize = 0;
            this.addExtraDataBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExtraDataBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addExtraDataBTN.ForeColor = System.Drawing.Color.White;
            this.addExtraDataBTN.Location = new System.Drawing.Point(632, 357);
            this.addExtraDataBTN.Name = "addExtraDataBTN";
            this.addExtraDataBTN.Size = new System.Drawing.Size(101, 34);
            this.addExtraDataBTN.TabIndex = 32;
            this.addExtraDataBTN.Text = "הוסף מוצר";
            this.addExtraDataBTN.TextColor = System.Drawing.Color.White;
            this.addExtraDataBTN.UseVisualStyleBackColor = false;
            this.addExtraDataBTN.Click += new System.EventHandler(this.addExtraDataBTN_Click);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.productIDDataGridViewTextBoxColumn.HeaderText = "שם המוצר";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyIDDataGridViewTextBoxColumn
            // 
            this.keyIDDataGridViewTextBoxColumn.DataPropertyName = "keyID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.keyIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.keyIDDataGridViewTextBoxColumn.HeaderText = "מאפיין";
            this.keyIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.keyIDDataGridViewTextBoxColumn.Name = "keyIDDataGridViewTextBoxColumn";
            this.keyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.valueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.valueDataGridViewTextBoxColumn.HeaderText = "ערך המאפיין";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addExtraData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 606);
            this.Controls.Add(this.addExtraDataBTN);
            this.Controls.Add(this.productIdNameCBX);
            this.Controls.Add(this.dgvProductExtreData);
            this.Controls.Add(this.txtboxProductvalue);
            this.Controls.Add(this.addTypeOfProduct);
            this.Controls.Add(this.addNameOfProduct);
            this.Controls.Add(this.ProductKeyCBX);
            this.Controls.Add(this.typeId);
            this.Controls.Add(this.addPriceToProduct);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addExtraData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "addExtraData";
            this.Load += new System.EventHandler(this.addExtraData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductExtreData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtraDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodExtraKeysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductExtreData;
        private System.Windows.Forms.Label addTypeOfProduct;
        private System.Windows.Forms.Label addNameOfProduct;
        private System.Windows.Forms.ComboBox ProductKeyCBX;
        private System.Windows.Forms.Label typeId;
        private System.Windows.Forms.Label addPriceToProduct;
        private System.Windows.Forms.ComboBox productIdNameCBX;
        private RJCodeAdvance.RJControls.RJTextBox txtboxProductvalue;
        private System.Windows.Forms.BindingSource productExtraDataBindingSource;
        private System.Windows.Forms.BindingSource prodExtraKeysBindingSource;
        private System.Windows.Forms.BindingSource productTBLBindingSource;
        private RJCodeAdvance.RJControls.RJButton addExtraDataBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}