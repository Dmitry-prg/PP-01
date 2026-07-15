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

namespace equipment.Forms.ManagerForms.StaffForms
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }
        public static string idStaff, login, password, surname, name, patronymic, 
            email, phone, pasportSeries, pasportNumber, idAccess, idPost;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridViewStaffManager.Rows.Count != 0)
            {

                login = dataGridViewStaffManager.CurrentRow.Cells["Column1"].Value.ToString();
                password = dataGridViewStaffManager.CurrentRow.Cells["Column2"].Value.ToString();
                surname = dataGridViewStaffManager.CurrentRow.Cells["Column3"].Value.ToString();
                name = dataGridViewStaffManager.CurrentRow.Cells["Column4"].Value.ToString();
                patronymic = dataGridViewStaffManager.CurrentRow.Cells["Column5"].Value.ToString();
                email = dataGridViewStaffManager.CurrentRow.Cells["Column6"].Value.ToString();
                phone = dataGridViewStaffManager.CurrentRow.Cells["Column7"].Value.ToString();
                pasportSeries = dataGridViewStaffManager.CurrentRow.Cells["Column8"].Value.ToString();
                pasportNumber = dataGridViewStaffManager.CurrentRow.Cells["Column9"].Value.ToString();
                idAccess = dataGridViewStaffManager.CurrentRow.Cells["Column11"].Value.ToString();
                idPost = dataGridViewStaffManager.CurrentRow.Cells["Column13"].Value.ToString();
                idStaff = dataGridViewStaffManager.CurrentRow.Cells["Column14"].Value.ToString();

                UpdateStaffForm updateStaffForm = new UpdateStaffForm();
                updateStaffForm.ShowDialog();
                UpdateData();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.ShowDialog();
            UpdateData();
        }

        private void UpdateData()
        {
            Staff.GetListStaff();
            dataGridViewStaffManager.DataSource = Staff.dtStaff;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
              UpdateData();
        }
    }
}
