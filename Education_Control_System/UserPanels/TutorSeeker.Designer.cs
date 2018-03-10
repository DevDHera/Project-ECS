namespace Education_Control_System.UserPanels
{
    partial class TutorSeeker
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtInitialize = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.mtlinkBack1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(98, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(653, 512);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // mtInitialize
            // 
            this.mtInitialize.ActiveControl = null;
            this.mtInitialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtInitialize.Location = new System.Drawing.Point(337, 129);
            this.mtInitialize.Name = "mtInitialize";
            this.mtInitialize.Size = new System.Drawing.Size(202, 182);
            this.mtInitialize.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtInitialize.TabIndex = 1;
            this.mtInitialize.Text = "Initialize \r\nTutor \r\nSeeker";
            this.mtInitialize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtInitialize.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtInitialize.UseSelectable = true;
            this.mtInitialize.UseStyleColors = true;
            this.mtInitialize.Click += new System.EventHandler(this.mtInitialize_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(250, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Find the Best Tutor Among You";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressSpinner1.Location = new System.Drawing.Point(315, 126);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(257, 182);
            this.metroProgressSpinner1.TabIndex = 10;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Visible = false;
            this.metroProgressSpinner1.Click += new System.EventHandler(this.metroProgressSpinner1_Click);
            // 
            // mtlinkBack1
            // 
            this.mtlinkBack1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkBack1.Image = global::Education_Control_System.Properties.Resources.if_left_1348641;
            this.mtlinkBack1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlinkBack1.Location = new System.Drawing.Point(890, 3);
            this.mtlinkBack1.Name = "mtlinkBack1";
            this.mtlinkBack1.Size = new System.Drawing.Size(75, 23);
            this.mtlinkBack1.TabIndex = 11;
            this.mtlinkBack1.Text = "Back";
            this.mtlinkBack1.UseSelectable = true;
            this.mtlinkBack1.Click += new System.EventHandler(this.mtlinkBack1_Click);
            // 
            // TutorSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtlinkBack1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.mtInitialize);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TutorSeeker";
            this.Size = new System.Drawing.Size(965, 540);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mtInitialize;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLink mtlinkBack1;
    }
}
