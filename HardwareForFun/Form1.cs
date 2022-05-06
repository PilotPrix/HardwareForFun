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
        SerialPort arduino = new SerialPort("COM8", 9600);

        public Form1()
        {
            arduino.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Write("1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting with the Serial Port", "Error", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                arduino.Write("0");
            }
            else
            {
                arduino.Write("1");
            }
        }
    }

    public class Test : Form1
    {

    }
}
