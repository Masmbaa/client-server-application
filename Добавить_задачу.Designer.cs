namespace курсач
{
    partial class Добавить_задачу
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
            textBoxNameTask = new TextBox();
            lblNT = new Label();
            ColBeg = new Label();
            dateTimePickerBegin = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            lblEnd = new Label();
            comboBoxStatus = new ComboBox();
            lblsost = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // textBoxNameTask
            // 
            textBoxNameTask.Location = new Point(12, 27);
            textBoxNameTask.Name = "textBoxNameTask";
            textBoxNameTask.Size = new Size(180, 23);
            textBoxNameTask.TabIndex = 0;
            // 
            // lblNT
            // 
            lblNT.AutoSize = true;
            lblNT.Location = new Point(12, 9);
            lblNT.Name = "lblNT";
            lblNT.Size = new Size(75, 15);
            lblNT.TabIndex = 1;
            lblNT.Text = "Цель задачи";
            // 
            // ColBeg
            // 
            ColBeg.AutoSize = true;
            ColBeg.Location = new Point(12, 59);
            ColBeg.Name = "ColBeg";
            ColBeg.Size = new Size(77, 15);
            ColBeg.TabIndex = 3;
            ColBeg.Text = "Дата начала ";
            // 
            // dateTimePickerBegin
            // 
            dateTimePickerBegin.Location = new Point(12, 77);
            dateTimePickerBegin.Name = "dateTimePickerBegin";
            dateTimePickerBegin.Size = new Size(200, 23);
            dateTimePickerBegin.TabIndex = 4;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(12, 132);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 5;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(12, 114);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(95, 15);
            lblEnd.TabIndex = 6;
            lblEnd.Text = "Дата окончания";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(12, 188);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 7;
            // 
            // lblsost
            // 
            lblsost.AutoSize = true;
            lblsost.Location = new Point(12, 170);
            lblsost.Name = "lblsost";
            lblsost.Size = new Size(83, 15);
            lblsost.TabIndex = 8;
            lblsost.Text = "Статус задачи";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(155, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Добавить_задачу
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 230);
            Controls.Add(btnSave);
            Controls.Add(lblsost);
            Controls.Add(comboBoxStatus);
            Controls.Add(lblEnd);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerBegin);
            Controls.Add(ColBeg);
            Controls.Add(lblNT);
            Controls.Add(textBoxNameTask);
            Name = "Добавить_задачу";
            Text = "Добавить задачу";
            Load += Добавить_задачу_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNameTask;
        private Label lblNT;
        private Label ColBeg;
        private DateTimePicker dateTimePickerBegin;
        private DateTimePicker dateTimePickerEnd;
        private Label lblEnd;
        private ComboBox comboBoxStatus;
        private Label lblsost;
        private Button btnSave;
    }
}