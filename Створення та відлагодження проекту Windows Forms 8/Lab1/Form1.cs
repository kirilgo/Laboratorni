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
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += Form1_MouseClick;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Monitor> monitory = new List<Monitor>();

            Monitor userMonitor = new Monitor(
                          textBox1.Text,
                          int.Parse(textBox2.Text),
                          int.Parse(textBox3.Text),
                          int.Parse(textBox4.Text),
                          int.Parse(textBox5.Text)
                      );
            monitory.Add(userMonitor);
            monitory.Add(new Monitor("LG", 1080, 1920, 250, 7000));
            monitory.Add(new Monitor("Samsung", 1440, 2560, 300, 9500));
            monitory.Add(new Monitor("Asus", 1080, 1920, 280, 8500));
            monitory.Add(new Monitor("Dell", 2160, 3840, 350, 12000));
            monitory.Insert(2, new Monitor("Acer", 900, 1600, 230, 6000));

            string textFilePath = "MonitorTextInfo.txt";
            using (StreamWriter writer = new StreamWriter(textFilePath))
            {
                foreach (Monitor m in monitory)
                {
                    writer.WriteLine(m.ToString());
                }
            }
            Monitor serializableMonitor = new Monitor("HP", 1440, 2560, 320, 8000);
            string binaryFilePath = "MonitorBinaryData.dat";
            using (FileStream fs = new FileStream(binaryFilePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, serializableMonitor);
            }
            string output = " Колекція моніторів (foreach) \n";

            foreach (Monitor m in monitory)
            {
                output += m.ToString() + "\n";
            }

            output += "\n Вміст Текстового файлу \n";
            string filePath = "MonitorTextInfo.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    output += line + "\n";
                }
            }

            output += "\n Файлові операції \n";
            output += $"Текстовий файл створено: {textFilePath}\n";
            output += $"Об’єкт серіалізовано: {binaryFilePath}\n";

            MessageBox.Show(output, "Звіт про колекцію та файлові операції", MessageBoxButtons.OK);
        }
    }
}

    
