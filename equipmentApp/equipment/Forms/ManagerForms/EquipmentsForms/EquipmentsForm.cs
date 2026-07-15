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
    public partial class EquipmentsForm : Form
    {
        public EquipmentsForm()
        {
            InitializeComponent();
        }

        public static bool readOnlyEquipments;
        public static string idEquipment;
        public static string nameEquipment;
        public static string idTypeEquipment;
        public static string price;
        public static string count;

        private void UpdateData()
        {
            Equipments.GetList();
            dataGridViewEquipments.DataSource = Equipments.dtEquipments;
            if (dataGridViewEquipments.SelectedRows.Count != 0)
                labelFindStatus.Visible = false;
            else
                labelFindStatus.Visible = true;
            SpTypeEquipment.GetList();
            comboBoxTypeEquipments.DataSource = SpTypeEquipment.dtTypeEquipment;
            comboBoxTypeEquipments.DisplayMember = "nameTypeEquipment";
            comboBoxTypeEquipments.ValueMember = "idTypeEquipment";
        }


        private void EquipmentsForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            if (readOnlyEquipments)
            {
                menuStripEquipments.Visible = false;
                dataGridViewEquipments.Columns["Column4"].Visible = false;
            }
            else
            {
                menuStripEquipments.Visible = true;
                dataGridViewEquipments.Columns["Column4"].Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTypeEquipments_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Equipments.GetListFilter(comboBoxTypeEquipments.SelectedValue.ToString());
            dataGridViewEquipments.DataSource = Equipments.dtFilterEquipments;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipmentsForm addEquipmentsForm = new AddEquipmentsForm();
            addEquipmentsForm.ShowDialog();
            UpdateData();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipments.SelectedRows.Count != 0)
            {
                nameEquipment = dataGridViewEquipments.CurrentRow.Cells["Column1"].Value.ToString();
                price = dataGridViewEquipments.CurrentRow.Cells["Column3"].Value.ToString();
                count = dataGridViewEquipments.CurrentRow.Cells["Column4"].Value.ToString();
                idEquipment = dataGridViewEquipments.CurrentRow.Cells["Column5"].Value.ToString();
                idTypeEquipment = dataGridViewEquipments.CurrentRow.Cells["Column6"].Value.ToString();

                UpdateEquipmentsForm updateEquipmentsForm = new UpdateEquipmentsForm();
                updateEquipmentsForm.ShowDialog();
                UpdateData();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridViewEquipments.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Equipments.CheckDelete(dataGridViewEquipments.CurrentRow.Cells[4].Value.ToString()))
                    {


                        if (Equipments.Delete(dataGridViewEquipments.CurrentRow.Cells[4].Value.ToString()))
                            MessageBox.Show("Запись удалена");
                        else
                            MessageBox.Show("Ошибка! Не получилось удалить запись");
                        UpdateData();
                    }
                    else MessageBox.Show("Невозможно удалить!\r\n(запись уже используется)");
                }
            }
        }

        private void txtFindEquipments_Leave(object sender, EventArgs e)
        {
            txtFindEquipments.Text = "Поиск";
            txtFindEquipments.ForeColor = Color.Silver;
        }

        private void txtFindEquipments_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFindEquipments.Text != string.Empty)
            {
                Equipments.GetListFindEquipments(txtFindEquipments.Text);
                dataGridViewEquipments.DataSource = Equipments.dtFindEquipments;
                if (dataGridViewEquipments.Rows.Count == 0)
                {
                    labelFindStatus.Visible = true;
                }
                else
                {
                    labelFindStatus.Visible = false;
                }
            }
            else
            {
                labelFindStatus.Visible = false;
                UpdateData();
            }
        }

        private void txtFindEquipments_Click(object sender, EventArgs e)
        {
            txtFindEquipments.Text = string.Empty;
            txtFindEquipments.ForeColor = Color.Black;
            comboBoxTypeEquipments.SelectedIndex = 0;
        }
    }
}
