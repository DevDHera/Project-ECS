namespace Education_Control_System.UserPanels
{
    partial class userPanelLecturer
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
            this.mtSchedule = new MetroFramework.Controls.MetroTile();
            this.mtReview = new MetroFramework.Controls.MetroTile();
            this.mtCheckStudent = new MetroFramework.Controls.MetroTile();
            this.mtEvaluvateSeeker = new MetroFramework.Controls.MetroTile();
            this.mtLogout = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mtSchedule
            // 
            this.mtSchedule.ActiveControl = null;
            this.mtSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mtSchedule.Location = new System.Drawing.Point(206, 164);
            this.mtSchedule.Name = "mtSchedule";
            this.mtSchedule.Size = new System.Drawing.Size(157, 335);
            this.mtSchedule.TabIndex = 8;
            this.mtSchedule.Text = "Check Schedule";
            this.mtSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSchedule.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSchedule.UseSelectable = true;
            this.mtSchedule.UseStyleColors = true;
            this.mtSchedule.Click += new System.EventHandler(this.mtSchedule_Click);
            // 
            // mtReview
            // 
            this.mtReview.ActiveControl = null;
            this.mtReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtReview.Location = new System.Drawing.Point(388, 164);
            this.mtReview.Name = "mtReview";
            this.mtReview.Size = new System.Drawing.Size(318, 122);
            this.mtReview.Style = MetroFramework.MetroColorStyle.Green;
            this.mtReview.TabIndex = 8;
            this.mtReview.Text = "Review Student";
            this.mtReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReview.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtReview.UseSelectable = true;
            this.mtReview.UseStyleColors = true;
            this.mtReview.Click += new System.EventHandler(this.mtReview_Click);
            // 
            // mtCheckStudent
            // 
            this.mtCheckStudent.ActiveControl = null;
            this.mtCheckStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtCheckStudent.Location = new System.Drawing.Point(388, 377);
            this.mtCheckStudent.Name = "mtCheckStudent";
            this.mtCheckStudent.Size = new System.Drawing.Size(318, 122);
            this.mtCheckStudent.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtCheckStudent.TabIndex = 8;
            this.mtCheckStudent.Text = "Student Details";
            this.mtCheckStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCheckStudent.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCheckStudent.UseSelectable = true;
            this.mtCheckStudent.UseStyleColors = true;
            // 
            // mtEvaluvateSeeker
            // 
            this.mtEvaluvateSeeker.ActiveControl = null;
            this.mtEvaluvateSeeker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtEvaluvateSeeker.Location = new System.Drawing.Point(735, 164);
            this.mtEvaluvateSeeker.Name = "mtEvaluvateSeeker";
            this.mtEvaluvateSeeker.Size = new System.Drawing.Size(157, 335);
            this.mtEvaluvateSeeker.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtEvaluvateSeeker.TabIndex = 8;
            this.mtEvaluvateSeeker.Text = "Tutor Seeker \r\nFeedback";
            this.mtEvaluvateSeeker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEvaluvateSeeker.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtEvaluvateSeeker.UseSelectable = true;
            this.mtEvaluvateSeeker.UseStyleColors = true;
            // 
            // mtLogout
            // 
            this.mtLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtLogout.Location = new System.Drawing.Point(925, 13);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(75, 23);
            this.mtLogout.TabIndex = 9;
            this.mtLogout.Text = "Log Out";
            this.mtLogout.UseSelectable = true;
            this.mtLogout.Click += new System.EventHandler(this.mtLogout_Click);
            // 
            // userPanelLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtLogout);
            this.Controls.Add(this.mtCheckStudent);
            this.Controls.Add(this.mtReview);
            this.Controls.Add(this.mtEvaluvateSeeker);
            this.Controls.Add(this.mtSchedule);
            this.Name = "userPanelLecturer";
            this.Size = new System.Drawing.Size(1059, 642);
            this.Controls.SetChildIndex(this.mtSchedule, 0);
            this.Controls.SetChildIndex(this.mtEvaluvateSeeker, 0);
            this.Controls.SetChildIndex(this.mtReview, 0);
            this.Controls.SetChildIndex(this.mtCheckStudent, 0);
            this.Controls.SetChildIndex(this.mtLogout, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtSchedule;
        private MetroFramework.Controls.MetroTile mtReview;
        private MetroFramework.Controls.MetroTile mtCheckStudent;
        private MetroFramework.Controls.MetroTile mtEvaluvateSeeker;
        private MetroFramework.Controls.MetroLink mtLogout;
    }
}
