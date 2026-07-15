using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using equipment.Classes;

namespace equipment.Forms.ManagerForms.InvoiceForms
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        public static string idInvoice;
        public static string dateInvoice;
        public static string idVendor;

        private void UpdateData()
        {
            Invoice.GetListInvoice();
            dataGridViewInvoice.DataSource = Invoice.dtInvoice;
            if (dataGridViewInvoice.SelectedRows.Count != 0)
            {
                EquipmentOnInvoice.GetListEquipmentOnInvoice(dataGridViewInvoice.CurrentRow.Cells["Column1"].Value.ToString());
                dataGridViewInvoiceInfo.DataSource = EquipmentOnInvoice.dtInvoiceInfo;
                labelFindStatus.Visible = false;
            }
        }


        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInvoiceForm addInvoiceForm = new AddInvoiceForm();
            addInvoiceForm.ShowDialog();
            UpdateData();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoice.SelectedRows.Count != 0)
            {
                idInvoice = dataGridViewInvoice.CurrentRow.Cells["Column1"].Value.ToString();
                dateInvoice = dataGridViewInvoice.CurrentRow.Cells["Column2"].Value.ToString();
                idVendor = dataGridViewInvoice.CurrentRow.Cells["Column4"].Value.ToString();
                UpdateInvoiceForm updateInvoiceForm = new UpdateInvoiceForm();
                updateInvoiceForm.ShowDialog();
                UpdateData();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoice.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("При удалении накладной, количество оборудования в наличии будет уменьшаться соразмерно составу накладной!\r\n" +
                    "Если в наличии оборудования будет меньше, чем в составе накладной, то количество оборудования в наличии не будет уменьшено!\r\n" +
                    "\r\nУдалить накладную?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idInvoice = dataGridViewInvoice.CurrentRow.Cells["column1"].Value.ToString();
                    if (EquipmentOnInvoice.DeleteForInvoice(idInvoice) && Invoice.Delete(idInvoice))
                        MessageBox.Show("Накладная удалена");
                    else
                        MessageBox.Show("Ошибка! Не получилось удалить накладную");
                    UpdateData();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EquipmentOnInvoice.GetListEquipmentOnInvoice(dataGridViewInvoice.CurrentRow.Cells["Column1"].Value.ToString());
            dataGridViewInvoiceInfo.DataSource = EquipmentOnInvoice.dtInvoiceInfo;
        }
    }
}
