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

namespace equipment.Forms.ManagerForms.EquipmentsForms
{
    public partial class AddEquipmentsForm : Form
    {
        public AddEquipmentsForm()
        {
            InitializeComponent();
        }

        private void txtPriceEquipment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void AddEquipmentsForm_Load(object sender, EventArgs e)
        {
            SpTypeEquipment.GetList();
            comboBoxTypeEquipment. DataSource = SpTypeEquipment.dtTypeEquipment;
            comboBoxTypeEquipment.DisplayMember = "nameTypeEquipment";
            comboBoxTypeEquipment.ValueMember = "idTypeEquipment";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameEquipment.Text != string.Empty &&
                txtPriceEquipment.Text != string.Empty &&
                txtCountEquipment.Text != string.Empty)
            {
                if (Equipments.CheckDuplicate(txtNameEquipment.Text))
                {
                    if (Equipments.Add(txtNameEquipment.Text,
                                      comboBoxTypeEquipment.SelectedValue.ToString(),
                                      Equipments.ConvertDecimal(txtPriceEquipment.Text),
                                      txtCountEquipment.Text))
                    {
                        MessageBox.Show("Запись добавлена");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ошибка! не получилось добавить запись");
                }
                else
                {
                    MessageBox.Show("Оборудование с таким наименованием уже существует!");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void txtCountEquipment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void labelCountEquipment_Click(object sender, EventArgs e)
        {

        }

        private void txtCountEquipment_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTypeEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPriceEquipment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameEquipment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNameEquipment_Click(object sender, EventArgs e)
        {

        }
    }
}
