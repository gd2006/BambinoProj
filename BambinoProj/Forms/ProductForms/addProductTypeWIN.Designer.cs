namespace BambinoProj.Forms.ProductForms
{
    partial class addProductTypeWIN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductData = new System.Windows.Forms.DataGridView();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addProductTypeBTN = new RJCodeAdvance.RJControls.RJButton();
            this.productdescription = new System.Windows.Forms.Label();
            this.txtboxProductDescription = new RJCodeAdvance.RJControls.RJTextBox();
            this.addTypeOfProduct = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.Label();
            this.txtboxProductName = new RJCodeAdvance.RJControls.RJTextBox();
            this.productTypeCount = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductData
            // 
            this.dgvProductData.AllowUserToAddRows = false;
            this.dgvProductData.AllowUserToDeleteRows = false;
            this.dgvProductData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.typeNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvProductData.DataSource = this.productTypeTBLBindingSource;
            this.dgvProductData.Location = new System.Drawing.Point(33, 54);
            this.dgvProductData.Name = "dgvProductData";
            this.dgvProductData.ReadOnly = true;
            this.dgvProductData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProductData.RowHeadersVisible = false;
            this.dgvProductData.RowHeadersWidth = 62;
            this.dgvProductData.RowTemplate.Height = 28;
            this.dgvProductData.Size = new System.Drawing.Size(486, 412);
            this.dgvProductData.TabIndex = 30;
            this.dgvProductData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductData_CellContentClick);
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "typeName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.typeNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "שם סוג המוצר";
            this.typeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "תיאור ....";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTypeTBLBindingSource
            // 
            this.productTypeTBLBindingSource.DataSource = typeof(BambinoProj.productTypeTBL);
            // 
            // addProductTypeBTN
            // 
            this.addProductTypeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductTypeBTN.BackColor = System.Drawing.Color.Olive;
            this.addProductTypeBTN.BackgroundColor = System.Drawing.Color.Olive;
            this.addProductTypeBTN.BorderColor = System.Drawing.Color.Transparent;
            this.addProductTypeBTN.BorderRadius = 0;
            this.addProductTypeBTN.BorderSize = 2;
            this.addProductTypeBTN.FlatAppearance.BorderSize = 0;
            this.addProductTypeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductTypeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addProductTypeBTN.ForeColor = System.Drawing.Color.Transparent;
            this.addProductTypeBTN.Location = new System.Drawing.Point(777, 371);
            this.addProductTypeBTN.Name = "addProductTypeBTN";
            this.addProductTypeBTN.Size = new System.Drawing.Size(126, 34);
            this.addProductTypeBTN.TabIndex = 29;
            this.addProductTypeBTN.Text = "הוסף סוג מוצר";
            this.addProductTypeBTN.TextColor = System.Drawing.Color.Transparent;
            this.addProductTypeBTN.UseVisualStyleBackColor = false;
            this.addProductTypeBTN.Click += new System.EventHandler(this.addProductBTN_Click);
            // 
            // productdescription
            // 
            this.productdescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productdescription.AutoSize = true;
            this.productdescription.Location = new System.Drawing.Point(906, 251);
            this.productdescription.Name = "productdescription";
            this.productdescription.Size = new System.Drawing.Size(98, 20);
            this.productdescription.TabIndex = 28;
            this.productdescription.Text = "תיאור המוצר ";
            this.productdescription.Click += new System.EventHandler(this.productLocation_Click);
            // 
            // txtboxProductDescription
            // 
            this.txtboxProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxProductDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxProductDescription.BorderColor = System.Drawing.Color.Black;
            this.txtboxProductDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtboxProductDescription.BorderRadius = 0;
            this.txtboxProductDescription.BorderSize = 2;
            this.txtboxProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxProductDescription.Location = new System.Drawing.Point(662, 241);
            this.txtboxProductDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxProductDescription.Multiline = false;
            this.txtboxProductDescription.Name = "txtboxProductDescription";
            this.txtboxProductDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtboxProductDescription.PasswordChar = false;
            this.txtboxProductDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtboxProductDescription.PlaceholderText = "";
            this.txtboxProductDescription.Size = new System.Drawing.Size(161, 39);
            this.txtboxProductDescription.TabIndex = 27;
            this.txtboxProductDescription.Texts = "";
            this.txtboxProductDescription.UnderlinedStyle = false;
            this.txtboxProductDescription._TextChanged += new System.EventHandler(this.txtboxProductLocation__TextChanged);
            // 
            // addTypeOfProduct
            // 
            this.addTypeOfProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTypeOfProduct.AutoSize = true;
            this.addTypeOfProduct.Location = new System.Drawing.Point(807, 150);
            this.addTypeOfProduct.Name = "addTypeOfProduct";
            this.addTypeOfProduct.Size = new System.Drawing.Size(0, 20);
            this.addTypeOfProduct.TabIndex = 25;
            this.addTypeOfProduct.Click += new System.EventHandler(this.addTypeOfProduct_Click);
            // 
            // productType
            // 
            this.productType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productType.AutoSize = true;
            this.productType.Location = new System.Drawing.Point(923, 140);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(76, 20);
            this.productType.TabIndex = 24;
            this.productType.Text = "סוג המוצר";
            this.productType.Click += new System.EventHandler(this.addNameOfProduct_Click);
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
            this.txtboxProductName.Location = new System.Drawing.Point(662, 131);
            this.txtboxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxProductName.Multiline = false;
            this.txtboxProductName.Name = "txtboxProductName";
            this.txtboxProductName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtboxProductName.PasswordChar = false;
            this.txtboxProductName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtboxProductName.PlaceholderText = "";
            this.txtboxProductName.Size = new System.Drawing.Size(161, 39);
            this.txtboxProductName.TabIndex = 23;
            this.txtboxProductName.Texts = "";
            this.txtboxProductName.UnderlinedStyle = false;
            this.txtboxProductName._TextChanged += new System.EventHandler(this.txtboxProductName__TextChanged);
            // 
            // productTypeCount
            // 
            this.productTypeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productTypeCount.Location = new System.Drawing.Point(546, 497);
            this.productTypeCount.Name = "productTypeCount";
            this.productTypeCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productTypeCount.Size = new System.Drawing.Size(6, 2);
            this.productTypeCount.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.productTypeCount.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.productTypeCount.TabIndex = 31;
            this.productTypeCount.Values.Text = "";
            this.productTypeCount.Click += new System.EventHandler(this.productTypeCount_Click);
            // 
            // addProductTypeWIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 550);
            this.Controls.Add(this.productTypeCount);
            this.Controls.Add(this.dgvProductData);
            this.Controls.Add(this.addProductTypeBTN);
            this.Controls.Add(this.productdescription);
            this.Controls.Add(this.txtboxProductDescription);
            this.Controls.Add(this.addTypeOfProduct);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.txtboxProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addProductTypeWIN";
            this.Text = "updateProductWIN";
            this.Load += new System.EventHandler(this.updateProductWIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductData;
        private RJCodeAdvance.RJControls.RJButton addProductTypeBTN;
        private System.Windows.Forms.Label productdescription;
        private RJCodeAdvance.RJControls.RJTextBox txtboxProductDescription;
        private System.Windows.Forms.Label addTypeOfProduct;
        private System.Windows.Forms.Label productType;
        private RJCodeAdvance.RJControls.RJTextBox txtboxProductName;
        private Krypton.Toolkit.KryptonLabel productTypeCount;
        private System.Windows.Forms.BindingSource productTypeTBLBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}