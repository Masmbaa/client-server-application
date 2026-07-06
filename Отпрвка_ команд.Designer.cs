namespace курсач
{
    partial class Отправка_команд
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
            dataGridViewCommand = new DataGridView();
            btn_new_com = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommand).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCommand
            // 
            dataGridViewCommand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCommand.Dock = DockStyle.Top;
            dataGridViewCommand.Location = new Point(0, 0);
            dataGridViewCommand.Name = "dataGridViewCommand";
            dataGridViewCommand.Size = new Size(479, 281);
            dataGridViewCommand.TabIndex = 0;
            dataGridViewCommand.CellContentClick += dataGridViewCommand_CellContentClick;
            // 
            // btn_new_com
            // 
            btn_new_com.Location = new Point(12, 297);
            btn_new_com.Name = "btn_new_com";
            btn_new_com.Size = new Size(137, 28);
            btn_new_com.TabIndex = 1;
            btn_new_com.Text = "Добавить команду";
            btn_new_com.UseVisualStyleBackColor = true;
            btn_new_com.Click += btn_new_com_Click;
            // 
            // Отправка_команд
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 337);
            Controls.Add(btn_new_com);
            Controls.Add(dataGridViewCommand);
            Name = "Отправка_команд";
            Text = "Журнал команд";
            Load += Отправка_команд_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommand).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCommand;
        private Button btn_new_com;
    }
}