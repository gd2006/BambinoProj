namespace BambinoProj.Forms.Clients
{
    partial class addClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.nameOfTheBank = new System.Windows.Forms.Label();
            this.institutionSymbolTBX = new RJCodeAdvance.RJControls.RJTextBox();
            this.clientPhoneNumberTBX = new RJCodeAdvance.RJControls.RJTextBox();
            this.addLastNameOfemployed = new System.Windows.Forms.Label();
            this.EmailAddress = new System.Windows.Forms.Label();
            this.clientEmailTBX = new RJCodeAdvance.RJControls.RJTextBox();
            this.lastNameClientTBX = new RJCodeAdvance.RJControls.RJTextBox();
            this.addTypeOfProduct = new System.Windows.Forms.Label();
            this.addNameOfemployed = new System.Windows.Forms.Label();
            this.clientNameTBX = new RJCodeAdvance.RJControls.RJTextBox();
            this.employedPhoneNumber = new System.Windows.Forms.Label();
            this.addClientBtn = new RJCodeAdvance.RJControls.RJButton();
            this.clientdgv = new System.Windows.Forms.DataGridView();
            this.clientsTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientInstitutionSymbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTBLBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Location = new System.Drawing.Point(963, 453);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(105, 20);
            this.paymentMethodLabel.TabIndex = 71;
            this.paymentMethodLabel.Text = "אמצעי תשלום ";
            // 
            // nameOfTheBank
            // 
            this.nameOfTheBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameOfTheBank.AutoSize = true;
            this.nameOfTheBank.Location = new System.Drawing.Point(982, 370);
            this.nameOfTheBank.Name = "nameOfTheBank";
            this.nameOfTheBank.Size = new System.Drawing.Size(74, 20);
            this.nameOfTheBank.TabIndex = 69;
            this.nameOfTheBank.Text = "סמל מוסד";
            this.nameOfTheBank.Click += new System.EventHandler(this.nameOfTheBank_Click);
            // 
            // institutionSymbolTBX
            // 
            this.institutionSymbolTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.institutionSymbolTBX.BackColor = System.Drawing.SystemColors.Window;
            this.institutionSymbolTBX.BorderColor = System.Drawing.Color.Black;
            this.institutionSymbolTBX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.institutionSymbolTBX.BorderRadius = 0;
            this.institutionSymbolTBX.BorderSize = 2;
            this.institutionSymbolTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.institutionSymbolTBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.institutionSymbolTBX.Location = new System.Drawing.Point(784, 360);
            this.institutionSymbolTBX.Margin = new System.Windows.Forms.Padding(4);
            this.institutionSymbolTBX.Multiline = false;
            this.institutionSymbolTBX.Name = "institutionSymbolTBX";
            this.institutionSymbolTBX.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.institutionSymbolTBX.PasswordChar = false;
            this.institutionSymbolTBX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.institutionSymbolTBX.PlaceholderText = "";
            this.institutionSymbolTBX.Size = new System.Drawing.Size(139, 39);
            this.institutionSymbolTBX.TabIndex = 68;
            this.institutionSymbolTBX.Texts = "";
            this.institutionSymbolTBX.UnderlinedStyle = false;
            // 
            // clientPhoneNumberTBX
            // 
            this.clientPhoneNumberTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPhoneNumberTBX.BackColor = System.Drawing.SystemColors.Window;
            this.clientPhoneNumberTBX.BorderColor = System.Drawing.Color.Black;
            this.clientPhoneNumberTBX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.clientPhoneNumberTBX.BorderRadius = 0;
            this.clientPhoneNumberTBX.BorderSize = 2;
            this.clientPhoneNumberTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPhoneNumberTBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientPhoneNumberTBX.Location = new System.Drawing.Point(784, 201);
            this.clientPhoneNumberTBX.Margin = new System.Windows.Forms.Padding(4);
            this.clientPhoneNumberTBX.Multiline = false;
            this.clientPhoneNumberTBX.Name = "clientPhoneNumberTBX";
            this.clientPhoneNumberTBX.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.clientPhoneNumberTBX.PasswordChar = false;
            this.clientPhoneNumberTBX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.clientPhoneNumberTBX.PlaceholderText = "";
            this.clientPhoneNumberTBX.Size = new System.Drawing.Size(139, 39);
            this.clientPhoneNumberTBX.TabIndex = 66;
            this.clientPhoneNumberTBX.Texts = "";
            this.clientPhoneNumberTBX.UnderlinedStyle = false;
            // 
            // addLastNameOfemployed
            // 
            this.addLastNameOfemployed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addLastNameOfemployed.AutoSize = true;
            this.addLastNameOfemployed.Location = new System.Drawing.Point(971, 137);
            this.addLastNameOfemployed.Name = "addLastNameOfemployed";
            this.addLastNameOfemployed.Size = new System.Drawing.Size(85, 20);
            this.addLastNameOfemployed.TabIndex = 65;
            this.addLastNameOfemployed.Text = "שם משפחה ";
            // 
            // EmailAddress
            // 
            this.EmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailAddress.AutoSize = true;
            this.EmailAddress.Location = new System.Drawing.Point(963, 287);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(99, 20);
            this.EmailAddress.TabIndex = 64;
            this.EmailAddress.Text = "כתובת אימייל";
            // 
            // clientEmailTBX
            // 
            this.clientEmailTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientEmailTBX.BackColor = System.Drawing.SystemColors.Window;
            this.clientEmailTBX.BorderColor = System.Drawing.Color.Black;
            this.clientEmailTBX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.clientEmailTBX.BorderRadius = 0;
            this.clientEmailTBX.BorderSize = 2;
            this.clientEmailTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientEmailTBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientEmailTBX.Location = new System.Drawing.Point(783, 277);
            this.clientEmailTBX.Margin = new System.Windows.Forms.Padding(4);
            this.clientEmailTBX.Multiline = false;
            this.clientEmailTBX.Name = "clientEmailTBX";
            this.clientEmailTBX.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.clientEmailTBX.PasswordChar = false;
            this.clientEmailTBX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.clientEmailTBX.PlaceholderText = "";
            this.clientEmailTBX.Size = new System.Drawing.Size(139, 39);
            this.clientEmailTBX.TabIndex = 63;
            this.clientEmailTBX.Texts = "";
            this.clientEmailTBX.UnderlinedStyle = false;
            // 
            // lastNameClientTBX
            // 
            this.lastNameClientTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameClientTBX.BackColor = System.Drawing.SystemColors.Window;
            this.lastNameClientTBX.BorderColor = System.Drawing.Color.Black;
            this.lastNameClientTBX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lastNameClientTBX.BorderRadius = 0;
            this.lastNameClientTBX.BorderSize = 2;
            this.lastNameClientTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameClientTBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastNameClientTBX.Location = new System.Drawing.Point(784, 128);
            this.lastNameClientTBX.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameClientTBX.Multiline = false;
            this.lastNameClientTBX.Name = "lastNameClientTBX";
            this.lastNameClientTBX.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lastNameClientTBX.PasswordChar = false;
            this.lastNameClientTBX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lastNameClientTBX.PlaceholderText = "";
            this.lastNameClientTBX.Size = new System.Drawing.Size(139, 39);
            this.lastNameClientTBX.TabIndex = 62;
            this.lastNameClientTBX.Texts = "";
            this.lastNameClientTBX.UnderlinedStyle = false;
            // 
            // addTypeOfProduct
            // 
            this.addTypeOfProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTypeOfProduct.AutoSize = true;
            this.addTypeOfProduct.Location = new System.Drawing.Point(929, 147);
            this.addTypeOfProduct.Name = "addTypeOfProduct";
            this.addTypeOfProduct.Size = new System.Drawing.Size(0, 20);
            this.addTypeOfProduct.TabIndex = 61;
            // 
            // addNameOfemployed
            // 
            this.addNameOfemployed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNameOfemployed.AutoSize = true;
            this.addNameOfemployed.Location = new System.Drawing.Point(1014, 72);
            this.addNameOfemployed.Name = "addNameOfemployed";
            this.addNameOfemployed.Size = new System.Drawing.Size(33, 20);
            this.addNameOfemployed.TabIndex = 60;
            this.addNameOfemployed.Text = "שם ";
            // 
            // clientNameTBX
            // 
            this.clientNameTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientNameTBX.BackColor = System.Drawing.SystemColors.Window;
            this.clientNameTBX.BorderColor = System.Drawing.Color.Black;
            this.clientNameTBX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.clientNameTBX.BorderRadius = 0;
            this.clientNameTBX.BorderSize = 2;
            this.clientNameTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameTBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientNameTBX.Location = new System.Drawing.Point(784, 62);
            this.clientNameTBX.Margin = new System.Windows.Forms.Padding(4);
            this.clientNameTBX.Multiline = false;
            this.clientNameTBX.Name = "clientNameTBX";
            this.clientNameTBX.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.clientNameTBX.PasswordChar = false;
            this.clientNameTBX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.clientNameTBX.PlaceholderText = "";
            this.clientNameTBX.Size = new System.Drawing.Size(138, 39);
            this.clientNameTBX.TabIndex = 59;
            this.clientNameTBX.Texts = "";
            this.clientNameTBX.UnderlinedStyle = false;
            // 
            // employedPhoneNumber
            // 
            this.employedPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employedPhoneNumber.AutoSize = true;
            this.employedPhoneNumber.Location = new System.Drawing.Point(968, 210);
            this.employedPhoneNumber.Name = "employedPhoneNumber";
            this.employedPhoneNumber.Size = new System.Drawing.Size(88, 20);
            this.employedPhoneNumber.TabIndex = 58;
            this.employedPhoneNumber.Text = "מספר טלפון";
            // 
            // addClientBtn
            // 
            this.addClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addClientBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addClientBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addClientBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addClientBtn.BorderRadius = 0;
            this.addClientBtn.BorderSize = 0;
            this.addClientBtn.FlatAppearance.BorderSize = 0;
            this.addClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientBtn.ForeColor = System.Drawing.Color.White;
            this.addClientBtn.Location = new System.Drawing.Point(699, 542);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(133, 40);
            this.addClientBtn.TabIndex = 75;
            this.addClientBtn.Text = "הוסף";
            this.addClientBtn.TextColor = System.Drawing.Color.White;
            this.addClientBtn.UseVisualStyleBackColor = false;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // clientdgv
            // 
            this.clientdgv.AllowUserToAddRows = false;
            this.clientdgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientdgv.AutoGenerateColumns = false;
            this.clientdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clientLastNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.clientInstitutionSymbolDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4});
            this.clientdgv.DataSource = this.clientsTBLBindingSource1;
            this.clientdgv.Location = new System.Drawing.Point(61, 72);
            this.clientdgv.Name = "clientdgv";
            this.clientdgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientdgv.RowHeadersWidth = 62;
            this.clientdgv.RowTemplate.Height = 28;
            this.clientdgv.Size = new System.Drawing.Size(595, 441);
            this.clientdgv.TabIndex = 76;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "צ\'ק",
            "applepay",
            "Bit",
            "מזומן"});
            this.comboBox1.Location = new System.Drawing.Point(778, 445);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "clientName";
            this.dataGridViewTextBoxColumn1.HeaderText = "שם";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // clientLastNameDataGridViewTextBoxColumn
            // 
            this.clientLastNameDataGridViewTextBoxColumn.DataPropertyName = "clientLastName";
            this.clientLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.clientLastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientLastNameDataGridViewTextBoxColumn.Name = "clientLastNameDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "clientPhone";
            this.dataGridViewTextBoxColumn2.HeaderText = "מספר טלפון";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // clientInstitutionSymbolDataGridViewTextBoxColumn
            // 
            this.clientInstitutionSymbolDataGridViewTextBoxColumn.DataPropertyName = "clientInstitutionSymbol";
            this.clientInstitutionSymbolDataGridViewTextBoxColumn.HeaderText = "סמל מוסד";
            this.clientInstitutionSymbolDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientInstitutionSymbolDataGridViewTextBoxColumn.Name = "clientInstitutionSymbolDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "paymentMethod";
            this.dataGridViewTextBoxColumn4.HeaderText = "שיטת תשלום";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // clientsTBLBindingSource1
            // 
            this.clientsTBLBindingSource1.DataSource = typeof(BambinoProj.ClientsTBL);
            // 
            // addClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1123, 661);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clientdgv);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.paymentMethodLabel);
            this.Controls.Add(this.nameOfTheBank);
            this.Controls.Add(this.institutionSymbolTBX);
            this.Controls.Add(this.clientPhoneNumberTBX);
            this.Controls.Add(this.addLastNameOfemployed);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.clientEmailTBX);
            this.Controls.Add(this.lastNameClientTBX);
            this.Controls.Add(this.addTypeOfProduct);
            this.Controls.Add(this.addNameOfemployed);
            this.Controls.Add(this.clientNameTBX);
            this.Controls.Add(this.employedPhoneNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addClient";
            this.Text = "addClient";
            this.Load += new System.EventHandler(this.addClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTBLBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.Label nameOfTheBank;
        private RJCodeAdvance.RJControls.RJTextBox institutionSymbolTBX;
        private RJCodeAdvance.RJControls.RJTextBox clientPhoneNumberTBX;
        private System.Windows.Forms.Label addLastNameOfemployed;
        private System.Windows.Forms.Label EmailAddress;
        private RJCodeAdvance.RJControls.RJTextBox clientEmailTBX;
        private RJCodeAdvance.RJControls.RJTextBox lastNameClientTBX;
        private System.Windows.Forms.Label addTypeOfProduct;
        private System.Windows.Forms.Label addNameOfemployed;
        private RJCodeAdvance.RJControls.RJTextBox clientNameTBX;
        private System.Windows.Forms.Label employedPhoneNumber;
        private RJCodeAdvance.RJControls.RJButton addClientBtn;
        private System.Windows.Forms.DataGridView clientdgv;
        private System.Windows.Forms.BindingSource clientsTBLBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLnstitutionSymbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientInstitutionSymbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource clientsTBLBindingSource1;
    }
}