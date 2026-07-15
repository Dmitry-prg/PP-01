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
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace equipment.Forms.ManagerForms.SpForms
{
    public partial class AddSpForm : Form
    {
        public AddSpForm()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSpForm_Load(object sender, EventArgs e)
        {
            if (SpForm.key == 3)
            {
                Size = new Size(550, 135);
                labelINNCompany.Visible = true;
                labelAddress.Visible = true;
                txtINN.Visible = true;
                txtAddress.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                switch (SpForm.key)
                {
                    case 1:
                        {
                            if (SpAccess.CheckDuplicate(txtName.Text))
                            {
                                if (SpAccess.Add(txtName.Text))
                                    MessageBox.Show("Запись добавлена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось добавить запись");
                                this.Close();
                            }
                            else MessageBox.Show("Запись с таким наименованием уже существует!");
                            break;
                        }
                    case 2:
                        {
                            if (SpPost.CheckDuplicate(txtName.Text))
                            {
                                if (SpPost.Add(txtName.Text))
                                    MessageBox.Show("Запись добавлена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось добавить запись");
                                this.Close();
                            }
                            else MessageBox.Show("Должность с таким наименованием уже существует!");
                            break;
                        }
                    case 3:
                        {

                            if (txtINN.Text.Length == 10 && txtAddress.Text != string.Empty)
                            {
                                if (SpCompany.CheckDuplicate(txtName.Text))
                                {
                                    if (SpCompany.Add(txtName.Text, txtINN.Text, txtAddress.Text))
                                        MessageBox.Show("Запись добавлена");
                                    else
                                        MessageBox.Show("Ошибка! Не получилось добавить запись");
                                    this.Close();
                                }
                                else MessageBox.Show("Организация с таким ИНН уже существует!");
                            }
                            else
                            {
                                if (txtINN.Text.Length != 10) MessageBox.Show("ИНН должен содержать 10 цифр");
                                else MessageBox.Show("Заполните все поля!");
                            }
                            break;
                        }
                    case 4:
                        {
                            if (SpVendor.CheckDuplicate(txtName.Text))
                            {
                                if (SpVendor.Add(txtName.Text))
                                    MessageBox.Show("Запись добавлена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось добавить запись");
                                this.Close();
                            }
                            else MessageBox.Show("Поставщик с таким наименованием уже существует!");
                            break;
                        }
                    case 5:
                        {
                            if (SpStatusOrder.CheckDuplicate(txtName.Text))
                            {
                                if (SpStatusOrder.Add(txtName.Text))
                                    MessageBox.Show("Запись добавлена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось добавить запись");
                                this.Close();
                            }
                            else MessageBox.Show("Статус заявки с таким наименованием уже существует!");
                            break;
                        }
                    case 6:
                        {
                            if (SpStatusOrder.CheckDuplicate(txtName.Text))
                            {
                                if (SpTypeEquipment.Add(txtName.Text))
                                    MessageBox.Show("Запись добавлена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось добавить запись");
                                this.Close();
                            }
                            else MessageBox.Show("Тип оборудования с таким наименованием уже существует!");
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void txtINN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
