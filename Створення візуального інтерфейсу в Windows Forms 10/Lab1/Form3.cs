using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1.Multiline = true;
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            Spisok();
        }
        private void Spisok() 
        {
            textBox1.Clear();

            if (File.Exists(Form1.textFilePath))
            {
                string[] lines = File.ReadAllLines(Form1.textFilePath);
                foreach (string line in lines)
                {
                    textBox1.Text += line + "\r\n";
                }
            }
            else
            {
                textBox1.Text = "Файл ще не створено.";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string modelToDelete = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(modelToDelete))
            {
                MessageBox.Show("Введіть назву моделі для видалення!");
                return;
            }
            List<string> lines = new List<string>(File.ReadAllLines(Form1.textFilePath));
            string foundLine = lines.FirstOrDefault(l => l.Contains($"Модель: {modelToDelete}"));

            if (foundLine != null)
            {
                lines.Remove(foundLine);
                File.WriteAllLines(Form1.textFilePath, lines);
                MessageBox.Show($"Монітор \"{modelToDelete}\" видалено.");
                Spisok();
            }
            else
            {
                MessageBox.Show("Такого монітора не знайдено!");
            }
        }
    }
}
