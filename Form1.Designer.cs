namespace AirplaneAp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAirplanes = new System.Windows.Forms.ListBox();
            this.buttonSortByFuelConsumption = new System.Windows.Forms.Button();
            this.buttonAddAirplane = new System.Windows.Forms.Button();
            this.numericUpDownFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.textBoxAirplaneName = new System.Windows.Forms.TextBox();
            this.dateTimePickerManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAirplanes
            // 
            this.listBoxAirplanes.FormattingEnabled = true;
            this.listBoxAirplanes.ItemHeight = 25;
            this.listBoxAirplanes.Location = new System.Drawing.Point(235, 381);
            this.listBoxAirplanes.Name = "listBoxAirplanes";
            this.listBoxAirplanes.Size = new System.Drawing.Size(321, 79);
            this.listBoxAirplanes.TabIndex = 23;
            // 
            // buttonSortByFuelConsumption
            // 
            this.buttonSortByFuelConsumption.Location = new System.Drawing.Point(235, 336);
            this.buttonSortByFuelConsumption.Name = "buttonSortByFuelConsumption";
            this.buttonSortByFuelConsumption.Size = new System.Drawing.Size(321, 39);
            this.buttonSortByFuelConsumption.TabIndex = 22;
            this.buttonSortByFuelConsumption.Text = "сортировка самолетов ";
            this.buttonSortByFuelConsumption.UseVisualStyleBackColor = true;
            // 
            // buttonAddAirplane
            // 
            this.buttonAddAirplane.Location = new System.Drawing.Point(235, 289);
            this.buttonAddAirplane.Name = "buttonAddAirplane";
            this.buttonAddAirplane.Size = new System.Drawing.Size(321, 41);
            this.buttonAddAirplane.TabIndex = 21;
            this.buttonAddAirplane.Text = "добавить летучую бибику";
            this.buttonAddAirplane.UseVisualStyleBackColor = true;
            
            // 
            this.numericUpDownFuelConsumption.Location = new System.Drawing.Point(455, 214);
            this.numericUpDownFuelConsumption.Name = "numericUpDownFuelConsumption";
            this.numericUpDownFuelConsumption.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownFuelConsumption.TabIndex = 20;
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Location = new System.Drawing.Point(455, 138);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownRange.TabIndex = 19;
            this.numericUpDownRange.Tag = "";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(235, 175);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(321, 33);
            this.comboBoxCompany.TabIndex = 18;
            this.comboBoxCompany.Text = "выберите авиакомпанию";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(235, 99);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(321, 33);
            this.comboBoxModel.TabIndex = 17;
            this.comboBoxModel.Text = "выберите модель самолета";
            // 
            // textBoxAirplaneName
            // 
            this.textBoxAirplaneName.Location = new System.Drawing.Point(235, 62);
            this.textBoxAirplaneName.Name = "textBoxAirplaneName";
            this.textBoxAirplaneName.Size = new System.Drawing.Size(321, 31);
            this.textBoxAirplaneName.TabIndex = 26;
            this.textBoxAirplaneName.Text = "Имя самолета";
            
            // 
            // dateTimePickerManufactureDate
            // 
            this.dateTimePickerManufactureDate.Location = new System.Drawing.Point(235, 251);
            this.dateTimePickerManufactureDate.Name = "dateTimePickerManufactureDate";
            this.dateTimePickerManufactureDate.Size = new System.Drawing.Size(321, 31);
            this.dateTimePickerManufactureDate.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 31);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "введите дальность";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 31);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "расход топлива";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePickerManufactureDate);
            this.Controls.Add(this.textBoxAirplaneName);
            this.Controls.Add(this.listBoxAirplanes);
            this.Controls.Add(this.buttonSortByFuelConsumption);
            this.Controls.Add(this.buttonAddAirplane);
            this.Controls.Add(this.numericUpDownFuelConsumption);
            this.Controls.Add(this.numericUpDownRange);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.comboBoxModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAirplanes;
        private System.Windows.Forms.Button buttonSortByFuelConsumption;
        private System.Windows.Forms.Button buttonAddAirplane;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelConsumption;
        private System.Windows.Forms.NumericUpDown numericUpDownRange;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.TextBox textBoxAirplaneName;
        private System.Windows.Forms.DateTimePicker dateTimePickerManufactureDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

