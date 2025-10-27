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

namespace Lab1
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "LG", "Samsung", "Asus", "Dell", "Acer", "HP" });
        }

        public Monitor Monitor
        {
            get => default;
            set
            {
            }
        }

        public Form3 Form3
        {
            get => default;
            set
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string model = comboBox1.Text;
                int vert = int.Parse(textBox1.Text);
                int horiz = int.Parse(textBox2.Text);
                int price = int.Parse(textBox3.Text);

                Monitor m = new Monitor(model, vert, horiz, 250, price);
                Form1.Monitory.Add(m);

                using (StreamWriter writer = new StreamWriter(Form1.textFilePath))
                {
                    foreach (Monitor mon in Form1.Monitory)
                        writer.WriteLine(mon.ToString());
                }
            MessageBox.Show("Монітор додано");
            }
            catch
            {
                MessageBox.Show("Помилка! Перевірте правильність введених даних.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
