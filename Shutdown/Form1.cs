using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Shutdown
{
    public partial class Form1 : Form
    {

        string timeType;
        float timeleft;         //Set the time left from the text box
        float secondsleft;      //Time left in seconds
        string option;          //Shutdown arguments


        public Form1()
        {
            InitializeComponent();
            cmbtype.SelectedIndex = 2;        //Set the first item in list as selected
        }
        
        private void btnshutdown_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblscheduled.Text = "Shut down Scheduled";
            Process.Start("shutdown", " /s /t " + ShutdownTime());
        }

        //Button to exit 
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string ShutdownTime()
        {
            timeleft = float.Parse(txttimeleft.Text);
            timeType = cmbtype.Text.ToLower();

            switch (timeType)
            {
                case "seconds":
                    secondsleft = timeleft;
                    break;
                case "minutes":
                    secondsleft = timeleft * 60;
                    break;
                case "hours":
                    secondsleft = timeleft * 3600;
                    break;
            }
            return secondsleft.ToString();
        }

        public string ShutdownType(string type)
        {
            switch (type.ToLower())
            {
                case "shutdown":
                    option = "/s";
                    break;
                case "restart":
                    option = "/r";
                    break;
                case "with options":
                    option = "/r /o";
                    break;
            }
            return option.ToString();
        }
    }
}
