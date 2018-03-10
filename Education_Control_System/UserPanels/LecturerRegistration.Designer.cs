namespace Education_Control_System.UserPanels
{
    partial class LecturerRegistration
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
            this.metroToolTipLecturer = new MetroFramework.Components.MetroToolTip();
            this.mrbLC = new MetroFramework.Controls.MetroRadioButton();
            this.mrbBM = new MetroFramework.Controls.MetroRadioButton();
            this.mrbMIS = new MetroFramework.Controls.MetroRadioButton();
            this.cbxLecID_digit = new MetroFramework.Controls.MetroComboBox();
            this.cbxLecID_PerTemp = new MetroFramework.Controls.MetroComboBox();
            this.mtcLecturerReg = new MetroFramework.Controls.MetroTabControl();
            this.mtpLecRegDeatails = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtlinkBackLecReg2 = new MetroFramework.Controls.MetroLink();
            this.txtLecID_Division = new MetroFramework.Controls.MetroTextBox();
            this.txtLecID_City = new MetroFramework.Controls.MetroTextBox();
            this.mdtLecDob = new MetroFramework.Controls.MetroDateTime();
            this.mbrLecFemale = new MetroFramework.Controls.MetroRadioButton();
            this.mrbLecMale = new MetroFramework.Controls.MetroRadioButton();
            this.txtLecAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtLecTempPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtLecPhno = new MetroFramework.Controls.MetroTextBox();
            this.txtLecLName = new MetroFramework.Controls.MetroTextBox();
            this.txtLecFName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.lblLecID_Full = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtpLecAddiDetails = new MetroFramework.Controls.MetroTabPage();
            this.btnLectPicCapture = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.errorProviderLecturer = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtcLecturerReg.SuspendLayout();
            this.mtpLecRegDeatails.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.mtpLecAddiDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToolTipLecturer
            // 
            this.metroToolTipLecturer.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTipLecturer.StyleManager = null;
            this.metroToolTipLecturer.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mrbLC
            // 
            this.mrbLC.AutoSize = true;
            this.mrbLC.Location = new System.Drawing.Point(170, 4);
            this.mrbLC.Name = "mrbLC";
            this.mrbLC.Size = new System.Drawing.Size(37, 15);
            this.mrbLC.TabIndex = 6;
            this.mrbLC.Text = "LC";
            this.metroToolTipLecturer.SetToolTip(this.mrbLC, "Language Center");
            this.mrbLC.UseSelectable = true;
            this.mrbLC.CheckedChanged += new System.EventHandler(this.mrbLC_CheckedChanged);
            // 
            // mrbBM
            // 
            this.mrbBM.AutoSize = true;
            this.mrbBM.Location = new System.Drawing.Point(77, 4);
            this.mrbBM.Name = "mrbBM";
            this.mrbBM.Size = new System.Drawing.Size(41, 15);
            this.mrbBM.TabIndex = 6;
            this.mrbBM.Text = "BM";
            this.metroToolTipLecturer.SetToolTip(this.mrbBM, "Business Management Division");
            this.mrbBM.UseSelectable = true;
            this.mrbBM.CheckedChanged += new System.EventHandler(this.mrbBM_CheckedChanged);
            // 
            // mrbMIS
            // 
            this.mrbMIS.AutoSize = true;
            this.mrbMIS.Location = new System.Drawing.Point(3, 4);
            this.mrbMIS.Name = "mrbMIS";
            this.mrbMIS.Size = new System.Drawing.Size(43, 15);
            this.mrbMIS.TabIndex = 6;
            this.mrbMIS.Text = "MIS";
            this.metroToolTipLecturer.SetToolTip(this.mrbMIS, "Management Information System Division");
            this.mrbMIS.UseSelectable = true;
            this.mrbMIS.CheckedChanged += new System.EventHandler(this.mrbMIS_CheckedChanged);
            // 
            // cbxLecID_digit
            // 
            this.cbxLecID_digit.FormattingEnabled = true;
            this.cbxLecID_digit.ItemHeight = 23;
            this.cbxLecID_digit.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005",
            "006",
            "007",
            "008",
            "009",
            "010"});
            this.cbxLecID_digit.Location = new System.Drawing.Point(367, 411);
            this.cbxLecID_digit.Name = "cbxLecID_digit";
            this.cbxLecID_digit.Size = new System.Drawing.Size(66, 29);
            this.cbxLecID_digit.TabIndex = 8;
            this.metroToolTipLecturer.SetToolTip(this.cbxLecID_digit, "Individual Number");
            this.cbxLecID_digit.UseSelectable = true;
            // 
            // cbxLecID_PerTemp
            // 
            this.cbxLecID_PerTemp.FormattingEnabled = true;
            this.cbxLecID_PerTemp.ItemHeight = 23;
            this.cbxLecID_PerTemp.Items.AddRange(new object[] {
            "P",
            "T"});
            this.cbxLecID_PerTemp.Location = new System.Drawing.Point(275, 411);
            this.cbxLecID_PerTemp.Name = "cbxLecID_PerTemp";
            this.cbxLecID_PerTemp.Size = new System.Drawing.Size(66, 29);
            this.cbxLecID_PerTemp.TabIndex = 8;
            this.metroToolTipLecturer.SetToolTip(this.cbxLecID_PerTemp, "Permenant or Temporary");
            this.cbxLecID_PerTemp.UseSelectable = true;
            // 
            // mtcLecturerReg
            // 
            this.mtcLecturerReg.Controls.Add(this.mtpLecRegDeatails);
            this.mtcLecturerReg.Controls.Add(this.mtpLecAddiDetails);
            this.mtcLecturerReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcLecturerReg.Location = new System.Drawing.Point(0, 0);
            this.mtcLecturerReg.Name = "mtcLecturerReg";
            this.mtcLecturerReg.SelectedIndex = 1;
            this.mtcLecturerReg.Size = new System.Drawing.Size(939, 528);
            this.mtcLecturerReg.TabIndex = 1;
            this.mtcLecturerReg.UseSelectable = true;
            // 
            // mtpLecRegDeatails
            // 
            this.mtpLecRegDeatails.Controls.Add(this.metroPanel1);
            this.mtpLecRegDeatails.Controls.Add(this.mtlinkBackLecReg2);
            this.mtpLecRegDeatails.Controls.Add(this.cbxLecID_digit);
            this.mtpLecRegDeatails.Controls.Add(this.cbxLecID_PerTemp);
            this.mtpLecRegDeatails.Controls.Add(this.txtLecID_Division);
            this.mtpLecRegDeatails.Controls.Add(this.txtLecID_City);
            this.mtpLecRegDeatails.Controls.Add(this.mdtLecDob);
            this.mtpLecRegDeatails.Controls.Add(this.mbrLecFemale);
            this.mtpLecRegDeatails.Controls.Add(this.mrbLecMale);
            this.mtpLecRegDeatails.Controls.Add(this.txtLecAddress);
            this.mtpLecRegDeatails.Controls.Add(this.txtLecTempPassword);
            this.mtpLecRegDeatails.Controls.Add(this.txtLecPhno);
            this.mtpLecRegDeatails.Controls.Add(this.txtLecLName);
            this.mtpLecRegDeatails.Controls.Add(this.txtLecFName);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel9);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel21);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel20);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel19);
            this.mtpLecRegDeatails.Controls.Add(this.lblLecID_Full);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel8);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel6);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel7);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel5);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel4);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel3);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel2);
            this.mtpLecRegDeatails.Controls.Add(this.metroLabel1);
            this.mtpLecRegDeatails.HorizontalScrollbarBarColor = true;
            this.mtpLecRegDeatails.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpLecRegDeatails.HorizontalScrollbarSize = 10;
            this.mtpLecRegDeatails.Location = new System.Drawing.Point(4, 38);
            this.mtpLecRegDeatails.Name = "mtpLecRegDeatails";
            this.mtpLecRegDeatails.Size = new System.Drawing.Size(931, 486);
            this.mtpLecRegDeatails.TabIndex = 0;
            this.mtpLecRegDeatails.Text = "Register Deatails";
            this.mtpLecRegDeatails.VerticalScrollbarBarColor = true;
            this.mtpLecRegDeatails.VerticalScrollbarHighlightOnWheel = false;
            this.mtpLecRegDeatails.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mrbMIS);
            this.metroPanel1.Controls.Add(this.mrbBM);
            this.metroPanel1.Controls.Add(this.mrbLC);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(142, 371);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(221, 30);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mtlinkBackLecReg2
            // 
            this.mtlinkBackLecReg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlinkBackLecReg2.Image = global::Education_Control_System.Properties.Resources.if_left_1348641;
            this.mtlinkBackLecReg2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlinkBackLecReg2.Location = new System.Drawing.Point(860, 3);
            this.mtlinkBackLecReg2.Name = "mtlinkBackLecReg2";
            this.mtlinkBackLecReg2.Size = new System.Drawing.Size(75, 23);
            this.mtlinkBackLecReg2.TabIndex = 9;
            this.mtlinkBackLecReg2.Text = "Back";
            this.mtlinkBackLecReg2.UseSelectable = true;
            this.mtlinkBackLecReg2.Click += new System.EventHandler(this.mtlinkBackLecReg2_Click);
            // 
            // txtLecID_Division
            // 
            // 
            // 
            // 
            this.txtLecID_Division.CustomButton.Image = null;
            this.txtLecID_Division.CustomButton.Location = new System.Drawing.Point(15, 1);
            this.txtLecID_Division.CustomButton.Name = "";
            this.txtLecID_Division.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtLecID_Division.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLecID_Division.CustomButton.TabIndex = 1;
            this.txtLecID_Division.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLecID_Division.CustomButton.UseSelectable = true;
            this.txtLecID_Division.CustomButton.Visible = false;
            this.txtLecID_Division.Enabled = false;
            this.txtLecID_Division.Lines = new string[0];
            this.txtLecID_Division.Location = new System.Drawing.Point(209, 412);
            this.txtLecID_Division.MaxLength = 32767;
            this.txtLecID_Division.Name = "txtLecID_Division";
            this.txtLecID_Division.PasswordChar = '\0';
            this.txtLecID_Division.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLecID_Division.SelectedText = "";
            this.txtLecID_Division.SelectionLength = 0;
            this.txtLecID_Division.SelectionStart = 0;
            this.txtLecID_Division.ShortcutsEnabled = true;
            this.txtLecID_Division.Size = new System.Drawing.Size(43, 29);
            this.txtLecID_Division.TabIndex = 7;
            this.txtLecID_Division.UseSelectable = true;
            this.txtLecID_Division.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLecID_Division.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLecID_City
            // 
            // 
            // 
            // 
            this.txtLecID_City.CustomButton.Image = null;
            this.txtLecID_City.CustomButton.Location = new System.Drawing.Point(15, 1);
            this.txtLecID_City.CustomButton.Name = "";
            this.txtLecID_City.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtLecID_City.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLecID_City.CustomButton.TabIndex = 1;
            this.txtLecID_City.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLecID_City.CustomButton.UseSelectable = true;
            this.txtLecID_City.CustomButton.Visible = false;
            this.txtLecID_City.Enabled = false;
            this.txtLecID_City.Lines = new string[0];
            this.txtLecID_City.Location = new System.Drawing.Point(142, 412);
            this.txtLecID_City.MaxLength = 32767;
            this.txtLecID_City.Name = "txtLecID_City";
            this.txtLecID_City.PasswordChar = '\0';
            this.txtLecID_City.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLecID_City.SelectedText = "";
            this.txtLecID_City.SelectionLength = 0;
            this.txtLecID_City.SelectionStart = 0;
            this.txtLecID_City.ShortcutsEnabled = true;
            this.txtLecID_City.Size = new System.Drawing.Size(43, 29);
            this.txtLecID_City.TabIndex = 7;
            this.txtLecID_City.UseSelectable = true;
            this.txtLecID_City.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLecID_City.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mdtLecDob
            // 
            this.mdtLecDob.Location = new System.Drawing.Point(142, 127);
            this.mdtLecDob.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtLecDob.Name = "mdtLecDob";
            this.mdtLecDob.Size = new System.Drawing.Size(190, 29);
            this.mdtLecDob.TabIndex = 5;
            this.mdtLecDob.Leave += new System.EventHandler(this.mdtLecDob_Leave);
            // 
            // mbrLecFemale
            // 
            this.mbrLecFemale.AutoSize = true;
            this.mbrLecFemale.Location = new System.Drawing.Point(271, 94);
            this.mbrLecFemale.Name = "mbrLecFemale";
            this.mbrLecFemale.Size = new System.Drawing.Size(61, 15);
            this.mbrLecFemale.TabIndex = 4;
            this.mbrLecFemale.Text = "Female";
            this.mbrLecFemale.UseSelectable = true;
            this.mbrLecFemale.CheckedChanged += new System.EventHandler(this.mbrLecFemale_CheckedChanged);
            // 
            // mrbLecMale
            // 
            this.mrbLecMale.AutoSize = true;
            this.mrbLecMale.Location = new System.Drawing.Point(142, 94);
            this.mrbLecMale.Name = "mrbLecMale";
            this.mrbLecMale.Size = new System.Drawing.Size(49, 15);
            this.mrbLecMale.TabIndex = 4;
            this.mrbLecMale.Text = "Male";
            this.mrbLecMale.UseSelectable = true;
            this.mrbLecMale.CheckedChanged += new System.EventHandler(this.mrbLecMale_CheckedChanged);
            // 
            // txtLecAddress
            // 
            // 
            // 
            // 
            this.txtLecAddress.CustomButton.Image = null;
            this.txtLecAddress.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtLecAddress.CustomButton.Name = "";
            this.txtLecAddress.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtLecAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLecAddress.CustomButton.TabIndex = 1;
            this.txtLecAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLecAddress.CustomButton.UseSelectable = true;
            this.txtLecAddress.CustomButton.Visible = false;
            this.txtLecAddress.Lines = new string[0];
            this.txtLecAddress.Location = new System.Drawing.Point(142, 193);
            this.txtLecAddress.MaxLength = 32767;
            this.txtLecAddress.Name = "txtLecAddress";
            this.txtLecAddress.PasswordChar = '\0';
            this.txtLecAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLecAddress.SelectedText = "";
            this.txtLecAddress.SelectionLength = 0;
            this.txtLecAddress.SelectionStart = 0;
            this.txtLecAddress.ShortcutsEnabled = true;
            this.txtLecAddress.Size = new System.Drawing.Size(190, 100);
            this.txtLecAddress.TabIndex = 3;
            this.txtLecAddress.UseSelectable = true;
            this.txtLecAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLecAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLecAddress.Leave += new System.EventHandler(this.txtLecAddress_Leave);
            // 
            // txtLecTempPassword
            // 
            // 
            // 
            // 
            this.txtLecTempPassword.CustomButton.Image = null;
            this.txtLecTempPassword.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtLecTempPassword.CustomButton.Name = "";
            this.txtLecTempPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLecTempPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLecTempPassword.CustomButton.TabIndex = 1;
            this.txtLecTempPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLecTempPassword.CustomButton.UseSelectable = true;
            this.txtLecTempPassword.CustomButton.Visible = false;
            this.txtLecTempPassword.Lines = new string[0];
            this.txtLecTempPassword.Location = new System.Drawing.Point(142, 460);
            this.txtLecTempPassword.MaxLength = 32767;
            this.txtLecTempPassword.Name = "txtLecTempPassword";
            this.txtLecTempPassword.PasswordChar = '\0';
            this.txtLecTempPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLecTempPassword.SelectedText = "";
            this.txtLecTempPassword.SelectionLength = 0;
            this.txtLecTempPassword.SelectionStart = 0;
            this.txtLecTempPassword.ShortcutsEnabled = true;
            this.txtLecTempPassword.Size = new System.Drawing.Size(190, 23);
            this.txtLecTempPassword.TabIndex = 3;
            this.txtLecTempPassword.UseSelectable = true;
            this.txtLecTempPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLecTempPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLecTempPassword.Leave += new System.EventHandler(this.txtLecTempPassword_Leave);
            // 
            // txtLecPhno
            // 
            // 
            // 
            // 
            this.txtLecPhno.CustomButton.Image = null;
            this.txtLecPhno.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtLecPhno.CustomButton.Name = "";
            this.txtLecPhno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLecPhno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLecPhno.CustomButton.TabIndex = 1;
            this.txtLecPhno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLecPhno.CustomButton.UseSelectable = true;
            this.txtLecPhno.CustomButton.Visible = false;
            this.txtLecPhno.Lines = new string[0];
            this.txtLecPhno.Location = new System.Drawing.Point(142, 323);
            this.txtLecPhno.MaxLength = 10;
            this.txtLecPhno.Name = "txtLecPhno";
            this.txtLecPhno.PasswordChar = '\0';
            this.txtLecPhno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLecPhno.SelectedText = "";
            this.txtLecPhno.SelectionLength = 0;
            this.txtLecPhno.SelectionStart = 0;
            this.txtLecPhno.ShortcutsEnabled = true;
            this.txtLecPhno.Size = new System.Drawing.Size(190, 23);
            this.txtLecPhno.TabIndex = 3;
            this.txtLecPhno.UseSelectable = true;
            this.txtLecPhno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLecPhno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLecPhno.Leave += new System.EventHandler(this.txtLecPhno_Leave);
            // 
            // txtLecLName
            // 
            // 
            // 
            // 
            this.txtLecLName.CustomButton.Image = null;
            this.txtLecLName.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtLecLName.CustomButton.Name = "";
            this.txtLecLName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLecLName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLecLName.CustomButton.TabIndex = 1;
            this.txtLecLName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLecLName.CustomButton.UseSelectable = true;
            this.txtLecLName.CustomButton.Visible = false;
            this.txtLecLName.Lines = new string[0];
            this.txtLecLName.Location = new System.Drawing.Point(142, 59);
            this.txtLecLName.MaxLength = 32767;
            this.txtLecLName.Name = "txtLecLName";
            this.txtLecLName.PasswordChar = '\0';
            this.txtLecLName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLecLName.SelectedText = "";
            this.txtLecLName.SelectionLength = 0;
            this.txtLecLName.SelectionStart = 0;
            this.txtLecLName.ShortcutsEnabled = true;
            this.txtLecLName.Size = new System.Drawing.Size(190, 23);
            this.txtLecLName.TabIndex = 3;
            this.txtLecLName.UseSelectable = true;
            this.txtLecLName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLecLName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLecLName.Leave += new System.EventHandler(this.txtLecLName_Leave);
            // 
            // txtLecFName
            // 
            // 
            // 
            // 
            this.txtLecFName.CustomButton.Image = null;
            this.txtLecFName.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtLecFName.CustomButton.Name = "";
            this.txtLecFName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLecFName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLecFName.CustomButton.TabIndex = 1;
            this.txtLecFName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLecFName.CustomButton.UseSelectable = true;
            this.txtLecFName.CustomButton.Visible = false;
            this.txtLecFName.Lines = new string[0];
            this.txtLecFName.Location = new System.Drawing.Point(142, 25);
            this.txtLecFName.MaxLength = 32767;
            this.txtLecFName.Name = "txtLecFName";
            this.txtLecFName.PasswordChar = '\0';
            this.txtLecFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLecFName.SelectedText = "";
            this.txtLecFName.SelectionLength = 0;
            this.txtLecFName.SelectionStart = 0;
            this.txtLecFName.ShortcutsEnabled = true;
            this.txtLecFName.Size = new System.Drawing.Size(190, 23);
            this.txtLecFName.TabIndex = 3;
            this.txtLecFName.UseSelectable = true;
            this.txtLecFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLecFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLecFName.Leave += new System.EventHandler(this.txtLecFName_Leave);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(8, 460);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(109, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Temp Password :";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(347, 415);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(15, 19);
            this.metroLabel21.TabIndex = 2;
            this.metroLabel21.Text = "-";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(258, 415);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(15, 19);
            this.metroLabel20.TabIndex = 2;
            this.metroLabel20.Text = "-";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(189, 415);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(15, 19);
            this.metroLabel19.TabIndex = 2;
            this.metroLabel19.Text = "-";
            // 
            // lblLecID_Full
            // 
            this.lblLecID_Full.AutoSize = true;
            this.lblLecID_Full.Location = new System.Drawing.Point(460, 422);
            this.lblLecID_Full.Name = "lblLecID_Full";
            this.lblLecID_Full.Size = new System.Drawing.Size(79, 19);
            this.lblLecID_Full.TabIndex = 2;
            this.lblLecID_Full.Text = "Lecturer ID :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(38, 415);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(79, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Lecturer ID :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(57, 371);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Division :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 323);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Contact Number :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 134);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Date of Birth :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(54, 193);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Address :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(58, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Gender :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Last Name :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "First Name :";
            // 
            // mtpLecAddiDetails
            // 
            this.mtpLecAddiDetails.Controls.Add(this.btnLectPicCapture);
            this.mtpLecAddiDetails.Controls.Add(this.pictureBox1);
            this.mtpLecAddiDetails.Controls.Add(this.metroLabel10);
            this.mtpLecAddiDetails.Controls.Add(this.btnSubmit);
            this.mtpLecAddiDetails.HorizontalScrollbarBarColor = true;
            this.mtpLecAddiDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpLecAddiDetails.HorizontalScrollbarSize = 10;
            this.mtpLecAddiDetails.Location = new System.Drawing.Point(4, 38);
            this.mtpLecAddiDetails.Name = "mtpLecAddiDetails";
            this.mtpLecAddiDetails.Size = new System.Drawing.Size(931, 486);
            this.mtpLecAddiDetails.TabIndex = 1;
            this.mtpLecAddiDetails.Text = "Additional Details";
            this.mtpLecAddiDetails.VerticalScrollbarBarColor = true;
            this.mtpLecAddiDetails.VerticalScrollbarHighlightOnWheel = false;
            this.mtpLecAddiDetails.VerticalScrollbarSize = 10;
            // 
            // btnLectPicCapture
            // 
            this.btnLectPicCapture.Location = new System.Drawing.Point(342, 165);
            this.btnLectPicCapture.Name = "btnLectPicCapture";
            this.btnLectPicCapture.Size = new System.Drawing.Size(107, 29);
            this.btnLectPicCapture.TabIndex = 5;
            this.btnLectPicCapture.Text = "Insert";
            this.btnLectPicCapture.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(125, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 155);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 39);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(107, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "Lecturer Picture :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(801, 437);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 46);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProviderLecturer
            // 
            this.errorProviderLecturer.ContainerControl = this;
            // 
            // LecturerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtcLecturerReg);
            this.Name = "LecturerRegistration";
            this.Size = new System.Drawing.Size(939, 528);
            this.mtcLecturerReg.ResumeLayout(false);
            this.mtpLecRegDeatails.ResumeLayout(false);
            this.mtpLecRegDeatails.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.mtpLecAddiDetails.ResumeLayout(false);
            this.mtpLecAddiDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecturer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcLecturerReg;
        private MetroFramework.Controls.MetroTabPage mtpLecRegDeatails;
        private MetroFramework.Controls.MetroRadioButton mbrLecFemale;
        private MetroFramework.Controls.MetroRadioButton mrbLecMale;
        private MetroFramework.Controls.MetroTextBox txtLecLName;
        private MetroFramework.Controls.MetroTextBox txtLecFName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLecAddress;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTabPage mtpLecAddiDetails;
        private MetroFramework.Controls.MetroRadioButton mrbLC;
        private MetroFramework.Components.MetroToolTip metroToolTipLecturer;
        private MetroFramework.Controls.MetroRadioButton mrbBM;
        private MetroFramework.Controls.MetroRadioButton mrbMIS;
        private MetroFramework.Controls.MetroDateTime mdtLecDob;
        private MetroFramework.Controls.MetroTextBox txtLecPhno;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbxLecID_digit;
        private MetroFramework.Controls.MetroComboBox cbxLecID_PerTemp;
        private MetroFramework.Controls.MetroTextBox txtLecID_Division;
        private MetroFramework.Controls.MetroTextBox txtLecID_City;
        private MetroFramework.Controls.MetroTextBox txtLecTempPassword;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel lblLecID_Full;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ErrorProvider errorProviderLecturer;
        private MetroFramework.Controls.MetroLink mtlinkBackLecReg2;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnLectPicCapture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
