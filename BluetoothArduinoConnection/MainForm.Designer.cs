namespace BluetoothArduinoConnection
{
    partial class MainForm
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
            this.scanButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.devicesListBox = new System.Windows.Forms.ListBox();
            this.led1Button = new System.Windows.Forms.Button();
            this.led2Button = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scanButton.Location = new System.Drawing.Point(14, 12);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(106, 40);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connectButton.Location = new System.Drawing.Point(14, 58);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(106, 40);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // devicesListBox
            // 
            this.devicesListBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.devicesListBox.FormattingEnabled = true;
            this.devicesListBox.ItemHeight = 19;
            this.devicesListBox.Location = new System.Drawing.Point(126, 13);
            this.devicesListBox.Name = "devicesListBox";
            this.devicesListBox.Size = new System.Drawing.Size(194, 232);
            this.devicesListBox.TabIndex = 2;
            // 
            // led1Button
            // 
            this.led1Button.Enabled = false;
            this.led1Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.led1Button.Location = new System.Drawing.Point(14, 177);
            this.led1Button.Name = "led1Button";
            this.led1Button.Size = new System.Drawing.Size(106, 31);
            this.led1Button.TabIndex = 3;
            this.led1Button.Text = "LED1";
            this.led1Button.UseVisualStyleBackColor = true;
            this.led1Button.Click += new System.EventHandler(this.SendData_Click);
            // 
            // led2Button
            // 
            this.led2Button.Enabled = false;
            this.led2Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.led2Button.Location = new System.Drawing.Point(14, 214);
            this.led2Button.Name = "led2Button";
            this.led2Button.Size = new System.Drawing.Size(106, 31);
            this.led2Button.TabIndex = 4;
            this.led2Button.Text = "LED2";
            this.led2Button.UseVisualStyleBackColor = true;
            this.led2Button.Click += new System.EventHandler(this.SendData_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.disconnectButton.Location = new System.Drawing.Point(14, 104);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(106, 40);
            this.disconnectButton.TabIndex = 5;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 257);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.led2Button);
            this.Controls.Add(this.led1Button);
            this.Controls.Add(this.devicesListBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.scanButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListBox devicesListBox;
        private System.Windows.Forms.Button led1Button;
        private System.Windows.Forms.Button led2Button;
        private System.Windows.Forms.Button disconnectButton;
    }
}