namespace OnBusinessOne.SDK.WindowsApp.Forms
{
    partial class ConnectionServerForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.companiesComboBox = new System.Windows.Forms.ComboBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.conectButton = new System.Windows.Forms.Button();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.companiesGroupBox = new System.Windows.Forms.GroupBox();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.companiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // companiesComboBox
            // 
            this.companiesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companiesComboBox.FormattingEnabled = true;
            this.companiesComboBox.Location = new System.Drawing.Point(146, 40);
            this.companiesComboBox.Name = "companiesComboBox";
            this.companiesComboBox.Size = new System.Drawing.Size(217, 24);
            this.companiesComboBox.TabIndex = 1;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(47, 48);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(79, 16);
            this.companyLabel.TabIndex = 0;
            this.companyLabel.Text = "Companies:";
            // 
            // conectButton
            // 
            this.conectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectButton.Location = new System.Drawing.Point(146, 180);
            this.conectButton.Name = "conectButton";
            this.conectButton.Size = new System.Drawing.Size(103, 24);
            this.conectButton.TabIndex = 6;
            this.conectButton.Text = "Conect";
            this.conectButton.UseVisualStyleBackColor = true;
            this.conectButton.Click += new System.EventHandler(this.ConectButton_Click);
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(26, 94);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(103, 16);
            this.usuarioLabel.TabIndex = 2;
            this.usuarioLabel.Text = "SAP Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(26, 141);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 16);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "SAP Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(146, 88);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(217, 22);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Text = "manager";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(146, 135);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(217, 22);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Text = "manager";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(260, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 24);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // companiesGroupBox
            // 
            this.companiesGroupBox.Controls.Add(this.errorsLabel);
            this.companiesGroupBox.Controls.Add(this.companiesComboBox);
            this.companiesGroupBox.Controls.Add(this.cancelButton);
            this.companiesGroupBox.Controls.Add(this.companyLabel);
            this.companiesGroupBox.Controls.Add(this.passwordTextBox);
            this.companiesGroupBox.Controls.Add(this.conectButton);
            this.companiesGroupBox.Controls.Add(this.usernameTextBox);
            this.companiesGroupBox.Controls.Add(this.usuarioLabel);
            this.companiesGroupBox.Controls.Add(this.passwordLabel);
            this.companiesGroupBox.Location = new System.Drawing.Point(25, 20);
            this.companiesGroupBox.Name = "companiesGroupBox";
            this.companiesGroupBox.Size = new System.Drawing.Size(417, 248);
            this.companiesGroupBox.TabIndex = 0;
            this.companiesGroupBox.TabStop = false;
            this.companiesGroupBox.Text = "Data connection to server";
            // 
            // errorsLabel
            // 
            this.errorsLabel.BackColor = System.Drawing.Color.Red;
            this.errorsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.errorsLabel.Location = new System.Drawing.Point(6, 217);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(405, 23);
            this.errorsLabel.TabIndex = 8;
            this.errorsLabel.Text = "errorLabel";
            this.errorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorsLabel.Visible = false;
            // 
            // ConnectionServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 280);
            this.Controls.Add(this.companiesGroupBox);
            this.MaximizeBox = false;
            this.Name = "ConnectionServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Server";
            this.Load += new System.EventHandler(this.ConnectionServerForm_Load);
            this.companiesGroupBox.ResumeLayout(false);
            this.companiesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox companiesComboBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Button conectButton;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox companiesGroupBox;
        private System.Windows.Forms.Label errorsLabel;
    }
}

