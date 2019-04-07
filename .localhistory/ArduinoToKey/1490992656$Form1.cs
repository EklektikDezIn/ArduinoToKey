using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoToKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            serialPort.PortName = "COM" + numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false){ //if not open, open the port
                serialPort.Open();
            }
        }

        private void portRead(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            textBox1.Text += serialPort.ReadExisting();
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }
    }
}
