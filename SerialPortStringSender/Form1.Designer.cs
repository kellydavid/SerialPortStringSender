namespace SerialPortStringSender
{
    partial class SerialPortStringSender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialPortStringSender));
            this.sendStringTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.openConnectionButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendStringTextBox
            // 
            this.sendStringTextBox.Location = new System.Drawing.Point(12, 12);
            this.sendStringTextBox.Name = "sendStringTextBox";
            this.sendStringTextBox.Size = new System.Drawing.Size(783, 20);
            this.sendStringTextBox.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(801, 9);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(87, 39);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.comPortComboBox.TabIndex = 2;
            this.comPortComboBox.Text = "Com Port";
            this.comPortComboBox.SelectedIndexChanged += new System.EventHandler(this.comPortComboBox_SelectedIndexChanged);
            // 
            // openConnectionButton
            // 
            this.openConnectionButton.Location = new System.Drawing.Point(253, 36);
            this.openConnectionButton.Name = "openConnectionButton";
            this.openConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.openConnectionButton.TabIndex = 3;
            this.openConnectionButton.Text = "Open Connection";
            this.openConnectionButton.UseVisualStyleBackColor = true;
            this.openConnectionButton.Click += new System.EventHandler(this.openConnectionButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(334, 36);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(6, 39);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SerialPortStringSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 72);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openConnectionButton);
            this.Controls.Add(this.comPortComboBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendStringTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialPortStringSender";
            this.Text = "Serial Port String Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendStringTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.Button openConnectionButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button refreshButton;
    }
}

