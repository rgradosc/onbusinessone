using OnBusinessOne.DataAccess;
using System.Windows.Forms;
using System;
using SAPbobsCOM;

namespace OnBusinessOne.SDK.WindowsApp.Forms
{
    public partial class BusinessPartnersForm : Form
    {
        private Recordset bussinesPartnersRecordset;
        private readonly SBOConnection sboConnection;

        public BusinessPartnersForm()
        {
            InitializeComponent();
            sboConnection = SBOConnection.GetInstance();
        }

        private void LoadBussinesPartnersData(string filterKey)
        {
            bussinesPartnersData.Rows.Clear();
            bussinesPartnersData.Columns.Clear();

            bussinesPartnersRecordset = sboConnection.GetSBOCompany().GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = $"SELECT CardCode, CardName, Address FROM OCRD ORDER BY CardCode, CardName, Address";
            if (!string.IsNullOrEmpty(filterKey))
            {
                query = $"SELECT CardCode, CardName, Address FROM OCRD WHERE CardName LIKE '%{filterKey}%' ORDER BY CardCode, CardName, Address";
            }
            bussinesPartnersRecordset.DoQuery(query);
            bussinesPartnersData.Columns.Add("CardCode", "Card Code");
            bussinesPartnersData.Columns.Add("CardName", "Card Name");
            bussinesPartnersData.Columns.Add("Address", "Address");
            bussinesPartnersData.Columns["CardCode"].Width = 150;
            bussinesPartnersData.Columns["CardName"].Width = 250;
            bussinesPartnersData.Columns["Address"].Width = 350;

            int record = 0;
            while (!bussinesPartnersRecordset.EoF)
            {
                bussinesPartnersData.Rows.Add();
                bussinesPartnersData.Rows[record].Cells["CardCode"].Value = bussinesPartnersRecordset.Fields.Item("CardCode").Value.ToString();
                bussinesPartnersData.Rows[record].Cells["CardName"].Value = bussinesPartnersRecordset.Fields.Item("CardName").Value.ToString();
                bussinesPartnersData.Rows[record].Cells["Address"].Value = bussinesPartnersRecordset.Fields.Item("Address").Value.ToString();
                record++;
                bussinesPartnersRecordset.MoveNext();
            }
            bussinesPartnersRecordset = null;
        }

        private void BusinessPartnersForm_Load(object sender, EventArgs e)
        {
            if (bussinesPartnersRecordset == null)
            {
                LoadBussinesPartnersData(string.Empty);
            }
        }

        private void FilterCustomerButton_Click(object sender, EventArgs e)
        {
            if (bussinesPartnersRecordset == null)
            {
                LoadBussinesPartnersData(customerNameTextBox.Text);
            }
        }

        private void BusinessPartnersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void BussinesPartnersData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GlobalSettings.PointOfSaleForm.customerCodeTextBox.Text = bussinesPartnersData.CurrentRow.Cells["CardCode"].Value.ToString();
            GlobalSettings.PointOfSaleForm.customerNameTextBox.Text = bussinesPartnersData.CurrentRow.Cells["CardName"].Value.ToString();
            GlobalSettings.PointOfSaleForm.customerAddressTextBox.Text = bussinesPartnersData.CurrentRow.Cells["Address"].Value.ToString();
            GlobalSettings.PointOfSaleForm.Show();
        }

    }
}
