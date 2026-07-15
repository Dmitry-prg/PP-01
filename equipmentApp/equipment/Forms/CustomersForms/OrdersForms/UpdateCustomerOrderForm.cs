using equipment.Classes;
using equipment.Forms.CustomersForms.EquipmentOnOrderForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipment.Forms.CustomersForms.OrdersForms
{
    public partial class UpdateCustomerOrderForm : Form
    {
        public UpdateCustomerOrderForm()
        {
            InitializeComponent();
        }


        private void UpdateData()
        {
            EquipmentOnOrder.GetListEquipmentOnOrder(CustomerOrdersForm.idOrder);
            dataGridViewOrderInfo.DataSource = EquipmentOnOrder.dtOrderInfo;
        }

        private void UpdateCustomerOrderForm_Load(object sender, EventArgs e)
        {
            dateTimePickerDateOrder.Value = Convert.ToDateTime(CustomerOrdersForm.dateOrder);

            EquipmentOnOrder.GetListEquipmentOnOrder(CustomerOrdersForm.idOrder);
            dataGridViewOrderInfo.DataSource = EquipmentOnOrder.dtOrderInfo;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipmentOnOrderForm.idOrder = CustomerOrdersForm.idOrder;
            AddEquipmentOnOrderForm addEquipmentOnOrderForm = new AddEquipmentOnOrderForm();
            addEquipmentOnOrderForm.ShowDialog();
            UpdateData();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderInfo.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Удалить оборудование из заявки?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (EquipmentOnOrder.Delete(dataGridViewOrderInfo.CurrentRow.Cells["column5"].Value.ToString()))
                        MessageBox.Show("Оборудование удалено из заявки");
                    else
                        MessageBox.Show("Ошибка! Не получилось удалить оборудование из заявки");
                    UpdateData();
                }
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderInfo.SelectedRows.Count != 0)
            {
                UpdateEquipmentOnOrderForm.count = dataGridViewOrderInfo.CurrentRow.Cells["Column3"].Value.ToString();
                UpdateEquipmentOnOrderForm.explanation = dataGridViewOrderInfo.CurrentRow.Cells["Column4"].Value.ToString();
                UpdateEquipmentOnOrderForm.idEquipmentOnOrder = dataGridViewOrderInfo.CurrentRow.Cells["Column5"].Value.ToString();
                UpdateEquipmentOnOrderForm.idEquipment = dataGridViewOrderInfo.CurrentRow.Cells["Column6"].Value.ToString();
                UpdateEquipmentOnOrderForm updateEquipmentOnOrderForm = new UpdateEquipmentOnOrderForm();
                updateEquipmentOnOrderForm.ShowDialog();
                UpdateData();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderInfo.Rows.Count >= 1)
            {
                MessageBox.Show("Заявка изменена");
                this.Close();
            }
            else
            {
                MessageBox.Show("Состав заявки не может быть пустым!");
            }
        }
    }
}
