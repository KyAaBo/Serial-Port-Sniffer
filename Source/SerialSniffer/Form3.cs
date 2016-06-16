using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialSniffer
{
    public partial class Form3 : Form
    {
        public Form1 mainForm;
        public Form3()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            port1NameText.Text = mainForm.port1Name;
            port2NameText.Text = mainForm.port2Name;
        }

        private void updateNames_Click(object sender, EventArgs e)
        {
            mainForm.port1Name = port1NameText.Text;
            mainForm.port2Name = port2NameText.Text;

            this.Close();
        }

        private void cancelNames_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
