using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Education_Control_System.UserPanels
{
    public partial class userPanelLecturer : userPanelSlider
    {
        public userPanelLecturer(Form owner) :base(owner) 
        {
            InitializeComponent();
        }

        private void mtSchedule_Click(object sender, EventArgs e)
        {
            MetroTaskWindow.ShowTaskWindow(this, "Upload Via", new LecCheckSchTaskWindow(), 10);
        }

        private void mtReview_Click(object sender, EventArgs e)
        {
            var tempForm = Form.ActiveForm as MainForm;
            studentReview _studentReview = new studentReview(tempForm);
            _studentReview.swipe(true);
        }

        private void mtLogout_Click(object sender, EventArgs e)
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
