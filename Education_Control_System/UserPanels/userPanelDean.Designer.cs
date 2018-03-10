namespace Education_Control_System.UserPanels
{
    partial class userPanelDean
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
            this.mtDetailedReport = new MetroFramework.Controls.MetroTile();
            this.mtSummeryReport = new MetroFramework.Controls.MetroTile();
            this.mtExceptionReports = new MetroFramework.Controls.MetroTile();
            this.mtlinkLogOut1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mtDetailedReport
            // 
            this.mtDetailedReport.ActiveControl = null;
            this.mtDetailedReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtDetailedReport.Location = new System.Drawing.Point(332, 118);
            this.mtDetailedReport.Name = "mtDetailedReport";
            this.mtDetailedReport.Size = new System.Drawing.Size(1096, 114);
            this.mtDetailedReport.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtDetailedReport.TabIndex = 8;
            this.mtDetailedReport.Text = "Detailed Reports";
            this.mtDetailedReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDetailedReport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDetailedReport.UseSelectable = true;
            this.mtDetailedReport.UseStyleColors = true;
            this.mtDetailedReport.Click += new System.EventHandler(this.mtDetailedReport_Click);
            // 
            // mtSummeryReport
            // 
            this.mtSummeryReport.ActiveControl = null;
            this.mtSummeryReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtSummeryReport.Location = new System.Drawing.Point(332, 256);
            this.mtSummeryReport.Name = "mtSummeryReport";
            this.mtSummeryReport.Size = new System.Drawing.Size(1096, 114);
            this.mtSummeryReport.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtSummeryReport.TabIndex = 8;
            this.mtSummeryReport.Text = "Summery Reports";
            this.mtSummeryReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSummeryReport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSummeryReport.UseSelectable = true;
            this.mtSummeryReport.Click += new System.EventHandler(this.mtSummeryReport_Click);
            // 
            // mtExceptionReports
            // 
            this.mtExceptionReports.ActiveControl = null;
            this.mtExceptionReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtExceptionReports.Location = new System.Drawing.Point(332, 392);
            this.mtExceptionReports.Name = "mtExceptionReports";
            this.mtExceptionReports.Size = new System.Drawing.Size(1096, 114);
            this.mtExceptionReports.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtExceptionReports.TabIndex = 8;
            this.mtExceptionReports.Text = "Exception Reports";
            this.mtExceptionReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtExceptionReports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtExceptionReports.UseSelectable = true;
            this.mtExceptionReports.Click += new System.EventHandler(this.mtExceptionReports_Click);
            // 
            // mtlinkLogOut1
            // 
            this.mtlinkLogOut1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkLogOut1.Location = new System.Drawing.Point(1623, 13);
            this.mtlinkLogOut1.Name = "mtlinkLogOut1";
            this.mtlinkLogOut1.Size = new System.Drawing.Size(75, 23);
            this.mtlinkLogOut1.TabIndex = 9;
            this.mtlinkLogOut1.Text = "Log Out";
            this.mtlinkLogOut1.UseSelectable = true;
            this.mtlinkLogOut1.Click += new System.EventHandler(this.mtlinkLogOut1_Click);
            // 
            // userPanelDean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtlinkLogOut1);
            this.Controls.Add(this.mtExceptionReports);
            this.Controls.Add(this.mtSummeryReport);
            this.Controls.Add(this.mtDetailedReport);
            this.Name = "userPanelDean";
            this.Size = new System.Drawing.Size(1736, 519);
            this.Controls.SetChildIndex(this.mtDetailedReport, 0);
            this.Controls.SetChildIndex(this.mtSummeryReport, 0);
            this.Controls.SetChildIndex(this.mtExceptionReports, 0);
            this.Controls.SetChildIndex(this.mtlinkLogOut1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtDetailedReport;
        private MetroFramework.Controls.MetroTile mtSummeryReport;
        private MetroFramework.Controls.MetroTile mtExceptionReports;
        private MetroFramework.Controls.MetroLink mtlinkLogOut1;
    }
}
