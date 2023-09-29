namespace WinFormsApp1
{
    partial class Form2
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

        private void InitializeComponent()
        {
            label = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(69, 103);
            label.Name = "label";
            label.Size = new Size(802, 32);
            label.TabIndex = 0;
            label.Text = "Алгоритм находит минимальное и максимальное число из заданных";
            // 
            // Form2
            // 
            ClientSize = new Size(986, 253);
            Controls.Add(label);
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label;

    }
}