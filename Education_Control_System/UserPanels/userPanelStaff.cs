using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Education_Control_System;

namespace Education_Control_System.UserPanels
{
    public partial class userPanelStaff : userPanelSlider
    {
        public userPanelStaff(Form owner) : base(owner)
        {
            InitializeComponent();
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            //Region rg = new Region(gp);
            //pictureBox1.Region = rg;

        }

        private void mtRegister_Click(object sender, EventArgs e)
        {
            var tempForm = Form.ActiveForm as MainForm;
            RegitrationPanel _RegistrationPanel = new RegitrationPanel(tempForm);
            _RegistrationPanel.swipe(true);
            
        }

        private void mtView_Click(object sender, EventArgs e)
        {
            var tempForm = Form.ActiveForm as MainForm;
            viewDetails _viewDetails = new viewDetails(tempForm);
            _viewDetails.swipe(true);
        }

        public void rolePrivilage(string role)
        {
            if (role == "Manager")
            {
                mtReports.Enabled=true;

            }
            else if (role == "Cashier")
            {
                mtPayment.Enabled = true;
            }
            else if (role == "Admin")
            {
                mtPayment.Enabled = true;
                mtReports.Enabled = true;
            }
        }

        private void mtSchedule_Click(object sender, EventArgs e)
        {
            var tempForm=Form.ActiveForm as MainForm;
            scheduleDetails _scheduleDetails = new scheduleDetails(tempForm);
            _scheduleDetails.swipe(true);
        }

        private void mtPayment_Click(object sender, EventArgs e)
        {
            var tempForm = Form.ActiveForm as MainForm;
            cashierPayment _cashierPayment = new cashierPayment(tempForm);
            _cashierPayment.swipe(true);
        }

        private void mtReports_Click(object sender, EventArgs e)
        {
            var tempForm = Form.ActiveForm as MainForm;
            managerReports _managerReports = new managerReports(tempForm);
            _managerReports.swipe(true);

        }

        
    }
}
