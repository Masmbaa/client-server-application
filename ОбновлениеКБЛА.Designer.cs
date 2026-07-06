namespace курсач
{
    partial class ОбновлениеКБЛА
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
            lblCurrentState = new Label();
            comboBoxStates = new ComboBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCurrentState
            // 
            lblCurrentState.AutoSize = true;
            lblCurrentState.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCurrentState.Location = new Point(23, 23);
            lblCurrentState.Margin = new Padding(4, 0, 4, 0);
            lblCurrentState.Name = "lblCurrentState";
            lblCurrentState.Size = new Size(143, 17);
            lblCurrentState.TabIndex = 0;
            lblCurrentState.Text = "Текущее состояние:";
            // 
            // comboBoxStates
            // 
            comboBoxStates.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStates.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxStates.FormattingEnabled = true;
            comboBoxStates.Location = new Point(27, 69);
            comboBoxStates.Margin = new Padding(4, 3, 4, 3);
            comboBoxStates.Name = "comboBoxStates";
            comboBoxStates.Size = new Size(291, 24);
            comboBoxStates.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnUpdate.Location = new Point(27, 127);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(178, 127);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ОбновлениеКБЛА
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(350, 185);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(comboBoxStates);
            Controls.Add(lblCurrentState);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ОбновлениеКБЛА";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Обновление состояния КБЛА";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.ComboBox comboBoxStates;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}