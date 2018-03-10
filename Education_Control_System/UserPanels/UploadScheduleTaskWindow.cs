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
    public partial class UploadScheduleTaskWindow : UserControl
    {
        public UploadScheduleTaskWindow()
        {
            InitializeComponent();
        }

        private void mtGmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/signin/v2/sl/pwd?service=mail&passive=true&rm=false&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ss=1&scc=1&ltmpl=default&ltmplcache=2&emr=1&osid=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
        }

        private void mtOffice365_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.office.com/");
        }
    }
}
