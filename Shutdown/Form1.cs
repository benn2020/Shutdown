﻿using System;
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

        private void Form1_Load(object sender, EventArgs e) => cmbtype.SelectedIndex = 2;        //Set the first item in list as selected

        string TimeType;
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
    }
}
