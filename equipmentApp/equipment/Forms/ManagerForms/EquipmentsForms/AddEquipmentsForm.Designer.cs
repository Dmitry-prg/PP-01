namespace equipment.Forms.ManagerForms.EquipmentsForms
{
    partial class AddEquipmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEquipmentsForm));
            this.labelNameEquipment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameEquipment = new System.Windows.Forms.TextBox();
            this.txtPriceEquipment = new System.Windows.Forms.TextBox();
            this.comboBoxTypeEquipment = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtCountEquipment = new System.Windows.Forms.TextBox();
            this.labelCountEquipment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNameEquipment
            // 
            this.labelNameEquipment.AutoSize = true;
            this.labelNameEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameEquipment.Location = new System.Drawing.Point(12, 9);
            this.labelNameEquipment.Name = "labelNameEquipment";
            this.labelNameEquipment.Size = new System.Drawing.Size(180, 15);
            this.labelNameEquipment.TabIndex = 0;
            this.labelNameEquipment.Text = "Наименование оборудования";
            this.labelNameEquipment.Click += new System.EventHandler(this.labelNameEquipment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип оборудования";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNameEquipment
            // 
            this.txtNameEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameEquipment.Location = new System.Drawing.Point(12, 27);
            this.txtNameEquipment.Name = "txtNameEquipment";
            this.txtNameEquipment.Size = new System.Drawing.Size(175, 22);
            this.txtNameEquipment.TabIndex = 3;
            this.txtNameEquipment.TextChanged += new System.EventHandler(this.txtNameEquipment_TextChanged);
            // 
            // txtPriceEquipment
            // 
            this.txtPriceEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPriceEquipment.Location = new System.Drawing.Point(224, 27);
            this.txtPriceEquipment.MaxLength = 10;
            this.txtPriceEquipment.Name = "txtPriceEquipment";
            this.txtPriceEquipment.Size = new System.Drawing.Size(175, 22);
            this.txtPriceEquipment.TabIndex = 4;
            this.txtPriceEquipment.TextChanged += new System.EventHandler(this.txtPriceEquipment_TextChanged);
            this.txtPriceEquipment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceEquipment_KeyPress);
            // 
            // comboBoxTypeEquipment
            // 
            this.comboBoxTypeEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeEquipment.FormattingEnabled = true;
            this.comboBoxTypeEquipment.Location = new System.Drawing.Point(12, 70);
            this.comboBoxTypeEquipment.Name = "comboBoxTypeEquipment";
            this.comboBoxTypeEquipment.Size = new System.Drawing.Size(177, 24);
            this.comboBoxTypeEquipment.TabIndex = 5;
            this.comboBoxTypeEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeEquipment_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(321, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(12, 102);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Отменить";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCountEquipment
            // 
            this.txtCountEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountEquipment.Location = new System.Drawing.Point(224, 72);
            this.txtCountEquipment.MaxLength = 6;
            this.txtCountEquipment.Name = "txtCountEquipment";
            this.txtCountEquipment.Size = new System.Drawing.Size(175, 22);
            this.txtCountEquipment.TabIndex = 11;
            this.txtCountEquipment.TextChanged += new System.EventHandler(this.txtCountEquipment_TextChanged);
            this.txtCountEquipment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountEquipment_KeyPress);
            // 
            // labelCountEquipment
            // 
            this.labelCountEquipment.AutoSize = true;
            this.labelCountEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountEquipment.Location = new System.Drawing.Point(226, 54);
            this.labelCountEquipment.Name = "labelCountEquipment";
            this.labelCountEquipment.Size = new System.Drawing.Size(76, 15);
            this.labelCountEquipment.TabIndex = 10;
            this.labelCountEquipment.Text = "Количество";
            this.labelCountEquipment.Click += new System.EventHandler(this.labelCountEquipment_Click);
            // 
            // AddEquipmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 137);
            this.Controls.Add(this.txtCountEquipment);
            this.Controls.Add(this.labelCountEquipment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBoxTypeEquipment);
            this.Controls.Add(this.txtPriceEquipment);
            this.Controls.Add(this.txtNameEquipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNameEquipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEquipmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление оборудования";
            this.Load += new System.EventHandler(this.AddEquipmentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameEquipment;
        private System.Windows.Forms.TextBox txtPriceEquipment;
        private System.Windows.Forms.ComboBox comboBoxTypeEquipment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCountEquipment;
        private System.Windows.Forms.Label labelCountEquipment;
    }
}