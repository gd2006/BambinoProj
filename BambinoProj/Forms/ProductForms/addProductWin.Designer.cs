namespace BambinoProj.Forms.ProductForms
{
    partial class addProductWin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addPriceToProduct = new System.Windows.Forms.Label();
            this.typeId = new System.Windows.Forms.Label();
            this.productLocation = new System.Windows.Forms.Label();
            this.txtboxProductLocation = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtboxProductPrice = new RJCodeAdvance.RJControls.RJTextBox();
            this.addTypeOfProduct = new System.Windows.Forms.Label();
            this.addNameOfProduct = new System.Windows.Forms.Label();
            this.txtboxProductName = new RJCodeAdvance.RJControls.RJTextBox();
            this.cmboboxProductTypes = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addProductBTN = new RJCodeAdvance.RJControls.RJButton();
            this.dgvProductData = new System.Windows.Forms.DataGridView();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productExtraDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxHiddenProducts = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvExtraData = new System.Windows.Forms.DataGridView();
            this.prodNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBLBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addPriceToProduct
            // 
            this.addPriceToProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPriceToProduct.AutoSize = true;
            this.addPriceToProduct.Location = new System.Drawing.Point(1186, 141);
            this.addPriceToProduct.Name = "addPriceToProduct";
            this.addPriceToProduct.Size = new System.Drawing.Size(43, 20);
            this.addPriceToProduct.TabIndex = 6;
            this.addPriceToProduct.Text = "מחיר";
            this.addPriceToProduct.Click += new System.EventHandler(this.addPriceToProduct_Click);
            // 
            // typeId
            // 
            this.typeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeId.AutoSize = true;
            this.typeId.Location = new System.Drawing.Point(1199, 213);
            this.typeId.Name = "typeId";
            this.typeId.Size = new System.Drawing.Size(30, 20);
            this.typeId.TabIndex = 7;
            this.typeId.Text = "סוג";
            this.typeId.Click += new System.EventHandler(this.typeId_Click);
            // 
            // productLocation
            // 
            this.productLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productLocation.AutoSize = true;
            this.productLocation.Location = new System.Drawing.Point(1136, 289);
            this.productLocation.Name = "productLocation";
            this.productLocation.Size = new System.Drawing.Size(93, 20);
            this.productLocation.TabIndex = 17;
            this.productLocation.Text = "מיקום המוצר";
            this.productLocation.Click += new System.EventHandler(this.productLocation_Click);
            // 
            // txtboxProductLocation
            // 
            this.txtboxProductLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxProductLocation.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxProductLocation.BorderColor = System.Drawing.Color.Black;
            this.txtboxProductLocation.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtboxProductLocation.BorderRadius = 0;
            this.txtboxProductLocation.BorderSize = 2;
            this.txtboxProductLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxProductLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxProductLocation.Location = new System.Drawing.Point(986, 280);
            this.txtboxProductLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxProductLocation.Multiline = false;
            this.txtboxProductLocation.Name = "txtboxProductLocation";
            this.txtboxProductLocation.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtboxProductLocation.PasswordChar = false;
            this.txtboxProductLocation.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtboxProductLocation.PlaceholderText = "";
            this.txtboxProductLocation.Size = new System.Drawing.Size(139, 39);
            this.txtboxProductLocation.TabIndex = 16;
            this.txtboxProductLocation.Texts = "";
            this.txtboxProductLocation.UnderlinedStyle = false;
            this.txtboxProductLocation._TextChanged += new System.EventHandler(this.txtboxProductLocation__TextChanged);
            // 
            // txtboxProductPrice
            // 
            this.txtboxProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxProductPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxProductPrice.BorderColor = System.Drawing.Color.Black;
            this.txtboxProductPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtboxProductPrice.BorderRadius = 0;
            this.txtboxProductPrice.BorderSize = 2;
            this.txtboxProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxProductPrice.Location = new System.Drawing.Point(987, 131);
            this.txtboxProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxProductPrice.Multiline = false;
            this.txtboxProductPrice.Name = "txtboxProductPrice";
            this.txtboxProductPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtboxProductPrice.PasswordChar = false;
            this.txtboxProductPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtboxProductPrice.PlaceholderText = "";
            this.txtboxProductPrice.Size = new System.Drawing.Size(139, 39);
            this.txtboxProductPrice.TabIndex = 15;
            this.txtboxProductPrice.Texts = "";
            this.txtboxProductPrice.UnderlinedStyle = false;
            this.txtboxProductPrice._TextChanged += new System.EventHandler(this.txtboxProductPrice__TextChanged);
            // 
            // addTypeOfProduct
            // 
            this.addTypeOfProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTypeOfProduct.AutoSize = true;
            this.addTypeOfProduct.Location = new System.Drawing.Point(1132, 150);
            this.addTypeOfProduct.Name = "addTypeOfProduct";
            this.addTypeOfProduct.Size = new System.Drawing.Size(0, 20);
            this.addTypeOfProduct.TabIndex = 14;
            this.addTypeOfProduct.Click += new System.EventHandler(this.addTypeOfProduct_Click_1);
            // 
            // addNameOfProduct
            // 
            this.addNameOfProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNameOfProduct.AutoSize = true;
            this.addNameOfProduct.Location = new System.Drawing.Point(1154, 74);
            this.addNameOfProduct.Name = "addNameOfProduct";
            this.addNameOfProduct.Size = new System.Drawing.Size(75, 20);
            this.addNameOfProduct.TabIndex = 13;
            this.addNameOfProduct.Text = "שם המוצר";
            // 
            // txtboxProductName
            // 
            this.txtboxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxProductName.BorderColor = System.Drawing.Color.Black;
            this.txtboxProductName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtboxProductName.BorderRadius = 0;
            this.txtboxProductName.BorderSize = 2;
            this.txtboxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxProductName.Location = new System.Drawing.Point(987, 65);
            this.txtboxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxProductName.Multiline = false;
            this.txtboxProductName.Name = "txtboxProductName";
            this.txtboxProductName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtboxProductName.PasswordChar = false;
            this.txtboxProductName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtboxProductName.PlaceholderText = "";
            this.txtboxProductName.Size = new System.Drawing.Size(138, 39);
            this.txtboxProductName.TabIndex = 12;
            this.txtboxProductName.Texts = "";
            this.txtboxProductName.UnderlinedStyle = false;
            // 
            // cmboboxProductTypes
            // 
            this.cmboboxProductTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboboxProductTypes.DataSource = this.bindingSource1;
            this.cmboboxProductTypes.DisplayMember = "typeName";
            this.cmboboxProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboboxProductTypes.FormattingEnabled = true;
            this.cmboboxProductTypes.Location = new System.Drawing.Point(987, 210);
            this.cmboboxProductTypes.Name = "cmboboxProductTypes";
            this.cmboboxProductTypes.Size = new System.Drawing.Size(138, 28);
            this.cmboboxProductTypes.TabIndex = 11;
            this.cmboboxProductTypes.ValueMember = "Id";
            this.cmboboxProductTypes.SelectedIndexChanged += new System.EventHandler(this.cmboboxProductTypes_SelectedIndexChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(BambinoProj.productTypeTBL);
            // 
            // addProductBTN
            // 
            this.addProductBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductBTN.BackColor = System.Drawing.Color.Olive;
            this.addProductBTN.BackgroundColor = System.Drawing.Color.Olive;
            this.addProductBTN.BorderColor = System.Drawing.Color.Transparent;
            this.addProductBTN.BorderRadius = 0;
            this.addProductBTN.BorderSize = 2;
            this.addProductBTN.FlatAppearance.BorderSize = 0;
            this.addProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addProductBTN.ForeColor = System.Drawing.Color.White;
            this.addProductBTN.Location = new System.Drawing.Point(1128, 382);
            this.addProductBTN.Name = "addProductBTN";
            this.addProductBTN.Size = new System.Drawing.Size(101, 34);
            this.addProductBTN.TabIndex = 18;
            this.addProductBTN.Text = "הוסף מוצר";
            this.addProductBTN.TextColor = System.Drawing.Color.White;
            this.addProductBTN.UseVisualStyleBackColor = false;
            this.addProductBTN.Click += new System.EventHandler(this.addProductBTN_Click);
            // 
            // dgvProductData
            // 
            this.dgvProductData.AllowUserToAddRows = false;
            this.dgvProductData.AllowUserToDeleteRows = false;
            this.dgvProductData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductData.AutoGenerateColumns = false;
            this.dgvProductData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeIDDataGridViewTextBoxColumn,
            this.Location,
            this.productExtraDataDataGridViewTextBoxColumn});
            this.dgvProductData.DataSource = this.productTBLBindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductData.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductData.Location = new System.Drawing.Point(3, 13);
            this.dgvProductData.Name = "dgvProductData";
            this.dgvProductData.ReadOnly = true;
            this.dgvProductData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProductData.RowHeadersVisible = false;
            this.dgvProductData.RowHeadersWidth = 62;
            this.dgvProductData.RowTemplate.Height = 28;
            this.dgvProductData.Size = new System.Drawing.Size(722, 241);
            this.dgvProductData.TabIndex = 19;
            this.dgvProductData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductData_CellContentClick);
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "prodName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.prodNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "שם המוצר";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.priceDataGridViewTextBoxColumn.HeaderText = "מחיר המוצר ";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "typeID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.typeIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "סוג המוצר";
            this.typeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            this.typeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Location.DefaultCellStyle = dataGridViewCellStyle5;
            this.Location.HeaderText = "מיקום המוצר";
            this.Location.MinimumWidth = 8;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // productExtraDataDataGridViewTextBoxColumn
            // 
            this.productExtraDataDataGridViewTextBoxColumn.DataPropertyName = "productExtraData";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productExtraDataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.productExtraDataDataGridViewTextBoxColumn.HeaderText = "מידע נוסף";
            this.productExtraDataDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productExtraDataDataGridViewTextBoxColumn.Name = "productExtraDataDataGridViewTextBoxColumn";
            this.productExtraDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTBLBindingSource1
            // 
            this.productTBLBindingSource1.DataSource = typeof(BambinoProj.productTBL);
            // 
            // productTBLBindingSource
            // 
            this.productTBLBindingSource.DataSource = typeof(BambinoProj.productTBL);
            // 
            // cbxHiddenProducts
            // 
            this.cbxHiddenProducts.FormattingEnabled = true;
            this.cbxHiddenProducts.Location = new System.Drawing.Point(210, 65);
            this.cbxHiddenProducts.Name = "cbxHiddenProducts";
            this.cbxHiddenProducts.Size = new System.Drawing.Size(121, 28);
            this.cbxHiddenProducts.TabIndex = 20;
            this.cbxHiddenProducts.Visible = false;
            this.cbxHiddenProducts.SelectedIndexChanged += new System.EventHandler(this.cbxHiddenProducts_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 492);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbxHiddenProducts);
            this.panel1.Controls.Add(this.dgvProductData);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 240);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvExtraData);
            this.panel2.Location = new System.Drawing.Point(3, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 240);
            this.panel2.TabIndex = 1;
            // 
            // dgvExtraData
            // 
            this.dgvExtraData.AllowUserToAddRows = false;
            this.dgvExtraData.AllowUserToDeleteRows = false;
            this.dgvExtraData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExtraData.AutoGenerateColumns = false;
            this.dgvExtraData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExtraData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvExtraData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtraData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodNameDataGridViewTextBoxColumn1,
            this.keyNameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn});
            this.dgvExtraData.DataSource = this.productViewBindingSource;
            this.dgvExtraData.Location = new System.Drawing.Point(0, 0);
            this.dgvExtraData.Name = "dgvExtraData";
            this.dgvExtraData.ReadOnly = true;
            this.dgvExtraData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvExtraData.RowHeadersVisible = false;
            this.dgvExtraData.RowHeadersWidth = 62;
            this.dgvExtraData.RowTemplate.Height = 28;
            this.dgvExtraData.Size = new System.Drawing.Size(719, 240);
            this.dgvExtraData.TabIndex = 0;
            this.dgvExtraData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtraData_CellContentClick);
            // 
            // prodNameDataGridViewTextBoxColumn1
            // 
            this.prodNameDataGridViewTextBoxColumn1.DataPropertyName = "prodName";
            this.prodNameDataGridViewTextBoxColumn1.HeaderText = "שם המוצר";
            this.prodNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.prodNameDataGridViewTextBoxColumn1.Name = "prodNameDataGridViewTextBoxColumn1";
            this.prodNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // keyNameDataGridViewTextBoxColumn
            // 
            this.keyNameDataGridViewTextBoxColumn.DataPropertyName = "KeyName";
            this.keyNameDataGridViewTextBoxColumn.HeaderText = "מאפיין";
            this.keyNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.keyNameDataGridViewTextBoxColumn.Name = "keyNameDataGridViewTextBoxColumn";
            this.keyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "ערך";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "typeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "סוג";
            this.typeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productViewBindingSource
            // 
            this.productViewBindingSource.DataSource = typeof(BambinoProj.productView);
            // 
            // addProductWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1310, 637);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addProductBTN);
            this.Controls.Add(this.productLocation);
            this.Controls.Add(this.txtboxProductLocation);
            this.Controls.Add(this.txtboxProductPrice);
            this.Controls.Add(this.addTypeOfProduct);
            this.Controls.Add(this.addNameOfProduct);
            this.Controls.Add(this.txtboxProductName);
            this.Controls.Add(this.cmboboxProductTypes);
            this.Controls.Add(this.typeId);
            this.Controls.Add(this.addPriceToProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addProductWin";
            this.Text = "addProductWin";
            this.Load += new System.EventHandler(this.addProductWin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBLBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label addPriceToProduct;
        private System.Windows.Forms.Label typeId;
        private System.Windows.Forms.Label productLocation;
        private RJCodeAdvance.RJControls.RJTextBox txtboxProductLocation;
        private RJCodeAdvance.RJControls.RJTextBox txtboxProductPrice;
        private System.Windows.Forms.Label addTypeOfProduct;
        private System.Windows.Forms.Label addNameOfProduct;
        private RJCodeAdvance.RJControls.RJTextBox txtboxProductName;
        private System.Windows.Forms.ComboBox cmboboxProductTypes;
        private RJCodeAdvance.RJControls.RJButton addProductBTN;
        private System.Windows.Forms.DataGridView dgvProductData;
              private System.Windows.Forms.BindingSource productTypeTBLBindingSource;
        private System.Windows.Forms.BindingSource productTBLBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource productTBLBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn productExtraDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxHiddenProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvExtraData;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productViewBindingSource;
    }
}