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

namespace HardwareForFun
{
    public partial class Form1 : Form
    {
        SerialPort arduino = new SerialPort("COM4", 9600);

        public Form1()
        {
            arduino.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arduino.Write("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arduino.Write("0");
        }
    }
}
