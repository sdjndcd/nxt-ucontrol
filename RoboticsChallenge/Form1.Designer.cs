namespace RoboticsChallenge
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

            foreach (RoboticsDeviceInfo di in nxtDevices)
            {
                //di.Disconnect();
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
            this.components = new System.ComponentModel.Container();
            this.btnFindDevices = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnBeep = new System.Windows.Forms.Button();
            this.btnBattery = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindDevices
            // 
            this.btnFindDevices.Location = new System.Drawing.Point(16, 15);
            this.btnFindDevices.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindDevices.Name = "btnFindDevices";
            this.btnFindDevices.Size = new System.Drawing.Size(180, 28);
            this.btnFindDevices.TabIndex = 0;
            this.btnFindDevices.Text = "Find Devices";
            this.btnFindDevices.UseVisualStyleBackColor = true;
            this.btnFindDevices.Click += new System.EventHandler(this.btnFindDevices_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 204);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(76, 28);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnVersion
            // 
            this.btnVersion.Location = new System.Drawing.Point(47, 311);
            this.btnVersion.Margin = new System.Windows.Forms.Padding(4);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(100, 28);
            this.btnVersion.TabIndex = 4;
            this.btnVersion.Text = "Version";
            this.btnVersion.UseVisualStyleBackColor = true;
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(47, 240);
            this.btnBeep.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(100, 28);
            this.btnBeep.TabIndex = 5;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // btnBattery
            // 
            this.btnBattery.Location = new System.Drawing.Point(47, 276);
            this.btnBattery.Margin = new System.Windows.Forms.Padding(4);
            this.btnBattery.Name = "btnBattery";
            this.btnBattery.Size = new System.Drawing.Size(100, 28);
            this.btnBattery.TabIndex = 6;
            this.btnBattery.Text = "Battery Life";
            this.btnBattery.UseVisualStyleBackColor = true;
            this.btnBattery.Click += new System.EventHandler(this.btnBattery_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(100, 204);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 28);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.ItemHeight = 16;
            this.lstDevices.Location = new System.Drawing.Point(16, 48);
            this.lstDevices.Margin = new System.Windows.Forms.Padding(4);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(179, 148);
            this.lstDevices.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            // 
            // rtxtLog
            // 
            this.rtxtLog.BackColor = System.Drawing.Color.White;
            this.rtxtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtLog.CausesValidation = false;
            this.rtxtLog.Location = new System.Drawing.Point(246, 15);
            this.rtxtLog.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(368, 392);
            this.rtxtLog.TabIndex = 2;
            this.rtxtLog.TabStop = false;
            this.rtxtLog.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 347);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Key Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnBattery);
            this.Controls.Add(this.btnBeep);
            this.Controls.Add(this.btnVersion);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.btnFindDevices);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "NXT uControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindDevices;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Button btnBattery;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Button button1;
    }
}

