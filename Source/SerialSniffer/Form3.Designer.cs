namespace SerialSniffer
{
    partial class Form3
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
            this.updateNames = new System.Windows.Forms.Button();
            this.cancelNames = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.port1NameText = new System.Windows.Forms.TextBox();
            this.port2NameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateNames
            // 
            this.updateNames.Location = new System.Drawing.Point(12, 144);
            this.updateNames.Name = "updateNames";
            this.updateNames.Size = new System.Drawing.Size(75, 23);
            this.updateNames.TabIndex = 0;
            this.updateNames.Text = "Update";
            this.updateNames.UseVisualStyleBackColor = true;
            this.updateNames.Click += new System.EventHandler(this.updateNames_Click);
            // 
            // cancelNames
            // 
            this.cancelNames.Location = new System.Drawing.Point(155, 144);
            this.cancelNames.Name = "cancelNames";
            this.cancelNames.Size = new System.Drawing.Size(75, 23);
            this.cancelNames.TabIndex = 1;
            this.cancelNames.Text = "Cancel";
            this.cancelNames.UseVisualStyleBackColor = true;
            this.cancelNames.Click += new System.EventHandler(this.cancelNames_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port #1 Name";
            // 
            // port1NameText
            // 
            this.port1NameText.Location = new System.Drawing.Point(12, 39);
            this.port1NameText.Name = "port1NameText";
            this.port1NameText.Size = new System.Drawing.Size(218, 20);
            this.port1NameText.TabIndex = 3;
            // 
            // port2NameText
            // 
            this.port2NameText.Location = new System.Drawing.Point(12, 95);
            this.port2NameText.Name = "port2NameText";
            this.port2NameText.Size = new System.Drawing.Size(218, 20);
            this.port2NameText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port #2 Name";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 185);
            this.Controls.Add(this.port2NameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.port1NameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelNames);
            this.Controls.Add(this.updateNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = "Rename Ports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateNames;
        private System.Windows.Forms.Button cancelNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port1NameText;
        private System.Windows.Forms.TextBox port2NameText;
        private System.Windows.Forms.Label label2;
    }
}