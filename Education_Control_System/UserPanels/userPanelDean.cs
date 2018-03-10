using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_Control_System.UserPanels
{
    public partial class userPanelDean : userPanelSlider
    {
        public userPanelDean(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void mtDetailedReport_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Not Enough Data to Provide Reports", "Hmm.....Dean We are So Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void mtSummeryReport_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Not Enough Data to Provide Reports", "Hmm.....Dean We are So Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void mtExceptionReports_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Not Enough Data to Provide Reports", "Hmm.....Dean We are So Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void mtlinkLogOut1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Log Out", "Sure Enough?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.Yes)
            {
                swipe(false);
                UserIDLogIn _login = new UserIDLogIn();
                _login.ShowDialog();
            }
        }
    }
}
