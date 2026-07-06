namespace курсач
{
    partial class Изменить_статус_задачи
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
            lblTaskInfo = new Label();
            comboBoчStatus = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTaskInfo
            // 
            lblTaskInfo.AutoSize = true;
            lblTaskInfo.Location = new Point(12, 9);
            lblTaskInfo.Name = "lblTaskInfo";
            lblTaskInfo.Size = new Size(38, 15);
            lblTaskInfo.TabIndex = 0;
            lblTaskInfo.Text = "label1";
            // 
            // comboBoчStatus
            // 
            comboBoчStatus.FormattingEnabled = true;
            comboBoчStatus.Location = new Point(12, 94);
            comboBoчStatus.Name = "comboBoчStatus";
            comboBoчStatus.Size = new Size(121, 23);
            comboBoчStatus.TabIndex = 1;
            comboBoчStatus.SelectedIndexChanged += comboBoчStatus_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(160, 94);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Изменить_статус_задачи
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 189);
            Controls.Add(btnSave);
            Controls.Add(comboBoчStatus);
            Controls.Add(lblTaskInfo);
            Name = "Изменить_статус_задачи";
            Text = "Изменить статус";
            Load += Изменить_статус_задачи_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskInfo;
        private ComboBox comboBoчStatus;
        private Button btnSave;
    }
}