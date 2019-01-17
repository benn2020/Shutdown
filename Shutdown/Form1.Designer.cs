namespace Shutdown
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
            this.btnoptions = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblscheduled = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.btnrestart = new System.Windows.Forms.Button();
            this.lblsecondsleft = new System.Windows.Forms.Label();
            this.lbltimeleft = new System.Windows.Forms.Label();
            this.btnabort = new System.Windows.Forms.Button();
            this.btnshutdown = new System.Windows.Forms.Button();
            this.txttimeleft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnoptions
            // 
            this.btnoptions.Location = new System.Drawing.Point(222, 76);
            this.btnoptions.Margin = new System.Windows.Forms.Padding(4);
            this.btnoptions.Name = "btnoptions";
            this.btnoptions.Size = new System.Drawing.Size(133, 25);
            this.btnoptions.TabIndex = 23;
            this.btnoptions.Text = "With Options";
            this.btnoptions.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(365, 13);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(135, 123);
            this.btnexit.TabIndex = 22;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // lblscheduled
            // 
            this.lblscheduled.AutoSize = true;
            this.lblscheduled.Location = new System.Drawing.Point(238, 140);
            this.lblscheduled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblscheduled.Name = "lblscheduled";
            this.lblscheduled.Size = new System.Drawing.Size(169, 17);
            this.lblscheduled.TabIndex = 21;
            this.lblscheduled.Text = "Shutdown Not scheduled ";
            // 
            // cmbtype
            // 
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
            this.cmbtype.Location = new System.Drawing.Point(81, 43);
            this.cmbtype.Margin = new System.Windows.Forms.Padding(4);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(132, 24);
            this.cmbtype.TabIndex = 20;
            // 
            // btnrestart
            // 
            this.btnrestart.Location = new System.Drawing.Point(222, 44);
            this.btnrestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(133, 25);
            this.btnrestart.TabIndex = 19;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            // 
            // lblsecondsleft
            // 
            this.lblsecondsleft.AutoSize = true;
            this.lblsecondsleft.Location = new System.Drawing.Point(126, 140);
            this.lblsecondsleft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsecondsleft.Name = "lblsecondsleft";
            this.lblsecondsleft.Size = new System.Drawing.Size(16, 17);
            this.lblsecondsleft.TabIndex = 18;
            this.lblsecondsleft.Text = "0";
            // 
            // lbltimeleft
            // 
            this.lbltimeleft.AutoSize = true;
            this.lbltimeleft.Location = new System.Drawing.Point(6, 140);
            this.lbltimeleft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltimeleft.Name = "lbltimeleft";
            this.lbltimeleft.Size = new System.Drawing.Size(86, 17);
            this.lbltimeleft.TabIndex = 17;
            this.lbltimeleft.Text = "Seconds left";
            // 
            // btnabort
            // 
            this.btnabort.Location = new System.Drawing.Point(222, 108);
            this.btnabort.Margin = new System.Windows.Forms.Padding(4);
            this.btnabort.Name = "btnabort";
            this.btnabort.Size = new System.Drawing.Size(133, 28);
            this.btnabort.TabIndex = 16;
            this.btnabort.Text = "Abort";
            this.btnabort.UseVisualStyleBackColor = true;
            // 
            // btnshutdown
            // 
            this.btnshutdown.Location = new System.Drawing.Point(222, 13);
            this.btnshutdown.Margin = new System.Windows.Forms.Padding(4);
            this.btnshutdown.Name = "btnshutdown";
            this.btnshutdown.Size = new System.Drawing.Size(133, 25);
            this.btnshutdown.TabIndex = 15;
            this.btnshutdown.Text = "Shutdown";
            this.btnshutdown.UseVisualStyleBackColor = true;
            // 
            // txttimeleft
            // 
            this.txttimeleft.Location = new System.Drawing.Point(81, 13);
            this.txttimeleft.Margin = new System.Windows.Forms.Padding(4);
            this.txttimeleft.Name = "txttimeleft";
            this.txttimeleft.Size = new System.Drawing.Size(132, 22);
            this.txttimeleft.TabIndex = 14;
            this.txttimeleft.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Set Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 198);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnoptions;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblscheduled;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Label lblsecondsleft;
        private System.Windows.Forms.Label lbltimeleft;
        private System.Windows.Forms.Button btnabort;
        private System.Windows.Forms.Button btnshutdown;
        private System.Windows.Forms.TextBox txttimeleft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

