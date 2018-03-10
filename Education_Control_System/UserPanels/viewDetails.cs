using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Education_Control_System.UserPanels
{
    public partial class viewDetails : userPanelSliderNormal
    {
        static string conString = "server=localhost;user id=root;database=nibm_ecs";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        DataTable dt; //= new DataTable();
        string viewString;
        

        public viewDetails(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void mtStuDetails_Click(object sender, EventArgs e)
        {
            mtLecDetails.Visible = false;
            mtStaffDetails.Visible = false;
            metroGrid1.Visible = true;

            viewString = "SELECT StuID,StuFName,StuLName,Gender,DOB,StuAddress,StuMobNo,StuLandNo,CID FROM Student";
            adp = new MySqlDataAdapter(viewString, con);
            dt = new DataTable();
            //DataTable dt = new DataTable();

            try
            {
                con.Open();
                adp.Fill(dt);
                con.Close();
            }
            catch (MySqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Contact the Admin\n"+ex.Message, "Hmm......Somethings Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Dispose();
            }

            metroGrid1.DataSource = dt;
        }

        private void mtStaffDetails_Click(object sender, EventArgs e)
        {
            mtLecDetails.Visible = false;
            mtStuDetails.Visible = false;
            metroGrid1.Visible = true;

            viewString = "SELECT StaffID,StaffFName,StaffLName,Gender,StaffAddress,StaffPhNo,DeptID,Designation FROM Staff";
            adp = new MySqlDataAdapter(viewString, con);
            dt = new DataTable();

            try
            {
                con.Open();
                adp.Fill(dt);
                con.Close();
            }
            catch (MySqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Contact the Admin\n" + ex.Message, "Hmm......Somethings Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Dispose();
            }

            metroGrid1.DataSource = dt;
        }

        private void mtLecDetails_Click(object sender, EventArgs e)
        {
            mtStaffDetails.Visible = false;
            mtStuDetails.Visible = false;
            metroGrid1.Visible = true;

            viewString = "SELECT LID,LFName,LLName,Gender,DOB,LAddress,LPhNo FROM Lecturer";
            adp = new MySqlDataAdapter(viewString, con);
            dt = new DataTable();

            try
            {
                con.Open();
                adp.Fill(dt);
                con.Close();
            }
            catch (MySqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Contact the Admin\n" + ex.Message, "Hmm......Somethings Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Dispose();
            }

            metroGrid1.DataSource = dt;
        }

        private void mtlinkBack1_Click(object sender, EventArgs e)
        {
            swipe(false);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            metroGrid1.Visible = false;
            mtStuDetails.Visible = true;
            mtStaffDetails.Visible = true;
            mtLecDetails.Visible = true;
        }
    }
}
