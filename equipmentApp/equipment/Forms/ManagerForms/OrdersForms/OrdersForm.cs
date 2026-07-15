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

namespace equipment.Forms.ManagerForms.OrdersForms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        public static bool checkCount = true;
        private bool CheckMenegerOrder(string id, string text)
        {
            if (id == Staff.GetId() || text == "Не назначен")
                return true;
            else 
                return false;
        }

        private void CheckCountEQuipmentsForOrder()
        {
            if (dataGridViewOrderInfo.Rows.Count != 0)
            {
                checkCount = true;
                for (int i = 0; i < dataGridViewOrderInfo.Rows.Count; i++)
                {
                    {
                        if ((Convert.ToInt32(Equipments.GetCountEquipment(dataGridViewOrderInfo.Rows[i].Cells["Column16"].Value.ToString()))
                                < Convert.ToInt32(dataGridViewOrderInfo.Rows[i].Cells["Column13"].Value.ToString())) &&
                                dataGridViewOrders.CurrentRow.Cells["Column4"].Value.ToString() == "Создана")
                        {
                            checkCount = false;
                            dataGridViewOrders.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                            dataGridViewOrderInfo.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            dataGridViewOrders.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Red;
                            dataGridViewOrderInfo.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
                        }
                    }
                }
            }
        }



        private void UpdateData()
        {
            Orders.GetListOrders();
            dataGridViewOrders.DataSource = Orders.dtOrders;
            if (dataGridViewOrders.SelectedRows.Count != 0)
            {
                dataGridViewOrderInfo.Show();
                labelFindStatus.Visible = false;
                EquipmentOnOrder.GetListEquipmentOnOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString());
                dataGridViewOrderInfo.DataSource = EquipmentOnOrder.dtOrderInfo;
                CheckCountEQuipmentsForOrder();
            }
            else
            {
                dataGridViewOrderInfo.Hide();
                labelFindStatus.Visible = true;
            }
            SpStatusOrder.GetList();
            comboBoxStatusOrders.DataSource = SpStatusOrder.dtStatusOrder;
            comboBoxStatusOrders.DisplayMember = "nameStatusOrder";
            comboBoxStatusOrders.ValueMember = "idStatusOrder";
            comboBoxStatusOrders.SelectedIndex = 3;

        }


        private void OrdersForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxStatusOrders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Orders.GetListFilterStatusOrders(comboBoxStatusOrders.SelectedValue.ToString());
            dataGridViewOrders.DataSource = Orders.dtFilterOrders;
            if (dataGridViewOrders.SelectedRows.Count != 0)
            {
                dataGridViewOrderInfo.Show();
                labelFindStatus.Visible = false;
                EquipmentOnOrder.GetListEquipmentOnOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString());
                dataGridViewOrderInfo.DataSource = EquipmentOnOrder.dtOrderInfo;
                CheckCountEQuipmentsForOrder();
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

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            switch (e.ColumnIndex.ToString())
            {
                case "0":
                    {
                        if (CheckMenegerOrder(dataGridViewOrders.CurrentRow.Cells["Column7"].Value.ToString(),
                            dataGridViewOrders.CurrentRow.Cells["Column6"].Value.ToString()))
                        {
                            switch (Orders.GetStatusOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString()))
                            {
                                case null:
                                    MessageBox.Show("Ошибка! Не удалось получить статус заявки");
                                    break;
                                case "1":
                                    MessageBox.Show("Невозможно отклонить выполненную заявку!");
                                    break;
                                case "2":
                                    MessageBox.Show("Заявка уже отклонена!");
                                    break;
                                case "3":
                                    if (MessageBox.Show("Отклонить заявку?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        if (Orders.SetStatusOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString(), "2", Staff.GetId()))
                                            MessageBox.Show("Заявка отклонена");
                                        else
                                            MessageBox.Show("Ошибка! Не удалось отклонить заявку");
                                        UpdateData();
                                    }
                                    break;
                                case "4":
                                    if (MessageBox.Show("Заявка в работе. Отклонить заявку?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        if (Orders.SetStatusOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString(), "2", Staff.GetId()))
                                            MessageBox.Show("Заявка отклонена");
                                        else
                                            MessageBox.Show("Ошибка! Не удалось отклонить заявку");
                                        UpdateData();
                                    }
                                    break;
                            }
                        }
                        else
                            MessageBox.Show("Выбранную заявку выполняет другой менеджер!");
                        break;
                    }
                case "1":
                    {
                        if (CheckMenegerOrder(dataGridViewOrders.CurrentRow.Cells["Column7"].Value.ToString(),
                            dataGridViewOrders.CurrentRow.Cells["Column6"].Value.ToString()))
                        {
                            switch (Orders.GetStatusOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString()))
                            {
                                case null:
                                    MessageBox.Show("Ошибка! Не удалось получить статус заявки");
                                    break;
                                case "1":
                                    MessageBox.Show("Невозможно взять выполненную заявку в работу!");
                                    break;
                                case "2":
                                    MessageBox.Show("Невозможно взять отклонённую заявку в работу!");
                                    break;
                                case "3":
                                    DialogResult result = MessageBox.Show("Взять заявку в работу?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.Yes)
                                    {
                                        if (Orders.SetStatusOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString(), "4", Staff.GetId()))
                                            MessageBox.Show("Заявка взята в работу");
                                        else
                                            MessageBox.Show("Ошибка! Не удалось взять заявку в работу");
                                        UpdateData();
                                    }
                                    break;
                                case "4":
                                    MessageBox.Show("Заявка уже в работе!");
                                    break;
                            }
                        }
                        else
                            MessageBox.Show("Выбранную заявку выполняет другой менеджер!");
                        break;
                    }
                case "2":
                    {
                        if (CheckMenegerOrder(dataGridViewOrders.CurrentRow.Cells["Column7"].Value.ToString(),
                            dataGridViewOrders.CurrentRow.Cells["Column6"].Value.ToString()))
                        {
                            switch (Orders.GetStatusOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString()))
                            {
                                case null:
                                    MessageBox.Show("Ошибка! Не удалось получить статус заявки");
                                    break;
                                case "1":
                                    MessageBox.Show("Заявка уже выполнена!");
                                    break;
                                case "2":
                                    MessageBox.Show("Заявка уже отклонена!");
                                    break;
                                case "3":
                                    if (checkCount)
                                    {
                                        if (MessageBox.Show("Выполнить заявку?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {

                                            if (Orders.SetStatusOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString(), "1", Staff.GetId()))
                                            {
                                                MessageBox.Show("Заявка выполнена");
                                                DateTime date = Convert.ToDateTime(dataGridViewOrders.CurrentRow.Cells["Column2"].Value.ToString());
                                                if (saveFileDialogAct.ShowDialog() == DialogResult.OK)
                                                {
                                                    DocumentsExport.Act(saveFileDialogAct.FileName,
                                                        dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString(), date.ToString("D"),
                                                        dataGridViewOrders.CurrentRow.Cells["Column3"].Value.ToString());
                                                }
                                                this.Focus();
                                            }
                                            else
                                                MessageBox.Show("Ошибка! Не удалось выполнить заявку");

                                            UpdateData();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Невозможно выполнить заявку!\r\nНеобходимого оборудования нет в наличии");
                                    }
                                        break;
                                case "4":
                                    if (MessageBox.Show("Выполнить заявку?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        if (Orders.SetStatusOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString(), "1", Staff.GetId()))
                                        {
                                            MessageBox.Show("Заявка выполнена");
                                            DateTime date = Convert.ToDateTime(dataGridViewOrders.CurrentRow.Cells["Column2"].Value.ToString());
                                            if (saveFileDialogAct.ShowDialog() == DialogResult.OK)
                                            {
                                                DocumentsExport.Act(saveFileDialogAct.FileName,
                                                    dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString(), date.ToString("D"),
                                                    dataGridViewOrders.CurrentRow.Cells["Column3"].Value.ToString());
                                            }
                                            this.Focus();
                                        }
                                        else
                                            MessageBox.Show("Ошибка! Не удалось выполнить заявку");
                                        UpdateData();
                                    }
                                    break;
                            }
                        }
                        else
                            MessageBox.Show("Выбранную заявку выполняет другой менеджер!");
                        break;
                    }
            }
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 0)
            {
                dataGridViewOrderInfo.Show();
                labelFindStatus.Visible = false;
                EquipmentOnOrder.GetListEquipmentOnOrder(dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString());
                dataGridViewOrderInfo.DataSource = EquipmentOnOrder.dtOrderInfo;
                CheckCountEQuipmentsForOrder();
            }
            else
            {
                dataGridViewOrderInfo.Hide();
                labelFindStatus.Visible = true;
            }
        }

        private void составЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogOrderInfo.ShowDialog() == DialogResult.OK)
            {
                DateTime date = Convert.ToDateTime(dataGridViewOrders.CurrentRow.Cells["Column2"].Value.ToString());
                DocumentsExport.OrderInfo(dataGridViewOrders.CurrentRow.Cells["Column3"].Value.ToString(),
                                          dataGridViewOrders.CurrentRow.Cells["Column1"].Value.ToString(),
                                          date.ToString("D"), saveFileDialogOrderInfo.FileName);
            }
            this.Focus();
        }
    }
}
