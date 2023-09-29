
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Threading;
using System.Diagnostics.CodeAnalysis;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private double angle;

        bool flag = false;
        int seconds = 0;
        int minutes;


        public Form1()
        {
            InitializeComponent();
            InstantiateMyNumericUpDown();

            label6.Parent = tabPage3;
            button4.Parent = tabPage3;
            button5.Parent = tabPage3;
            button6.Parent = tabPage4;
            button7.Parent = tabPage4;
            button8.Parent = tabPage4;

            timer1.Interval = 1000;
            timer2.Interval = 500;
            timer3.Interval = 1;
        }

        private void InstantiateMyNumericUpDown()
        {
            numericUpDown1.Value = 10;
            numericUpDown1.Maximum = 2500000;
            numericUpDown1.Minimum = -100;
            numericUpDown1.Increment = 0;
            numericUpDown1.ThousandsSeparator = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 aboutUs = new Form2();
            aboutUs.ShowDialog();
            //Закрываем окно
            Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int sum;

            int valueA, valueB, valueC, valueD;

            try
            {
                valueA = Convert.ToInt32(textBox1.Text);

                try
                {
                    valueB = Convert.ToInt32(textBox2.Text);

                    try
                    {
                        valueC = Convert.ToInt32(textBox3.Text);

                        try
                        {
                            valueD = Convert.ToInt32(textBox4.Text);
                            int[] mass = { valueA, valueB, valueC, valueD };

                            int max = mass[0];
                            int min = mass[0];
                            sum = valueA + valueB + valueC + valueD;

                            for (int i = 1; i < mass.Length; i++)
                            {
                                if (mass[i] > max)
                                {
                                    max = mass[i];
                                }

                                if (mass[i] < min)
                                {
                                    min = mass[i];
                                }
                            }

                            label5.Text = "\nСумма значений: " + sum + "\nMin значение: " + min.ToString() +
                                          "\nMax значение: " + max.ToString();

                            button2.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Введите D:");
                            textBox4.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите C:");
                        textBox3.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Введите B:");
                    textBox2.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Введите A:");
                textBox1.Focus();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Calculate();

            tabControl1.TabPages[1].Text = "Результат дополнен";
            tabControl1.TabPages[1].BackColor = Color.YellowGreen;

            Control control1 = button2 as Control;
            control1.Text = "Результат алгоритма";

            Control control2 = button2.Parent as Control;
            control2.BackColor = Color.LightGreen;

            Control control3 = textBox1 as Control;
            if (control3.CanFocus)
            {
                control3.Focus();
            }

            if (control3.Focused)
            {
                control1.Hide();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                button4.Text = "Старт";
                button5.Text = "Очистить";
                button5.Show();
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                button4.Text = "Стоп";
                button5.Hide();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = "00:00:00";
        }
        private void sumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int valueA, valueB, valueC, valueD;

            try
            {
                valueA = Convert.ToInt32(textBox1.Text);

                try
                {
                    valueB = Convert.ToInt32(textBox2.Text);

                    try
                    {
                        valueC = Convert.ToInt32(textBox3.Text);

                        try
                        {
                            valueD = Convert.ToInt32(textBox4.Text);
                            int[] mass = { valueA, valueB, valueC, valueD };

                            int max = mass[0];
                            int min = mass[0];

                            for (int i = 1; i < mass.Length; i++)
                            {
                                if (mass[i] > max)
                                {
                                    max = mass[i];
                                }

                                if (mass[i] < min)
                                {
                                    min = mass[i];
                                }
                            }

                            label5.Text = "Min: " + min.ToString() + "\nMax: " + max.ToString();

                            button1.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Введите D:");
                            textBox4.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите C:");
                        textBox3.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Введите B:");
                    textBox2.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Введите A:");
                textBox1.Focus();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            timer3.Stop();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (chart1 != null && chart1.Series.Count > 0 && chart1.Series[0] != null)
            {
                // Очищаем существующие точки путем удаления каждой точки в цикле
                for (int i = chart1.Series[0].Points.Count - 1; i >= 0; i--)
                {
                    chart1.Series[0].Points.RemoveAt(i);
                }
                chart1.Refresh();
            }
            else
            {
                chart1.Series.Clear(); // Очищаем все ранее созданные серии данных, если они есть
                var series = new Series(); // Создаем новую серию данных
                chart1.Series.Add(series); // Добавляем серию данных в объект chart1
                chart1.Refresh();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {

            Thread fib = new Thread(CalculateFibonacci);
            fib.Start();
        }

        private void Calculate()
        {
            int sum;

            int valueA, valueB, valueC, valueD, value;
            double divide;

            valueA = Convert.ToInt32(textBox1.Text);
            valueB = Convert.ToInt32(textBox2.Text);
            valueC = Convert.ToInt32(textBox3.Text);
            valueD = Convert.ToInt32(textBox4.Text);

            sum = valueA + valueB + valueC + valueD;
            value = (int)numericUpDown1.Value;

            if (radioButton1.Checked)
            {
                divide = sum * value;
                label5.Text = "Сумма значений: " + sum + "\nРезультат вычислений: " + divide.ToString();

                if (checkBox1.Checked)
                {
                    divide *= 3;
                    label5.Text = "Сумма значений: " + sum + "\nРезультат вычислений: " + divide.ToString();
                }

                if (checkBox2.Checked)
                {
                    divide *= 2;
                    label5.Text = "Сумма значений: " + sum + "\nРезультат вычислений: " + divide.ToString();
                }
            }
            else
            {
                if (radioButton2.Checked)
                {
                    divide = sum / value;
                    label5.Text = "Сумма значений: " + sum + "\nРезультат вычислений: " + divide.ToString();

                    if (checkBox1.Checked)
                    {
                        divide *= 3;
                        label5.Text = "Сумма значений: " + sum + "\nРезультат вычислений: " + divide.ToString();
                    }

                    if (checkBox2.Checked)
                    {
                        divide *= 2;
                        label5.Text = "Сумма значений: " + sum + "\nРезультат вычислений: " + divide.ToString();
                    }
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        divide = sum - value;
                        label5.Text = "Сумма значений: " + sum + "\nРезультат вычислений: " + divide.ToString();

                        if (checkBox1.Checked)
                        {
                            divide *= 3;
                            label5.Text = "Сумма значений: " + sum + "\nРезультат вычислений: " + divide.ToString();
                        }

                        if (checkBox2.Checked)
                        {
                            divide *= 2;
                            label5.Text = "Сумма значений: " + sum + "\nРезультат вычислений: " + divide.ToString();
                        }
                    }
                }
            }
        }

        private void addResultToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Получение информации о файле
            var fi1 = new FileInfo("C://Users//nv025//Документы//C# RiderProjects//WinFormsApp1//Файлы// Результаты.txt");
            StreamWriter sw;

            // Выполнение расчета результатов
            Calculate();

            if (fi1.Exists)
            {
                // Если файл существует, открываем его для дописывания
                sw = fi1.AppendText();
            }
            else
            {
                // Если файл не существует, создаем его
                sw = fi1.CreateText();
            }

            // Запись результатов
            sw.WriteLine(label5.Text);
            sw.WriteLine("\n");

            sw.Close();
        }

        private void readFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog1.Title = "Выберите файл с параметрами";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string[] lines = File.ReadAllLines(fileName);

                // Предполагается, что файл содержит 4 числа, каждое на новой строке
                if (lines.Length != 4)
                {
                    MessageBox.Show("Неверный формат записи данных в файл ");
                    return;
                }

                // Заполняем текстовые поля числами из файла
                textBox1.Text = lines[0];
                textBox2.Text = lines[1];
                textBox3.Text = lines[2];
                textBox4.Text = lines[3];
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Получаем текущие дату и время
            DateTime currentTime = DateTime.Now;

            // Обновляем отображение времени на форме
            label6.Text = currentTime.ToString("HH:mm:ss");
        }


        private void timer3_Tick(object sender, EventArgs e)

        {
            double step = 0.1;
            double minValue = 0;
            double maxValue = 360;

            chart1.Series[0].Points.Clear();

            for (double x = minValue; x <= maxValue; x += step)
            {
                double y = Math.Sin((angle + x) * Math.PI / 180);
                chart1.Series[0].Points.AddXY(x, y);
            }

            chart1.Refresh();
            angle += step;
        }

        private async void CalculateFibonacci()
        {
            int n = 20;
            // Создаем массив для храненnия чисел Фибоначчи
            int[] fibNumbers = new int[n];

            // Первые два числа Фибоначчи равны 0 и 1
            fibNumbers[0] = 0;
            fibNumbers[1] = 1;

            // Вычисляем остальные числа Фибоначчи
            for (int i = 2; i < n; i++)
            {
                // Каждое следующее число равно сумме двух предыдущих
                fibNumbers[i] = fibNumbers[i - 1] + fibNumbers[i - 2];

                // Задержка для наглядности в демонстрационных целях
                Thread.Sleep(100);
            }

            foreach (int num in fibNumbers)
            {
                Invoke(new Action(() => textBox5.Text += num.ToString() + " "));
            }

            // Выводим результаты


        }
    }
}