using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Monitor userMonitor = new Monitor(
                          textBox1.Text,                       
                          int.Parse(textBox2.Text),            
                          int.Parse(textBox3.Text),            
                          int.Parse(textBox4.Text),            
                          int.Parse(textBox5.Text)
                      );
            List<Monitor> monitory = new List<Monitor>();

            monitory.Add(userMonitor);

            monitory.Add(new Monitor("LG", 1080, 1920, 250, 7000));
            monitory.Add(new Monitor("Samsung", 1440, 2560, 300, 9500));
            monitory.Add(new Monitor("Asus", 1080, 1920, 280, 8500));
            monitory.Add(new Monitor("Dell", 2160, 3840, 350, 12000));

            monitory.Insert(2, new Monitor("Acer", 900, 1600, 230, 6000));

            string output = " Монітори \n";

            output += "\n Вивід через цикл FOR:\n";
            for (int i = 0; i < monitory.Count; i++)
            {
                output += monitory[i].ToString() + "\n";
            }

            output += "\n Вивід через цикл FOREACH:\n";
            foreach (Monitor m in monitory)
            {
                output += m.ToString() + "\n";
            }

            monitory.Sort();

            output += "\n Відсортовано за ціною (ЗРОСТАННЯ):\n";
            foreach (Monitor m in monitory)
            {
                output += m.ToString() + "\n";
            }
            MessageBox.Show(output, "Інформація про монітори", MessageBoxButtons.OK);
        }
    }
}