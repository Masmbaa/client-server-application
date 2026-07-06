namespace курсач
{
    partial class Главная_оператора
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
            lblWelcome = new Label();
            lblMenu = new Label();
            btnTaskManagement = new Button();
            btnUAVStatus = new Button();
            btnSendCommands = new Button();
            btnKBLA = new Button();
            btnReports = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(12, 37);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(126, 15);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Выберете тип работы";
            // 
            // btnTaskManagement
            // 
            btnTaskManagement.Location = new Point(12, 55);
            btnTaskManagement.Name = "btnTaskManagement";
            btnTaskManagement.Size = new Size(204, 23);
            btnTaskManagement.TabIndex = 2;
            btnTaskManagement.Text = "Управление задачами ";
            btnTaskManagement.UseVisualStyleBackColor = true;
            btnTaskManagement.Click += btnTaskManagement_Click;
            // 
            // btnUAVStatus
            // 
            btnUAVStatus.Location = new Point(12, 84);
            btnUAVStatus.Name = "btnUAVStatus";
            btnUAVStatus.Size = new Size(204, 23);
            btnUAVStatus.TabIndex = 3;
            btnUAVStatus.Text = "Контроль состояния";
            btnUAVStatus.UseVisualStyleBackColor = true;
            btnUAVStatus.Click += btnUAVStatus_Click;
            // 
            // btnSendCommands
            // 
            btnSendCommands.Location = new Point(12, 113);
            btnSendCommands.Name = "btnSendCommands";
            btnSendCommands.Size = new Size(204, 23);
            btnSendCommands.TabIndex = 4;
            btnSendCommands.Text = "Отправка команд";
            btnSendCommands.UseVisualStyleBackColor = true;
            btnSendCommands.Click += btnSendCommands_Click;
            // 
            // btnKBLA
            // 
            btnKBLA.Location = new Point(13, 142);
            btnKBLA.Name = "btnKBLA";
            btnKBLA.Size = new Size(203, 23);
            btnKBLA.TabIndex = 6;
            btnKBLA.Text = "Работа с КБЛА";
            btnKBLA.UseVisualStyleBackColor = true;
            btnKBLA.Click += btnKBLA_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(12, 171);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(204, 23);
            btnReports.TabIndex = 7;
            btnReports.Text = "Генерация отчетов";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(77, 200);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Главная_оператора
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 231);
            Controls.Add(btnExit);
            Controls.Add(btnReports);
            Controls.Add(btnKBLA);
            Controls.Add(btnSendCommands);
            Controls.Add(btnUAVStatus);
            Controls.Add(btnTaskManagement);
            Controls.Add(lblMenu);
            Controls.Add(lblWelcome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Главная_оператора";
            Text = "Главная";
            Load += Главная_оператора_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblMenu;
        private Button btnTaskManagement;
        private Button btnUAVStatus;
        private Button btnSendCommands;
        private Button btnKBLA;
        private Button btnReports;
        private Button btnExit;
    }
}