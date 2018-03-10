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
    public partial class LecCheckSchTaskWindow : UserControl
    {
        public LecCheckSchTaskWindow()
        {
            InitializeComponent();
        }

        private void mtPDF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "..\\..\\..\\Schedule\\ExistingSchedule\\October_2017_MIS_Schedule.pdf");
        }

        private void mtOnline_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.office.com/");
        }
    }
}
