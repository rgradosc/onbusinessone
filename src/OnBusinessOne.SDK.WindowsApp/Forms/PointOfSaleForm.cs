using OnBusinessOne.DataAccess;
using System;
using System.Windows.Forms;
using SAPbobsCOM;

namespace OnBusinessOne.SDK.WindowsApp.Forms
{
    public partial class PointOfSaleForm : Form
    {
        private readonly SBOConnection sboConnection;

        public PointOfSaleForm()
        {
            InitializeComponent();
            this.sboConnection = SBOConnection.GetInstance();
            this.setDocsAllowsComboBox.SelectedIndex = 0;
        }

        private void CalculateTotals()
        {
            double totalColumn = 0;
            foreach (DataGridViewRow row in listOfItemsData.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["ItemQuantity"].Value as string))
                {
                    double totalRow = double.Parse(row.Cells["ItemQuantity"].Value.ToString()) * double.Parse(row.Cells["ItemPrice"].Value.ToString());
                    totalColumn += totalRow;
                }
            }
            subtotalAmountTextBox.Text = totalColumn.ToString();
            totalTaxTextBox.Text = (totalColumn * 0.12).ToString();
            totalAmountTextBox.Text = (double.Parse(subtotalAmountTextBox.Text) + double.Parse(totalTaxTextBox.Text)).ToString();
        }


        private void FilterPartnersButton_Click(object sender, EventArgs e)
        {
            GlobalSettings.BusinessPartnersForm.Show();
        }

        private void FilterItemsButton_Click(object sender, EventArgs e)
        {
            GlobalSettings.ItemsForm.Show();
        }

        private void ListOfItemsData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Recordset itemsRecordset;
                itemsRecordset = sboConnection.GetSBOCompany().GetBusinessObject(BoObjectTypes.BoRecordset);
                string itemCode = listOfItemsData.CurrentRow.Cells["ItemCode"].Value.ToString();
                string query = $"SELECT T0.ItemName, T1.Price FROM OITM T0 INNER JOIN ITM1 T1 ON T0.ItemCode = T1.ItemCode " +
                               $"WHERE PriceList = 1 AND T0.ItemCode = '{itemCode}' ORDER BY T0.ItemName";
                itemsRecordset.DoQuery(query);
                listOfItemsData.CurrentRow.Cells["ItemName"].Value = itemsRecordset.Fields.Item("ItemName").Value.ToString();
                listOfItemsData.CurrentRow.Cells["ItemPrice"].Value = itemsRecordset.Fields.Item("Price").Value.ToString();

            }

            if (e.ColumnIndex == 2)
            {
                if (!string.IsNullOrEmpty(listOfItemsData.CurrentRow.Cells["ItemQuantity"].Value as string))
                {
                    CalculateTotals();
                }
            }
        }

        private void PointOfSaleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerCodeTextBox.Text) && (listOfItemsData.Rows.Count == 0 || listOfItemsData.Rows[0].Cells["ItemCode"].Value == null))
            {
                errorsMessageLabel.Text = "*Make sure to complete the customer data and items to continue.";
                errorsMessageLabel.Visible = true;
                return;
            }

            if (setDocsAllowsComboBox.SelectedIndex == 0)
            {
                var dialogResult = MessageBox.Show("Are you sure to create the sales offer? This action cannot be undone.", 
                    "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    CreateSalesOffer();
                }
            } 
            else if (setDocsAllowsComboBox.SelectedIndex == 1)
            {
                var dialogResult = MessageBox.Show("Are you sure to create the sales order? This action cannot be undone.",
                    "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    CreateSalesOrder();
                }
            } 
            else if(setDocsAllowsComboBox.SelectedIndex == 2)
            {
                var dialogResult = MessageBox.Show("Are you sure to create the invoice? This action cannot be undone.",
                    "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    CreateInvoice();
                }
            }
        }

        private void CreateSalesOrder()
        {
            sboConnection.GetSBOCompany().StartTransaction();
            Documents documents = sboConnection.GetSBOCompany().GetBusinessObject(BoObjectTypes.oOrders);
            documents.CardCode = customerCodeTextBox.Text;
            documents.DocDate = DateTime.Now;
            documents.DocDueDate = DateTime.Now;
            documents.NumAtCard = "Sales Order create to SDK";
            documents.DocType = BoDocumentTypes.dDocument_Items;
            int index = 0;
            foreach (DataGridViewRow row in listOfItemsData.Rows)
            {
                if (!string.IsNullOrWhiteSpace(row.Cells["ItemCode"].Value as string))
                {
                    if(index != 0)
                        documents.Lines.Add();
                    documents.Lines.ItemCode = row.Cells["ItemCode"].Value.ToString();
                    documents.Lines.Quantity = double.Parse(row.Cells["ItemQuantity"].Value.ToString());
                    documents.Lines.WarehouseCode = row.Cells["ItemWarehouse"].Value.ToString();
                    documents.Lines.TaxCode = "IVA";
                    documents.Lines.LineTotal = double.Parse(row.Cells["ItemQuantity"].Value.ToString()) * double.Parse(row.Cells["ItemPrice"].Value.ToString());
                    documents.Lines.TaxTotal = documents.Lines.LineTotal * 0.12;
                    index++;
                }
            }

            if (documents.Add() != 0)
            {
                MessageBox.Show(
                    $"{sboConnection.GetSBOCompany().GetLastErrorDescription()}.", 
                    "Transaction error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sboConnection.GetSBOCompany().EndTransaction(BoWfTransOpt.wf_RollBack);    
            } 
            else
            {
                MessageBox.Show($"Sales Order created successfuly.", "Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                sboConnection.GetSBOCompany().EndTransaction(BoWfTransOpt.wf_Commit);
            }
        }

        private void CreateSalesOffer()
        {
            sboConnection.GetSBOCompany().StartTransaction();
            Documents documents = sboConnection.GetSBOCompany().GetBusinessObject(BoObjectTypes.oQuotations);
            documents.CardCode = customerCodeTextBox.Text;
            documents.DocDate = DateTime.Now;
            documents.DocDueDate = DateTime.Now;
            documents.NumAtCard = "Sales Offer create to SDK";
            documents.DocType = BoDocumentTypes.dDocument_Items;
            int index = 0;
            foreach (DataGridViewRow row in listOfItemsData.Rows)
            {
                if (!string.IsNullOrWhiteSpace(row.Cells["ItemCode"].Value as string))
                {
                    if(index != 0)
                        documents.Lines.Add();
                    documents.Lines.ItemCode = row.Cells["ItemCode"].Value.ToString();
                    documents.Lines.Quantity = double.Parse(row.Cells["ItemQuantity"].Value.ToString());
                    documents.Lines.WarehouseCode = row.Cells["ItemWarehouse"].Value.ToString();
                    documents.Lines.TaxCode = "IVA";
                    documents.Lines.LineTotal = double.Parse(row.Cells["ItemQuantity"].Value.ToString()) * double.Parse(row.Cells["ItemPrice"].Value.ToString());
                    documents.Lines.TaxTotal = documents.Lines.LineTotal * 0.12;
                    index++;
                }
            }

            if (documents.Add() != 0)
            {
                MessageBox.Show(
                    $"{sboConnection.GetSBOCompany().GetLastErrorDescription()}.",
                    "Transaction error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sboConnection.GetSBOCompany().EndTransaction(BoWfTransOpt.wf_RollBack);
            }
            else
            {
                MessageBox.Show($"Sales Offer created successfuly.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                sboConnection.GetSBOCompany().EndTransaction(BoWfTransOpt.wf_Commit);
            }
        }

        private void CreateInvoice()
        {
            sboConnection.GetSBOCompany().StartTransaction();
            Documents documents = sboConnection.GetSBOCompany().GetBusinessObject(BoObjectTypes.oInvoices);
            documents.CardCode = customerCodeTextBox.Text;
            documents.DocDate = DateTime.Now;
            documents.DocDueDate = DateTime.Now;
            documents.NumAtCard = "Invoice create to SDK";
            documents.DocType = BoDocumentTypes.dDocument_Items;
            int index = 0;
            foreach (DataGridViewRow row in listOfItemsData.Rows)
            {
                if (!string.IsNullOrWhiteSpace(row.Cells["ItemCode"].Value as string))
                {
                    if(index != 0)
                        documents.Lines.Add();
                    documents.Lines.ItemCode = row.Cells["ItemCode"].Value.ToString();
                    documents.Lines.Quantity = double.Parse(row.Cells["ItemQuantity"].Value.ToString());
                    documents.Lines.WarehouseCode = row.Cells["ItemWarehouse"].Value.ToString();
                    documents.Lines.TaxCode = "IVA";
                    documents.Lines.LineTotal = double.Parse(row.Cells["ItemQuantity"].Value.ToString()) * double.Parse(row.Cells["ItemPrice"].Value.ToString());
                    documents.Lines.TaxTotal = documents.Lines.LineTotal * 0.12;
                    index++;
                }
            }

            if (documents.Add() != 0)
            {
                MessageBox.Show(
                    $"{sboConnection.GetSBOCompany().GetLastErrorDescription()}.",
                    "Transaction error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sboConnection.GetSBOCompany().EndTransaction(BoWfTransOpt.wf_RollBack);
            }
            else
            {
                MessageBox.Show($"Invoice created successfuly.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                sboConnection.GetSBOCompany().EndTransaction(BoWfTransOpt.wf_Commit);
            }
        }

    }
}
