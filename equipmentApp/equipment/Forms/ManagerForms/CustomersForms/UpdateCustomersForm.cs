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
    public partial class UpdateCustomersForm : Form
    {
        public UpdateCustomersForm()
        {
            InitializeComponent();
        }

        static bool checkDuplicate = true;


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
                    if (checkBoxUpdatePassword.Checked)
                    {
                        if (Customers.CheckPassword(txtPassword.Text))
                        {
                            if (Customers.CheckEmail(txtEmail.Text))
                            {
                                if (Customers.Update(CustomersForm.idCustomer,
                                            checkBoxUpdatePassword.Checked,
                                            txtLogin.Text,
                                            txtPassword.Text,
                                            txtSurname.Text,
                                            txtName.Text,
                                            txtPatronymic.Text,
                                            txtEmail.Text,
                                            txtTelephone.Text,
                                            comboBoxCompany.SelectedValue.ToString(),
                                            comboBoxAccess.SelectedValue.ToString()))
                                {
                                    MessageBox.Show("Данные клиента изменены");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ошибка! Не удалось изменить данные");
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
                        if (Customers.CheckEmail(txtEmail.Text))
                        {
                            if (Customers.Update(CustomersForm.idCustomer,
                                        checkBoxUpdatePassword.Checked,
                                        txtLogin.Text,
                                        txtPassword.Text,
                                        txtSurname.Text,
                                        txtName.Text,
                                        txtPatronymic.Text,
                                        txtEmail.Text,
                                        txtTelephone.Text,
                                        comboBoxCompany.SelectedValue.ToString(),
                                        comboBoxAccess.SelectedValue.ToString()))
                            {
                                MessageBox.Show("Данные клиента изменены");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ошибка! Не удалось изменить данные");
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

        private void UpdateCustomersForm_Load(object sender, EventArgs e)
        {
            SpAccess.GetList();
            comboBoxAccess.DataSource = SpAccess.dtAccess;
            comboBoxAccess.DisplayMember = "nameAccess";
            comboBoxAccess.ValueMember = "idAccess";

            SpCompany.GetListComboBox();
            comboBoxCompany.DataSource = SpCompany.dtCompanyComboBox;
            comboBoxCompany.DisplayMember = "nameCompany";
            comboBoxCompany.ValueMember = "idCompany";

            txtLogin.Text = CustomersForm.login;
            txtPassword.Text = CustomersForm.password;
            txtSurname.Text = CustomersForm.surname;
            txtName.Text = CustomersForm.name;
            txtPatronymic.Text = CustomersForm.patronymic;
            txtEmail.Text = CustomersForm.email;
            txtTelephone.Text = CustomersForm.phone;
            comboBoxCompany.SelectedValue = CustomersForm.idCompany;
            comboBoxAccess.SelectedValue = CustomersForm.idAccess;
     

        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (Customers.CheckDuplicate(txtLogin.Text) || txtLogin.Text == CustomersForm.login)
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

        private void checkBoxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxViewPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBoxUpdatePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUpdatePassword.Checked)
            {
                txtPassword.Clear();
                labelPassword.Visible = true;
                txtPassword.Visible = true;
                checkBoxViewPassword.Visible = true;
            }
            else
            {
                txtPassword.Text = CustomersForm.password;
                labelPassword.Visible = false;
                txtPassword.Visible = false;
                checkBoxViewPassword.Visible = false;
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
