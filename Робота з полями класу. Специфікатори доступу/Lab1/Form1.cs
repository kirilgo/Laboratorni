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
        Monitor monitor = new Monitor(
        textBox1.Text,
        int.Parse(textBox2.Text),
        int.Parse(textBox3.Text),
        int.Parse(textBox4.Text),
        int.Parse(textBox5.Text));

                MessageBox.Show(monitor.ToString());
        }
    }
}

