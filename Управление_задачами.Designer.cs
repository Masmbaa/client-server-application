namespace курсач
{
    partial class Управление_задачами
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
            dataGridViewTasks = new DataGridView();
            btnAddTask = new Button();
            btnUpdateStatus = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(0, 0);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.Size = new Size(745, 378);
            dataGridViewTasks.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddTask.Location = new Point(12, 384);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(120, 23);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Добавить задачу";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateStatus.Location = new Point(138, 384);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(163, 23);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Изменить статус задачи";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.Location = new Point(307, 384);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Управление_задачами
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 412);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnAddTask);
            Controls.Add(dataGridViewTasks);
            Name = "Управление_задачами";
            Text = "Управление_задачами";
            Load += Управление_задачами_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTasks;
        private Button btnAddTask;
        private Button btnUpdateStatus;
        private Button btnRefresh;
    }
}