using equipment.Classes;
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
    public partial class CustomerOrdersForm : Form
    {
        public CustomerOrdersForm()
        {
            InitializeComponent();
        }
        public static string idOrder;
        public static string dateOrder;

        private void UpdateData()
        {
            if (Customers.GetId() != null)
            {
                Orders.GetListCustomerOrders(Customers.GetId());
                dataGridViewOrders.DataSource = Orders.dtOrders;
                if (dataGridViewOrders.SelectedRows.Count != 0)
                {
                    EquipmentOnOrder.GetListEquipmentOnOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString());
                    dataGridViewOrderInfo.DataSource = EquipmentOnOrder.dtOrderInfo;
                    labelFindStatus.Visible = false;
                }
                SpStatusOrder.GetList();
                comboBoxStatusOrders.DataSource = SpStatusOrder.dtStatusOrder;
                comboBoxStatusOrders.DisplayMember = "nameStatusOrder";
                comboBoxStatusOrders.ValueMember = "idStatusOrder";
                comboBoxStatusOrders.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Не удалось найти заявки пользователя!");
            }

        }
        private void CustomerOrdersForm_Load(object sender, EventArgs e)
        {
             UpdateData();
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 0)
            {
                EquipmentOnOrder.GetListEquipmentOnOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString());
                dataGridViewOrderInfo.DataSource = EquipmentOnOrder.dtOrderInfo;
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerOrderForm addCustomerOrderForm = new AddCustomerOrderForm();
            addCustomerOrderForm.ShowDialog();
            UpdateData();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 0)
            {
                switch (Orders.GetStatusOrder(dataGridViewOrders.CurrentRow.Cells["column1"].Value.ToString()))
                {
                    case null:
                        {
                            MessageBox.Show("Ошибка! Не удалось получить статус заявки");
                            break;
                        }
                    case "3":
                        {
                            idOrder = dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString();
                            dateOrder = dataGridViewOrders.CurrentRow.Cells["Column2"].Value.ToString();

                            UpdateCustomerOrderForm updateCustomerOrderForm = new UpdateCustomerOrderForm();
                            updateCustomerOrderForm.ShowDialog();
                            UpdateData();
                            break;
                        }
                        default:
                        {
                            MessageBox.Show("Изменять можно только заявки со статусом 'Создана'!");
                            break;
                        }
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 0)
            {
                switch (Orders.GetStatusOrder(dataGridViewOrders.CurrentRow.Cells["column1"].Value.ToString()))
                {
                    case null:
                        {
                            MessageBox.Show("Ошибка! Не удалось получить статус заявки");
                            break;
                        }
                    case "3":
                        {
                            if (MessageBox.Show("Удалить заявку?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string idOrder = dataGridViewOrders.CurrentRow.Cells["column1"].Value.ToString();
                                if (EquipmentOnOrder.DeleteForOrder(idOrder) && Orders.Delete(idOrder))
                                    MessageBox.Show("Заявка удалена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось удалить заявку");
                                UpdateData();
                            }
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Удалять можно только заявки со статусом 'Создана'!");
                            break;
                        }
                }
            }
        }

        private void comboBoxStatusOrders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Orders.GetListFilterCustomerOrders(Customers.GetId(), comboBoxStatusOrders.SelectedValue.ToString());
            dataGridViewOrders.DataSource = Orders.dtFilterOrders;
            if (dataGridViewOrders.SelectedRows.Count != 0)
            {
                dataGridViewOrderInfo.Show();
                labelFindStatus.Visible = false;
                EquipmentOnOrder.GetListEquipmentOnOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString());
                dataGridViewOrderInfo.DataSource = EquipmentOnOrder.dtOrderInfo;
            }
            else
            {
                dataGridViewOrderInfo.Hide();
                labelFindStatus.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
