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
using equipment.Forms;
using equipment.Forms.CustomersForms;
using equipment.Forms.ManagerForms;

namespace equipment.Forms.AutorizationForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        int countFails = 0;


        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (DBConnection.ConnectBD())
            {
                labelStatusConnect.Text = "Подключено";
                labelStatusConnect.ForeColor = Color.Green;
                btnLogin.Enabled = true;
            }
            else
            {
                labelStatusConnect.Text = "Ошибка подключения";
                labelStatusConnect.ForeColor = Color.Red;
                btnLogin.Enabled = false;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!DBConnection.CloseBD())
            {
                MessageBox.Show("Ошибка отключения от базы данных!");
            }
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                CaptchaForm captchaForm = new CaptchaForm();
                if (Customers.Autorization(txtLogin.Text, txtPassword.Text))
                {
                    switch (Customers.user)
                    {
                        case null: 
                            if (Staff.Autorization(txtLogin.Text, txtPassword.Text))
                            {
                                switch (Staff.user)
                                {
                                    case null:
                                        if (countFails == 3)
                                        {
                                            timerBan.Start();
                                            btnLogin.Enabled = false;
                                            txtLogin.ReadOnly = true;
                                            txtPassword.ReadOnly = true;
                                            checkBoxViewPassword.Enabled = false;
                                            labelBan.Text = "Слишком много неудачных попыток входа!\r\nДоступ заблокирован на 5 секунд";
                                            //MessageBox.Show("Слишком много неправильных попыток входа!\r\nДоступ заблокирован на 5 минут");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Неверный логин или пароль!");
                                            countFails++;
                                        }
                                        break;
                                    default:
                                        switch (Staff.CheckAccess(Staff.user))
                                        {
                                            case "0":
                                                captchaForm.ShowDialog();
                                                if (CaptchaForm.check)
                                                {
                                                    ManagerMenuForm managerMenuForm = new ManagerMenuForm();
                                                    managerMenuForm.ShowDialog();
                                                }

                                                break;
                                            case "1": 
                                                MessageBox.Show("Доступ запрещён!\r\nСвяжитесь с нами для решения данной проблемы");
                                                break;
                                            case null: 
                                                MessageBox.Show("Ошибка при проверке доступа!");
                                                break;
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при авторизации!");
                            }
                            break;
                        default:
                            switch (Customers.CheckAccess(Customers.user))
                            {
                                case "0":
                                    captchaForm.ShowDialog();
                                    if (CaptchaForm.check)
                                    {
                                        CustomerMenuForm customerMenuForm = new CustomerMenuForm();
                                        customerMenuForm.ShowDialog();
                                    }
                                    break;
                                case "1":
                                    MessageBox.Show("Доступ запрещён!\r\nСвяжитесь с нами для решения данной проблемы");
                                    break;
                                case null:
                                    MessageBox.Show("Ошибка при проверке доступа!");
                                    break;
                            }
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка при авторизации!");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd.MM.yyyy dddd");// и день недели

        }

        private void timerBan_Tick(object sender, EventArgs e)
        {
            countFails = 0;
            txtLogin.ReadOnly = false;
            txtPassword.ReadOnly = false;
            checkBoxViewPassword.Enabled = true;
            btnLogin.Enabled = true;
            labelBan.Text = " ";
            timerBan.Stop();
        }
    }
}
