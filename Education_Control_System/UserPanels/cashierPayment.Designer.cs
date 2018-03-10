namespace Education_Control_System.UserPanels
{
    partial class cashierPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mrbCard = new MetroFramework.Controls.MetroRadioButton();
            this.mrbCash = new MetroFramework.Controls.MetroRadioButton();
            this.btnComplete = new MetroFramework.Controls.MetroButton();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.txtRemain = new MetroFramework.Controls.MetroTextBox();
            this.txtPay = new MetroFramework.Controls.MetroTextBox();
            this.txtCFee = new MetroFramework.Controls.MetroTextBox();
            this.txtCID = new MetroFramework.Controls.MetroTextBox();
            this.txtStuID = new MetroFramework.Controls.MetroTextBox();
            this.btnSelect = new MetroFramework.Controls.MetroButton();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.lbl2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtlinkBack = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrbCard
            // 
            this.mrbCard.AutoSize = true;
            this.mrbCard.Location = new System.Drawing.Point(568, 317);
            this.mrbCard.Name = "mrbCard";
            this.mrbCard.Size = new System.Drawing.Size(48, 15);
            this.mrbCard.TabIndex = 7;
            this.mrbCard.Text = "Card";
            this.mrbCard.UseSelectable = true;
            this.mrbCard.CheckedChanged += new System.EventHandler(this.mrbCard_CheckedChanged);
            // 
            // mrbCash
            // 
            this.mrbCash.AutoSize = true;
            this.mrbCash.Location = new System.Drawing.Point(469, 316);
            this.mrbCash.Name = "mrbCash";
            this.mrbCash.Size = new System.Drawing.Size(49, 15);
            this.mrbCash.TabIndex = 7;
            this.mrbCash.Text = "Cash";
            this.mrbCash.UseSelectable = true;
            this.mrbCash.CheckedChanged += new System.EventHandler(this.mrbCash_CheckedChanged);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(622, 464);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(140, 38);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete Transaction";
            this.btnComplete.UseSelectable = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(461, 357);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(156, 29);
            this.metroDateTime1.TabIndex = 5;
            this.metroDateTime1.Leave += new System.EventHandler(this.metroDateTime1_Leave);
            // 
            // txtRemain
            // 
            // 
            // 
            // 
            this.txtRemain.CustomButton.Image = null;
            this.txtRemain.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtRemain.CustomButton.Name = "";
            this.txtRemain.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRemain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemain.CustomButton.TabIndex = 1;
            this.txtRemain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemain.CustomButton.UseSelectable = true;
            this.txtRemain.CustomButton.Visible = false;
            this.txtRemain.Enabled = false;
            this.txtRemain.Lines = new string[0];
            this.txtRemain.Location = new System.Drawing.Point(461, 411);
            this.txtRemain.MaxLength = 32767;
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.PasswordChar = '\0';
            this.txtRemain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemain.SelectedText = "";
            this.txtRemain.SelectionLength = 0;
            this.txtRemain.SelectionStart = 0;
            this.txtRemain.ShortcutsEnabled = true;
            this.txtRemain.Size = new System.Drawing.Size(156, 23);
            this.txtRemain.TabIndex = 4;
            this.txtRemain.UseSelectable = true;
            this.txtRemain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPay
            // 
            // 
            // 
            // 
            this.txtPay.CustomButton.Image = null;
            this.txtPay.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtPay.CustomButton.Name = "";
            this.txtPay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPay.CustomButton.TabIndex = 1;
            this.txtPay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPay.CustomButton.UseSelectable = true;
            this.txtPay.CustomButton.Visible = false;
            this.txtPay.Lines = new string[0];
            this.txtPay.Location = new System.Drawing.Point(461, 262);
            this.txtPay.MaxLength = 32767;
            this.txtPay.Name = "txtPay";
            this.txtPay.PasswordChar = '\0';
            this.txtPay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPay.SelectedText = "";
            this.txtPay.SelectionLength = 0;
            this.txtPay.SelectionStart = 0;
            this.txtPay.ShortcutsEnabled = true;
            this.txtPay.Size = new System.Drawing.Size(156, 23);
            this.txtPay.TabIndex = 4;
            this.txtPay.UseSelectable = true;
            this.txtPay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPay.Leave += new System.EventHandler(this.txtPay_Leave);
            // 
            // txtCFee
            // 
            // 
            // 
            // 
            this.txtCFee.CustomButton.Image = null;
            this.txtCFee.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtCFee.CustomButton.Name = "";
            this.txtCFee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCFee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCFee.CustomButton.TabIndex = 1;
            this.txtCFee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCFee.CustomButton.UseSelectable = true;
            this.txtCFee.CustomButton.Visible = false;
            this.txtCFee.Enabled = false;
            this.txtCFee.Lines = new string[0];
            this.txtCFee.Location = new System.Drawing.Point(461, 206);
            this.txtCFee.MaxLength = 32767;
            this.txtCFee.Name = "txtCFee";
            this.txtCFee.PasswordChar = '\0';
            this.txtCFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCFee.SelectedText = "";
            this.txtCFee.SelectionLength = 0;
            this.txtCFee.SelectionStart = 0;
            this.txtCFee.ShortcutsEnabled = true;
            this.txtCFee.Size = new System.Drawing.Size(156, 23);
            this.txtCFee.TabIndex = 4;
            this.txtCFee.UseSelectable = true;
            this.txtCFee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCFee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCID
            // 
            // 
            // 
            // 
            this.txtCID.CustomButton.Image = null;
            this.txtCID.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtCID.CustomButton.Name = "";
            this.txtCID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCID.CustomButton.TabIndex = 1;
            this.txtCID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCID.CustomButton.UseSelectable = true;
            this.txtCID.CustomButton.Visible = false;
            this.txtCID.Enabled = false;
            this.txtCID.Lines = new string[0];
            this.txtCID.Location = new System.Drawing.Point(461, 155);
            this.txtCID.MaxLength = 32767;
            this.txtCID.Name = "txtCID";
            this.txtCID.PasswordChar = '\0';
            this.txtCID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCID.SelectedText = "";
            this.txtCID.SelectionLength = 0;
            this.txtCID.SelectionStart = 0;
            this.txtCID.ShortcutsEnabled = true;
            this.txtCID.Size = new System.Drawing.Size(156, 23);
            this.txtCID.TabIndex = 4;
            this.txtCID.UseSelectable = true;
            this.txtCID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStuID
            // 
            // 
            // 
            // 
            this.txtStuID.CustomButton.Image = null;
            this.txtStuID.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtStuID.CustomButton.Name = "";
            this.txtStuID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStuID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStuID.CustomButton.TabIndex = 1;
            this.txtStuID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStuID.CustomButton.UseSelectable = true;
            this.txtStuID.CustomButton.Visible = false;
            this.txtStuID.Enabled = false;
            this.txtStuID.Lines = new string[0];
            this.txtStuID.Location = new System.Drawing.Point(461, 106);
            this.txtStuID.MaxLength = 32767;
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.PasswordChar = '\0';
            this.txtStuID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStuID.SelectedText = "";
            this.txtStuID.SelectionLength = 0;
            this.txtStuID.SelectionStart = 0;
            this.txtStuID.ShortcutsEnabled = true;
            this.txtStuID.Size = new System.Drawing.Size(156, 23);
            this.txtStuID.TabIndex = 4;
            this.txtStuID.UseSelectable = true;
            this.txtStuID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStuID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(41, 441);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(248, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseSelectable = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(41, 399);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(248, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View ";
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(391, 159);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(64, 19);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Cousere :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(412, 362);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Date :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(342, 415);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Amount Payable :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(338, 313);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(117, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Payment Method :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(349, 266);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Paying Amount :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(373, 210);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Course Fee :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(379, 106);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 19);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Student ID :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Student Payment ";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 106);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(333, 245);
            this.metroGrid1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mtlinkBack
            // 
            this.mtlinkBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkBack.Image = global::Education_Control_System.Properties.Resources.if_left_1348641;
            this.mtlinkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlinkBack.Location = new System.Drawing.Point(986, 3);
            this.mtlinkBack.Name = "mtlinkBack";
            this.mtlinkBack.Size = new System.Drawing.Size(75, 23);
            this.mtlinkBack.TabIndex = 8;
            this.mtlinkBack.Text = "Back";
            this.mtlinkBack.UseSelectable = true;
            this.mtlinkBack.Click += new System.EventHandler(this.mtlinkBack_Click);
            // 
            // cashierPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtlinkBack);
            this.Controls.Add(this.mrbCard);
            this.Controls.Add(this.mrbCash);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.txtRemain);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtCFee);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGrid1);
            this.Name = "cashierPayment";
            this.Size = new System.Drawing.Size(1064, 543);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroLabel lbl2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnView;
        private MetroFramework.Controls.MetroTextBox txtStuID;
        private MetroFramework.Controls.MetroTextBox txtCID;
        private MetroFramework.Controls.MetroTextBox txtCFee;
        private MetroFramework.Controls.MetroTextBox txtPay;
        private MetroFramework.Controls.MetroTextBox txtRemain;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroButton btnComplete;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroRadioButton mrbCash;
        private MetroFramework.Controls.MetroRadioButton mrbCard;
        private MetroFramework.Controls.MetroButton btnSelect;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLink mtlinkBack;
    }
}
