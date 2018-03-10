namespace Education_Control_System.UserPanels
{
    partial class managerReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtlinkBack = new MetroFramework.Controls.MetroLink();
            this.mtlinkExit = new MetroFramework.Controls.MetroLink();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.mtStaffSalary = new MetroFramework.Controls.MetroTile();
            this.mtCouDeatails = new MetroFramework.Controls.MetroTile();
            this.mtCouPay = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtlinkBack
            // 
            this.mtlinkBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkBack.Image = global::Education_Control_System.Properties.Resources.if_left_1348641;
            this.mtlinkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlinkBack.Location = new System.Drawing.Point(742, 3);
            this.mtlinkBack.Name = "mtlinkBack";
            this.mtlinkBack.Size = new System.Drawing.Size(75, 23);
            this.mtlinkBack.TabIndex = 4;
            this.mtlinkBack.Text = "Back";
            this.mtlinkBack.UseSelectable = true;
            this.mtlinkBack.Click += new System.EventHandler(this.mtlinkBack_Click);
            // 
            // mtlinkExit
            // 
            this.mtlinkExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkExit.Image = global::Education_Control_System.Properties.Resources.if_icons_exit_1564505;
            this.mtlinkExit.Location = new System.Drawing.Point(739, 69);
            this.mtlinkExit.Name = "mtlinkExit";
            this.mtlinkExit.Size = new System.Drawing.Size(75, 23);
            this.mtlinkExit.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.mtlinkExit, "Go Back to \r\nReport Views");
            this.mtlinkExit.UseSelectable = true;
            this.mtlinkExit.Click += new System.EventHandler(this.mtlinkExit_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 395);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(817, 150);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.Visible = false;
            // 
            // mtStaffSalary
            // 
            this.mtStaffSalary.ActiveControl = null;
            this.mtStaffSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtStaffSalary.Location = new System.Drawing.Point(242, 479);
            this.mtStaffSalary.Name = "mtStaffSalary";
            this.mtStaffSalary.Size = new System.Drawing.Size(371, 95);
            this.mtStaffSalary.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtStaffSalary.TabIndex = 1;
            this.mtStaffSalary.Text = "Staff Salary\r\nDetails";
            this.mtStaffSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtStaffSalary.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtStaffSalary.UseSelectable = true;
            this.mtStaffSalary.UseStyleColors = true;
            this.mtStaffSalary.Click += new System.EventHandler(this.mtStaffSalary_Click);
            // 
            // mtCouDeatails
            // 
            this.mtCouDeatails.ActiveControl = null;
            this.mtCouDeatails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtCouDeatails.Location = new System.Drawing.Point(242, 294);
            this.mtCouDeatails.Name = "mtCouDeatails";
            this.mtCouDeatails.Size = new System.Drawing.Size(371, 95);
            this.mtCouDeatails.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtCouDeatails.TabIndex = 1;
            this.mtCouDeatails.Text = "Course\r\nDetails";
            this.mtCouDeatails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCouDeatails.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCouDeatails.UseSelectable = true;
            this.mtCouDeatails.UseStyleColors = true;
            this.mtCouDeatails.Click += new System.EventHandler(this.mtCouDeatails_Click);
            // 
            // mtCouPay
            // 
            this.mtCouPay.ActiveControl = null;
            this.mtCouPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtCouPay.Location = new System.Drawing.Point(242, 131);
            this.mtCouPay.Name = "mtCouPay";
            this.mtCouPay.Size = new System.Drawing.Size(371, 95);
            this.mtCouPay.Style = MetroFramework.MetroColorStyle.Green;
            this.mtCouPay.TabIndex = 1;
            this.mtCouPay.Text = "Course Payment \r\nDetails";
            this.mtCouPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCouPay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCouPay.UseSelectable = true;
            this.mtCouPay.UseStyleColors = true;
            this.mtCouPay.Click += new System.EventHandler(this.mtCouPay_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(175, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Management Reports";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // managerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtlinkBack);
            this.Controls.Add(this.mtlinkExit);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.mtStaffSalary);
            this.Controls.Add(this.mtCouDeatails);
            this.Controls.Add(this.mtCouPay);
            this.Controls.Add(this.metroLabel1);
            this.Name = "managerReports";
            this.Size = new System.Drawing.Size(817, 646);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mtCouPay;
        private MetroFramework.Controls.MetroTile mtCouDeatails;
        private MetroFramework.Controls.MetroTile mtStaffSalary;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLink mtlinkExit;
        private MetroFramework.Controls.MetroLink mtlinkBack;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
