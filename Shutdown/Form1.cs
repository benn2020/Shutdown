using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbtype.SelectedIndex = 0;        //Set the first item in list as selected
        }

        string timeType;
        float timeleft;         //Set the time left from the text box
        float secondsleft;      //Time left in seconds
        string option;          //Shutdown arguments


        private void btnshutdown_Click(object sender, EventArgs e)
        {
            
        }

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
