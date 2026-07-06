namespace курсач
{
    partial class Добавить_КБЛА
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label2 = new Label();
            comboBoxTask = new ComboBox();
            label3 = new Label();
            comboBoxOrbit = new ComboBox();
            label4 = new Label();
            comboBoxType = new ComboBox();
            label5 = new Label();
            comboBoxStatus = new ComboBox();
            label6 = new Label();
            dateTimePickerLaunchDate = new DateTimePicker();
            label7 = new Label();
            textBoxManufacturer = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Задача:";
            // 
            // comboBoxTask
            // 
            comboBoxTask.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTask.FormattingEnabled = true;
            comboBoxTask.Location = new Point(120, 15);
            comboBoxTask.Name = "comboBoxTask";
            comboBoxTask.Size = new Size(250, 23);
            comboBoxTask.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 48);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Орбита:";
            // 
            // comboBoxOrbit
            // 
            comboBoxOrbit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrbit.FormattingEnabled = true;
            comboBoxOrbit.Location = new Point(120, 45);
            comboBoxOrbit.Name = "comboBoxOrbit";
            comboBoxOrbit.Size = new Size(250, 23);
            comboBoxOrbit.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 78);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Тип:";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(120, 75);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(250, 23);
            comboBoxType.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 108);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(120, 105);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(250, 23);
            comboBoxStatus.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 138);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 10;
            label6.Text = "Дата запуска:";
            // 
            // dateTimePickerLaunchDate
            // 
            dateTimePickerLaunchDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerLaunchDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerLaunchDate.Location = new Point(120, 135);
            dateTimePickerLaunchDate.Name = "dateTimePickerLaunchDate";
            dateTimePickerLaunchDate.Size = new Size(250, 23);
            dateTimePickerLaunchDate.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 168);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 12;
            label7.Text = "Производитель:";
            // 
            // textBoxManufacturer
            // 
            textBoxManufacturer.Location = new Point(120, 165);
            textBoxManufacturer.Name = "textBoxManufacturer";
            textBoxManufacturer.Size = new Size(250, 23);
            textBoxManufacturer.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(120, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 198);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 30);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Добавить_КБЛА
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 266);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textBoxManufacturer);
            Controls.Add(label7);
            Controls.Add(dateTimePickerLaunchDate);
            Controls.Add(label6);
            Controls.Add(comboBoxStatus);
            Controls.Add(label5);
            Controls.Add(comboBoxType);
            Controls.Add(label4);
            Controls.Add(comboBoxOrbit);
            Controls.Add(label3);
            Controls.Add(comboBoxTask);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Добавить_КБЛА";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление нового КБЛА";
            ResumeLayout(false);
            PerformLayout();
        }

        // Объявления элементов формы
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOrbit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerLaunchDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}