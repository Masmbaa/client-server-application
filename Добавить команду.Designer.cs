namespace курсач
{
    partial class Добавить_команду
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
            label1 = new Label();
            comboBoxKBLA = new ComboBox();
            label2 = new Label();
            comboBoxCommand = new ComboBox();
            label3 = new Label();
            dateTimePickerStart = new DateTimePicker();
            label4 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            btnAddCommand = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "КБЛА:";
            // 
            // comboBoxKBLA
            // 
            comboBoxKBLA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKBLA.FormattingEnabled = true;
            comboBoxKBLA.Location = new Point(120, 12);
            comboBoxKBLA.Name = "comboBoxKBLA";
            comboBoxKBLA.Size = new Size(200, 23);
            comboBoxKBLA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Выберите команду:";
            // 
            // comboBoxCommand
            // 
            comboBoxCommand.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCommand.FormattingEnabled = true;
            comboBoxCommand.Location = new Point(120, 42);
            comboBoxCommand.Name = "comboBoxCommand";
            comboBoxCommand.Size = new Size(200, 23);
            comboBoxCommand.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "Время отправки:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(120, 72);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 6;
            label4.Text = "Время завершения:";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(120, 102);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 7;
            // 
            // btnAddCommand
            // 
            btnAddCommand.Location = new Point(120, 135);
            btnAddCommand.Name = "btnAddCommand";
            btnAddCommand.Size = new Size(95, 30);
            btnAddCommand.TabIndex = 8;
            btnAddCommand.Text = "Добавить";
            btnAddCommand.UseVisualStyleBackColor = true;
            btnAddCommand.Click += btnAddCommand_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(225, 135);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Добавить_команду
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 176);
            Controls.Add(btnCancel);
            Controls.Add(btnAddCommand);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(label4);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label3);
            Controls.Add(comboBoxCommand);
            Controls.Add(label2);
            Controls.Add(comboBoxKBLA);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Добавить_команду";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление команды";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKBLA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.Button btnCancel;
    }
}