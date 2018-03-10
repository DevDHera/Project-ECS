namespace Education_Control_System
{
    partial class MainForm
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlSettings = new MetroFramework.Controls.MetroPanel();
            this.mtcSettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpTheme = new MetroFramework.Controls.MetroTabPage();
            this.mtpStyle = new MetroFramework.Controls.MetroTabPage();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mrbDark = new MetroFramework.Controls.MetroRadioButton();
            this.mrbLight = new MetroFramework.Controls.MetroRadioButton();
            this.mtlinkBack = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.mtcSettings.SuspendLayout();
            this.mtpTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSettings.Controls.Add(this.mtcSettings);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSettings.HorizontalScrollbarBarColor = true;
            this.pnlSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSettings.HorizontalScrollbarSize = 10;
            this.pnlSettings.Location = new System.Drawing.Point(509, 60);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(228, 435);
            this.pnlSettings.TabIndex = 0;
            this.pnlSettings.VerticalScrollbarBarColor = true;
            this.pnlSettings.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSettings.VerticalScrollbarSize = 10;
            this.pnlSettings.Visible = false;
            this.pnlSettings.VisibleChanged += new System.EventHandler(this.pnlSettings_VisibleChanged);
            // 
            // mtcSettings
            // 
            this.mtcSettings.Controls.Add(this.mtpTheme);
            this.mtcSettings.Controls.Add(this.mtpStyle);
            this.mtcSettings.Location = new System.Drawing.Point(14, 51);
            this.mtcSettings.Name = "mtcSettings";
            this.mtcSettings.SelectedIndex = 0;
            this.mtcSettings.Size = new System.Drawing.Size(200, 287);
            this.mtcSettings.TabIndex = 2;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpTheme
            // 
            this.mtpTheme.Controls.Add(this.mrbLight);
            this.mtpTheme.Controls.Add(this.mrbDark);
            this.mtpTheme.Controls.Add(this.metroLabel1);
            this.mtpTheme.Controls.Add(this.flpSettings);
            this.mtpTheme.HorizontalScrollbarBarColor = true;
            this.mtpTheme.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpTheme.HorizontalScrollbarSize = 10;
            this.mtpTheme.Location = new System.Drawing.Point(4, 38);
            this.mtpTheme.Name = "mtpTheme";
            this.mtpTheme.Size = new System.Drawing.Size(192, 245);
            this.mtpTheme.TabIndex = 0;
            this.mtpTheme.Text = "Theme";
            this.mtpTheme.VerticalScrollbarBarColor = true;
            this.mtpTheme.VerticalScrollbarHighlightOnWheel = false;
            this.mtpTheme.VerticalScrollbarSize = 10;
            // 
            // mtpStyle
            // 
            this.mtpStyle.HorizontalScrollbarBarColor = true;
            this.mtpStyle.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpStyle.HorizontalScrollbarSize = 10;
            this.mtpStyle.Location = new System.Drawing.Point(4, 38);
            this.mtpStyle.Name = "mtpStyle";
            this.mtpStyle.Size = new System.Drawing.Size(192, 245);
            this.mtpStyle.TabIndex = 1;
            this.mtpStyle.Text = "Style";
            this.mtpStyle.VerticalScrollbarBarColor = true;
            this.mtpStyle.VerticalScrollbarHighlightOnWheel = false;
            this.mtpStyle.VerticalScrollbarSize = 10;
            // 
            // flpSettings
            // 
            this.flpSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpSettings.Location = new System.Drawing.Point(3, 125);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(186, 100);
            this.flpSettings.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Theme";
            // 
            // mrbDark
            // 
            this.mrbDark.AutoSize = true;
            this.mrbDark.Location = new System.Drawing.Point(10, 55);
            this.mrbDark.Name = "mrbDark";
            this.mrbDark.Size = new System.Drawing.Size(47, 15);
            this.mrbDark.TabIndex = 4;
            this.mrbDark.Text = "Dark";
            this.mrbDark.UseSelectable = true;
            this.mrbDark.CheckedChanged += new System.EventHandler(this.mrbDark_CheckedChanged);
            // 
            // mrbLight
            // 
            this.mrbLight.AutoSize = true;
            this.mrbLight.Checked = true;
            this.mrbLight.Location = new System.Drawing.Point(104, 55);
            this.mrbLight.Name = "mrbLight";
            this.mrbLight.Size = new System.Drawing.Size(50, 15);
            this.mrbLight.TabIndex = 4;
            this.mrbLight.TabStop = true;
            this.mrbLight.Text = "Light";
            this.mrbLight.UseSelectable = true;
            this.mrbLight.CheckedChanged += new System.EventHandler(this.mrbLight_CheckedChanged);
            // 
            // mtlinkBack
            // 
            this.mtlinkBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkBack.Image = global::Education_Control_System.Properties.Resources.if_left_1348641;
            this.mtlinkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlinkBack.Location = new System.Drawing.Point(509, 24);
            this.mtlinkBack.Name = "mtlinkBack";
            this.mtlinkBack.Size = new System.Drawing.Size(84, 30);
            this.mtlinkBack.TabIndex = 3;
            this.mtlinkBack.Text = "Back";
            this.mtlinkBack.UseSelectable = true;
            this.mtlinkBack.Visible = false;
            this.mtlinkBack.Click += new System.EventHandler(this.mtlinkBack_Click);
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 515);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.mtlinkBack);
            this.Name = "MainForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "ECS";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.mtcSettings.ResumeLayout(false);
            this.mtpTheme.ResumeLayout(false);
            this.mtpTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel pnlSettings;
        private MetroFramework.Controls.MetroTabControl mtcSettings;
        private MetroFramework.Controls.MetroTabPage mtpTheme;
        private MetroFramework.Controls.MetroRadioButton mrbLight;
        private MetroFramework.Controls.MetroRadioButton mrbDark;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private MetroFramework.Controls.MetroTabPage mtpStyle;
        private MetroFramework.Controls.MetroLink mtlinkBack;
    }
}

