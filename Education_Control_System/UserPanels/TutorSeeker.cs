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

namespace Education_Control_System.UserPanels
{
    public partial class TutorSeeker : userPanelSliderNormal
    {
        Timer timer = new Timer();

        public TutorSeeker(Form owner) : base (owner)
        {
            InitializeComponent();
        }

        private void mtInitialize_Click(object sender, EventArgs e)
        {
            mtInitialize.Style = (MetroFramework.MetroColorStyle)5;
            int destination = metroPanel1.Height - mtInitialize.Height;
            Transition.run(mtInitialize, "Top", destination, new TransitionType_Bounce(1500));
            //mtInitialize.Visible = false;
            //metroProgressSpinner1.Visible = true;
            setAndStartTimer();
            
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

            if (count == 100)
            {
                //metroProgressSpinner1.Visible = false;
                mtInitialize.Visible = false;
                MetroFramework.MetroMessageBox.Show(this, "Not Enough Data to Cross Refernce the best tutor for you", "Its Embarrassing....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timer.Stop();
            }

        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {
            
        }

        private void mtlinkBack1_Click(object sender, EventArgs e)
        {
            swipe(false);
        }
    }
}
