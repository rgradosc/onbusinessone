namespace OnBusinessOne.SDK.WindowsApp.Forms
{
    partial class ItemsForm
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
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionLabel = new System.Windows.Forms.Label();
            this.listItemsButton = new System.Windows.Forms.Button();
            this.itemsData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemsData)).BeginInit();
            this.SuspendLayout();
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescriptionTextBox.Location = new System.Drawing.Point(154, 12);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(503, 22);
            this.productDescriptionTextBox.TabIndex = 7;
            // 
            // productDescriptionLabel
            // 
            this.productDescriptionLabel.AutoSize = true;
            this.productDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescriptionLabel.Location = new System.Drawing.Point(21, 15);
            this.productDescriptionLabel.Name = "productDescriptionLabel";
            this.productDescriptionLabel.Size = new System.Drawing.Size(127, 16);
            this.productDescriptionLabel.TabIndex = 6;
            this.productDescriptionLabel.Text = "Product Description:";
            // 
            // listItemsButton
            // 
            this.listItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItemsButton.Location = new System.Drawing.Point(663, 11);
            this.listItemsButton.Name = "listItemsButton";
            this.listItemsButton.Size = new System.Drawing.Size(108, 24);
            this.listItemsButton.TabIndex = 8;
            this.listItemsButton.Text = "Filter";
            this.listItemsButton.UseVisualStyleBackColor = true;
            this.listItemsButton.Click += new System.EventHandler(this.ListItemsButton_Click);
            // 
            // itemsData
            // 
            this.itemsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.itemsData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemsData.Location = new System.Drawing.Point(24, 53);
            this.itemsData.Name = "itemsData";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.itemsData.Size = new System.Drawing.Size(747, 345);
            this.itemsData.TabIndex = 9;
            this.itemsData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemsData_RowHeaderMouseDoubleClick);
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.itemsData);
            this.Controls.Add(this.listItemsButton);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(this.productDescriptionLabel);
            this.Name = "ItemsForm";
            this.Text = "Business Partners";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemsForm_FormClosing);
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.Label productDescriptionLabel;
        private System.Windows.Forms.Button listItemsButton;
        private System.Windows.Forms.DataGridView itemsData;
    }
}