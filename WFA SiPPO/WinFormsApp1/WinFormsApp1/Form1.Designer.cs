using System.Diagnostics.Metrics;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            sumToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            readFromFileToolStripMenuItem = new ToolStripMenuItem();
            addResultToFileToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            numericUpDown1 = new NumericUpDown();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            chart1 = new Chart();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            textBox5 = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(2, 1, 0, 1);
            menuStrip1.Size = new Size(1366, 26);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sumToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // sumToolStripMenuItem
            // 
            sumToolStripMenuItem.Name = "sumToolStripMenuItem";
            sumToolStripMenuItem.Size = new Size(143, 26);
            sumToolStripMenuItem.Text = "Решить";
            sumToolStripMenuItem.Click += sumToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(143, 26);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { readFromFileToolStripMenuItem, addResultToFileToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(158, 24);
            actionsToolStripMenuItem.Text = "Действия с файлом";
            // 
            // readFromFileToolStripMenuItem
            // 
            readFromFileToolStripMenuItem.Name = "readFromFileToolStripMenuItem";
            readFromFileToolStripMenuItem.Size = new Size(327, 26);
            readFromFileToolStripMenuItem.Text = "Прочитать из файла";
            readFromFileToolStripMenuItem.Click += readFromFileToolStripMenuItem_Click;
            // 
            // addResultToFileToolStripMenuItem
            // 
            addResultToFileToolStripMenuItem.Name = "addResultToFileToolStripMenuItem";
            addResultToFileToolStripMenuItem.Size = new Size(327, 26);
            addResultToFileToolStripMenuItem.Text = "Записать ответ в файл 'Результат' ";
            addResultToFileToolStripMenuItem.Click += addResultToFileToolStripMenuItem_Click;

            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(74, 588);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(156, 42);
            button1.TabIndex = 9;
            button1.Text = "О программе";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Enabled = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(1022, 449);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(221, 52);
            button2.TabIndex = 12;
            button2.Text = "Решить алгоритм";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(1022, 539);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(221, 91);
            button3.TabIndex = 12;
            button3.Text = "Вычислить значения";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(83, 140);
            button4.Name = "button4";
            button4.Size = new Size(220, 50);
            button4.TabIndex = 3;
            button4.Text = "Старт";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(499, 140);
            button5.Name = "button5";
            button5.Size = new Size(151, 50);
            button5.TabIndex = 4;
            button5.Text = "Очистить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            button5.Hide();
            // 
            // button6
            // 
            button6.Location = new Point(41, 206);
            button6.Name = "button6";
            button6.Size = new Size(151, 50);
            button6.TabIndex = 16;
            button6.Text = "Старт";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(319, 206);
            button7.Name = "button7";
            button7.Size = new Size(151, 50);
            button7.TabIndex = 17;
            button7.Text = "Стоп";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(626, 206);
            button8.Name = "button8";
            button8.Size = new Size(151, 50);
            button8.TabIndex = 18;
            button8.Text = "Очистить";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(391, 129);
            button9.Name = "button9";
            button9.Size = new Size(221, 52);
            button9.TabIndex = 16;
            button9.Text = "Запустить";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;

            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(220, 429);
            numericUpDown1.Margin = new Padding(1);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(107, 39);
            numericUpDown1.TabIndex = 8;

            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(20, 386);
            radioButton1.Margin = new Padding(1);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(168, 41);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Умножить";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(20, 429);
            radioButton2.Margin = new Padding(1);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(129, 41);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Делить";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(20, 472);
            radioButton3.Margin = new Padding(1);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(143, 41);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Вычесть";
            radioButton3.UseVisualStyleBackColor = true;

            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(356, 386);
            checkBox1.Margin = new Padding(1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(228, 41);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Умножить на 3";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(356, 472);
            checkBox2.Margin = new Padding(1);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(228, 41);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Умножить на 2";
            checkBox2.UseVisualStyleBackColor = true;

            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;

            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(3, 5);
            chart1.Name = "chart1";
            chart1.Palette = ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Синусоида";
            chart1.Series.Add(series1);
            chart1.Size = new Size(809, 195);
            chart1.TabIndex = 19;
            chart1.Text = "chart1";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 37);
            label1.TabIndex = 0;
            label1.Text = "Введите A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(480, 23);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 37);
            label2.TabIndex = 1;
            label2.Text = "Введите B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 104);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 37);
            label3.TabIndex = 2;
            label3.Text = "Введите C:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(477, 104);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 37);
            label4.TabIndex = 3;
            label4.Text = "Введите D:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1, 2);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 37);
            label5.TabIndex = 4;
            label5.Text = "Результат:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 52);
            label6.Name = "label6";
            label6.Size = new Size(90, 37);
            label6.TabIndex = 0;
            label6.Text = minutes.ToString();

            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(176, 23);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 43);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(641, 98);
            textBox2.Margin = new Padding(1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 43);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(176, 98);
            textBox3.Margin = new Padding(1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 43);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(641, 20);
            textBox4.Margin = new Padding(1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 43);
            textBox4.TabIndex = 8;
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(50, 33);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(867, 43);
            textBox5.TabIndex = 17;

            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(20, 39);
            tabControl1.Margin = new Padding(2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(974, 327);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 46);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(966, 277);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Данные";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 46);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(966, 277);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Результат";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button4);
            tabPage3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 46);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(966, 277);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Таймер/Время";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(chart1);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(button8);
            tabPage4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(966, 277);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "График";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(textBox5);
            tabPage5.Controls.Add(button9);
            tabPage5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage5.Location = new Point(4, 46);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(966, 277);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Поток";
           
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1366, 1055);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(menuStrip1);
            Controls.Add(numericUpDown1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem sumToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;


        private NumericUpDown numericUpDown1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;

        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem addResultToFileToolStripMenuItem;
        private ToolStripMenuItem readFromFileToolStripMenuItem;


        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private TabPage tabPage4;
        private Chart chart1;
        private Button button6;
        private Button button7;
        private Button button8;
        private TabPage tabPage3;
        private Label label6;
        private Button button5;
        private Button button4;
        private TabPage tabPage2;
        private Label label5;
        private TabPage tabPage1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private TabControl tabControl1;
        private Button button9;
        private TextBox textBox5;
        private TabPage tabPage5;
    }
}