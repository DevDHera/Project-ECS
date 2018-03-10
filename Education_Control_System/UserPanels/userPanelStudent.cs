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
    public partial class userPanelStudent : userPanelSlider
    {
        public userPanelStudent(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void mtTutorSeeker_Click(object sender, EventArgs e)
        {
            var tempForm = Form.ActiveForm as MainForm;
            TutorSeeker _TutorSeeker = new TutorSeeker(tempForm);
            _TutorSeeker.swipe(true);
        }

        private void mtReference_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#sent/15efbf4b3fe90166?projector=1");
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B_nAks3LLTO9NnViZTNFdjJMYmc/view?usp=sharing");
        }

        private void mtYoutube_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "We are Redirecting You to the Fox Learn YouTube Channel\nDo you want to continue", "Youtube Here We Come...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC8inCnD25Es0VLokfmhko5g/videos");
            }
        }

        private void mtAttendance_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Not enough data on the Attendance File", "Sorry.......", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void mtOnlinePay_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nibm.lk/payments");
        }
    }
}
