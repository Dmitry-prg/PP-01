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

namespace equipment.Forms.ManagerForms.SpForms
{
    public partial class UpdateSpForm : Form
    {
        public UpdateSpForm()
        {
            InitializeComponent();
        }

        public static string id;
        public static string name;
        public static string inn;
        public static string address;
        

        private void UpdateSpForm_Load(object sender, EventArgs e)
        {
            
            if (SpForm.key == 3)
            {
                Size = new Size(550, 135);
                labelINNCompany.Visible = true;
                labelAddress.Visible = true;
                txtINN.Visible = true;
                txtAddress.Visible = true;
                txtName.Text = name;
                txtINN.Text = inn;
                txtAddress.Text = address;
            }
            else
            {
                txtName.Text = name;
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateSpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            name = null;
            inn = null;
            address = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                switch (SpForm.key)
                {
                    case 1:
                        {
                            if (SpAccess.CheckDuplicate(txtName.Text) || txtName.Text == name)
                            {
                                if (SpAccess.Update(id, txtName.Text))
                                    MessageBox.Show("Запись изменена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось изменить запись");
                                this.Close();
                            }
                            else MessageBox.Show("Запись с таким наименованием уже существует!");
                            break;
                        }
                    case 2:
                        {
                            if (SpPost.CheckDuplicate(txtName.Text) || txtName.Text == name)
                            {
                                if (SpPost.Update(id, txtName.Text))
                                    MessageBox.Show("Запись изменена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось изменить запись");
                                this.Close();
                            }
                            else MessageBox.Show("Должность с таким наименованием уже существует!");
                            break;
                        }
                    case 3:
                        {

                            if (txtINN.Text.Length == 10 && txtAddress.Text != string.Empty)
                            {
                                if (SpCompany.CheckDuplicate(txtINN.Text) || txtINN.Text == inn)
                                {
                                    if (SpCompany.Update(id, txtName.Text, txtINN.Text, txtAddress.Text))
                                        MessageBox.Show("Запись изменена");
                                    else
                                        MessageBox.Show("Ошибка! Не получилось изменить запись");
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
                            if (SpVendor.CheckDuplicate(txtName.Text) || txtName.Text == name)
                            {
                                if (SpVendor.Update(id, txtName.Text))
                                    MessageBox.Show("Запись изменена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось изменить запись");
                                this.Close();
                            }
                            else MessageBox.Show("Поставщик с таким наименованием уже существует!");
                            break;
                        }
                    case 5:
                        {
                            if (SpStatusOrder.CheckDuplicate(txtName.Text) || txtName.Text == name)
                            {
                                if (SpStatusOrder.Update(id, txtName.Text))
                                    MessageBox.Show("Запись изменена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось изменить запись");
                                this.Close();
                            }
                            else MessageBox.Show("Статус заявки с таким наименованием уже существует!");
                            break;
                        }
                    case 6:
                        {
                            if (SpTypeEquipment.CheckDuplicate(txtName.Text) || txtName.Text == name)
                            {
                                if (SpTypeEquipment.Update(id, txtName.Text))
                                    MessageBox.Show("Запись изменена");
                                else
                                    MessageBox.Show("Ошибка! Не получилось изменить запись");
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
