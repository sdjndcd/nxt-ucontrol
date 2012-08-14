namespace RoboticsChallenge
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioforwardA = new System.Windows.Forms.RadioButton();
            this.radioreverseA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPowerA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trkPowerA = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trkPowerB = new System.Windows.Forms.TrackBar();
            this.radioreverseB = new System.Windows.Forms.RadioButton();
            this.radioforwardB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPowerB = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trkPowerC = new System.Windows.Forms.TrackBar();
            this.radioreverseC = new System.Windows.Forms.RadioButton();
            this.radioforwardC = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPowerC = new System.Windows.Forms.Label();
            this.btnCreateKey = new System.Windows.Forms.Button();
            this.txtKeyBind1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPowerA)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPowerB)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPowerC)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(39, 127);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 148);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioforwardA
            // 
            this.radioforwardA.AutoSize = true;
            this.radioforwardA.Location = new System.Drawing.Point(14, 56);
            this.radioforwardA.Margin = new System.Windows.Forms.Padding(4);
            this.radioforwardA.Name = "radioforwardA";
            this.radioforwardA.Size = new System.Drawing.Size(80, 21);
            this.radioforwardA.TabIndex = 5;
            this.radioforwardA.TabStop = true;
            this.radioforwardA.Text = "Forward";
            this.radioforwardA.UseVisualStyleBackColor = true;
            this.radioforwardA.CheckedChanged += new System.EventHandler(this.radioforwardA_CheckedChanged);
            // 
            // radioreverseA
            // 
            this.radioreverseA.AutoSize = true;
            this.radioreverseA.Location = new System.Drawing.Point(14, 79);
            this.radioreverseA.Margin = new System.Windows.Forms.Padding(4);
            this.radioreverseA.Name = "radioreverseA";
            this.radioreverseA.Size = new System.Drawing.Size(82, 21);
            this.radioreverseA.TabIndex = 6;
            this.radioreverseA.TabStop = true;
            this.radioreverseA.Text = "Reverse";
            this.radioreverseA.UseVisualStyleBackColor = true;
            this.radioreverseA.CheckedChanged += new System.EventHandler(this.radioreverseA_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Direction:";
            // 
            // lblPowerA
            // 
            this.lblPowerA.AutoSize = true;
            this.lblPowerA.Location = new System.Drawing.Point(11, 116);
            this.lblPowerA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPowerA.Name = "lblPowerA";
            this.lblPowerA.Size = new System.Drawing.Size(84, 17);
            this.lblPowerA.TabIndex = 8;
            this.lblPowerA.Text = "Power: (Off)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trkPowerA);
            this.groupBox1.Controls.Add(this.radioreverseA);
            this.groupBox1.Controls.Add(this.radioforwardA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPowerA);
            this.groupBox1.Location = new System.Drawing.Point(76, 315);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(117, 197);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port A";
            // 
            // trkPowerA
            // 
            this.trkPowerA.Location = new System.Drawing.Point(7, 136);
            this.trkPowerA.Margin = new System.Windows.Forms.Padding(4);
            this.trkPowerA.Maximum = 100;
            this.trkPowerA.Name = "trkPowerA";
            this.trkPowerA.Size = new System.Drawing.Size(105, 56);
            this.trkPowerA.TabIndex = 26;
            this.trkPowerA.TickFrequency = 20;
            this.trkPowerA.Scroll += new System.EventHandler(this.trkPowerA_Scroll);
            this.trkPowerA.ValueChanged += new System.EventHandler(this.trkPowerA_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trkPowerB);
            this.groupBox2.Controls.Add(this.radioreverseB);
            this.groupBox2.Controls.Add(this.radioforwardB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblPowerB);
            this.groupBox2.Location = new System.Drawing.Point(217, 315);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(116, 197);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port B";
            // 
            // trkPowerB
            // 
            this.trkPowerB.Location = new System.Drawing.Point(4, 136);
            this.trkPowerB.Margin = new System.Windows.Forms.Padding(4);
            this.trkPowerB.Maximum = 100;
            this.trkPowerB.Name = "trkPowerB";
            this.trkPowerB.Size = new System.Drawing.Size(105, 56);
            this.trkPowerB.TabIndex = 26;
            this.trkPowerB.TickFrequency = 20;
            this.trkPowerB.Scroll += new System.EventHandler(this.trkPowerB_Scroll);
            this.trkPowerB.ValueChanged += new System.EventHandler(this.trkPowerB_ValueChanged);
            // 
            // radioreverseB
            // 
            this.radioreverseB.AutoSize = true;
            this.radioreverseB.Location = new System.Drawing.Point(14, 79);
            this.radioreverseB.Margin = new System.Windows.Forms.Padding(4);
            this.radioreverseB.Name = "radioreverseB";
            this.radioreverseB.Size = new System.Drawing.Size(82, 21);
            this.radioreverseB.TabIndex = 6;
            this.radioreverseB.TabStop = true;
            this.radioreverseB.Text = "Reverse";
            this.radioreverseB.UseVisualStyleBackColor = true;
            this.radioreverseB.CheckedChanged += new System.EventHandler(this.radioreverseB_CheckedChanged);
            // 
            // radioforwardB
            // 
            this.radioforwardB.AutoSize = true;
            this.radioforwardB.Location = new System.Drawing.Point(14, 56);
            this.radioforwardB.Margin = new System.Windows.Forms.Padding(4);
            this.radioforwardB.Name = "radioforwardB";
            this.radioforwardB.Size = new System.Drawing.Size(80, 21);
            this.radioforwardB.TabIndex = 5;
            this.radioforwardB.TabStop = true;
            this.radioforwardB.Text = "Forward";
            this.radioforwardB.UseVisualStyleBackColor = true;
            this.radioforwardB.CheckedChanged += new System.EventHandler(this.radioforwardB_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direction:";
            // 
            // lblPowerB
            // 
            this.lblPowerB.AutoSize = true;
            this.lblPowerB.Location = new System.Drawing.Point(6, 116);
            this.lblPowerB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPowerB.Name = "lblPowerB";
            this.lblPowerB.Size = new System.Drawing.Size(84, 17);
            this.lblPowerB.TabIndex = 8;
            this.lblPowerB.Text = "Power: (Off)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trkPowerC);
            this.groupBox3.Controls.Add(this.radioreverseC);
            this.groupBox3.Controls.Add(this.radioforwardC);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblPowerC);
            this.groupBox3.Location = new System.Drawing.Point(360, 315);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(117, 197);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port C";
            // 
            // trkPowerC
            // 
            this.trkPowerC.Location = new System.Drawing.Point(6, 136);
            this.trkPowerC.Margin = new System.Windows.Forms.Padding(4);
            this.trkPowerC.Maximum = 100;
            this.trkPowerC.Name = "trkPowerC";
            this.trkPowerC.Size = new System.Drawing.Size(105, 56);
            this.trkPowerC.TabIndex = 25;
            this.trkPowerC.TickFrequency = 20;
            this.trkPowerC.Scroll += new System.EventHandler(this.trkPowerC_Scroll);
            this.trkPowerC.ValueChanged += new System.EventHandler(this.trkPowerC_ValueChanged);
            // 
            // radioreverseC
            // 
            this.radioreverseC.AutoSize = true;
            this.radioreverseC.Location = new System.Drawing.Point(13, 79);
            this.radioreverseC.Margin = new System.Windows.Forms.Padding(4);
            this.radioreverseC.Name = "radioreverseC";
            this.radioreverseC.Size = new System.Drawing.Size(82, 21);
            this.radioreverseC.TabIndex = 6;
            this.radioreverseC.TabStop = true;
            this.radioreverseC.Text = "Reverse";
            this.radioreverseC.UseVisualStyleBackColor = true;
            this.radioreverseC.CheckedChanged += new System.EventHandler(this.radioreverseC_CheckedChanged);
            // 
            // radioforwardC
            // 
            this.radioforwardC.AutoSize = true;
            this.radioforwardC.Location = new System.Drawing.Point(13, 56);
            this.radioforwardC.Margin = new System.Windows.Forms.Padding(4);
            this.radioforwardC.Name = "radioforwardC";
            this.radioforwardC.Size = new System.Drawing.Size(80, 21);
            this.radioforwardC.TabIndex = 5;
            this.radioforwardC.TabStop = true;
            this.radioforwardC.Text = "Forward";
            this.radioforwardC.UseVisualStyleBackColor = true;
            this.radioforwardC.CheckedChanged += new System.EventHandler(this.radioforwardC_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direction:";
            // 
            // lblPowerC
            // 
            this.lblPowerC.AutoSize = true;
            this.lblPowerC.Location = new System.Drawing.Point(10, 116);
            this.lblPowerC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPowerC.Name = "lblPowerC";
            this.lblPowerC.Size = new System.Drawing.Size(84, 17);
            this.lblPowerC.TabIndex = 8;
            this.lblPowerC.Text = "Power: (Off)";
            // 
            // btnCreateKey
            // 
            this.btnCreateKey.Location = new System.Drawing.Point(37, 66);
            this.btnCreateKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateKey.Name = "btnCreateKey";
            this.btnCreateKey.Size = new System.Drawing.Size(108, 28);
            this.btnCreateKey.TabIndex = 1;
            this.btnCreateKey.Text = "Create Bind";
            this.btnCreateKey.UseVisualStyleBackColor = true;
            this.btnCreateKey.Click += new System.EventHandler(this.btnCreateKey_Click);
            // 
            // txtKeyBind1
            // 
            this.txtKeyBind1.Location = new System.Drawing.Point(11, 34);
            this.txtKeyBind1.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyBind1.Name = "txtKeyBind1";
            this.txtKeyBind1.Size = new System.Drawing.Size(183, 22);
            this.txtKeyBind1.TabIndex = 0;
            this.txtKeyBind1.Text = "Click Here and Press Key";
            this.txtKeyBind1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyBind1_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Key Binds:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(55, 238);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(0, 17);
            this.lblFilename.TabIndex = 19;
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Location = new System.Drawing.Point(19, 62);
            this.btnLoadConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(100, 28);
            this.btnLoadConfig.TabIndex = 20;
            this.btnLoadConfig.Text = "Load Config";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(19, 30);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(465, 22);
            this.txtFilename.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Filename:";
            // 
            // openFileDialog1
            // 
            //this.openFileDialog1.FileName = "openFileDialog1";
            //this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 22);
            this.button2.TabIndex = 23;
            this.button2.Text = "Remove Key";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtKeyBind1);
            this.groupBox4.Controls.Add(this.btnCreateKey);
            this.groupBox4.Location = new System.Drawing.Point(283, 119);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(203, 110);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Custom Binds";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 534);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPowerA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPowerB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPowerC)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioforwardA;
        private System.Windows.Forms.RadioButton radioreverseA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPowerA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioreverseB;
        private System.Windows.Forms.RadioButton radioforwardB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPowerB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioreverseC;
        private System.Windows.Forms.RadioButton radioforwardC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPowerC;
        private System.Windows.Forms.TextBox txtKeyBind1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateKey;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TrackBar trkPowerC;
        private System.Windows.Forms.TrackBar trkPowerA;
        private System.Windows.Forms.TrackBar trkPowerB;
    }
}