namespace OnBusinessOne.SDK.WindowsApp.Forms
{
    partial class PointOfSaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerCodeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPartnersButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.listOfItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.filterItemsButton = new System.Windows.Forms.Button();
            this.listOfItemsData = new System.Windows.Forms.DataGridView();
            this.subtotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.totalTaxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.setDocsAllowsComboBox = new System.Windows.Forms.ComboBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.errorsMessageLabel = new System.Windows.Forms.Label();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.listOfItemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfItemsData)).BeginInit();
            this.SuspendLayout();
            // 
            // customerCodeTextBox
            // 
            this.customerCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCodeTextBox.Location = new System.Drawing.Point(134, 26);
            this.customerCodeTextBox.Name = "customerCodeTextBox";
            this.customerCodeTextBox.Size = new System.Drawing.Size(213, 22);
            this.customerCodeTextBox.TabIndex = 7;
            // 
            // customerCodeLabel
            // 
            this.customerCodeLabel.AutoSize = true;
            this.customerCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCodeLabel.Location = new System.Drawing.Point(25, 29);
            this.customerCodeLabel.Name = "customerCodeLabel";
            this.customerCodeLabel.Size = new System.Drawing.Size(103, 16);
            this.customerCodeLabel.TabIndex = 6;
            this.customerCodeLabel.Text = "Customer Code:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.filterPartnersButton);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.customerNameLabel);
            this.groupBox1.Controls.Add(this.customerAddressTextBox);
            this.groupBox1.Controls.Add(this.customerAddressLabel);
            this.groupBox1.Controls.Add(this.customerCodeTextBox);
            this.groupBox1.Controls.Add(this.customerCodeLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Business Partner Data";
            // 
            // filterPartnersButton
            // 
            this.filterPartnersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPartnersButton.Location = new System.Drawing.Point(366, 25);
            this.filterPartnersButton.Name = "filterPartnersButton";
            this.filterPartnersButton.Size = new System.Drawing.Size(68, 24);
            this.filterPartnersButton.TabIndex = 12;
            this.filterPartnersButton.Text = "...";
            this.filterPartnersButton.UseVisualStyleBackColor = true;
            this.filterPartnersButton.Click += new System.EventHandler(this.FilterPartnersButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(134, 65);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(300, 22);
            this.customerNameTextBox.TabIndex = 9;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(21, 68);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(107, 16);
            this.customerNameLabel.TabIndex = 8;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressTextBox.Location = new System.Drawing.Point(576, 65);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(300, 22);
            this.customerAddressTextBox.TabIndex = 11;
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressLabel.Location = new System.Drawing.Point(449, 68);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(121, 16);
            this.customerAddressLabel.TabIndex = 10;
            this.customerAddressLabel.Text = "Customer Address:";
            // 
            // listOfItemsGroupBox
            // 
            this.listOfItemsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfItemsGroupBox.Controls.Add(this.filterItemsButton);
            this.listOfItemsGroupBox.Controls.Add(this.listOfItemsData);
            this.listOfItemsGroupBox.Location = new System.Drawing.Point(12, 129);
            this.listOfItemsGroupBox.Name = "listOfItemsGroupBox";
            this.listOfItemsGroupBox.Size = new System.Drawing.Size(899, 341);
            this.listOfItemsGroupBox.TabIndex = 9;
            this.listOfItemsGroupBox.TabStop = false;
            this.listOfItemsGroupBox.Text = "List of Items";
            // 
            // filterItemsButton
            // 
            this.filterItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterItemsButton.Location = new System.Drawing.Point(24, 23);
            this.filterItemsButton.Name = "filterItemsButton";
            this.filterItemsButton.Size = new System.Drawing.Size(103, 30);
            this.filterItemsButton.TabIndex = 3;
            this.filterItemsButton.Text = "Add Item(s)";
            this.filterItemsButton.UseVisualStyleBackColor = true;
            this.filterItemsButton.Click += new System.EventHandler(this.FilterItemsButton_Click);
            // 
            // listOfItemsData
            // 
            this.listOfItemsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfItemsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listOfItemsData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.listOfItemsData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listOfItemsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listOfItemsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.ItemQuantity,
            this.ItemPrice,
            this.ItemWarehouse});
            this.listOfItemsData.Location = new System.Drawing.Point(24, 60);
            this.listOfItemsData.Name = "listOfItemsData";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listOfItemsData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listOfItemsData.Size = new System.Drawing.Size(852, 265);
            this.listOfItemsData.TabIndex = 0;
            this.listOfItemsData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfItemsData_CellEndEdit);
            // 
            // subtotalAmountTextBox
            // 
            this.subtotalAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subtotalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalAmountTextBox.Location = new System.Drawing.Point(453, 496);
            this.subtotalAmountTextBox.Name = "subtotalAmountTextBox";
            this.subtotalAmountTextBox.ReadOnly = true;
            this.subtotalAmountTextBox.Size = new System.Drawing.Size(135, 22);
            this.subtotalAmountTextBox.TabIndex = 14;
            this.subtotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(453, 477);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(64, 16);
            this.subtotalLabel.TabIndex = 13;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // totalTaxTextBox
            // 
            this.totalTaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTaxTextBox.Location = new System.Drawing.Point(603, 496);
            this.totalTaxTextBox.Name = "totalTaxTextBox";
            this.totalTaxTextBox.ReadOnly = true;
            this.totalTaxTextBox.Size = new System.Drawing.Size(135, 22);
            this.totalTaxTextBox.TabIndex = 16;
            this.totalTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tax (12%)";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTextBox.Location = new System.Drawing.Point(753, 496);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.ReadOnly = true;
            this.totalAmountTextBox.Size = new System.Drawing.Size(135, 22);
            this.totalAmountTextBox.TabIndex = 18;
            this.totalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(308, 492);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 26);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // setDocsAllowsComboBox
            // 
            this.setDocsAllowsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setDocsAllowsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setDocsAllowsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDocsAllowsComboBox.FormattingEnabled = true;
            this.setDocsAllowsComboBox.Items.AddRange(new object[] {
            "Create Sales Offer",
            "Create Sales Order",
            "Create Invoice"});
            this.setDocsAllowsComboBox.Location = new System.Drawing.Point(36, 492);
            this.setDocsAllowsComboBox.Name = "setDocsAllowsComboBox";
            this.setDocsAllowsComboBox.Size = new System.Drawing.Size(146, 24);
            this.setDocsAllowsComboBox.TabIndex = 4;
            // 
            // continueButton
            // 
            this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(189, 492);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(113, 26);
            this.continueButton.TabIndex = 20;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // errorsMessageLabel
            // 
            this.errorsMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsMessageLabel.BackColor = System.Drawing.Color.Red;
            this.errorsMessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorsMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsMessageLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.errorsMessageLabel.Location = new System.Drawing.Point(12, 519);
            this.errorsMessageLabel.Name = "errorsMessageLabel";
            this.errorsMessageLabel.Size = new System.Drawing.Size(901, 23);
            this.errorsMessageLabel.TabIndex = 13;
            this.errorsMessageLabel.Text = "errors";
            this.errorsMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorsMessageLabel.Visible = false;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "Quantity";
            this.ItemQuantity.Name = "ItemQuantity";
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Price";
            this.ItemPrice.Name = "ItemPrice";
            // 
            // ItemWarehouse
            // 
            this.ItemWarehouse.HeaderText = "Warehouse";
            this.ItemWarehouse.Name = "ItemWarehouse";
            this.ItemWarehouse.ReadOnly = true;
            // 
            // PointOfSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 546);
            this.Controls.Add(this.errorsMessageLabel);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.setDocsAllowsComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalTaxTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtotalAmountTextBox);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.listOfItemsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "PointOfSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PointOfSaleForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.listOfItemsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfItemsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label customerCodeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.Button filterPartnersButton;
        private System.Windows.Forms.GroupBox listOfItemsGroupBox;
        private System.Windows.Forms.Button filterItemsButton;
        private System.Windows.Forms.TextBox subtotalAmountTextBox;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.TextBox totalTaxTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox setDocsAllowsComboBox;
        private System.Windows.Forms.Button continueButton;
        public System.Windows.Forms.DataGridView listOfItemsData;
        public System.Windows.Forms.TextBox customerCodeTextBox;
        public System.Windows.Forms.TextBox customerNameTextBox;
        public System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.Label errorsMessageLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemWarehouse;
    }
}