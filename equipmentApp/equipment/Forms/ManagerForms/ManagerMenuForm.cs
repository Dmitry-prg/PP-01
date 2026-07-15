using equipment.Classes;
using equipment.Forms.AutorizationForms;
using equipment.Forms.ManagerForms.CustomersForms;
using equipment.Forms.ManagerForms.EquipmentsForms;
using equipment.Forms.ManagerForms.InvoiceForms;
using equipment.Forms.ManagerForms.OrdersForms;
using equipment.Forms.ManagerForms.SpForms;
using equipment.Forms.ManagerForms.StaffForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipment.Forms.ManagerForms
{
    public partial class ManagerMenuForm : Form
    {
        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        private void ManagerMenuForm_Load(object sender, EventArgs e)
        {
            if(Staff.role == "1")
            {
                menuStripManager.Items["сотрудникиToolStripMenuItem"].Visible = true;
                menuStripManager.Items["справочникиToolStripMenuItem"].Visible = true;
            }
            else
            {
                menuStripManager.Items["сотрудникиToolStripMenuItem"].Visible = false;
                menuStripManager.Items["справочникиToolStripMenuItem"].Visible = false;
            }

        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void доступToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpForm.key = 1;
            SpForm spForm = new SpForm();
            spForm.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpForm.key = 2;
            SpForm spForm = new SpForm();
            spForm.Show();
        }

        private void организацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpForm.key = 3;
            SpForm spForm = new SpForm();
            spForm.Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpForm.key = 4;
            SpForm spForm = new SpForm();
            spForm.Show();
        }

        private void статусыЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpForm.key = 5;
            SpForm spForm = new SpForm();
            spForm.Show();
        }

        private void типыОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpForm.key = 6;
            SpForm spForm = new SpForm();
            spForm.Show();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentsForm.readOnlyEquipments = false;
            EquipmentsForm equipmentsForm = new EquipmentsForm();
            equipmentsForm.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.Show();
        }

        private void накладныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.Show();
        }
    }
}
