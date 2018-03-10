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
    public partial class userPanelSlider : MetroFramework.Controls.MetroUserControl
    {
        Form _owner = null;
        bool _loaded = false;
        Timer timer = new Timer();

        public event EventHandler Closed;
        public event EventHandler Shown;

        protected virtual void closed(EventArgs e)
        {
            EventHandler handler = Closed;
            if (handler != null) handler(this, e);
        }

        protected virtual void shown(EventArgs e)
        {
            EventHandler handler = Shown;
            if (handler != null) handler(this, e);
        }

        public userPanelSlider()
        {
            InitializeComponent();
            setAndStartTimer();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            //logInLabel(role);
        }

        public userPanelSlider(Form owner)
            : this()
        {
            this.Visible = false;

            _owner = owner;
            owner.Controls.Add(this);
            this.BringToFront();
            owner.Resize += owner_Resize;
            ResizeForm();
        }

        

        void owner_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            this.Width = _owner.Width;
            this.Height = _owner.Height - 77;
            this.Location = new Point(_loaded ? 0 : _owner.Width, 50);
            
        }

        public void swipe(bool show = true)
        {
            this.Visible = true;
            Transition _transition = new Transitions.Transition(new TransitionType_EaseInEaseOut(1000));
            _transition.add(this, "Left", show ? 0 : this.Width);
            _transition.run();

            while (this.Left != (show ? 0 : this.Width))
            {
                Application.DoEvents();
            }



            if (!show)
            {
                closed(new EventArgs());
                _owner.Resize -= owner_Resize;
                _owner.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                _loaded = true;
                ResizeForm();
                shown(new EventArgs());
            }
            show = false;
        }

        private void mtlinkSettings_Click(object sender, EventArgs e)
        {
            var tempForm = Form.ActiveForm as MainForm;
            tempForm.initiate_pnlSettings();
            swipe(false);
        }

        private void mtlinkMail_Click(object sender, EventArgs e)
        {
            //mtlinkMail
            System.Diagnostics.Process.Start("https://www.office.com/");
        }

        private void setAndStartTimer()
        {
            timer.Tick+=new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void logInLabel(string role)
        {
            metroLabel2.Text = role;
        }

        private void mtlinkLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr=MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Log Out", "Sure Enough?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.Yes)
            {
                swipe(false);
                UserIDLogIn _login = new UserIDLogIn();
                _login.ShowDialog();
            }
        }



       
    }
}
