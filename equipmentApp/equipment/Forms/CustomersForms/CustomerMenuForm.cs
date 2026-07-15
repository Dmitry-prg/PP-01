using equipment.Classes;
using equipment.Forms.CustomersForms.OrdersForms;
using equipment.Forms.ManagerForms.EquipmentsForms;
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
    public partial class CustomerMenuForm : Form
    {
        public CustomerMenuForm()
        {
            InitializeComponent();
        }



        private void CustomerMenuForm_Load(object sender, EventArgs e)
        {
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerOrdersForm customerOrdersForm = new CustomerOrdersForm();
            customerOrdersForm.Show();
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LKCustomerForm lKCustomerForm = new LKCustomerForm();
            lKCustomerForm.ShowDialog();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentsForm.readOnlyEquipments = true;
            EquipmentsForm equipmentsForm = new EquipmentsForm();
            equipmentsForm.Show();
        }
    }
}
