namespace equipment.Forms.ManagerForms.InvoiceForms
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.groupBoxInvoiceInfo = new System.Windows.Forms.GroupBox();
            this.dataGridViewInvoiceInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.labelFindStatus = new System.Windows.Forms.Label();
            this.menuStripCustomerOrders = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.menuStripCustomerOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInvoiceInfo
            // 
            this.groupBoxInvoiceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInvoiceInfo.Controls.Add(this.dataGridViewInvoiceInfo);
            this.groupBoxInvoiceInfo.Location = new System.Drawing.Point(13, 377);
            this.groupBoxInvoiceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInvoiceInfo.Name = "groupBoxInvoiceInfo";
            this.groupBoxInvoiceInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInvoiceInfo.Size = new System.Drawing.Size(995, 250);
            this.groupBoxInvoiceInfo.TabIndex = 18;
            this.groupBoxInvoiceInfo.TabStop = false;
            this.groupBoxInvoiceInfo.Text = "Состав накладной";
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
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewInvoiceInfo.Location = new System.Drawing.Point(8, 23);
            this.dataGridViewInvoiceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInvoiceInfo.Name = "dataGridViewInvoiceInfo";
            this.dataGridViewInvoiceInfo.ReadOnly = true;
            this.dataGridViewInvoiceInfo.RowHeadersWidth = 51;
            this.dataGridViewInvoiceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoiceInfo.Size = new System.Drawing.Size(979, 220);
            this.dataGridViewInvoiceInfo.TabIndex = 15;
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewInvoice.Location = new System.Drawing.Point(13, 32);
            this.dataGridViewInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            this.dataGridViewInvoice.RowHeadersWidth = 51;
            this.dataGridViewInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(995, 337);
            this.dataGridViewInvoice.TabIndex = 17;
            this.dataGridViewInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoice_CellClick);
            // 
            // labelFindStatus
            // 
            this.labelFindStatus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelFindStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFindStatus.Location = new System.Drawing.Point(244, 176);
            this.labelFindStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFindStatus.Name = "labelFindStatus";
            this.labelFindStatus.Size = new System.Drawing.Size(533, 49);
            this.labelFindStatus.TabIndex = 20;
            this.labelFindStatus.Text = "Ничего не найдено";
            this.labelFindStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFindStatus.Visible = false;
            // 
            // menuStripCustomerOrders
            // 
            this.menuStripCustomerOrders.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCustomerOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStripCustomerOrders.Location = new System.Drawing.Point(0, 0);
            this.menuStripCustomerOrders.Name = "menuStripCustomerOrders";
            this.menuStripCustomerOrders.Size = new System.Drawing.Size(1021, 28);
            this.menuStripCustomerOrders.TabIndex = 19;
            this.menuStripCustomerOrders.Text = "menuStrip1";
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
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(13, 635);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 31);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idInvoice";
            this.Column1.HeaderText = "Номер накладной";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dateInvoice";
            this.Column2.HeaderText = "Дата поступления";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nameVendor";
            this.Column3.HeaderText = "Поставщик";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "idVendor";
            this.Column4.HeaderText = "Номер поставщика";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nameEquipment";
            this.Column5.HeaderText = "Наименование оборудования";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nameTypeEquipment";
            this.Column6.HeaderText = "Тип оборудования";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "count";
            this.Column7.HeaderText = "Количество";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "idEquipmentOnInvoice";
            this.Column8.HeaderText = "Номер записи";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "idEquipment";
            this.Column9.HeaderText = "Номер оборудования";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 679);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelFindStatus);
            this.Controls.Add(this.menuStripCustomerOrders);
            this.Controls.Add(this.groupBoxInvoiceInfo);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1039, 726);
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накладные";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.groupBoxInvoiceInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.menuStripCustomerOrders.ResumeLayout(false);
            this.menuStripCustomerOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInvoiceInfo;
        private System.Windows.Forms.DataGridView dataGridViewInvoiceInfo;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Label labelFindStatus;
        private System.Windows.Forms.MenuStrip menuStripCustomerOrders;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}