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

namespace equipment.Forms.CustomersForms
{
    public partial class LKCustomerForm : Form
    {
        public LKCustomerForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LKCustomerForm_Load(object sender, EventArgs e)
        {
            Customers.GetLKInfo();
            txtSurname.Text = Customers.surname;
            txtName.Text = Customers.name;
            txtPatronymic.Text = Customers.patronymic;
            txtEmail.Text = Customers.email;
            txtTelephone.Text = Customers.phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtSurname.Text != string.Empty && 
                txtName.Text != string.Empty &&
                txtPatronymic.Text != string.Empty &&
                txtEmail.Text != string.Empty &&
                txtTelephone.Text != string.Empty)
            {
                if(Customers.UpdateForCustomer(Customers.GetId(), txtSurname.Text, 
                    txtName.Text, txtPatronymic.Text, txtEmail.Text, txtTelephone.Text))
                {
                    MessageBox.Show("Данные изменены");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка! Не удалось изменить данные");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
