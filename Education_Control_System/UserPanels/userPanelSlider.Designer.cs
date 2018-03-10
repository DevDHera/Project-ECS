namespace Education_Control_System.UserPanels
{
    partial class userPanelSlider
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtlinkLogOut = new MetroFramework.Controls.MetroLink();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.mtlinkMail = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtlinkSettings = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(0, 41);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1414, 1);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(81, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Log in as :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(155, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "gfdgfd";
            // 
            // mtlinkLogOut
            // 
            this.mtlinkLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkLogOut.Location = new System.Drawing.Point(1260, 16);
            this.mtlinkLogOut.Name = "mtlinkLogOut";
            this.mtlinkLogOut.Size = new System.Drawing.Size(75, 23);
            this.mtlinkLogOut.TabIndex = 5;
            this.mtlinkLogOut.Text = "Log Out";
            this.mtlinkLogOut.UseSelectable = true;
            this.mtlinkLogOut.Click += new System.EventHandler(this.mtlinkLogOut_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(597, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 0);
            this.lblTime.TabIndex = 7;
            // 
            // mtlinkMail
            // 
            this.mtlinkMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtlinkMail.BackColor = System.Drawing.Color.Transparent;
            this.mtlinkMail.BackgroundImage = global::Education_Control_System.Properties.Resources.if_mailbox_103624;
            this.mtlinkMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mtlinkMail.Location = new System.Drawing.Point(477, 13);
            this.mtlinkMail.Name = "mtlinkMail";
            this.mtlinkMail.Size = new System.Drawing.Size(75, 23);
            this.mtlinkMail.TabIndex = 6;
            this.mtlinkMail.UseSelectable = true;
            this.mtlinkMail.Click += new System.EventHandler(this.mtlinkMail_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 36);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mtlinkSettings
            // 
            this.mtlinkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkSettings.BackColor = System.Drawing.Color.Transparent;
            this.mtlinkSettings.BackgroundImage = global::Education_Control_System.Properties.Resources.if_settings_115801;
            this.mtlinkSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mtlinkSettings.Location = new System.Drawing.Point(1341, 3);
            this.mtlinkSettings.Name = "mtlinkSettings";
            this.mtlinkSettings.Size = new System.Drawing.Size(77, 33);
            this.mtlinkSettings.TabIndex = 0;
            this.mtlinkSettings.UseSelectable = true;
            this.mtlinkSettings.Click += new System.EventHandler(this.mtlinkSettings_Click);
            // 
            // userPanelSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mtlinkMail);
            this.Controls.Add(this.mtlinkLogOut);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtlinkSettings);
            this.Name = "userPanelSlider";
            this.Size = new System.Drawing.Size(1421, 610);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mtlinkSettings;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink mtlinkLogOut;
        private MetroFramework.Controls.MetroLink mtlinkMail;
        private MetroFramework.Controls.MetroLabel lblTime;
    }
}
