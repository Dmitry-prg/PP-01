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

namespace equipment.Forms.ManagerForms.CustomersForms
{
    public partial class AddCustomersForm : Form
    {
        public AddCustomersForm()
        {
            InitializeComponent();
        }

        static bool checkDuplicate;

        private void checkBoxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxViewPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != string.Empty &&
                txtPassword.Text != string.Empty &&
                txtSurname.Text != string.Empty &&
                txtName.Text != string.Empty &&
                txtTelephone.Text != string.Empty &&
                txtEmail.Text != string.Empty)
            {
                if (checkDuplicate)
                {
                    if (Customers.CheckPassword(txtPassword.Text))
                    {
                        if (Customers.CheckEmail(txtEmail.Text))
                        {
                            if (Customers.Add(txtLogin.Text,
                                      txtPassword.Text,
                                      txtSurname.Text,
                                      txtName.Text,
                                      txtPatronymic.Text,
                                      txtEmail.Text,
                                      txtTelephone.Text,
                                      comboBoxCompany.SelectedValue.ToString(),
                                      comboBoxAccess.SelectedValue.ToString()))
                            {
                                MessageBox.Show("Клиент добавлен");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ошибка! Не удалось добавить клиента");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ошибка! Некорректный Email.\r\n" +
                                " Требования к Email: \r\n" +
                                "- наличие не более одного символа '@';\r\n" +
                                "- наличие минимум одного символа '.'; \r\n" +
                                "- email не должен содержать символов '.' и '@' в начале и в конце.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ненадёжный пароль!\r\n" +
                                 " Требования к паролю: \r\n" +
                                 "- длина пароля должна быть не менее 6 символов;\r\n" +
                                 "- обязательное наличие цифр, знаков препинания, строчных и прописных букв.");
                    }
                }
                else
                {
                    MessageBox.Show("Клиент с таким логином уже существует!");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (Customers.CheckDuplicate(txtLogin.Text))
            {
                checkDuplicate = true;
                labelCheckDuplicate.ForeColor = Color.Green;
                labelCheckDuplicate.Text = "Логин свободен";
            }
            else
            {
                checkDuplicate = false;
                labelCheckDuplicate.ForeColor = Color.Red;
                labelCheckDuplicate.Text = "Логин занят!";
            }
        }

        private void AddCustomersForm_Load(object sender, EventArgs e)
        {
            SpAccess.GetList();
            comboBoxAccess.DataSource = SpAccess.dtAccess;
            comboBoxAccess.DisplayMember = "nameAccess";
            comboBoxAccess.ValueMember = "idAccess";
            comboBoxAccess.SelectedValue = 0;

            SpCompany.GetListComboBox();
            comboBoxCompany.DataSource = SpCompany.dtCompanyComboBox;
            comboBoxCompany.DisplayMember = "nameCompany";
            comboBoxCompany.ValueMember = "idCompany";
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }   
}
