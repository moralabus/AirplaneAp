namespace AirplaneAp
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
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.buttonAddAirplane = new System.Windows.Forms.Button();
            this.buttonSortByFuelConsumption = new System.Windows.Forms.Button();
            this.listBoxAirplanes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(246, 45);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(321, 33);
            this.comboBoxModel.TabIndex = 0;
            this.comboBoxModel.Text = "выберите модель самолета";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(246, 121);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(321, 33);
            this.comboBoxCompany.TabIndex = 1;
            this.comboBoxCompany.Text = "выберите авиакомпанию";
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Location = new System.Drawing.Point(246, 84);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(321, 31);
            this.numericUpDownRange.TabIndex = 2;
            this.numericUpDownRange.Tag = "";
            // 
            // numericUpDownFuelConsumption
            // 
            this.numericUpDownFuelConsumption.Location = new System.Drawing.Point(246, 160);
            this.numericUpDownFuelConsumption.Name = "numericUpDownFuelConsumption";
            this.numericUpDownFuelConsumption.Size = new System.Drawing.Size(321, 31);
            this.numericUpDownFuelConsumption.TabIndex = 3;
            // 
            // buttonAddAirplane
            // 
            this.buttonAddAirplane.Location = new System.Drawing.Point(246, 197);
            this.buttonAddAirplane.Name = "buttonAddAirplane";
            this.buttonAddAirplane.Size = new System.Drawing.Size(321, 41);
            this.buttonAddAirplane.TabIndex = 5;
            this.buttonAddAirplane.Text = "добавить летучую бибику";
            this.buttonAddAirplane.UseVisualStyleBackColor = true;
            // 
            // buttonSortByFuelConsumption
            // 
            this.buttonSortByFuelConsumption.Location = new System.Drawing.Point(246, 244);
            this.buttonSortByFuelConsumption.Name = "buttonSortByFuelConsumption";
            this.buttonSortByFuelConsumption.Size = new System.Drawing.Size(321, 39);
            this.buttonSortByFuelConsumption.TabIndex = 6;
            this.buttonSortByFuelConsumption.Text = "сортировка самолетов ";
            this.buttonSortByFuelConsumption.UseVisualStyleBackColor = true;
            // 
            // listBoxAirplanes
            // 
            this.listBoxAirplanes.FormattingEnabled = true;
            this.listBoxAirplanes.ItemHeight = 25;
            this.listBoxAirplanes.Location = new System.Drawing.Point(246, 289);
            this.listBoxAirplanes.Name = "listBoxAirplanes";
            this.listBoxAirplanes.Size = new System.Drawing.Size(321, 79);
            this.listBoxAirplanes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.NumericUpDown numericUpDownRange;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelConsumption;
        private System.Windows.Forms.Button buttonAddAirplane;
        private System.Windows.Forms.Button buttonSortByFuelConsumption;
        private System.Windows.Forms.ListBox listBoxAirplanes;
    }
}

