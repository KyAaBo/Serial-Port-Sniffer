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

namespace SerialSniffer
{
    public partial class Form2 : Form
    {
        private int dataBits;
        public Form1 mainForm;   
        public Form2()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            var ports2 = SerialPort.GetPortNames();
            port1Combo.DataSource = ports;
            port2Combo.DataSource = ports2;

            formatCombo.Items.Add("7 Bit");
            formatCombo.Items.Add("8 Bit");
            formatCombo.SelectedIndex = 1;

            baudCombo.Items.Add(1200);
            baudCombo.Items.Add(2400);
            baudCombo.Items.Add(4800);
            baudCombo.Items.Add(9600);
            baudCombo.Items.Add(14400);
            baudCombo.Items.Add(28800);
            baudCombo.Items.Add(33300);
            baudCombo.SelectedIndex = 3;

            flowCombo.Items.Add("None");
            flowCombo.Items.Add("XOnXOff");
            flowCombo.Items.Add("RequestToSend");
            flowCombo.SelectedIndex = 0;

            parityCombo.Items.Add("None");
            parityCombo.Items.Add("Even");
            parityCombo.Items.Add("Odd");
            parityCombo.SelectedIndex = 0;

            stopCombo.Items.Add("One");
            stopCombo.Items.Add("Two");
            stopCombo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm.serialPort1 = new SerialPort();
                mainForm.serialPort1.PortName = port1Combo.SelectedItem.ToString();

                mainForm.serialPort2 = new SerialPort();
                mainForm.serialPort2.PortName = port2Combo.SelectedItem.ToString();

                if (formatCombo.SelectedIndex == 0) { dataBits = 7; }
                else { dataBits = 8; }
                mainForm.serialPort1.DataBits = dataBits;
                mainForm.serialPort2.DataBits = dataBits;

                mainForm.serialPort1.BaudRate = (int)baudCombo.SelectedItem;
                mainForm.serialPort2.BaudRate = (int)baudCombo.SelectedItem;

                if (flowCombo.SelectedItem.ToString() == "XOnXOff") { mainForm.serialPort1.Handshake = Handshake.XOnXOff; mainForm.serialPort2.Handshake = Handshake.XOnXOff; }
                else if (flowCombo.SelectedItem.ToString() == "RequestToSend") { mainForm.serialPort1.Handshake = Handshake.RequestToSend; mainForm.serialPort2.Handshake = Handshake.RequestToSend; }
                else { mainForm.serialPort1.Handshake = Handshake.None; mainForm.serialPort2.Handshake = Handshake.None; }

                if (parityCombo.SelectedItem.ToString() == "Even") { mainForm.serialPort1.Parity = Parity.Even; mainForm.serialPort2.Parity = Parity.Even; }
                else if (parityCombo.SelectedItem.ToString() == "Odd") { mainForm.serialPort1.Parity = Parity.Odd; mainForm.serialPort2.Parity = Parity.Odd; }
                else { mainForm.serialPort1.Parity = Parity.None; mainForm.serialPort2.Parity = Parity.None; }

                if (stopCombo.SelectedItem.ToString() == "Two") { mainForm.serialPort1.StopBits = StopBits.Two; mainForm.serialPort2.StopBits = StopBits.Two; }
                else { mainForm.serialPort1.StopBits = StopBits.One; mainForm.serialPort2.StopBits = StopBits.One; }

                mainForm.serialPort1.DataReceived += mainForm.port1_receivePacket;
                mainForm.serialPort2.DataReceived += mainForm.port2_receivePacket;

            }
            catch { MessageBox.Show("No port selected.", "Error Selecting Port"); };

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void port1Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
