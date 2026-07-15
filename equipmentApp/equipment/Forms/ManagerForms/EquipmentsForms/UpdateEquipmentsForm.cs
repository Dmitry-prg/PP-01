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
    public partial class UpdateEquipmentsForm : Form
    {
        public UpdateEquipmentsForm()
        {
            InitializeComponent();
        }

        private void UpdateEquipmentsForm_Load(object sender, EventArgs e)
        {
            SpTypeEquipment.GetList();
            comboBoxTypeEquipment.DataSource = SpTypeEquipment.dtTypeEquipment;
            comboBoxTypeEquipment.DisplayMember = "nameTypeEquipment";
            comboBoxTypeEquipment.ValueMember = "idTypeEquipment";
            txtNameEquipment.Text = EquipmentsForm.nameEquipment;
            comboBoxTypeEquipment.SelectedValue = EquipmentsForm.idTypeEquipment;
            txtPriceEquipment.Text = EquipmentsForm.price;
            txtCountEquipment.Text = EquipmentsForm.count;
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
                if (Equipments.CheckDuplicate(txtNameEquipment.Text) || txtNameEquipment.Text == EquipmentsForm.nameEquipment)
                {
                    if (Equipments.Update(EquipmentsForm.idEquipment,
                                    txtNameEquipment.Text,
                                    comboBoxTypeEquipment.SelectedValue.ToString(),
                                    Equipments.ConvertDecimal(txtPriceEquipment.Text),
                                    txtCountEquipment.Text))
                    {
                        MessageBox.Show("Запись изменена");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ошибка! не получилось изменить запись");
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
    }
}

