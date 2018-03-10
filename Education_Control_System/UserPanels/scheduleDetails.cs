using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using MetroFramework.Forms;

namespace Education_Control_System.UserPanels
{
    public partial class scheduleDetails : userPanelSliderNormal
    {
        public scheduleDetails(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void mtcrateSch_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application _scheduleTemplate = new Microsoft.Office.Interop.Word.Application();
                Document document = _scheduleTemplate.Documents.Open(System.Windows.Forms.Application.StartupPath + "..\\..\\..\\Schedule\\Template\\ScheduleTemplate.docx",ReadOnly:true);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtUpdateSchedule_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "..\\..\\..\\Schedule\\ExistingSchedule\\October_2017_MIS_Schedule.pdf");
        }

        private void mtUploadSch_Click(object sender, EventArgs e)
        {
            MetroTaskWindow.ShowTaskWindow(this, "Upload Via", new UploadScheduleTaskWindow(), 10);
        }

        private void mtlinkBack1_Click(object sender, EventArgs e)
        {
            swipe(false);
        }
    }
}
