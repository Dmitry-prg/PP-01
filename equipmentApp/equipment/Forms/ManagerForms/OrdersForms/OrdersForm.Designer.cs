namespace equipment.Forms.ManagerForms.OrdersForms
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.btnReset = new System.Windows.Forms.Button();
            this.comboBoxStatusOrders = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewOrderInfo = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxOrderInfo = new System.Windows.Forms.GroupBox();
            this.labelFindStatus = new System.Windows.Forms.Label();
            this.saveFileDialogAct = new System.Windows.Forms.SaveFileDialog();
            this.menuStripManagerOrdder = new System.Windows.Forms.MenuStrip();
            this.saveFileDialogOrderInfo = new System.Windows.Forms.SaveFileDialog();
            this.документToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderInfo)).BeginInit();
            this.groupBoxOrderInfo.SuspendLayout();
            this.menuStripManagerOrdder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(1196, 645);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 31);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // comboBoxStatusOrders
            // 
            this.comboBoxStatusOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatusOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatusOrders.FormattingEnabled = true;
            this.comboBoxStatusOrders.Location = new System.Drawing.Point(988, 646);
            this.comboBoxStatusOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStatusOrders.Name = "comboBoxStatusOrders";
            this.comboBoxStatusOrders.Size = new System.Drawing.Size(199, 28);
            this.comboBoxStatusOrders.TabIndex = 7;
            this.comboBoxStatusOrders.SelectionChangeCommitted += new System.EventHandler(this.comboBoxStatusOrders_SelectionChangeCommitted);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(16, 645);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewOrders.Location = new System.Drawing.Point(16, 33);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1280, 331);
            this.dataGridViewOrders.TabIndex = 9;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idOrder";
            this.Column1.HeaderText = "Номер заявки";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dateOrder";
            this.Column2.HeaderText = "Дата оформления";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nameCompany";
            this.Column3.HeaderText = "Организация";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nameStatusOrder";
            this.Column4.HeaderText = "Статус заявки";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cost";
            this.Column5.HeaderText = "Стоимость";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "fioManager";
            this.Column6.HeaderText = "Менеджер";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "idStaff";
            this.Column7.HeaderText = "Номер менеджера";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Text = "Отклонить";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Text = "Взять в работу";
            this.Column9.UseColumnTextForButtonValue = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Text = "Акт";
            this.Column10.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewOrderInfo
            // 
            this.dataGridViewOrderInfo.AllowUserToAddRows = false;
            this.dataGridViewOrderInfo.AllowUserToDeleteRows = false;
            this.dataGridViewOrderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrderInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dataGridViewOrderInfo.Location = new System.Drawing.Point(8, 23);
            this.dataGridViewOrderInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewOrderInfo.Name = "dataGridViewOrderInfo";
            this.dataGridViewOrderInfo.ReadOnly = true;
            this.dataGridViewOrderInfo.RowHeadersWidth = 51;
            this.dataGridViewOrderInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderInfo.Size = new System.Drawing.Size(1264, 223);
            this.dataGridViewOrderInfo.TabIndex = 10;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "nameEquipment";
            this.Column11.HeaderText = "Наименование оборудования";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "nameTypeEquipment";
            this.Column12.HeaderText = "Тип оборудования";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "count";
            this.Column13.HeaderText = "Количество";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "explanation";
            this.Column14.HeaderText = "Обоснование";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "idEquipmentOnOrder";
            this.Column15.HeaderText = "Номер записи";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "idEquipment";
            this.Column16.HeaderText = "Номер оборудования";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            // 
            // groupBoxOrderInfo
            // 
            this.groupBoxOrderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOrderInfo.Controls.Add(this.dataGridViewOrderInfo);
            this.groupBoxOrderInfo.Location = new System.Drawing.Point(16, 372);
            this.groupBoxOrderInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOrderInfo.Name = "groupBoxOrderInfo";
            this.groupBoxOrderInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOrderInfo.Size = new System.Drawing.Size(1280, 266);
            this.groupBoxOrderInfo.TabIndex = 11;
            this.groupBoxOrderInfo.TabStop = false;
            this.groupBoxOrderInfo.Text = "Состав заявки";
            // 
            // labelFindStatus
            // 
            this.labelFindStatus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelFindStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFindStatus.Location = new System.Drawing.Point(392, 176);
            this.labelFindStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFindStatus.Name = "labelFindStatus";
            this.labelFindStatus.Size = new System.Drawing.Size(533, 49);
            this.labelFindStatus.TabIndex = 12;
            this.labelFindStatus.Text = "Ничего не найдено";
            this.labelFindStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFindStatus.Visible = false;
            // 
            // saveFileDialogAct
            // 
            this.saveFileDialogAct.FileName = "Акт";
            this.saveFileDialogAct.Filter = "Excel Files|*.xlsx;*.xls";
            // 
            // menuStripManagerOrdder
            // 
            this.menuStripManagerOrdder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripManagerOrdder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.документToolStripMenuItem});
            this.menuStripManagerOrdder.Location = new System.Drawing.Point(0, 0);
            this.menuStripManagerOrdder.Name = "menuStripManagerOrdder";
            this.menuStripManagerOrdder.Size = new System.Drawing.Size(1312, 28);
            this.menuStripManagerOrdder.TabIndex = 13;
            this.menuStripManagerOrdder.Text = "menuStrip1";
            // 
            // saveFileDialogOrderInfo
            // 
            this.saveFileDialogOrderInfo.FileName = "Состав заявки";
            this.saveFileDialogOrderInfo.Filter = "Text Files|*.docx;*.PDF";
            // 
            // документToolStripMenuItem
            // 
            this.документToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.составЗаявкиToolStripMenuItem});
            this.документToolStripMenuItem.Name = "документToolStripMenuItem";
            this.документToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.документToolStripMenuItem.Text = "Документ";
            // 
            // составЗаявкиToolStripMenuItem
            // 
            this.составЗаявкиToolStripMenuItem.Name = "составЗаявкиToolStripMenuItem";
            this.составЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.составЗаявкиToolStripMenuItem.Text = "Состав заявки";
            this.составЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.составЗаявкиToolStripMenuItem_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.labelFindStatus);
            this.Controls.Add(this.groupBoxOrderInfo);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxStatusOrders);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStripManagerOrdder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripManagerOrdder;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1326, 726);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderInfo)).EndInit();
            this.groupBoxOrderInfo.ResumeLayout(false);
            this.menuStripManagerOrdder.ResumeLayout(false);
            this.menuStripManagerOrdder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboBoxStatusOrders;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrderInfo;
        private System.Windows.Forms.GroupBox groupBoxOrderInfo;
        private System.Windows.Forms.Label labelFindStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.SaveFileDialog saveFileDialogAct;
        private System.Windows.Forms.MenuStrip menuStripManagerOrdder;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOrderInfo;
        private System.Windows.Forms.ToolStripMenuItem документToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составЗаявкиToolStripMenuItem;
    }
}