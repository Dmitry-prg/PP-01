using equipment.Classes;
using equipment.Forms.ManagerForms.EquipmentOnInvoiceForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipment.Forms.ManagerForms.InvoiceForms
{
    public partial class UpdateInvoiceForm : Form
    {
        public UpdateInvoiceForm()
        {
            InitializeComponent();
        }
        public static string dateInvoice;

        private void UpdateData()
        {
            EquipmentOnInvoice.GetListEquipmentOnInvoice(InvoiceForm.idInvoice);
            dataGridViewInvoiceInfo.DataSource = EquipmentOnInvoice.dtInvoiceInfo;
        }

        private void UpdateInvoiceForm_Load(object sender, EventArgs e)
        {
            dateInvoice = InvoiceForm.dateInvoice;
            dateTimePickerDateOrder.Value = Convert.ToDateTime(dateInvoice);

            SpVendor.GetList();
            comboBoxVendor.DataSource = SpVendor.dtVendor;
            comboBoxVendor.DisplayMember = "nameVendor";
            comboBoxVendor.ValueMember = "idVendor";
            comboBoxVendor.SelectedValue = InvoiceForm.idVendor;

            UpdateData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipmentOnInvoiceForm.idInvoice = InvoiceForm.idInvoice;
            AddEquipmentOnInvoiceForm addEquipmentOnInvoiceForm = new AddEquipmentOnInvoiceForm();
            addEquipmentOnInvoiceForm.ShowDialog();
            UpdateData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoiceInfo.Rows.Count != 0)
            {
                dateInvoice = dateTimePickerDateOrder.Value.ToString("yyyy-MM-dd");
                if (Invoice.Update(InvoiceForm.idInvoice, dateInvoice, comboBoxVendor.SelectedValue.ToString()))
                {
                    MessageBox.Show("Накладная изменена");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка! Не получилось изменить накладную");
                }
            }
            else
            {
                MessageBox.Show("Состав накладной не может быть пустым!");
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoiceInfo.SelectedRows.Count != 0)
            {
                UpdateEquipmentOnInvoiceForm.idInvoice = InvoiceForm.idInvoice;
                UpdateEquipmentOnInvoiceForm.count = dataGridViewInvoiceInfo.CurrentRow.Cells["Column3"].Value.ToString();
                UpdateEquipmentOnInvoiceForm.idEquipmentOnInvoice = dataGridViewInvoiceInfo.CurrentRow.Cells["Column4"].Value.ToString();
                UpdateEquipmentOnInvoiceForm.idEquipment = dataGridViewInvoiceInfo.CurrentRow.Cells["Column5"].Value.ToString();
                UpdateEquipmentOnInvoiceForm updateEquipmentOnInvoiceForm = new UpdateEquipmentOnInvoiceForm();
                updateEquipmentOnInvoiceForm.ShowDialog();
                UpdateData();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoiceInfo.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Удалить оборудование из состава накладной?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (EquipmentOnInvoice.Delete(dataGridViewInvoiceInfo.CurrentRow.Cells["Column4"].Value.ToString()))
                        MessageBox.Show("Оборудование удалено из состава накладной");
                    else
                        MessageBox.Show("Ошибка! Не получилось удалить оборудование из состава накладной");
                    UpdateData();
                }
            }
        }
    }
}
