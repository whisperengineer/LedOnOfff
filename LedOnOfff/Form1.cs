using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LedOnOfff
{
    public partial class Form1 : Form
    {   string[] portlar=SerialPort.GetPortNames();  
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in portlar)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }
            label2.Text = "Bağlantı Yok";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            label2.Text = "Bağlantı Var";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen==true)
            {
                serialPort1.Close();
                label2.Text = "Bağlantı Yok";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            label1.Text = "Led Açık";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            label1.Text = "Led Kapalı";
        }
    }
}
