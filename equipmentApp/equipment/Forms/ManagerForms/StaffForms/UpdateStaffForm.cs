using equipment.Classes;
using equipment.Forms.ManagerForms.CustomersForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipment.Forms.ManagerForms.StaffForms
{
    public partial class UpdateStaffForm : Form
    {
        public UpdateStaffForm()
        {
            InitializeComponent();
        }

        static bool checkDuplicate = true;


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
                txtEmail.Text != string.Empty &&
                txtPasportSeries.Text != string.Empty &&
                txtPasportNumber.Text != string.Empty)
            {
                if (checkDuplicate)
                {
                    if (checkBoxUpdatePassword.Checked)
                    {
                        if (Staff.CheckPassword(txtPassword.Text))
                        {
                            if (Staff.CheckEmail(txtEmail.Text))
                            {
                                if (Staff.Update(StaffForm.idStaff,
                                          checkBoxUpdatePassword.Checked,
                                          txtLogin.Text,
                                          txtPassword.Text,
                                          txtSurname.Text,
                                          txtName.Text,
                                          txtPatronymic.Text,
                                          txtEmail.Text,
                                          txtTelephone.Text,
                                          txtPasportSeries.Text,
                                          txtPasportNumber.Text,
                                          comboBoxAccess.SelectedValue.ToString(),
                                          comboBoxPost.SelectedValue.ToString()))
                                {
                                    MessageBox.Show("Данные сотрудника изменены");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ошибка! Не удалось изменить сотрудника");
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
                        if (Staff.CheckEmail(txtEmail.Text))
                        {
                            if (Staff.Update(StaffForm.idStaff,
                                      checkBoxUpdatePassword.Checked,
                                      txtLogin.Text,
                                      txtPassword.Text,
                                      txtSurname.Text,
                                      txtName.Text,
                                      txtPatronymic.Text,
                                      txtEmail.Text,
                                      txtTelephone.Text,
                                      txtPasportSeries.Text,
                                      txtPasportNumber.Text,
                                      comboBoxAccess.SelectedValue.ToString(),
                                      comboBoxPost.SelectedValue.ToString()))
                            {
                                MessageBox.Show("Данные сотрудника изменены");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ошибка! Не удалось изменить сотрудника");
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
                    MessageBox.Show("Сотрудник с таким логином уже существует!");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void UpdateStaffForm_Load(object sender, EventArgs e)
        {
            SpAccess.GetList();
            comboBoxAccess.DataSource = SpAccess.dtAccess;
            comboBoxAccess.DisplayMember = "nameAccess";
            comboBoxAccess.ValueMember = "idAccess";
            comboBoxAccess.SelectedValue = 0;

            SpPost.GetList();
            comboBoxPost.DataSource = SpPost.dtPost;
            comboBoxPost.DisplayMember = "namePost";
            comboBoxPost.ValueMember = "idPost";

            txtLogin.Text = StaffForm.login;
            txtPassword.Text = StaffForm.password;
            txtSurname.Text = StaffForm.surname;
            txtName.Text = StaffForm.name;
            txtPatronymic.Text = StaffForm.patronymic;
            txtEmail.Text = StaffForm.email;
            txtPasportSeries.Text = StaffForm.pasportSeries;
            txtPasportNumber.Text = StaffForm.pasportNumber;
            txtTelephone.Text = StaffForm.phone;
            comboBoxPost.SelectedValue = StaffForm.idPost;
            comboBoxAccess.SelectedValue = StaffForm.idAccess;
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
                txtPassword.Text = StaffForm.password;
                labelPassword.Visible = false;
                txtPassword.Visible = false;
                checkBoxViewPassword.Visible = false;
            }
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (Staff.CheckDuplicate(txtLogin.Text) || txtLogin.Text == StaffForm.login)
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
