namespace Shutdoww
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txttimeleft = new System.Windows.Forms.TextBox();
            this.btnshutdown = new System.Windows.Forms.Button();
            this.btnabort = new System.Windows.Forms.Button();
            this.lbltimeleft = new System.Windows.Forms.Label();
            this.lblsecondsleft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.lblscheduled = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.btnoptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Time";
            // 
            // txttimeleft
            // 
            this.txttimeleft.Location = new System.Drawing.Point(68, 9);
            this.txttimeleft.Name = "txttimeleft";
            this.txttimeleft.Size = new System.Drawing.Size(100, 20);
            this.txttimeleft.TabIndex = 2;
            this.txttimeleft.Text = "2";
            // 
            // btnshutdown
            // 
            this.btnshutdown.Location = new System.Drawing.Point(174, 9);
            this.btnshutdown.Name = "btnshutdown";
            this.btnshutdown.Size = new System.Drawing.Size(100, 20);
            this.btnshutdown.TabIndex = 4;
            this.btnshutdown.Text = "Shutdown";
            this.btnshutdown.UseVisualStyleBackColor = true;
            this.btnshutdown.Click += new System.EventHandler(this.btnshutdown_Click);
            // 
            // btnabort
            // 
            this.btnabort.Location = new System.Drawing.Point(174, 86);
            this.btnabort.Name = "btnabort";
            this.btnabort.Size = new System.Drawing.Size(100, 23);
            this.btnabort.TabIndex = 5;
            this.btnabort.Text = "Abort";
            this.btnabort.UseVisualStyleBackColor = true;
            this.btnabort.Click += new System.EventHandler(this.btnabort_Click);
            // 
            // lbltimeleft
            // 
            this.lbltimeleft.AutoSize = true;
            this.lbltimeleft.Location = new System.Drawing.Point(12, 112);
            this.lbltimeleft.Name = "lbltimeleft";
            this.lbltimeleft.Size = new System.Drawing.Size(66, 13);
            this.lbltimeleft.TabIndex = 6;
            this.lbltimeleft.Text = "Seconds left";
            // 
            // lblsecondsleft
            // 
            this.lblsecondsleft.AutoSize = true;
            this.lblsecondsleft.Location = new System.Drawing.Point(102, 112);
            this.lblsecondsleft.Name = "lblsecondsleft";
            this.lblsecondsleft.Size = new System.Drawing.Size(13, 13);
            this.lblsecondsleft.TabIndex = 7;
            this.lblsecondsleft.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbtype
            // 
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
            this.cmbtype.Location = new System.Drawing.Point(68, 33);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(100, 21);
            this.cmbtype.TabIndex = 9;
            // 
            // lblscheduled
            // 
            this.lblscheduled.AutoSize = true;
            this.lblscheduled.Location = new System.Drawing.Point(186, 112);
            this.lblscheduled.Name = "lblscheduled";
            this.lblscheduled.Size = new System.Drawing.Size(130, 13);
            this.lblscheduled.TabIndex = 10;
            this.lblscheduled.Text = "Shutdown Not scheduled ";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(281, 9);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(101, 100);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Location = new System.Drawing.Point(174, 34);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(100, 20);
            this.btnrestart.TabIndex = 8;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btnoptions
            // 
            this.btnoptions.Location = new System.Drawing.Point(174, 60);
            this.btnoptions.Name = "btnoptions";
            this.btnoptions.Size = new System.Drawing.Size(100, 20);
            this.btnoptions.TabIndex = 12;
            this.btnoptions.Text = "With Options";
            this.btnoptions.UseVisualStyleBackColor = true;
            this.btnoptions.Click += new System.EventHandler(this.btnoptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 176);
            this.Controls.Add(this.btnoptions);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblscheduled);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.lblsecondsleft);
            this.Controls.Add(this.lbltimeleft);
            this.Controls.Add(this.btnabort);
            this.Controls.Add(this.btnshutdown);
            this.Controls.Add(this.txttimeleft);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Shutdown Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimeleft;
        private System.Windows.Forms.Button btnshutdown;
        private System.Windows.Forms.Button btnabort;
        private System.Windows.Forms.Label lbltimeleft;
        private System.Windows.Forms.Label lblsecondsleft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Label lblscheduled;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button btnoptions;
    }
}

