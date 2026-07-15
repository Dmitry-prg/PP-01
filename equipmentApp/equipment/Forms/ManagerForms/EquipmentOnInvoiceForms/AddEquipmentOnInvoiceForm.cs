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
    public partial class AddEquipmentOnInvoiceForm : Form
    {
        public AddEquipmentOnInvoiceForm()
        {
            InitializeComponent();
        }

        public static string idInvoice;


        private void AddEquipmentOnInvoiceForm_Load(object sender, EventArgs e)
        {
            Equipments.GetList();
            comboBoxEquipment.DataSource = Equipments.dtEquipments;
            comboBoxEquipment.DisplayMember = "nameEquipment";
            comboBoxEquipment.ValueMember = "idEquipment";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(EquipmentOnInvoice.CheckDuplicate(idInvoice, comboBoxEquipment.SelectedValue.ToString()))
            {
                if (EquipmentOnInvoice.Add(idInvoice, comboBoxEquipment.SelectedValue.ToString(), txtCount.Text))
                {
                    MessageBox.Show("Оборудование добавлено в накладную");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка! Не получилось добавить оборудование в накладную");
                }
            }
            else
            {
                MessageBox.Show("Оборудование с таким наименованием уже есть в составе накладной!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
