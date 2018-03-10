namespace Education_Control_System.UserPanels
{
    partial class LecCheckSchTaskWindow
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
            this.mtPDF = new MetroFramework.Controls.MetroTile();
            this.mtOnline = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtPDF
            // 
            this.mtPDF.ActiveControl = null;
            this.mtPDF.Location = new System.Drawing.Point(47, 16);
            this.mtPDF.Name = "mtPDF";
            this.mtPDF.Size = new System.Drawing.Size(98, 92);
            this.mtPDF.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtPDF.TabIndex = 0;
            this.mtPDF.Text = "PDF";
            this.mtPDF.UseSelectable = true;
            this.mtPDF.UseStyleColors = true;
            this.mtPDF.Click += new System.EventHandler(this.mtPDF_Click);
            // 
            // mtOnline
            // 
            this.mtOnline.ActiveControl = null;
            this.mtOnline.Location = new System.Drawing.Point(239, 16);
            this.mtOnline.Name = "mtOnline";
            this.mtOnline.Size = new System.Drawing.Size(98, 92);
            this.mtOnline.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtOnline.TabIndex = 0;
            this.mtOnline.Text = "Online";
            this.mtOnline.UseSelectable = true;
            this.mtOnline.UseStyleColors = true;
            this.mtOnline.Click += new System.EventHandler(this.mtOnline_Click);
            // 
            // LecCheckSchTaskWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtOnline);
            this.Controls.Add(this.mtPDF);
            this.Name = "LecCheckSchTaskWindow";
            this.Size = new System.Drawing.Size(439, 234);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtPDF;
        private MetroFramework.Controls.MetroTile mtOnline;
    }
}
