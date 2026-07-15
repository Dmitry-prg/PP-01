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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        public static string idCustomer, login, password, surname, name, patronymic, email, phone, idCompany, idAccess;

        private void UpdateData()
        {
            Customers.GetListCustomers();
            dataGridViewCustomers.DataSource = Customers.dtCustomers;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm();
            addCustomersForm.ShowDialog();
            UpdateData();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridViewCustomers.SelectedRows.Count != 0)
            {
                login = dataGridViewCustomers.CurrentRow.Cells["Column1"].Value.ToString();
                password = dataGridViewCustomers.CurrentRow.Cells["Column2"].Value.ToString();
                surname = dataGridViewCustomers.CurrentRow.Cells["Column3"].Value.ToString();
                name = dataGridViewCustomers.CurrentRow.Cells["Column4"].Value.ToString();
                patronymic = dataGridViewCustomers.CurrentRow.Cells["Column5"].Value.ToString();
                email = dataGridViewCustomers.CurrentRow.Cells["Column6"].Value.ToString();
                phone = dataGridViewCustomers.CurrentRow.Cells["Column7"].Value.ToString();
                idCompany = dataGridViewCustomers.CurrentRow.Cells["Column9"].Value.ToString();
                idAccess = dataGridViewCustomers.CurrentRow.Cells["Column11"].Value.ToString();
                idCustomer = dataGridViewCustomers.CurrentRow.Cells["Column12"].Value.ToString();
                UpdateCustomersForm updateCustomersForm = new UpdateCustomersForm();
                updateCustomersForm.ShowDialog();
                UpdateData();
            }
        }
    }
}
