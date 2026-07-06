namespace курсач
{
    partial class Работа_сКБЛА
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
            dataGridViewKBLA = new DataGridView();
            btn_AddKBLA = new Button();
            btn_up_trg = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKBLA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewKBLA
            // 
            dataGridViewKBLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKBLA.Dock = DockStyle.Top;
            dataGridViewKBLA.Location = new Point(0, 0);
            dataGridViewKBLA.Name = "dataGridViewKBLA";
            dataGridViewKBLA.Size = new Size(800, 395);
            dataGridViewKBLA.TabIndex = 0;
            // 
            // btn_AddKBLA
            // 
            btn_AddKBLA.Location = new Point(12, 415);
            btn_AddKBLA.Name = "btn_AddKBLA";
            btn_AddKBLA.Size = new Size(117, 23);
            btn_AddKBLA.TabIndex = 1;
            btn_AddKBLA.Text = "Добавить КБЛА";
            btn_AddKBLA.UseVisualStyleBackColor = true;
            btn_AddKBLA.Click += btn_AddKBLA_Click;
            // 
            // btn_up_trg
            // 
            btn_up_trg.Location = new Point(145, 415);
            btn_up_trg.Name = "btn_up_trg";
            btn_up_trg.Size = new Size(179, 23);
            btn_up_trg.TabIndex = 2;
            btn_up_trg.Text = "Обновление статуса КБЛА";
            btn_up_trg.UseVisualStyleBackColor = true;
            btn_up_trg.Click += btn_up_trg_Click;
            // 
            // Работа_сКБЛА
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_up_trg);
            Controls.Add(btn_AddKBLA);
            Controls.Add(dataGridViewKBLA);
            Name = "Работа_сКБЛА";
            Text = "Работа с КБЛА";
            Load += Работа_сКБЛА_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKBLA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewKBLA;
        private Button btn_AddKBLA;
        private Button btn_up_trg;
    }
}