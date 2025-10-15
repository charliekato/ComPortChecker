using System;
using System.IO.Ports;
namespace ComPortCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SerialPort _serialPort;
            InitializeComponent();
            using (_serialPort = new SerialPort())
            {
                GetPortName();
            }
        }
        public void GetPortName()
        {

            label1.Text = "Available Ports:\n";
            foreach (string s in SerialPort.GetPortNames())
            {
                label1.Text = label1.Text + s + "\n";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReRun_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            GetPortName();

        }
    }
}
