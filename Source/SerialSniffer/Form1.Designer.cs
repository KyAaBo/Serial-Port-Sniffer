namespace SerialSniffer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.port1Status = new System.Windows.Forms.ComboBox();
            this.port1Display = new System.Windows.Forms.TextBox();
            this.port1Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.port2Status = new System.Windows.Forms.ComboBox();
            this.port2Display = new System.Windows.Forms.TextBox();
            this.port2Label = new System.Windows.Forms.Label();
            this.configText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.displayCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(701, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.port1Status);
            this.groupBox1.Controls.Add(this.port1Display);
            this.groupBox1.Controls.Add(this.port1Label);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port #1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Port Status";
            // 
            // port1Status
            // 
            this.port1Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port1Status.FormattingEnabled = true;
            this.port1Status.Location = new System.Drawing.Point(72, 22);
            this.port1Status.Name = "port1Status";
            this.port1Status.Size = new System.Drawing.Size(121, 21);
            this.port1Status.TabIndex = 10;
            this.port1Status.SelectedIndexChanged += new System.EventHandler(this.port1Status_SelectedIndexChanged);
            // 
            // port1Display
            // 
            this.port1Display.Location = new System.Drawing.Point(6, 70);
            this.port1Display.Multiline = true;
            this.port1Display.Name = "port1Display";
            this.port1Display.ReadOnly = true;
            this.port1Display.Size = new System.Drawing.Size(238, 178);
            this.port1Display.TabIndex = 3;
            // 
            // port1Label
            // 
            this.port1Label.AutoSize = true;
            this.port1Label.Location = new System.Drawing.Point(7, 54);
            this.port1Label.Name = "port1Label";
            this.port1Label.Size = new System.Drawing.Size(82, 13);
            this.port1Label.TabIndex = 2;
            this.port1Label.Text = "Port #1 Display:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.port2Status);
            this.groupBox2.Controls.Add(this.port2Display);
            this.groupBox2.Controls.Add(this.port2Label);
            this.groupBox2.Location = new System.Drawing.Point(269, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 254);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port #2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Port Status";
            // 
            // port2Status
            // 
            this.port2Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port2Status.FormattingEnabled = true;
            this.port2Status.Location = new System.Drawing.Point(72, 22);
            this.port2Status.Name = "port2Status";
            this.port2Status.Size = new System.Drawing.Size(121, 21);
            this.port2Status.TabIndex = 10;
            this.port2Status.SelectedIndexChanged += new System.EventHandler(this.port2Status_SelectedIndexChanged);
            // 
            // port2Display
            // 
            this.port2Display.Location = new System.Drawing.Point(6, 70);
            this.port2Display.Multiline = true;
            this.port2Display.Name = "port2Display";
            this.port2Display.ReadOnly = true;
            this.port2Display.Size = new System.Drawing.Size(238, 178);
            this.port2Display.TabIndex = 3;
            // 
            // port2Label
            // 
            this.port2Label.AutoSize = true;
            this.port2Label.Location = new System.Drawing.Point(7, 54);
            this.port2Label.Name = "port2Label";
            this.port2Label.Size = new System.Drawing.Size(82, 13);
            this.port2Label.TabIndex = 2;
            this.port2Label.Text = "Port #2 Display:";
            // 
            // configText
            // 
            this.configText.Location = new System.Drawing.Point(525, 39);
            this.configText.Multiline = true;
            this.configText.Name = "configText";
            this.configText.ReadOnly = true;
            this.configText.Size = new System.Drawing.Size(164, 155);
            this.configText.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Serial Port Configuration";
            // 
            // displayCombo
            // 
            this.displayCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayCombo.FormattingEnabled = true;
            this.displayCombo.Location = new System.Drawing.Point(525, 215);
            this.displayCombo.Name = "displayCombo";
            this.displayCombo.Size = new System.Drawing.Size(164, 21);
            this.displayCombo.TabIndex = 14;
            this.displayCombo.SelectedIndexChanged += new System.EventHandler(this.displayCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Output Display Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear Displays";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 17;
            this.button2.Text = "Rename Ports";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.displayCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.configText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "KAB Serial Port Sniffer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox port1Status;
        private System.Windows.Forms.TextBox port1Display;
        private System.Windows.Forms.Label port1Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox port2Status;
        private System.Windows.Forms.TextBox port2Display;
        private System.Windows.Forms.Label port2Label;
        private System.Windows.Forms.TextBox configText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox displayCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

