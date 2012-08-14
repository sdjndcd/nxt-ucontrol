using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;

namespace RoboticsChallenge
{
    
    public partial class Form2 : Form
    {
        public Command newCommand = null;
        
        public Form2()
        {
            InitializeComponent();
            

            if (Variables.config != null)
            {
                LoadListboxCommands();
            }

            listBox1.DisplayMember = "ShortName";

        //    Command cmd = (Command)listBox1.SelectedItem;
            //Variables.config.saveconfig("config");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null) return;

            Motor motorA = cmd.motors[0];
            Motor motorB = cmd.motors[1];
            Motor motorC = cmd.motors[2];

            


            //Port A
            trkPowerA.Value = motorA.power;
            //textpowerA.Text = motorA.power.ToString();
            if (motorA.direction == 1)
            {
                radioforwardA.Select();
            }
            else if (motorA.direction == -1)
            {
                radioreverseA.Select();

            }
            //Port B
            trkPowerB.Value = motorB.power;
            //textpowerB.Text = motorB.power.ToString();
            if (motorB.direction == 1)
            {
                radioforwardB.Select();
            }
            else if (motorB.direction == -1)
            {
                radioreverseB.Select();

            }
            //Port C
            trkPowerC.Value = motorC.power;
            //textpowerC.Text = motorC.power.ToString();
            if (motorC.direction == 1)
            {
                radioforwardC.Select();
            }
            else if (motorC.direction == -1)
            {
                radioreverseC.Select();

            }
        }





        

        private void radioreverseA_CheckedChanged(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motorA = cmd.motors[0];
            motorA.direction = -1;
        }

        private void radioforwardA_CheckedChanged(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motorA = cmd.motors[0];
            motorA.direction = 1;
        }

        private void radioreverseB_CheckedChanged(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motorB = cmd.motors[1];
            motorB.direction = -1;
        }

        private void radioforwardB_CheckedChanged(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motorB = cmd.motors[1];
            motorB.direction = 1;
        }

        private void radioreverseC_CheckedChanged(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motorC = cmd.motors[2];
            motorC.direction = -1;
        }

        private void radioforwardC_CheckedChanged(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motorC = cmd.motors[2];
            motorC.direction = 1;
        }

        

        private void txtKeyBind1_KeyUp(object sender, KeyEventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;

            //cmd.keys1 = e.KeyCode;
            //txtKeyBind1.Text = e.KeyCode.ToString();

        }

        [DllImport("user32.dll")]
        public static extern int GetKeyboardState(byte[] keystate);

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!txtKeyBind1.Focused)
                return base.ProcessCmdKey(ref msg, keyData);

            byte[] keys = new byte[255];
            GetKeyboardState(keys);

            String szKeys = "";

            int keysCount = 0;
            int[] keys1 = new int[4];

            for (int i = 0; i < 255; i++)
            {
                if (keysCount > 2)
                    break;

                if ((keys[i] & 128) > 0)
                {
                    szKeys = szKeys + Enum.GetName(typeof(Keys), i) +  " ";
                    keys1[keysCount++] = i;
                }
            }

            //Remove trailing space
            szKeys = szKeys.Substring(0, szKeys.Length - 1);

            
            this.txtKeyBind1.Text = szKeys;

            return true;// base.ProcessKeyPreview(ref msg);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            openFileDialog1.Reset();

            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = @"Text Files |*.txt";
            //openFileDialog1.InitialDirectory = ".";
            openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);


            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                String filename = openFileDialog1.FileName;

                filename = System.IO.Path.GetFileName(filename);
                txtFilename.Text = filename;

                Variables.config.readconfig(openFileDialog1.FileName);

                LoadListboxCommands();
            }
        }

        public void LoadListboxCommands()
        {
            listBox1.Items.Clear();

            ArrayList cmdlist = new ArrayList();
            foreach (Command cmd in Variables.config.commands)
            {
                listBox1.Items.Add(cmd);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String savedFile = "";

            saveFileDialog1.Reset();
            saveFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            saveFileDialog1.Title = "Save Configuration File";
            saveFileDialog1.FileName = this.txtFilename.Text;

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                savedFile = saveFileDialog1.FileName;
                txtFilename.Text = System.IO.Path.GetFileName(savedFile);
                Variables.config.saveconfig(savedFile);
            }

        }

        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            newCommand = new Command("[" + txtKeyBind1.Text + "]");

            Variables.config.addcommand(newCommand);
            listBox1.Items.Add(newCommand);
            txtKeyBind1.Text = "Click Here and Press Key";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;

            Variables.config.commands.Remove(cmd);
            listBox1.Items.Remove(cmd);
        }


        private void trkPowerC_ValueChanged(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motor = cmd.motors[2];

            motor.power = trkPowerC.Value;
            String szPower = motor.power.ToString();
            if (motor.power == 0)
                szPower = "Off";
            lblPowerC.Text = "Power: (" + szPower + ")";
        }

        private void trkPowerB_ValueChanged(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motor = cmd.motors[1];

            motor.power = trkPowerB.Value;
            String szPower = motor.power.ToString();
            if (motor.power == 0)
                szPower = "Off";
            lblPowerB.Text = "Power: (" + szPower + ")";
        }

        private void trkPowerA_ValueChanged(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motor = cmd.motors[0];

            motor.power = trkPowerA.Value;

            String szPower = motor.power.ToString();
            if (motor.power == 0)
                szPower = "Off";
            lblPowerA.Text = "Power: (" + szPower + ")";
        }

        private void trkPowerA_Scroll(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motor = cmd.motors[0];

            motor.power = trkPowerA.Value;

            String szPower = motor.power.ToString();
            if (motor.power == 0)
                szPower = "Off";
            lblPowerA.Text = "Power: (" + szPower + ")";
        }

        private void trkPowerB_Scroll(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motor = cmd.motors[1];

            motor.power = trkPowerB.Value;
            String szPower = motor.power.ToString();
            if (motor.power == 0)
                szPower = "Off";
            lblPowerB.Text = "Power: (" + szPower + ")";
        }

        private void trkPowerC_Scroll(object sender, EventArgs e)
        {
            Command cmd = (Command)listBox1.SelectedItem;
            if (cmd == null)
                return;
            Motor motor = cmd.motors[2];

            motor.power = trkPowerC.Value;
            String szPower = motor.power.ToString();
            if (motor.power == 0)
                szPower = "Off";
            lblPowerC.Text = "Power: (" + szPower + ")";
        }
       

        

        
    }
}
