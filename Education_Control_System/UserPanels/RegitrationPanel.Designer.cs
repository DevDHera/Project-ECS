namespace Education_Control_System.UserPanels
{
    partial class RegitrationPanel
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
            this.mtlinkBackRegP1 = new MetroFramework.Controls.MetroLink();
            this.mtStaffReg = new MetroFramework.Controls.MetroTile();
            this.mtStudentReg = new MetroFramework.Controls.MetroTile();
            this.mtLecturerReg = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtlinkBackRegP1
            // 
            this.mtlinkBackRegP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkBackRegP1.BackColor = System.Drawing.Color.Transparent;
            this.mtlinkBackRegP1.Image = global::Education_Control_System.Properties.Resources.if_left_1348641;
            this.mtlinkBackRegP1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlinkBackRegP1.Location = new System.Drawing.Point(989, 3);
            this.mtlinkBackRegP1.Name = "mtlinkBackRegP1";
            this.mtlinkBackRegP1.Size = new System.Drawing.Size(75, 23);
            this.mtlinkBackRegP1.TabIndex = 1;
            this.mtlinkBackRegP1.Text = "Back";
            this.mtlinkBackRegP1.UseCustomBackColor = true;
            this.mtlinkBackRegP1.UseSelectable = true;
            this.mtlinkBackRegP1.Click += new System.EventHandler(this.mtlinkBackRegP1_Click);
            // 
            // mtStaffReg
            // 
            this.mtStaffReg.ActiveControl = null;
            this.mtStaffReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtStaffReg.Location = new System.Drawing.Point(772, 478);
            this.mtStaffReg.Name = "mtStaffReg";
            this.mtStaffReg.Size = new System.Drawing.Size(176, 129);
            this.mtStaffReg.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtStaffReg.TabIndex = 0;
            this.mtStaffReg.Text = "Staff Member\r\nRegistration";
            this.mtStaffReg.TileImage = global::Education_Control_System.Properties.Resources.if_Man_9__379446;
            this.mtStaffReg.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtStaffReg.UseSelectable = true;
            this.mtStaffReg.UseStyleColors = true;
            this.mtStaffReg.UseTileImage = true;
            this.mtStaffReg.Click += new System.EventHandler(this.mtStaffReg_Click);
            // 
            // mtStudentReg
            // 
            this.mtStudentReg.ActiveControl = null;
            this.mtStudentReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mtStudentReg.Location = new System.Drawing.Point(413, 70);
            this.mtStudentReg.Name = "mtStudentReg";
            this.mtStudentReg.Size = new System.Drawing.Size(143, 537);
            this.mtStudentReg.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtStudentReg.TabIndex = 0;
            this.mtStudentReg.Text = "Student\r\nRegistration";
            this.mtStudentReg.TileImage = global::Education_Control_System.Properties.Resources.if_Student_3_379383;
            this.mtStudentReg.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtStudentReg.UseSelectable = true;
            this.mtStudentReg.UseStyleColors = true;
            this.mtStudentReg.UseTileImage = true;
            this.mtStudentReg.Click += new System.EventHandler(this.mtStudentReg_Click);
            // 
            // mtLecturerReg
            // 
            this.mtLecturerReg.ActiveControl = null;
            this.mtLecturerReg.Location = new System.Drawing.Point(49, 70);
            this.mtLecturerReg.Name = "mtLecturerReg";
            this.mtLecturerReg.Size = new System.Drawing.Size(148, 132);
            this.mtLecturerReg.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtLecturerReg.TabIndex = 0;
            this.mtLecturerReg.Text = "Lecturer \r\nRegistartion";
            this.mtLecturerReg.TileImage = global::Education_Control_System.Properties.Resources.if_Man_14_379444;
            this.mtLecturerReg.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtLecturerReg.UseSelectable = true;
            this.mtLecturerReg.UseStyleColors = true;
            this.mtLecturerReg.UseTileImage = true;
            this.mtLecturerReg.Click += new System.EventHandler(this.mtLecturerReg_Click);
            // 
            // RegitrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.mtlinkBackRegP1);
            this.Controls.Add(this.mtStaffReg);
            this.Controls.Add(this.mtStudentReg);
            this.Controls.Add(this.mtLecturerReg);
            this.Name = "RegitrationPanel";
            this.Size = new System.Drawing.Size(1064, 642);
            this.UseCustomBackColor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtLecturerReg;
        private MetroFramework.Controls.MetroTile mtStudentReg;
        private MetroFramework.Controls.MetroTile mtStaffReg;
        private MetroFramework.Controls.MetroLink mtlinkBackRegP1;
    }
}
