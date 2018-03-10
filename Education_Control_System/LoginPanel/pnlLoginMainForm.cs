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
using MetroFramework.Interfaces;
using System.IO;
using Education_Control_System;

namespace Education_Control_System.LoginPanel
{
    public partial class pnlLoginMainForm : pnlSilderLogin
    {
        public pnlLoginMainForm(Form owner):base(owner) 
        {
            InitializeComponent();
        }

        //bool status = true;

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult dr=MetroFramework.MetroMessageBox.Show(this, "You Will Unable To Use Any Fuctions\nAre You Sure You Want to Skip the Log in", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                swipe(false);
                MetroTaskWindow.ShowTaskWindow(this, "No Log in Required", new GPUCalculatorTaskWindow(), 10);
            }
            else
            {
 
            }
            
            
            //status = false;

            //string stat = status.ToString()+"\n";
            //File.WriteAllText(Application.StartupPath + "..\\..\\..\\Files\\Status.txt", stat);

            
            
        }

        private void mtUserID_Click(object sender, EventArgs e)
        {
            swipe(false);
            UserIDLogIn uIDLogIN = new UserIDLogIn();
            uIDLogIN.ShowDialog();
        }

        
    
        

        
    }
}
