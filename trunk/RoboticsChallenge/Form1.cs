using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Management;
using System.Collections;
using System.Runtime.InteropServices;


using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using InTheHand.Net;



namespace RoboticsChallenge
{
    
    
    public partial class Form1 : Form
    {
        public const int MAX_MESSAGE_SIZE = 128;

        public delegate void AddDevicesDelegate();
        public AddDevicesDelegate addDeviceDelegate;

        public BluetoothClient btClient;
        public ArrayList nxtDevices = new ArrayList();

        public String szCurrentCommand = "";
        public Motor[] runningMotors = new Motor[3];

        public Form1()
        {
            InitializeComponent();

            if (Variables.config == null)
            {
                Variables.config = new MotorConfig();
                Variables.config.readconfig("config.txt");
            }

            btnDisconnect.Enabled = false;
            btnConnect.Enabled = false;

            //Create delegate to change Form inputs
            addDeviceDelegate = new AddDevicesDelegate(AddDevicesMethod);
        }

        /// <summary>
        /// Locates all Bluetooth Devices in range and grabs their COM port, and saves to list.
        /// </summary>
        public void FindDevices()
        {
            BluetoothDeviceInfo[] bdi;
            try
            {
                //Get a list of Discovered Devices
                btClient = new BluetoothClient();
                bdi = (BluetoothDeviceInfo[])btClient.DiscoverDevices();
            }
            catch (Exception e)
            {
                this.Invoke(addDeviceDelegate);
                return;
            }
            //Compare discovered Bluetooth Devices with COM ports, and create new RoboticsDeviceInfo
            foreach (BluetoothDeviceInfo di in bdi)
            {
                //Add device to nxtDevices list
                RoboticsDeviceInfo rdi = new RoboticsDeviceInfo(di);
                        
                lock (nxtDevices)
                {
                    bool bAdd = true;
                    foreach (RoboticsDeviceInfo nxtdi in nxtDevices)
                    {
                        if (nxtdi.DeviceName.Equals(rdi.DeviceName))
                        {
                            bAdd = false;
                            break;
                        }
                    }
                    if( bAdd )
                        nxtDevices.Add(rdi);
                }
            }

            //Update our ComboBox and the FindDevices button state
            this.Invoke(addDeviceDelegate);
        }

        /// <summary>
        /// Delegate to update form inputs after devices have been located.
        /// </summary>
        public void AddDevicesMethod()
        {
            lstDevices.Items.Clear();
            foreach (RoboticsDeviceInfo rdi in nxtDevices)
            {
                lstDevices.Items.Add(rdi);
            }
            lstDevices.DisplayMember = "DeviceName";

            btnFindDevices.Text = "Find Devices";
            btnFindDevices.Enabled = true;
            btnConnect.Enabled = true;
        }


        public void ConnectToDevice()
        {
            try
            {
                btnConnect.Enabled = false;
                
                btnFindDevices.Enabled = false;
                lstDevices.Enabled = false;
                RoboticsDeviceInfo rdi = (RoboticsDeviceInfo)lstDevices.SelectedItem;

                rdi.logDelegate = this.Log;
                rdi.connectedDelegate = this.Connected;
                rdi.Connect();
            }
            catch (Exception e)
            {
                btnConnect.Enabled = true;
                btnFindDevices.Enabled = true;
                lstDevices.Enabled = true;
            }
        }

        public void Connected()
        {

            RoboticsDeviceInfo rdi = (RoboticsDeviceInfo)lstDevices.SelectedItem;

            if (rdi.IsConnected)
            {
                Log("Connected to " + rdi.DeviceName);

                btnDisconnect.Enabled = true;
            }
            else
            {
                btnConnect.Enabled = true;
                lstDevices.Enabled = true;
                btnFindDevices.Enabled = true;
            }
        }

        /// <summary>
        /// Begin finding all Bluetooth devices in range
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindDevices_Click(object sender, EventArgs e)
        {
            btnFindDevices.Text = "Finding...";
            btnFindDevices.Enabled = false;

            System.Threading.Thread t1 = new System.Threading.Thread(FindDevices);
            t1.Start();
        }



        /// <summary>
        /// Attempt to pair with Bluetooth device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectToDevice();
        }


        private void btnBeep_Click(object sender, EventArgs e)
        {
            RoboticsDeviceInfo rdi = (RoboticsDeviceInfo)lstDevices.SelectedItem;
            try
            {
                rdi.NXT.PlayTone(400, 100, false);
            }
            catch (Exception ex)
            {
                this.Log("You must be connected to an NXT to Beep the NXT.");
            }
        }

        private void btnBattery_Click(object sender, EventArgs e)
        {
            RoboticsDeviceInfo rdi = (RoboticsDeviceInfo)lstDevices.SelectedItem;
            try
            {
                rdi.NXT.GetBatteryLevel();
            }
            catch (Exception ex)
            {
                this.Log("You must be connected to an NXT to view Battery Life.");
            }
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            RoboticsDeviceInfo rdi = (RoboticsDeviceInfo)lstDevices.SelectedItem;
            try
            {
                rdi.NXT.GetVersion();
            }
            catch (Exception ex)
            {
                this.Log("You must be connected to an NXT to check Version.");
            }
        }

        public void Log(string msg)
        {
            rtxtLog.Text += msg + "\r\n";
            rtxtLog.Select(rtxtLog.Text.Length, 1);
            rtxtLog.ScrollToCaret();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            RoboticsDeviceInfo rdi = (RoboticsDeviceInfo)lstDevices.SelectedItem;
            rdi.Disconnect();

            lstDevices.Enabled = true;
            btnConnect.Enabled = true;
            btnFindDevices.Enabled = true;
            btnDisconnect.Enabled = false;
        }
       
        [DllImport("user32.dll")]
        public static extern int GetKeyboardState(byte[] keystate);

        protected override bool ProcessKeyPreview(ref Message msg)
        {
            RoboticsDeviceInfo rdi = (RoboticsDeviceInfo)lstDevices.SelectedItem;

            byte[] keys = new byte[255];
            GetKeyboardState(keys);

            bool passed = false;
            int activeMotors = 0;

            runningMotors[0] = null;
            runningMotors[1] = null;
            runningMotors[2] = null;
            
            //Check double keys first
            foreach (Command cmd in Variables.config.commands)
            {
                if (cmd.keys1Count < 2)
                    continue;

                passed = true;
                foreach (int iKey in cmd.keys1)
                {
                    if ((keys[iKey] & 128) == 0)
                    {
                        passed = false;
                        break;
                    }
                }

                if (passed)
                {
                    int motorcnt = 0;
                    foreach (Motor mtr in cmd.motors)
                    {
                        if (runningMotors[motorcnt] == null && mtr.power > 0)
                        {
                            runningMotors[motorcnt] = mtr;
                            activeMotors++;
                        }
                       
                        motorcnt++;
                    }
                    szCurrentCommand = cmd.name;
                }
            }

            
            //Check single keys 
            foreach (Command cmd in Variables.config.commands)
            {
                if (cmd.keys1Count >= 2)
                    continue;

                passed = true;
                foreach (int iKey in cmd.keys1)
                {
                    if ((keys[iKey] & 128) == 0)
                    {
                        passed = false;
                        break;
                    }
                }

                if (passed)
                {
                    int motorcnt = 0;
                    foreach (Motor mtr in cmd.motors)
                    {
                        if (runningMotors[motorcnt] == null && mtr.power > 0)
                        {
                            runningMotors[motorcnt] = mtr;
                            activeMotors++;
                        }
                       
                        motorcnt++;
                    }
                    szCurrentCommand = cmd.name;
                }
            }

            if( activeMotors == 0 )
            {
                for (int i=0; i<runningMotors.Length; i++)
                {
                    runningMotors[i] = null;
                }
                szCurrentCommand = "";
                RunMotors();
            }

            this.rtxtLog.Focus();
           
            if (szCurrentCommand.Length > 0)
            {
                timer1.Enabled = true;
                return true;
            }


            return base.ProcessKeyPreview(ref msg);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            RunMotors();
        }


        public void RunMotors()
        {
            RoboticsDeviceInfo rdi = (RoboticsDeviceInfo)lstDevices.SelectedItem;
            if (rdi == null || rdi.NXT == null)
                return;

            sbyte turn = 0;
            ulong tacho = 0;

            int motorcnt = 0;
            foreach (Motor mtr in runningMotors)
            {
                if (mtr == null || mtr.power == 0)
                {
                    rdi.NXT.SetOutputState((NXTOutputPort)motorcnt, 0, NXTOutputMode.NONE, NXTOutputRegulationMode.REGULATION_MODE_IDLE, 0, NXTOutputRunState.MOTOR_RUN_STATE_IDLE, tacho);
                }
                else
                {
                    rdi.NXT.SetOutputState(mtr.port, (sbyte)(mtr.power * mtr.direction), NXTOutputMode.MOTORON, NXTOutputRegulationMode.REGULATION_MODE_MOTOR_SPEED, turn, NXTOutputRunState.MOTOR_RUN_STATE_RUNNING, tacho);
                }
                motorcnt++;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Variables.form2 != null)
            {
                Variables.form2.BringToFront();
                Variables.form2.Show();
                return;
            }

            ThreadProc();
        }


        public void ThreadProc()
        {
            Variables.form2 = new Form2();
            Variables.form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            //btClient.Close();
            //this.Dispose();
            //Application.Exit();
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Dispose();
        }

        



       
    }

}
