using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using MetroFramework.Forms;
using Transitions;

using Education_Control_System.LoginPanel;
using Education_Control_System.UserPanels;

namespace Education_Control_System
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        Timer timer = new Timer();
        public string currentRole = null;
        
        public MainForm()
        {
            InitializeComponent();
            this.Shown+=MainForm_Shown;
            this.StyleManager = metroStyleManager1;
            setAndStartTimer();            
        }

        void MainForm_Shown(object sender,EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }

        private void setAndStartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        static int count = 0;

        void timer_Tick(object sender, EventArgs e)
        {
            count += 2;

            if (count == 30)
            {
                timer.Stop();
                login();
                //userView();
            }
        }

        
       
        public void login()
        {
            pnlLoginMainForm _pnlLoginMainForm = new pnlLoginMainForm(this);
            _pnlLoginMainForm.swipe(true);           
        }

        public void userView(string role)
        {
            currentRole = role;
            if ((role == "Admin") || (role == "Manager") || (role == "Cashier") || (role=="Staff"))
            {
                userPanelStaff _userPanelStaff = new userPanelStaff(this);
                _userPanelStaff.swipe(true);
                _userPanelStaff.logInLabel(role);
                _userPanelStaff.rolePrivilage(role);
            }
            else if (role == "Dean")
            {
                userPanelDean _userPanelDean = new userPanelDean(this);
                _userPanelDean.swipe(true);
                _userPanelDean.logInLabel(role);
            }
            else if (role == "Student")
            {
                userPanelStudent _userPanelStudent = new userPanelStudent(this);
                _userPanelStudent.swipe(true);
                _userPanelStudent.logInLabel(role);
            }
            else if (role == "Lecturer")
            {
                userPanelLecturer _userPanelLecturer = new userPanelLecturer(this);
                _userPanelLecturer.swipe(true);
                _userPanelLecturer.logInLabel(role);
            }

        }

        public void chageStyleMF()
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)13;
        }

        private void pnlSettings_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSettings.Visible == true)
            {
                for (int i = 3; i < 13; i++)
                {
                    MetroFramework.Controls.MetroTile _tile = new MetroFramework.Controls.MetroTile();
                    _tile.Size = new Size(30, 30);
                    _tile.Tag = i;
                    _tile.Style = (MetroFramework.MetroColorStyle)i;
                    _tile.Click+=_tile_Click;
                    flpSettings.Controls.Add(_tile);
                }
            }
        }

        void _tile_Click(object sender, EventArgs e)
        {
            //((MetroForm)this.Parent).StyleManager.Style = (MetroFramework.MetroColorStyle)((MetroFramework.Controls.MetroTile)sender).Tag;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)((MetroFramework.Controls.MetroTile)sender).Tag;
        }

        public void initiate_pnlSettings()
        {
            pnlSettings.Visible = true;
            mtlinkBack.Visible = true;
        }

        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked)
            {
                //((MetroForm)this.Parent).StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                //((MetroForm)this.Parent).StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        private void mtlinkBack_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = false;
            mtlinkBack.Visible = false;
            userView(currentRole);
        }
        /*public string checkStatus()
        {
            string writtenStatus = File.ReadLines(Application.StartupPath + "..\\..\\..\\Files\\Status.txt").Last();
            return writtenStatus;            
        }*/

        /*public void exitClick()
        {
                loginSkipMessage();            
        }*/

        /*public void loginSkipMessage()
        {
            MetroFramework.MetroMessageBox.Show(this, "You Will Unable To Use Any Fuctions\nAre You Sure You Want to Skip the Log in", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }*/

       
        
    }
}
