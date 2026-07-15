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

namespace equipment.Forms.ManagerForms.SpForms
{
    public partial class SpForm : Form
    {
        public SpForm()
        {
            InitializeComponent();
        }
        public static int key;

        private void UpdateData()
        {
            switch (key)
            {
                case 1:
                    {
                        Text = "Справочник - 'Доступ'";
                        SpAccess.GetList();
                        dataGridViewSp.DataSource = SpAccess.dtAccess;
                        dataGridViewSp.Columns[0].HeaderText = "Наименование";
                        dataGridViewSp.Columns[1].Visible = false;
                        break;
                    }
                case 2:
                    {
                        Text = "Справочник - 'Должности'";
                        SpPost.GetList();
                        dataGridViewSp.DataSource = SpPost.dtPost;
                        dataGridViewSp.Columns[0].HeaderText = "Наименование";
                        dataGridViewSp.Columns[1].Visible = false;
                        break;
                    }
                case 3:
                    {
                        Text = "Справочник - 'Организации'";
                        SpCompany.GetList();
                        dataGridViewSp.DataSource = SpCompany.dtCompany;
                        dataGridViewSp.Columns[0].HeaderText = "Наименование";
                        dataGridViewSp.Columns[1].HeaderText = "ИНН";
                        dataGridViewSp.Columns[2].HeaderText = "Адрес";
                        dataGridViewSp.Columns[3].Visible = false;
                        break;
                    }
                case 4:
                    {
                        Text = "Справочник - 'Поставщики'";
                        SpVendor.GetList();
                        dataGridViewSp.DataSource = SpVendor.dtVendor;
                        dataGridViewSp.Columns[0].HeaderText = "Наименование";
                        dataGridViewSp.Columns[1].Visible = false;
                        break;
                    }
                case 5:
                    {
                        Text = "Справочник - 'Статусы заявок'";
                        SpStatusOrder.GetList();
                        dataGridViewSp.DataSource = SpStatusOrder.dtStatusOrder;
                        dataGridViewSp.Columns[0].HeaderText = "Наименование";
                        dataGridViewSp.Columns[1].Visible = false;
                        break;
                    }
                case 6:
                    {
                        Text = "Справочник - 'Типы оборудования'";
                        SpTypeEquipment.GetList();
                        dataGridViewSp.DataSource = SpTypeEquipment.dtTypeEquipment;
                        dataGridViewSp.Columns[0].HeaderText = "Наименование";
                        dataGridViewSp.Columns[1].Visible = false;
                        break;
                    }
            }
        }


        private void SpForm_Load(object sender, EventArgs e)
        {
            
            UpdateData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpForm addSpForm = new AddSpForm();
            addSpForm.ShowDialog();
            UpdateData();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridViewSp.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idSp = dataGridViewSp.CurrentRow.Cells[1].Value.ToString();
                    switch (key)
                    {
                        case 1:
                            {
                                if (SpAccess.CheckDelete(idSp))
                                {
                                    if (SpAccess.Delete(idSp))
                                        MessageBox.Show("Запись удалена");
                                    else
                                        MessageBox.Show("Ошибка! Не получилось удалить запись");
                                }
                                else MessageBox.Show("Невозможно удалить!\r\n(запись уже используется)");
                                break;
                            }
                        case 2:
                            {
                                if (SpPost.CheckDelete(idSp))
                                {
                                    if (SpPost.Delete(idSp))
                                        MessageBox.Show("Запись удалена");
                                    else
                                        MessageBox.Show("Ошибка! Не получилось удалить запись");
                                }
                                else MessageBox.Show("Невозможно удалить!\r\n(запись уже используется)");
                                break;
                            }
                        case 3:
                            {
                                if (SpCompany.CheckDelete(idSp))
                                {
                                    if (SpCompany.Delete(idSp))
                                        MessageBox.Show("Запись удалена");
                                    else
                                        MessageBox.Show("Ошибка! Не получилось удалить запись");
                                }
                                else MessageBox.Show("Невозможно удалить!\r\n(запись уже используется)");
                                break;
                            }
                        case 4:
                            {
                                if (SpVendor.CheckDelete(idSp))
                                {
                                    if (SpVendor.Delete(idSp))
                                        MessageBox.Show("Запись удалена");
                                    else
                                        MessageBox.Show("Ошибка! Не получилось удалить запись");
                                }
                                else MessageBox.Show("Невозможно удалить!\r\n(запись уже используется)");
                                break;
                            }
                        case 5:
                            {
                                if (SpStatusOrder.CheckDelete(idSp))
                                {
                                    if (SpStatusOrder.Delete(idSp))
                                        MessageBox.Show("Запись удалена");
                                    else
                                        MessageBox.Show("Ошибка! Не получилось удалить запись");
                                }
                                else MessageBox.Show("Невозможно удалить!\r\n(запись уже используется)");
                                break;
                            }
                        case 6:
                            {
                                if (SpTypeEquipment.CheckDelete(idSp))
                                {
                                    if (SpTypeEquipment.Delete(idSp))
                                        MessageBox.Show("Запись удалена");
                                    else
                                        MessageBox.Show("Ошибка! Не получилось удалить запись");
                                }
                                else MessageBox.Show("Невозможно удалить!\r\n(запись уже используется)");
                                break;
                            }
                    }
                    UpdateData();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewSp.SelectedRows.Count != 0)
            {
                switch (key)
                {
                    case 3:
                        {
                            UpdateSpForm.id = dataGridViewSp.CurrentRow.Cells[3].Value.ToString();
                            UpdateSpForm.name = dataGridViewSp.CurrentRow.Cells[0].Value.ToString();
                            UpdateSpForm.inn = dataGridViewSp.CurrentRow.Cells[1].Value.ToString();
                            UpdateSpForm.address = dataGridViewSp.CurrentRow.Cells[2].Value.ToString();
                            break;
                        }

                    default:
                        {
                            UpdateSpForm.id = dataGridViewSp.CurrentRow.Cells[1].Value.ToString();
                            UpdateSpForm.name = dataGridViewSp.CurrentRow.Cells[0].Value.ToString();
                            break;
                        }
                }
                UpdateSpForm updateSpForm = new UpdateSpForm();
                updateSpForm.ShowDialog();
                UpdateData();

            }
        }
    }
}
