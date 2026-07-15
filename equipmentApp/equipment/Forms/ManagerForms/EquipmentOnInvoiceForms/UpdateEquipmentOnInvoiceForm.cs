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

namespace equipment.Forms.ManagerForms.EquipmentOnInvoiceForms
{
    public partial class UpdateEquipmentOnInvoiceForm : Form
    {
        public UpdateEquipmentOnInvoiceForm()
        {
            InitializeComponent();
        }

        public static string idInvoice;
        public static string idEquipment;
        public static string count;
        public static string idEquipmentOnInvoice;
        private void UpdateEquipmentOnInvoiceForm_Load(object sender, EventArgs e)
        {
            Equipments.GetList();
            comboBoxEquipment.DataSource = Equipments.dtEquipments;
            comboBoxEquipment.DisplayMember = "nameEquipment";
            comboBoxEquipment.ValueMember = "idEquipment";
            comboBoxEquipment.SelectedValue = idEquipment;
            txtCount.Text = count;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtCount.Clear();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EquipmentOnInvoice.CheckDuplicate(idInvoice, comboBoxEquipment.SelectedValue.ToString()) ||
                    comboBoxEquipment.SelectedValue.ToString() == idEquipment) 
            {
                MessageBox.Show(idInvoice + " " + idEquipment);
                if (EquipmentOnInvoice.Update(idEquipmentOnInvoice, comboBoxEquipment.SelectedValue.ToString(), txtCount.Text))
                {
                    MessageBox.Show("Оборудование в накладной изменено");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка! Не получилось изменить оборудование в накладной");
                }
            }
            else
            {
                MessageBox.Show("Оборудование с таким наименованием уже есть в составе накладной!");
            }
        }
    }
}
