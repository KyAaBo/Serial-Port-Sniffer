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

/* Student: Kyle Boudreau
 * Date:	12 March 2015  
 */

namespace SerialSniffer
{
    public partial class Form1 : Form
    {
        public SerialPort serialPort1 { get; set; }
        public SerialPort serialPort2 { get; set; }
        public Encoding encoder = Encoding.ASCII;
        public string port1Name = "Port #1";
        public string port2Name = "Port #2";

        byte[] port1_receivedPacket;
        byte[] port2_receivedPacket;
        bool displayType = false; // false == text, true == hex

        public Form1()
        {
            InitializeComponent();

            port1Status.Items.Add("Opened");
            port1Status.Items.Add("Closed");
            port1Status.SelectedIndex = 1;

            port2Status.Items.Add("Opened");
            port2Status.Items.Add("Closed");
            port2Status.SelectedIndex = 1;

            displayCombo.Items.Add("Text");
            displayCombo.Items.Add("Hexadecimal");
            displayCombo.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen) { MessageBox.Show("Please close all ports before trying to open a new one.", "Error Selecting Port"); }
                else if (serialPort2.IsOpen) { MessageBox.Show("Please close all ports before trying to open a new one.", "Error Selecting Port"); }
                else
                {
                    Form2 newWindow = new Form2();
                    newWindow.mainForm = this;
                    newWindow.ShowDialog();
                    outputConfig();
                }
            }
            catch
            {
                Form2 newWindow = new Form2();
                newWindow.mainForm = this;
                newWindow.ShowDialog();
                outputConfig();
            }
        }     

        private void port1Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (port1Status.SelectedIndex == 0)
            {
                try { if (!serialPort1.IsOpen) { serialPort1.Open(); } }
                catch
                {
                    MessageBox.Show("No port found. Please select a port, then try again.", "Error Opening Port");
                    port1Status.SelectedIndex = 1;
                };
            }
            else if (port1Status.SelectedIndex == 1)
            {
                try { if (serialPort1.IsOpen) { serialPort1.Close(); } }
                catch { };
            }
        }

        private void port2Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (port2Status.SelectedIndex == 0)
            {
                try { if (!serialPort2.IsOpen) { serialPort2.Open(); } }
                catch
                {
                    MessageBox.Show("No port found. Please select a port, then try again.", "Error Opening Port");
                    port2Status.SelectedIndex = 1;
                };
            }
            else if (port2Status.SelectedIndex == 1)
            {
                try { if (serialPort2.IsOpen) { serialPort2.Close(); } }
                catch { };
            }
        }

        private void outputConfig()
        {
            try
            {
                configText.Clear();
                configText.AppendText("Port #1: " + serialPort1.PortName + "\n");
                configText.AppendText("Port #2: " + serialPort2.PortName + "\n");
                configText.AppendText("Flow Control: " + serialPort1.Handshake + "\n");
                configText.AppendText("Data Bits: " + serialPort1.DataBits + "\n");
                configText.AppendText("Baud Rate: " + serialPort1.BaudRate + "\n");
                configText.AppendText("Parity: " + serialPort1.Parity + "\n");
                configText.AppendText("Stop Bits: " + serialPort1.StopBits + "\n");
            }
            catch { };
        }

        public void port1_receivePacket(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen) 
            {
                readPort1(); 
            }
        }

        public void port2_receivePacket(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort2.IsOpen) { readPort2(); }
        }

        private void readPort1()
        {
            byte port1_headerByte = (byte)serialPort1.ReadByte();
            byte port1_byteCount = (byte)serialPort1.ReadByte();

            port1_receivedPacket = new byte[port1_byteCount];
            port1_receivedPacket[0] = port1_headerByte;
            port1_receivedPacket[1] = port1_byteCount;

            for (int i = 2; i < port1_byteCount; i++)
            {
                port1_receivedPacket[i] = (byte)serialPort1.ReadByte();
            }

            byte[] receivedData = new byte[(port1_byteCount - 3)];
            int dataByteCount = 0;

            for (int i = 2; i < (port1_byteCount - 1); i++)
            {
                receivedData[dataByteCount] = port1_receivedPacket[i];
                dataByteCount++;
            }

            string receivedText;

            if (displayType == false)
            {
                receivedText = encoder.GetString(receivedData);
                port1_SetText(receivedText);
            }
            else if (displayType == true)
            {
                receivedText = " ";
                for (int i = 0; i < port1_byteCount; i++)
                {
                    receivedText += (port1_receivedPacket[i].ToString("X2") + " ");
                }
                port1_SetHex(receivedText);
            }
        }

        private void readPort2()
        {
            byte port2_headerByte = (byte)serialPort2.ReadByte();
            byte port2_byteCount = (byte)serialPort2.ReadByte();

            port2_receivedPacket = new byte[port2_byteCount];
            port2_receivedPacket[0] = port2_headerByte;
            port2_receivedPacket[1] = port2_byteCount;

            for (int i = 2; i < port2_byteCount; i++)
            {
                port2_receivedPacket[i] = (byte)serialPort2.ReadByte();
            }

            byte[] receivedData = new byte[(port2_byteCount - 3)];
            int dataByteCount = 0;

            for (int i = 2; i < (port2_byteCount - 1); i++)
            {
                receivedData[dataByteCount] = port2_receivedPacket[i];
                dataByteCount++;
            }

            string receivedText;

            if (displayType == false)
            {
                receivedText = encoder.GetString(receivedData);
                port2_SetText(receivedText);
            }
            else if (displayType == true)
            {
                receivedText = " ";
                for (int i = 0; i < port2_byteCount; i++)
                {
                    receivedText += (port2_receivedPacket[i].ToString("X2") + " ");
                }
                port2_SetHex(receivedText);
            }
        }

        delegate void SetTextCallback(string text);

        private void port1_SetText(string text)
        {
            // InvokeRequired compares thread ID of calling to thread ID of creating thread, returns true if different
            if (this.port1Display.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(port1_SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.port1Display.AppendText(DateTime.Now.ToString("h:mm:ss tt") + ": " + text + "\n");
                this.port1Display.BackColor = System.Drawing.Color.White;
            }
        }

        private void port1_SetHex(string hex)
        {
            // InvokeRequired compares thread ID of calling to thread ID of creating thread, returns true if different
            if (this.port1Display.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(port1_SetHex);
                this.Invoke(d, new object[] { hex });
            }
            else
            {
                this.port1Display.AppendText(DateTime.Now.ToString("h:mm:ss tt") + ": " + hex + "\n");
                this.port1Display.BackColor = System.Drawing.Color.White;
            }
        }

        private void port2_SetText(string text)
        {
            // InvokeRequired compares thread ID of calling to thread ID of creating thread, returns true if different
            if (this.port2Display.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(port2_SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.port2Display.AppendText(DateTime.Now.ToString("h:mm:ss tt") + ": " + text + "\n"); 
                this.port2Display.BackColor = System.Drawing.Color.White;
            }
        }

        private void port2_SetHex(string hex)
        {
            // InvokeRequired compares thread ID of calling to thread ID of creating thread, returns true if different
            if (this.port2Display.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(port1_SetHex);
                this.Invoke(d, new object[] { hex });
            }
            else
            {
                this.port2Display.AppendText(DateTime.Now.ToString("h:mm:ss tt") + ": " + hex + "\n");
                this.port2Display.BackColor = System.Drawing.Color.White;
            }
        }

        private void displayCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(displayCombo.SelectedIndex == 0)
            {
                displayType = false;
            }
            else if(displayCombo.SelectedIndex == 1)
            {
                displayType = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newWindow = new Form3();
            newWindow.mainForm = this;
            newWindow.ShowDialog();
            port1Label.Text = port1Name + " Display:";
            port2Label.Text = port2Name + " Display:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port1Display.Clear();
            port2Display.Clear();
        }

    }
}
