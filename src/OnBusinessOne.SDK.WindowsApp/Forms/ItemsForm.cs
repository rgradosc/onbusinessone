using OnBusinessOne.DataAccess;
using System.Windows.Forms;
using SAPbobsCOM;

namespace OnBusinessOne.SDK.WindowsApp.Forms
{
    public partial class ItemsForm : Form
    {
        private Recordset itemsRecordset;
        private readonly SBOConnection sboConnection;

        public ItemsForm()
        {
            InitializeComponent();
            this.sboConnection = SBOConnection.GetInstance();
        }

        private void LoadItemsData(string filterKey)
        {
            itemsData.Rows.Clear();
            itemsData.Columns.Clear();

            itemsRecordset = sboConnection.GetSBOCompany().GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = $"SELECT T0.ItemCode, T0.ItemName, T1.Price FROM OITM T0 INNER JOIN ITM1 T1 ON T0.ItemCode = T1.ItemCode " +
                           $"WHERE PriceList = 1 ORDER BY T0.ItemCode, T0.ItemName";
            if (!string.IsNullOrEmpty(filterKey))
            {
                query = $"SELECT T0.ItemCode, T0.ItemName, T1.Price FROM OITM T0 INNER JOIN ITM1 T1 ON T0.ItemCode = T1.ItemCode " +
                        $"WHERE PriceList = 1 AND (T0.ItemName LIKE '%{filterKey}%' OR T0.ItemCode LIKE '%{filterKey}%') ORDER BY T0.ItemCode, T0.ItemName";
            }
            itemsRecordset.DoQuery(query);

            itemsData.Columns.Add("ItemCode", "Item Code");
            itemsData.Columns.Add("ItemName", "Item Name");
            itemsData.Columns.Add("Price", "Price");
            itemsData.Columns["ItemCode"].Width = 150;
            itemsData.Columns["ItemName"].Width = 350;
            itemsData.Columns["Price"].Width = 100;

            int record = 0;
            while (!itemsRecordset.EoF)
            {
                itemsData.Rows.Add();
                itemsData.Rows[record].Cells["ItemCode"].Value = itemsRecordset.Fields.Item("ItemCode").Value.ToString();
                itemsData.Rows[record].Cells["ItemName"].Value = itemsRecordset.Fields.Item("ItemName").Value.ToString();
                itemsData.Rows[record].Cells["Price"].Value = itemsRecordset.Fields.Item("Price").Value.ToString();
                record++;
                itemsRecordset.MoveNext();
            }
            itemsRecordset = null;
        }

        private void ItemsForm_Load(object sender, System.EventArgs e)
        {
            if (itemsRecordset == null)
            {
                LoadItemsData(string.Empty);
            }
        }

        private void ListItemsButton_Click(object sender, System.EventArgs e)
        {
            if (itemsRecordset == null)
            {
                LoadItemsData(productDescriptionTextBox.Text);
            }
        }

        private void ItemsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ItemsData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = GlobalSettings.PointOfSaleForm.listOfItemsData.RowCount - 1;
            GlobalSettings.PointOfSaleForm.listOfItemsData.Rows[row].Cells["ItemCode"].Value = itemsData.CurrentRow.Cells["ItemCode"].Value.ToString();
            GlobalSettings.PointOfSaleForm.listOfItemsData.Rows[row].Cells["ItemName"].Value = itemsData.CurrentRow.Cells["ItemName"].Value.ToString();
            GlobalSettings.PointOfSaleForm.listOfItemsData.Rows[row].Cells["ItemPrice"].Value = itemsData.CurrentRow.Cells["Price"].Value.ToString();
            GlobalSettings.PointOfSaleForm.listOfItemsData.Rows[row].Cells["ItemWarehouse"].Value = "01";
            GlobalSettings.PointOfSaleForm.Show();
        }
    }
}
