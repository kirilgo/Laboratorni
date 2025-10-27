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
        public static List<Monitor> Monitory = new List<Monitor>();
        public static string textFilePath = "MonitorTextInfo.txt";
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += Form1_MouseClick;
        }

        public Form2 Form2
        {
            get => default;
            set
            {
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Гончар Кирило БІП1-24 ");
        }
    }
}