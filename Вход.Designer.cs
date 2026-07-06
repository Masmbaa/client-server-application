namespace курсач
{
    partial class Vhod
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_vh = new Button();
            CNILC_vh = new Label();
            textBox_vh = new TextBox();
            SuspendLayout();
            // 
            // btn_vh
            // 
            btn_vh.Location = new Point(32, 71);
            btn_vh.Margin = new Padding(3, 2, 3, 2);
            btn_vh.Name = "btn_vh";
            btn_vh.Size = new Size(172, 22);
            btn_vh.TabIndex = 0;
            btn_vh.Text = "Войти";
            btn_vh.UseVisualStyleBackColor = true;
            btn_vh.Click += btn_vh_Click;
            // 
            // CNILC_vh
            // 
            CNILC_vh.AutoSize = true;
            CNILC_vh.Location = new Point(54, 22);
            CNILC_vh.Name = "CNILC_vh";
            CNILC_vh.Size = new Size(115, 15);
            CNILC_vh.TabIndex = 1;
            CNILC_vh.Text = "СНИЛС сотрудника";
            CNILC_vh.Click += label1_Click;
            // 
            // textBox_vh
            // 
            textBox_vh.Location = new Point(32, 39);
            textBox_vh.Margin = new Padding(3, 2, 3, 2);
            textBox_vh.Name = "textBox_vh";
            textBox_vh.Size = new Size(173, 23);
            textBox_vh.TabIndex = 2;
            // 
            // Vhod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 127);
            Controls.Add(textBox_vh);
            Controls.Add(CNILC_vh);
            Controls.Add(btn_vh);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Vhod";
            Text = "Вход";
            Load += Vhod_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_vh;
        private Label CNILC_vh;
        private TextBox textBox_vh;
    }
}
