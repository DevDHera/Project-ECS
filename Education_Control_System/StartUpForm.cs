using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

using Education_Control_System.StartUpPanel;

namespace Education_Control_System
{
    public partial class StartUpForm : MetroFramework.Forms.MetroForm
    {
        Timer timer = new Timer();

        

        public StartUpForm()
        {
            InitializeComponent();
            setAndStartTimer();
        }

        private void setAndStartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        static int count = 0;

        void timer_Tick(object sender,EventArgs e)
        {
            count += 2;
            //metroStyleManager1.Style = (MetroFramework.MetroColorStyle)10;
            //mtlblProgress.Text = "Welcome";
            //this.Text = "Welcome";

            if (count == 10)
            {
                mtlblProgress.Text = "Welcome";
                pnlLearn _pnlLearn = new pnlLearn(this);
                _pnlLearn.Closed += _pnlLearn_Closed;
                _pnlLearn.Shown += _pnlLearn_Shown;
                _pnlLearn.swipe(true);
                

                while (true)
                {
                    count += 2;
                    //metroStyleManager1.Style = (MetroFramework.MetroColorStyle)m;

                    if (count == 90)
                    {
                        _pnlLearn.cc();
                        
                        
                        break;
                    }
                }
            }

            if (count == 120)
            {
                mtlblProgress.Text = "Loading Components...";
                pnlStaff _pnlStaff = new pnlStaff(this);
                
                _pnlStaff.swipe(true);

                while (true)
                {
                    count += 2;
                    if (count == 200)
                    {
                        _pnlStaff.cc();
                        
                        break;
                    }
                }
            }
            //mtlblProgress.Text = "Initializing Components...";

            if (count == 230)
            {
                pnlLecturer _pnlLecturer = new pnlLecturer(this);

                _pnlLecturer.swipe(true);

                while (true)
                {
                    count += 2;
                    if (count == 310)
                    {
                        _pnlLecturer.cc();
                        
                        break;
                    }
                }
            }
           

            if (count == 400)
            {
                timer.Stop();
                this.Close();
            }
        }

        void _pnlLearn_Closed(Object sender, EventArgs e)
        {
 
        }

        void _pnlLearn_Shown(Object sender, EventArgs e)
        {

        }
    }
}
