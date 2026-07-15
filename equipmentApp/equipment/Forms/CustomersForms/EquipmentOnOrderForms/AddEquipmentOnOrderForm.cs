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

namespace equipment.Forms.CustomersForms.EquipmentOnOrderForms
{
    public partial class AddEquipmentOnOrderForm : Form
    {
        public AddEquipmentOnOrderForm()
        {
            InitializeComponent();
        }
        public static string idOrder;


        private void AddEquipmentOnOrderForm_Load(object sender, EventArgs e)
        {
            Equipments.GetList();
            comboBoxEquipment.DataSource = Equipments.dtEquipments;
            comboBoxEquipment.DisplayMember = "nameEquipment";
            comboBoxEquipment.ValueMember = "idEquipment";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCount.Text != string.Empty && txtExplanation.Text != string.Empty)
            {
                if (EquipmentOnOrder.CheckDuplicate(idOrder, comboBoxEquipment.SelectedValue.ToString()))
                {

                    if (EquipmentOnOrder.Add(idOrder,
                        comboBoxEquipment.SelectedValue.ToString(),
                        txtCount.Text, txtExplanation.Text))
                    {
                        MessageBox.Show("Оборудование добавлено в заявку");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка! Не получилось добавить оборудование в заявку");
                    }
                }
                else
                {
                    MessageBox.Show("Оборудование с таким наименованием уже есть в составе заявки!");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
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
