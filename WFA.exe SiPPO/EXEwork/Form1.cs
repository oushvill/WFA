using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXEwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            string text = textBox1.Text;
            process.StartInfo.FileName = text;
            process.Start();

            // C:\\Users\nv025\Документы\C# RiderProjects\WinFormsApp1\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\WinFormsApp1.exe

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\\Users\nv025\Документы\C# RiderProjects\WinFormsApp1\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\WinFormsApp1.exe");
        }
    }
}
