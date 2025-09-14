using OnBusinessOne.Domain.Entities;
using OnBusinessOne.DataAccess;
using System;
using System.Windows.Forms;
using SAPbobsCOM;

namespace OnBusinessOne.SDK.WindowsApp.Forms
{
    public partial class ConnectionServerForm : Form
    {
        private readonly SBOConnection SBOConnection;

        public ConnectionServerForm()
        {
            InitializeComponent();
            this.errorsLabel.Text = string.Empty;
            this.SBOConnection = SBOConnection.GetInstance();
        }

        private void ConnectionServerForm_Load(object sender, EventArgs e)
        {
            Recordset companiesRecordset = SBOConnection.GetCompaniesRecordset();
            while (!companiesRecordset.EoF)
            {
                companiesComboBox.Items.Add(companiesRecordset.Fields.Item(0).Value);
                companiesRecordset.MoveNext();
            }
            companiesComboBox.SelectedIndex = 0;
        }

        private void ConectButton_Click(object sender, EventArgs e)
        {
            if (!IsValidForm())
            {
                errorsLabel.Text = "* Connection failed. Make sure you enter the correct credentials.";
                errorsLabel.Visible = true;
                usernameTextBox.Focus();
                return;
            }

            conectButton.Text = "Connecting...";
            conectButton.Enabled = false;
            cancelButton.Enabled = false;

            var isConnect = SBOConnection.ConnectToSAP(new UserAuth
            {
                CompanyDB = companiesComboBox.Text,
                UserName = usernameTextBox.Text,
                Password = passwordTextBox.Text,
            });

            if (isConnect != 0)
            {
                errorsLabel.Text = $"* Connection failed. {SBOConnection.GetSBOCompany().GetLastErrorDescription()}";
                errorsLabel.Visible = true;
                usernameTextBox.Focus();
                conectButton.Text = "Connect";
                conectButton.Enabled = true;
                cancelButton.Enabled = true;
                return;
            }

            conectButton.Text = "Connect";
            conectButton.Enabled = true;
            cancelButton.Enabled = true;
            errorsLabel.Text = string.Empty;
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            this.Hide();
            GlobalSettings.PointOfSaleForm.ShowDialog();
            this.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool IsValidForm()
        {
            return companiesComboBox.SelectedIndex != -1 
                && usernameTextBox.Text != string.Empty
                && passwordTextBox.Text != string.Empty;
        }

    }
}
