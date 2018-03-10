namespace Education_Control_System.UserPanels
{
    partial class scheduleDetails
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
            this.mtlinkBack1 = new MetroFramework.Controls.MetroLink();
            this.mtcrateSch = new MetroFramework.Controls.MetroTile();
            this.mtUploadSch = new MetroFramework.Controls.MetroTile();
            this.mtUpdateSchedule = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtlinkBack1
            // 
            this.mtlinkBack1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkBack1.Image = global::Education_Control_System.Properties.Resources.if_left_1348641;
            this.mtlinkBack1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlinkBack1.Location = new System.Drawing.Point(734, 3);
            this.mtlinkBack1.Name = "mtlinkBack1";
            this.mtlinkBack1.Size = new System.Drawing.Size(75, 23);
            this.mtlinkBack1.TabIndex = 1;
            this.mtlinkBack1.Text = "Back";
            this.mtlinkBack1.UseSelectable = true;
            this.mtlinkBack1.Click += new System.EventHandler(this.mtlinkBack1_Click);
            // 
            // mtcrateSch
            // 
            this.mtcrateSch.ActiveControl = null;
            this.mtcrateSch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mtcrateSch.Location = new System.Drawing.Point(55, 173);
            this.mtcrateSch.Name = "mtcrateSch";
            this.mtcrateSch.Size = new System.Drawing.Size(172, 187);
            this.mtcrateSch.TabIndex = 0;
            this.mtcrateSch.Text = "Create \r\nSchedule";
            this.mtcrateSch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtcrateSch.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtcrateSch.UseSelectable = true;
            this.mtcrateSch.Click += new System.EventHandler(this.mtcrateSch_Click);
            // 
            // mtUploadSch
            // 
            this.mtUploadSch.ActiveControl = null;
            this.mtUploadSch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtUploadSch.Location = new System.Drawing.Point(524, 173);
            this.mtUploadSch.Name = "mtUploadSch";
            this.mtUploadSch.Size = new System.Drawing.Size(172, 187);
            this.mtUploadSch.TabIndex = 0;
            this.mtUploadSch.Text = "Upload \r\nSchedule";
            this.mtUploadSch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUploadSch.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtUploadSch.UseSelectable = true;
            this.mtUploadSch.Click += new System.EventHandler(this.mtUploadSch_Click);
            // 
            // mtUpdateSchedule
            // 
            this.mtUpdateSchedule.ActiveControl = null;
            this.mtUpdateSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mtUpdateSchedule.Location = new System.Drawing.Point(292, 173);
            this.mtUpdateSchedule.Name = "mtUpdateSchedule";
            this.mtUpdateSchedule.Size = new System.Drawing.Size(172, 187);
            this.mtUpdateSchedule.TabIndex = 0;
            this.mtUpdateSchedule.Text = "Update \r\nSchedule";
            this.mtUpdateSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUpdateSchedule.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtUpdateSchedule.UseSelectable = true;
            this.mtUpdateSchedule.Click += new System.EventHandler(this.mtUpdateSchedule_Click);
            // 
            // scheduleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtlinkBack1);
            this.Controls.Add(this.mtcrateSch);
            this.Controls.Add(this.mtUploadSch);
            this.Controls.Add(this.mtUpdateSchedule);
            this.Name = "scheduleDetails";
            this.Size = new System.Drawing.Size(812, 504);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtUpdateSchedule;
        private MetroFramework.Controls.MetroTile mtcrateSch;
        private MetroFramework.Controls.MetroTile mtUploadSch;
        private MetroFramework.Controls.MetroLink mtlinkBack1;
    }
}
