namespace OnBusinessOne.SDK.WindowsApp.Forms
{
    partial class BusinessPartnersForm
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.filterCustomerButton = new System.Windows.Forms.Button();
            this.bussinesPartnersData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bussinesPartnersData)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(141, 12);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(516, 22);
            this.customerNameTextBox.TabIndex = 7;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(21, 18);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(107, 16);
            this.customerNameLabel.TabIndex = 6;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // filterCustomerButton
            // 
            this.filterCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCustomerButton.Location = new System.Drawing.Point(663, 11);
            this.filterCustomerButton.Name = "filterCustomerButton";
            this.filterCustomerButton.Size = new System.Drawing.Size(108, 24);
            this.filterCustomerButton.TabIndex = 8;
            this.filterCustomerButton.Text = "Filter";
            this.filterCustomerButton.UseVisualStyleBackColor = true;
            this.filterCustomerButton.Click += new System.EventHandler(this.FilterCustomerButton_Click);
            // 
            // bussinesPartnersData
            // 
            this.bussinesPartnersData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bussinesPartnersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bussinesPartnersData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.bussinesPartnersData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bussinesPartnersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bussinesPartnersData.Location = new System.Drawing.Point(24, 53);
            this.bussinesPartnersData.Name = "bussinesPartnersData";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bussinesPartnersData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bussinesPartnersData.Size = new System.Drawing.Size(747, 345);
            this.bussinesPartnersData.TabIndex = 9;
            this.bussinesPartnersData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BussinesPartnersData_RowHeaderMouseDoubleClick);
            // 
            // BusinessPartnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.bussinesPartnersData);
            this.Controls.Add(this.filterCustomerButton);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "BusinessPartnersForm";
            this.Text = "Business Partners";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BusinessPartnersForm_FormClosing);
            this.Load += new System.EventHandler(this.BusinessPartnersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bussinesPartnersData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Button filterCustomerButton;
        private System.Windows.Forms.DataGridView bussinesPartnersData;
    }
}