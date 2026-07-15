using equipment.Classes;
using equipment.Forms.CustomersForms.EquipmentOnOrderForms;
using Mysqlx.Crud;
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
    public partial class AddCustomerOrderForm : Form
    {
        public AddCustomerOrderForm()
        {
            InitializeComponent();
        }
        bool change = false;



        private void UpdateData()
        {
            EquipmentOnOrder.GetListEquipmentOnOrder(AddEquipmentOnOrderForm.idOrder);
            dataGridViewOrderInfo.DataSource = EquipmentOnOrder.dtOrderInfo;
        }

        private void AddCustomerOrderForm_Load(object sender, EventArgs e)
        {
            dateTimePickerDateOrder.Value = DateTime.Now;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dateOrder = dateTimePickerDateOrder.Value.ToString("yyyy-MM-dd");
            if (!change)
            {
                if (Orders.Add(Customers.GetId(), dateOrder))
                {
                    change = true;
                    AddEquipmentOnOrderForm.idOrder = Orders.GetMaxIdOrder(); 
                    AddEquipmentOnOrderForm addEquipmentOnOrderForm = new AddEquipmentOnOrderForm();
                    addEquipmentOnOrderForm.ShowDialog();
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("Ошибка! Не получилось открыть форму для добавления оборудования в заявку");
                }
            }
            else
            {
                AddEquipmentOnOrderForm addEquipmentOnOrderForm = new AddEquipmentOnOrderForm();
                addEquipmentOnOrderForm.ShowDialog();
                UpdateData();
            }

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridViewOrderInfo.SelectedRows.Count != 0)
            {
                UpdateEquipmentOnOrderForm.count = dataGridViewOrderInfo.CurrentRow.Cells["Column3"].Value.ToString();
                UpdateEquipmentOnOrderForm.explanation = dataGridViewOrderInfo.CurrentRow.Cells["Column4"].Value.ToString();
                UpdateEquipmentOnOrderForm.idEquipmentOnOrder = dataGridViewOrderInfo.CurrentRow.Cells["Column5"].Value.ToString();
                UpdateEquipmentOnOrderForm.idEquipment = dataGridViewOrderInfo.CurrentRow.Cells["Column6"].Value.ToString();
                UpdateEquipmentOnOrderForm updateEquipmentOnOrderForm = new UpdateEquipmentOnOrderForm();
                updateEquipmentOnOrderForm.ShowDialog();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {   
            if (change)
            {
                if (EquipmentOnOrder.DeleteForOrder(Orders.GetMaxIdOrder()) && Orders.Delete(Orders.GetMaxIdOrder()))
                    MessageBox.Show("Добавление заявки отменено");
            }
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderInfo.Rows.Count >= 1)
            {
                MessageBox.Show("Заявка добавлена");
                this.Close();
            }
            else
            {
                MessageBox.Show("Состав заявки не может быть пустым!");
            }
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
    }
}
