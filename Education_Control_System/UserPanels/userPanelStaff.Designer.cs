namespace Education_Control_System.UserPanels
{
    partial class userPanelStaff
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
            this.mtRegister = new MetroFramework.Controls.MetroTile();
            this.mtView = new MetroFramework.Controls.MetroTile();
            this.mtSchedule = new MetroFramework.Controls.MetroTile();
            this.mtReports = new MetroFramework.Controls.MetroTile();
            this.mtPayment = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtRegister
            // 
            this.mtRegister.ActiveControl = null;
            this.mtRegister.Location = new System.Drawing.Point(213, 157);
            this.mtRegister.Name = "mtRegister";
            this.mtRegister.Size = new System.Drawing.Size(179, 334);
            this.mtRegister.TabIndex = 8;
            this.mtRegister.Text = "Register";
            this.mtRegister.TileImage = global::Education_Control_System.Properties.Resources.if_Application_46710;
            this.mtRegister.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRegister.UseSelectable = true;
            this.mtRegister.UseTileImage = true;
            this.mtRegister.Click += new System.EventHandler(this.mtRegister_Click);
            // 
            // mtView
            // 
            this.mtView.ActiveControl = null;
            this.mtView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtView.Location = new System.Drawing.Point(404, 157);
            this.mtView.Name = "mtView";
            this.mtView.Size = new System.Drawing.Size(400, 159);
            this.mtView.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtView.TabIndex = 8;
            this.mtView.Text = "View";
            this.mtView.TileImage = global::Education_Control_System.Properties.Resources.if_Application_46710;
            this.mtView.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtView.UseSelectable = true;
            this.mtView.UseStyleColors = true;
            this.mtView.UseTileImage = true;
            this.mtView.Click += new System.EventHandler(this.mtView_Click);
            // 
            // mtSchedule
            // 
            this.mtSchedule.ActiveControl = null;
            this.mtSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtSchedule.Location = new System.Drawing.Point(404, 332);
            this.mtSchedule.Name = "mtSchedule";
            this.mtSchedule.Size = new System.Drawing.Size(400, 159);
            this.mtSchedule.Style = MetroFramework.MetroColorStyle.Magenta;
            this.mtSchedule.TabIndex = 8;
            this.mtSchedule.Text = "Schedule";
            this.mtSchedule.TileImage = global::Education_Control_System.Properties.Resources.if_ChronologicalReview_46712;
            this.mtSchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSchedule.UseSelectable = true;
            this.mtSchedule.UseStyleColors = true;
            this.mtSchedule.UseTileImage = true;
            this.mtSchedule.Click += new System.EventHandler(this.mtSchedule_Click);
            // 
            // mtReports
            // 
            this.mtReports.ActiveControl = null;
            this.mtReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtReports.Enabled = false;
            this.mtReports.Location = new System.Drawing.Point(810, 157);
            this.mtReports.Name = "mtReports";
            this.mtReports.Size = new System.Drawing.Size(179, 334);
            this.mtReports.TabIndex = 8;
            this.mtReports.Text = "Reports";
            this.mtReports.TileImage = global::Education_Control_System.Properties.Resources.if_ParameterReview_46717;
            this.mtReports.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReports.UseSelectable = true;
            this.mtReports.UseTileImage = true;
            this.mtReports.Click += new System.EventHandler(this.mtReports_Click);
            // 
            // mtPayment
            // 
            this.mtPayment.ActiveControl = null;
            this.mtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtPayment.Enabled = false;
            this.mtPayment.Location = new System.Drawing.Point(995, 157);
            this.mtPayment.Name = "mtPayment";
            this.mtPayment.Size = new System.Drawing.Size(179, 334);
            this.mtPayment.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtPayment.TabIndex = 8;
            this.mtPayment.Text = "Payment";
            this.mtPayment.TileImage = global::Education_Control_System.Properties.Resources.if_Application_46710;
            this.mtPayment.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPayment.UseSelectable = true;
            this.mtPayment.UseTileImage = true;
            this.mtPayment.Click += new System.EventHandler(this.mtPayment_Click);
            // 
            // userPanelStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.mtSchedule);
            this.Controls.Add(this.mtView);
            this.Controls.Add(this.mtPayment);
            this.Controls.Add(this.mtReports);
            this.Controls.Add(this.mtRegister);
            this.Name = "userPanelStaff";
            this.Size = new System.Drawing.Size(1353, 701);
            this.Controls.SetChildIndex(this.mtRegister, 0);
            this.Controls.SetChildIndex(this.mtReports, 0);
            this.Controls.SetChildIndex(this.mtPayment, 0);
            this.Controls.SetChildIndex(this.mtView, 0);
            this.Controls.SetChildIndex(this.mtSchedule, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtRegister;
        private MetroFramework.Controls.MetroTile mtView;
        private MetroFramework.Controls.MetroTile mtSchedule;
        private MetroFramework.Controls.MetroTile mtReports;
        private MetroFramework.Controls.MetroTile mtPayment;

    }
}
