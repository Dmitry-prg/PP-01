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
    public partial class AddInvoiceForm : Form
    {
        public AddInvoiceForm()
        {
            InitializeComponent();
        }

        bool change = false;
        string dateInvoice;

        private void UpdateData()
        {
            EquipmentOnInvoice.GetListEquipmentOnInvoice(AddEquipmentOnInvoiceForm.idInvoice);
            dataGridViewInvoiceInfo.DataSource = EquipmentOnInvoice.dtInvoiceInfo;
        }

        private void AddInvoiceForm_Load(object sender, EventArgs e)
        {
            dateTimePickerDateOrder.Value = DateTime.Now;
            SpVendor.GetList();
            comboBoxVendor.DataSource = SpVendor.dtVendor;
            comboBoxVendor.DisplayMember = "nameVendor";
            comboBoxVendor.ValueMember = "idVendor";

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateInvoice = dateTimePickerDateOrder.Value.ToString("yyyy-MM-dd");
            if (!change)
            {
                if (Invoice.Add(dateInvoice, comboBoxVendor.SelectedValue.ToString()))
                {
                    change = true;
                    AddEquipmentOnInvoiceForm.idInvoice = Invoice.GetMaxIdInvoice();
                    AddEquipmentOnInvoiceForm addEquipmentOnInvoiceForm = new AddEquipmentOnInvoiceForm();
                    addEquipmentOnInvoiceForm.ShowDialog();
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("Ошибка! Не получилось открыть форму для добавления оборудования в накладную");
                }
            }
            else
            {
                AddEquipmentOnInvoiceForm addEquipmentOnInvoiceForm = new AddEquipmentOnInvoiceForm();
                addEquipmentOnInvoiceForm.ShowDialog();
                UpdateData();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoiceInfo.SelectedRows.Count != 0)
            {
                UpdateEquipmentOnInvoiceForm.idInvoice = AddEquipmentOnInvoiceForm.idInvoice;
                UpdateEquipmentOnInvoiceForm.count = dataGridViewInvoiceInfo.CurrentRow.Cells["Column3"].Value.ToString();
                UpdateEquipmentOnInvoiceForm.idEquipmentOnInvoice = dataGridViewInvoiceInfo.CurrentRow.Cells["Column4"].Value.ToString();
                UpdateEquipmentOnInvoiceForm.idEquipment = dataGridViewInvoiceInfo.CurrentRow.Cells["Column5"].Value.ToString();
                UpdateEquipmentOnInvoiceForm updateEquipmentOnInvoiceForm = new UpdateEquipmentOnInvoiceForm();
                updateEquipmentOnInvoiceForm.ShowDialog();
                UpdateData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dataGridViewInvoiceInfo.Rows.Count != 0)
            {
                dateInvoice = dateTimePickerDateOrder.Value.ToString("yyyy-MM-dd");
                if (Invoice.Update(AddEquipmentOnInvoiceForm.idInvoice, dateInvoice, comboBoxVendor.SelectedValue.ToString()))
                {
                    MessageBox.Show("Накладная добавлена!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка! Не получилось добавить накладную");
                }
            }
            else
            {
                MessageBox.Show("Состав накладной не может быть пустым!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (change)
            {
                if (EquipmentOnInvoice.DeleteForInvoice(AddEquipmentOnInvoiceForm.idInvoice) 
                    && Orders.Delete(Orders.GetMaxIdOrder()))
                    MessageBox.Show("Добавление накладной отменено");
            }
            this.Close();
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
