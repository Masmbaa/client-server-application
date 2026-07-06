namespace курсач
{
    partial class Контроль_состояния
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
            dataGridViewSostoinie = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSostoinie).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSostoinie
            // 
            dataGridViewSostoinie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSostoinie.Dock = DockStyle.Fill;
            dataGridViewSostoinie.Location = new Point(0, 0);
            dataGridViewSostoinie.Name = "dataGridViewSostoinie";
            dataGridViewSostoinie.Size = new Size(531, 450);
            dataGridViewSostoinie.TabIndex = 0;
            // 
            // Контроль_состояния
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 450);
            Controls.Add(dataGridViewSostoinie);
            Name = "Контроль_состояния";
            Text = "Контроль сотояния КБЛА";
            Load += Контроль_состояния_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSostoinie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSostoinie;
    }
}