using equipment.Classes;
using equipment.Forms.CustomersForms.OrdersForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipment.Forms.CustomersForms.EquipmentOnOrderForms
{
    public partial class UpdateEquipmentOnOrderForm : Form
    {
        public UpdateEquipmentOnOrderForm()
        {
            InitializeComponent();
        }

        public static string idEquipmentOnOrder;
        public static string idEquipment;
        public static string count;
        public static string explanation;

        private void UpdateEquipmentOnOrderForm_Load(object sender, EventArgs e)
        {
            Equipments.GetList();
            comboBoxEquipment.DataSource = Equipments.dtEquipments;
            comboBoxEquipment.DisplayMember = "nameEquipment";
            comboBoxEquipment.ValueMember = "idEquipment";
            comboBoxEquipment.SelectedValue = idEquipment;
            txtCount.Text = count;
            txtExplanation.Text = explanation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EquipmentOnOrder.CheckDuplicate(CustomerOrdersForm.idOrder,
                comboBoxEquipment.SelectedValue.ToString()) || 
                comboBoxEquipment.SelectedValue.ToString() == idEquipment)
            {
                if (txtCount.Text != string.Empty && txtExplanation.Text != string.Empty)
                {
                    if (EquipmentOnOrder.Update(idEquipmentOnOrder,
                                                comboBoxEquipment.SelectedValue.ToString(),
                                                txtCount.Text, txtExplanation.Text))
                    {
                        MessageBox.Show("Оборудование в заявке изменено");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка! Не получилось изменить оборудование в заявке");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            else
            {
                MessageBox.Show("Оборудование с таким наименованием уже есть в составе заявки!");
            }
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8)
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
