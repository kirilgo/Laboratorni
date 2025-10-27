using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        List<Monitor> monitory = new List<Monitor>();
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += Form1_MouseClick;
            comboBox1.Items.AddRange(new string[] { "LG", "Samsung", "Asus", "Dell", "Acer", "HP" });
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string model = comboBox1.Text;
                int vert = int.Parse(textBox1.Text);
                int horiz = int.Parse(textBox2.Text);
                int price = int.Parse(textBox3.Text);

                Monitor m = new Monitor(model, vert, horiz, 250, price);
                monitory.Add(m);

                textBox4.Text += $"{m}\n\r";
            }
            catch
            {
                MessageBox.Show("Перевір правильність введених даних!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "Monitory.txt";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (Monitor m in monitory)
                    sw.WriteLine(m.ToString());
            }

            MessageBox.Show($"Дані збережено у файл:\n{filePath}");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Text += "Колекція моніторів:\r\n";
            foreach (Monitor m in monitory)
            {
                textBox4.Text += m + "\r\n";
            }
        }
    }
}