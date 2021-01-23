using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legion_Save_Manager
{
    
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private static readonly int VK_SNAPSHOT = 0x2C; //This is the print-screen key.

        //Assume the timer is setup with Interval = 16 (corresponds to ~60FPS).
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        WDLSaveManager sm = new WDLSaveManager();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Timer1_Tick(object source, EventArgs e)
        {
            short keyState = GetAsyncKeyState(VK_SNAPSHOT);

            //Check if the MSB is set. If so, then the key is pressed.
            bool prntScrnIsPressed = ((keyState >> 15) & 0x0001) == 0x0001;

            //Check if the LSB is set. If so, then the key was pressed since
            //the last call to GetAsyncKeyState
            bool unprocessedPress = ((keyState >> 0) & 0x0001) == 0x0001;

            if (prntScrnIsPressed)
            {
                //TODO Execute client code...
                System.Diagnostics.Debug.WriteLine("Save Key Pressed");
            }

            if (unprocessedPress)
            {
                //TODO Execute client code...
                System.Diagnostics.Debug.WriteLine("Timer Running");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WriteToLogBox("Application Launch Successful");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            WriteToLogBox("test");
            timer1.Tick += new System.EventHandler(Timer1_Tick);
            timer1.Start();
            sm.PromptWDLSaveLocation();
        }
        private void WriteToLogBox(string message)
        {
            logtextbox.AppendText(message);
            logtextbox.AppendText(Environment.NewLine);
        }
    }
}
