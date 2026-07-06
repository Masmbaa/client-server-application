namespace курсач
{
    partial class Отчет
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
            comboBoxReportType = new ComboBox();
            dataGridViewReport = new DataGridView();
            lblReportTitle = new Label();
            btnGenerateReport = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxReportType
            // 
            comboBoxReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReportType.Font = new Font("Segoe UI", 10F);
            comboBoxReportType.FormattingEnabled = true;
            comboBoxReportType.Location = new Point(12, 12);
            comboBoxReportType.Name = "comboBoxReportType";
            comboBoxReportType.Size = new Size(250, 25);
            comboBoxReportType.TabIndex = 0;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AllowUserToAddRows = false;
            dataGridViewReport.AllowUserToDeleteRows = false;
            dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReport.BackgroundColor = SystemColors.Window;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Dock = DockStyle.Fill;
            dataGridViewReport.Location = new Point(0, 50);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.ReadOnly = true;
            dataGridViewReport.Size = new Size(698, 362);
            dataGridViewReport.TabIndex = 1;
            // 
            // lblReportTitle
            // 
            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReportTitle.Location = new Point(12, 10);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(0, 21);
            lblReportTitle.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Font = new Font("Segoe UI", 10F);
            btnGenerateReport.Location = new Point(268, 10);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(170, 30);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Сформировать отчет";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxReportType);
            panel1.Controls.Add(btnGenerateReport);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 50);
            panel1.TabIndex = 5;
            // 
            // Отчет
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 412);
            Controls.Add(dataGridViewReport);
            Controls.Add(panel1);
            Name = "Отчет";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Генератор отчетов";
            Load += Отчет_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxReportType;
        private DataGridView dataGridViewReport;
        private Label lblReportTitle;
        private Button btnGenerateReport;
        private Panel panel1;
    }
}