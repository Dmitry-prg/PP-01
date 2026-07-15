namespace equipment.Forms.ManagerForms.StaffForms
{
    partial class AddStaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaffForm));
            this.groupBoxJobInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.comboBoxAccess = new System.Windows.Forms.ComboBox();
            this.labelAccess = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.labelCheckDuplicate = new System.Windows.Forms.Label();
            this.checkBoxViewPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxContact = new System.Windows.Forms.GroupBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmaill = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.groupBoxPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPasportNumber = new System.Windows.Forms.TextBox();
            this.txtPasportSeries = new System.Windows.Forms.TextBox();
            this.labelPasportSeries = new System.Windows.Forms.Label();
            this.labelPasportNumber = new System.Windows.Forms.Label();
            this.groupBoxJobInfo.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
            this.groupBoxContact.SuspendLayout();
            this.groupBoxPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxJobInfo
            // 
            this.groupBoxJobInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxJobInfo.Controls.Add(this.comboBoxPost);
            this.groupBoxJobInfo.Controls.Add(this.comboBoxAccess);
            this.groupBoxJobInfo.Controls.Add(this.labelAccess);
            this.groupBoxJobInfo.Controls.Add(this.labelPost);
            this.groupBoxJobInfo.Location = new System.Drawing.Point(11, 281);
            this.groupBoxJobInfo.Name = "groupBoxJobInfo";
            this.groupBoxJobInfo.Size = new System.Drawing.Size(182, 121);
            this.groupBoxJobInfo.TabIndex = 20;
            this.groupBoxJobInfo.TabStop = false;
            this.groupBoxJobInfo.Text = "Рабочая информация";
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(6, 33);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(150, 21);
            this.comboBoxPost.TabIndex = 13;
            // 
            // comboBoxAccess
            // 
            this.comboBoxAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccess.FormattingEnabled = true;
            this.comboBoxAccess.Location = new System.Drawing.Point(5, 83);
            this.comboBoxAccess.Name = "comboBoxAccess";
            this.comboBoxAccess.Size = new System.Drawing.Size(150, 21);
            this.comboBoxAccess.TabIndex = 12;
            // 
            // labelAccess
            // 
            this.labelAccess.AutoSize = true;
            this.labelAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccess.Location = new System.Drawing.Point(4, 65);
            this.labelAccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccess.Name = "labelAccess";
            this.labelAccess.Size = new System.Drawing.Size(48, 15);
            this.labelAccess.TabIndex = 12;
            this.labelAccess.Text = "Доступ";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPost.Location = new System.Drawing.Point(10, 15);
            this.labelPost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(73, 15);
            this.labelPost.TabIndex = 13;
            this.labelPost.Text = "Должность";
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAccount.Controls.Add(this.labelCheckDuplicate);
            this.groupBoxAccount.Controls.Add(this.checkBoxViewPassword);
            this.groupBoxAccount.Controls.Add(this.txtPassword);
            this.groupBoxAccount.Controls.Add(this.txtLogin);
            this.groupBoxAccount.Controls.Add(this.labelLogin);
            this.groupBoxAccount.Controls.Add(this.labelPassword);
            this.groupBoxAccount.Location = new System.Drawing.Point(11, 12);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(366, 91);
            this.groupBoxAccount.TabIndex = 18;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Регистрационные данные";
            // 
            // labelCheckDuplicate
            // 
            this.labelCheckDuplicate.AutoSize = true;
            this.labelCheckDuplicate.Location = new System.Drawing.Point(10, 64);
            this.labelCheckDuplicate.Name = "labelCheckDuplicate";
            this.labelCheckDuplicate.Size = new System.Drawing.Size(10, 13);
            this.labelCheckDuplicate.TabIndex = 6;
            this.labelCheckDuplicate.Text = " ";
            // 
            // checkBoxViewPassword
            // 
            this.checkBoxViewPassword.AutoSize = true;
            this.checkBoxViewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxViewPassword.Location = new System.Drawing.Point(197, 66);
            this.checkBoxViewPassword.Name = "checkBoxViewPassword";
            this.checkBoxViewPassword.Size = new System.Drawing.Size(127, 19);
            this.checkBoxViewPassword.TabIndex = 5;
            this.checkBoxViewPassword.Text = "Показать пароль";
            this.checkBoxViewPassword.UseVisualStyleBackColor = true;
            this.checkBoxViewPassword.CheckedChanged += new System.EventHandler(this.checkBoxViewPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(195, 38);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 45;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(7, 38);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.MaxLength = 45;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(150, 22);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            this.txtLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyUp);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(10, 16);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 15);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(194, 16);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(51, 15);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль";
            // 
            // groupBoxContact
            // 
            this.groupBoxContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxContact.Controls.Add(this.txtTelephone);
            this.groupBoxContact.Controls.Add(this.txtEmail);
            this.groupBoxContact.Controls.Add(this.labelEmaill);
            this.groupBoxContact.Controls.Add(this.labelTelephone);
            this.groupBoxContact.Location = new System.Drawing.Point(199, 281);
            this.groupBoxContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxContact.Name = "groupBoxContact";
            this.groupBoxContact.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxContact.Size = new System.Drawing.Size(178, 122);
            this.groupBoxContact.TabIndex = 19;
            this.groupBoxContact.TabStop = false;
            this.groupBoxContact.Text = "Контактные данные";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTelephone.Location = new System.Drawing.Point(9, 38);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelephone.Mask = "+7(000)000-00-00";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(150, 22);
            this.txtTelephone.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(7, 83);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // labelEmaill
            // 
            this.labelEmaill.AutoSize = true;
            this.labelEmaill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmaill.Location = new System.Drawing.Point(6, 64);
            this.labelEmaill.Name = "labelEmaill";
            this.labelEmaill.Size = new System.Drawing.Size(39, 15);
            this.labelEmaill.TabIndex = 8;
            this.labelEmaill.Text = "Email";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTelephone.Location = new System.Drawing.Point(6, 15);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(60, 15);
            this.labelTelephone.TabIndex = 7;
            this.labelTelephone.Text = "Телефон";
            // 
            // groupBoxPersonalInfo
            // 
            this.groupBoxPersonalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPersonalInfo.Controls.Add(this.txtPasportNumber);
            this.groupBoxPersonalInfo.Controls.Add(this.txtPasportSeries);
            this.groupBoxPersonalInfo.Controls.Add(this.labelPasportSeries);
            this.groupBoxPersonalInfo.Controls.Add(this.labelPasportNumber);
            this.groupBoxPersonalInfo.Controls.Add(this.txtPatronymic);
            this.groupBoxPersonalInfo.Controls.Add(this.txtName);
            this.groupBoxPersonalInfo.Controls.Add(this.txtSurname);
            this.groupBoxPersonalInfo.Controls.Add(this.labelSurname);
            this.groupBoxPersonalInfo.Controls.Add(this.labelName);
            this.groupBoxPersonalInfo.Controls.Add(this.labelPatronymic);
            this.groupBoxPersonalInfo.Location = new System.Drawing.Point(11, 110);
            this.groupBoxPersonalInfo.Name = "groupBoxPersonalInfo";
            this.groupBoxPersonalInfo.Size = new System.Drawing.Size(365, 165);
            this.groupBoxPersonalInfo.TabIndex = 17;
            this.groupBoxPersonalInfo.TabStop = false;
            this.groupBoxPersonalInfo.Text = "Персональные данные";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPatronymic.Location = new System.Drawing.Point(7, 128);
            this.txtPatronymic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatronymic.MaxLength = 45;
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(150, 22);
            this.txtPatronymic.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(7, 83);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.MaxLength = 45;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.Location = new System.Drawing.Point(7, 38);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.MaxLength = 45;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(150, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(10, 16);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(62, 15);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(10, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(10, 109);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(63, 15);
            this.labelPatronymic.TabIndex = 5;
            this.labelPatronymic.Text = "Отчество";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(296, 408);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(11, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Отменить";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPasportNumber
            // 
            this.txtPasportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPasportNumber.Location = new System.Drawing.Point(189, 83);
            this.txtPasportNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasportNumber.MaxLength = 45;
            this.txtPasportNumber.Name = "txtPasportNumber";
            this.txtPasportNumber.Size = new System.Drawing.Size(150, 22);
            this.txtPasportNumber.TabIndex = 8;
            // 
            // txtPasportSeries
            // 
            this.txtPasportSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPasportSeries.Location = new System.Drawing.Point(189, 38);
            this.txtPasportSeries.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasportSeries.MaxLength = 45;
            this.txtPasportSeries.Name = "txtPasportSeries";
            this.txtPasportSeries.Size = new System.Drawing.Size(150, 22);
            this.txtPasportSeries.TabIndex = 6;
            // 
            // labelPasportSeries
            // 
            this.labelPasportSeries.AutoSize = true;
            this.labelPasportSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasportSeries.Location = new System.Drawing.Point(192, 16);
            this.labelPasportSeries.Name = "labelPasportSeries";
            this.labelPasportSeries.Size = new System.Drawing.Size(101, 15);
            this.labelPasportSeries.TabIndex = 7;
            this.labelPasportSeries.Text = "Серия паспорта";
            // 
            // labelPasportNumber
            // 
            this.labelPasportNumber.AutoSize = true;
            this.labelPasportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasportNumber.Location = new System.Drawing.Point(192, 64);
            this.labelPasportNumber.Name = "labelPasportNumber";
            this.labelPasportNumber.Size = new System.Drawing.Size(104, 15);
            this.labelPasportNumber.TabIndex = 9;
            this.labelPasportNumber.Text = "Номер паспорта";
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 442);
            this.Controls.Add(this.groupBoxJobInfo);
            this.Controls.Add(this.groupBoxAccount);
            this.Controls.Add(this.groupBoxContact);
            this.Controls.Add(this.groupBoxPersonalInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.AddStaffForm_Load);
            this.groupBoxJobInfo.ResumeLayout(false);
            this.groupBoxJobInfo.PerformLayout();
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxAccount.PerformLayout();
            this.groupBoxContact.ResumeLayout(false);
            this.groupBoxContact.PerformLayout();
            this.groupBoxPersonalInfo.ResumeLayout(false);
            this.groupBoxPersonalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxJobInfo;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.ComboBox comboBoxAccess;
        private System.Windows.Forms.Label labelAccess;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.Label labelCheckDuplicate;
        private System.Windows.Forms.CheckBox checkBoxViewPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.GroupBox groupBoxContact;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmaill;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.GroupBox groupBoxPersonalInfo;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPasportNumber;
        private System.Windows.Forms.TextBox txtPasportSeries;
        private System.Windows.Forms.Label labelPasportSeries;
        private System.Windows.Forms.Label labelPasportNumber;
    }
}