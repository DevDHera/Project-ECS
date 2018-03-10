namespace Education_Control_System.UserPanels
{
    partial class UploadScheduleTaskWindow
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
            this.mtGmail = new MetroFramework.Controls.MetroTile();
            this.mtOffice365 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtGmail
            // 
            this.mtGmail.ActiveControl = null;
            this.mtGmail.Location = new System.Drawing.Point(50, 24);
            this.mtGmail.Name = "mtGmail";
            this.mtGmail.Size = new System.Drawing.Size(90, 85);
            this.mtGmail.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtGmail.TabIndex = 0;
            this.mtGmail.Text = "Gmail";
            this.mtGmail.UseSelectable = true;
            this.mtGmail.UseStyleColors = true;
            this.mtGmail.Click += new System.EventHandler(this.mtGmail_Click);
            // 
            // mtOffice365
            // 
            this.mtOffice365.ActiveControl = null;
            this.mtOffice365.Location = new System.Drawing.Point(228, 24);
            this.mtOffice365.Name = "mtOffice365";
            this.mtOffice365.Size = new System.Drawing.Size(90, 85);
            this.mtOffice365.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtOffice365.TabIndex = 0;
            this.mtOffice365.Text = "Office 365";
            this.mtOffice365.UseSelectable = true;
            this.mtOffice365.UseStyleColors = true;
            this.mtOffice365.Click += new System.EventHandler(this.mtOffice365_Click);
            // 
            // UploadScheduleTaskWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtOffice365);
            this.Controls.Add(this.mtGmail);
            this.Name = "UploadScheduleTaskWindow";
            this.Size = new System.Drawing.Size(429, 236);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtGmail;
        private MetroFramework.Controls.MetroTile mtOffice365;
    }
}
