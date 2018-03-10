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
using Transitions;

using Education_Control_System;

namespace Education_Control_System.UserPanels
{
    public partial class RegitrationPanel : userPanelSliderNormal
    {
        public RegitrationPanel(Form owner):base(owner) 
        {
            InitializeComponent();
        }

        private void mtlinkBackRegP1_Click(object sender, EventArgs e)
        {
            swipe(false);
        }

        private void mtLecturerReg_Click(object sender, EventArgs e)
        {
            DialogResult dr=MetroFramework.MetroMessageBox.Show(this, "Authorize the Activity via Manager", "Manager Administration Required", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                UserIDLogIn managerLogIN = new UserIDLogIn();
                managerLogIN.Text = "Manager Authorization";
                managerLogIN.ShowDialog();
                var tempForm = Form.ActiveForm as MainForm;
                //tempForm.Text = "ECS - Lecturer Registration";
                LecturerRegistration _LecturerRegistration = new LecturerRegistration(tempForm);
                _LecturerRegistration.swipe(true);
            }
            

        }

        private void mtStudentReg_Click(object sender, EventArgs e)
        {
            var tempForm = Form.ActiveForm as MainForm;
            StudentRegistration _StudentRegistration = new StudentRegistration(tempForm);
            _StudentRegistration.swipe(true);
        }

        private void mtStaffReg_Click(object sender, EventArgs e)
        {
            var tempForm = Form.ActiveForm as MainForm;
            StaffRegistration _StaffRegistration = new StaffRegistration(tempForm);
            _StaffRegistration.swipe(true);
        }
    }
}
