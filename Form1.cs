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

namespace Shutdoww
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbtype.SelectedIndex = 2;        // set the first item in list as selected
        }

        string TimeType; 
        float timeleft; // Set the time left from the text box
        float secondsleft; // Time left in seconds
        string option; //Shutdown arguments


        public string ShutdownTimeFunction()
        {
            timeleft = float.Parse(txttimeleft.Text); // Set the time left from the text box
            TimeType = cmbtype.Text; //Take mesaure of time eg. Hour/minute
            switch (TimeType)
            {
                case "Seconds":
                    secondsleft = timeleft; // Sets the time in seconds
                    break;
                case "Minutes":
                    secondsleft = timeleft * 60; // Sets the time in minutes
                    break;
                case "Hours":
                    secondsleft = timeleft * 3600; // Sets the time in hours
                    break;
            }
            return secondsleft.ToString();
        }
        
        public string ShutdownTypeFunction(string Type)
        {
            //string ShutdownType;
            switch (Type)
            {
                case "Shutdown":
                    option = "/s";
                    break;
                case "Restart":
                    option = "/r";
                    break;
                case "With options":
                    option = "/r /o";
                    break;
            }
            return option.ToString();
        }
        private void btnshutdown_Click(object sender, EventArgs e)
        {
            //ShutdownTimeFunction(); // Sets the time 
            timer1.Enabled = true; // Starts the timer 
            lblscheduled.Text = "Shutdown scheduled"; // Tells the user that the shutdown is scheduled
            Process.Start("shutdown", " /s /t " + ShutdownTimeFunction()); // Start the shutdown process
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            ShutdownTimeFunction(); // Sets the time 
            timer1.Enabled = true; // Starts the timer 
            lblscheduled.Text = "Restart scheduled"; // Tells the user that the restart is scheduled
            Process.Start("shutdown", " /r /t " + secondsleft); //Starts the restart process
        }

        private void btnoptions_Click(object sender, EventArgs e)
        {
            ShutdownTimeFunction();
            timer1.Enabled = true;
            lblscheduled.Text = "Restart with options scheduled"; // Tells the user that the restart is scheduled
            Process.Start("shutdown", "/r /o /t " + secondsleft); // Starts the restart process
        }

        private void btnabort_Click(object sender, EventArgs e)
        {
            lblscheduled.Text = "Shutdown/Restart not scheduled"; //Tell the user that nothing is scheduled
            lblsecondsleft.Text = "0"; // Set the timer label to 0
            Process.Start("shutdown", "/a"); // Abort the process
            timer1.Stop(); // Stop the timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsleft--;
            lblsecondsleft.Text = secondsleft.ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}