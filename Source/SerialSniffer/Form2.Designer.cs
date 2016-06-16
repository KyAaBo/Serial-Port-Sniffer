namespace SerialSniffer
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowCombo = new System.Windows.Forms.ComboBox();
            this.baudCombo = new System.Windows.Forms.ComboBox();
            this.stopCombo = new System.Windows.Forms.ComboBox();
            this.parityCombo = new System.Windows.Forms.ComboBox();
            this.formatCombo = new System.Windows.Forms.ComboBox();
            this.port2Combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.port1Combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Configure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Stop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Flow Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Port # 2";
            // 
            // flowCombo
            // 
            this.flowCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowCombo.FormattingEnabled = true;
            this.flowCombo.Location = new System.Drawing.Point(12, 194);
            this.flowCombo.Name = "flowCombo";
            this.flowCombo.Size = new System.Drawing.Size(121, 21);
            this.flowCombo.TabIndex = 19;
            // 
            // baudCombo
            // 
            this.baudCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudCombo.FormattingEnabled = true;
            this.baudCombo.Location = new System.Drawing.Point(12, 154);
            this.baudCombo.Name = "baudCombo";
            this.baudCombo.Size = new System.Drawing.Size(121, 21);
            this.baudCombo.TabIndex = 18;
            // 
            // stopCombo
            // 
            this.stopCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopCombo.FormattingEnabled = true;
            this.stopCombo.Location = new System.Drawing.Point(12, 274);
            this.stopCombo.Name = "stopCombo";
            this.stopCombo.Size = new System.Drawing.Size(121, 21);
            this.stopCombo.TabIndex = 17;
            // 
            // parityCombo
            // 
            this.parityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityCombo.FormattingEnabled = true;
            this.parityCombo.Location = new System.Drawing.Point(12, 234);
            this.parityCombo.Name = "parityCombo";
            this.parityCombo.Size = new System.Drawing.Size(121, 21);
            this.parityCombo.TabIndex = 16;
            // 
            // formatCombo
            // 
            this.formatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatCombo.FormattingEnabled = true;
            this.formatCombo.Location = new System.Drawing.Point(12, 114);
            this.formatCombo.Name = "formatCombo";
            this.formatCombo.Size = new System.Drawing.Size(121, 21);
            this.formatCombo.TabIndex = 15;
            // 
            // port2Combo
            // 
            this.port2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port2Combo.FormattingEnabled = true;
            this.port2Combo.Location = new System.Drawing.Point(12, 74);
            this.port2Combo.Name = "port2Combo";
            this.port2Combo.Size = new System.Drawing.Size(121, 21);
            this.port2Combo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Port # 1";
            // 
            // port1Combo
            // 
            this.port1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port1Combo.FormattingEnabled = true;
            this.port1Combo.Location = new System.Drawing.Point(12, 34);
            this.port1Combo.Name = "port1Combo";
            this.port1Combo.Size = new System.Drawing.Size(121, 21);
            this.port1Combo.TabIndex = 28;
            this.port1Combo.SelectedIndexChanged += new System.EventHandler(this.port1Combo_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 359);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.port1Combo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowCombo);
            this.Controls.Add(this.baudCombo);
            this.Controls.Add(this.stopCombo);
            this.Controls.Add(this.parityCombo);
            this.Controls.Add(this.formatCombo);
            this.Controls.Add(this.port2Combo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Port Configuration";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox flowCombo;
        private System.Windows.Forms.ComboBox baudCombo;
        private System.Windows.Forms.ComboBox stopCombo;
        private System.Windows.Forms.ComboBox parityCombo;
        private System.Windows.Forms.ComboBox formatCombo;
        private System.Windows.Forms.ComboBox port2Combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox port1Combo;
    }
}