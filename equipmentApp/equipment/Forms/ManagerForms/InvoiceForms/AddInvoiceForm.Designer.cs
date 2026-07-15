namespace equipment.Forms.ManagerForms.InvoiceForms
{
    partial class AddInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInvoiceForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.comboBoxVendor = new System.Windows.Forms.ComboBox();
            this.labelVendor = new System.Windows.Forms.Label();
            this.dateTimePickerDateOrder = new System.Windows.Forms.DateTimePicker();
            this.labelDateOrder = new System.Windows.Forms.Label();
            this.groupBoxOrderInfo = new System.Windows.Forms.GroupBox();
            this.dataGridViewInvoiceInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripInvoice = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceInfo)).BeginInit();
            this.menuStripInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(1122, 337);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 31);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(15, 337);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 31);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Отменить";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOrder.Controls.Add(this.comboBoxVendor);
            this.groupBoxOrder.Controls.Add(this.labelVendor);
            this.groupBoxOrder.Controls.Add(this.dateTimePickerDateOrder);
            this.groupBoxOrder.Controls.Add(this.labelDateOrder);
            this.groupBoxOrder.Location = new System.Drawing.Point(15, 15);
            this.groupBoxOrder.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOrder.Size = new System.Drawing.Size(1213, 71);
            this.groupBoxOrder.TabIndex = 15;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Информация о накладной";
            // 
            // comboBoxVendor
            // 
            this.comboBoxVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVendor.FormattingEnabled = true;
            this.comboBoxVendor.Location = new System.Drawing.Point(248, 37);
            this.comboBoxVendor.Name = "comboBoxVendor";
            this.comboBoxVendor.Size = new System.Drawing.Size(199, 24);
            this.comboBoxVendor.TabIndex = 3;
            // 
            // labelVendor
            // 
            this.labelVendor.AutoSize = true;
            this.labelVendor.Location = new System.Drawing.Point(245, 19);
            this.labelVendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendor.Name = "labelVendor";
            this.labelVendor.Size = new System.Drawing.Size(79, 16);
            this.labelVendor.TabIndex = 2;
            this.labelVendor.Text = "Поставщик";
            // 
            // dateTimePickerDateOrder
            // 
            this.dateTimePickerDateOrder.Location = new System.Drawing.Point(8, 39);
            this.dateTimePickerDateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDateOrder.Name = "dateTimePickerDateOrder";
            this.dateTimePickerDateOrder.Size = new System.Drawing.Size(199, 22);
            this.dateTimePickerDateOrder.TabIndex = 1;
            // 
            // labelDateOrder
            // 
            this.labelDateOrder.AutoSize = true;
            this.labelDateOrder.Location = new System.Drawing.Point(8, 20);
            this.labelDateOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOrder.Name = "labelDateOrder";
            this.labelDateOrder.Size = new System.Drawing.Size(125, 16);
            this.labelDateOrder.TabIndex = 0;
            this.labelDateOrder.Text = "Дата оформления";
            // 
            // groupBoxOrderInfo
            // 
            this.groupBoxOrderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOrderInfo.Controls.Add(this.dataGridViewInvoiceInfo);
            this.groupBoxOrderInfo.Controls.Add(this.menuStripInvoice);
            this.groupBoxOrderInfo.Location = new System.Drawing.Point(15, 86);
            this.groupBoxOrderInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOrderInfo.Name = "groupBoxOrderInfo";
            this.groupBoxOrderInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOrderInfo.Size = new System.Drawing.Size(1213, 244);
            this.groupBoxOrderInfo.TabIndex = 14;
            this.groupBoxOrderInfo.TabStop = false;
            this.groupBoxOrderInfo.Text = "Состав накладной";
            // 
            // dataGridViewInvoiceInfo
            // 
            this.dataGridViewInvoiceInfo.AllowUserToAddRows = false;
            this.dataGridViewInvoiceInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInvoiceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInvoiceInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoiceInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInvoiceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoiceInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewInvoiceInfo.Location = new System.Drawing.Point(8, 53);
            this.dataGridViewInvoiceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInvoiceInfo.Name = "dataGridViewInvoiceInfo";
            this.dataGridViewInvoiceInfo.ReadOnly = true;
            this.dataGridViewInvoiceInfo.RowHeadersWidth = 51;
            this.dataGridViewInvoiceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoiceInfo.Size = new System.Drawing.Size(1197, 183);
            this.dataGridViewInvoiceInfo.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nameEquipment";
            this.Column1.HeaderText = "Наименование оборудования";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nameTypeEquipment";
            this.Column2.HeaderText = "Тип оборудования";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "count";
            this.Column3.HeaderText = "Количество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "idEquipmentOnInvoice";
            this.Column4.HeaderText = "Номер записи";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idEquipment";
            this.Column5.HeaderText = "Номер оборудования";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // menuStripInvoice
            // 
            this.menuStripInvoice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStripInvoice.Location = new System.Drawing.Point(4, 19);
            this.menuStripInvoice.Name = "menuStripInvoice";
            this.menuStripInvoice.Size = new System.Drawing.Size(1205, 28);
            this.menuStripInvoice.TabIndex = 1;
            this.menuStripInvoice.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // AddInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 383);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.groupBoxOrderInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1263, 430);
            this.Name = "AddInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление накладной";
            this.Load += new System.EventHandler(this.AddInvoiceForm_Load);
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.groupBoxOrderInfo.ResumeLayout(false);
            this.groupBoxOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceInfo)).EndInit();
            this.menuStripInvoice.ResumeLayout(false);
            this.menuStripInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOrder;
        private System.Windows.Forms.Label labelDateOrder;
        private System.Windows.Forms.GroupBox groupBoxOrderInfo;
        private System.Windows.Forms.DataGridView dataGridViewInvoiceInfo;
        private System.Windows.Forms.MenuStrip menuStripInvoice;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label labelVendor;
        private System.Windows.Forms.ComboBox comboBoxVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}