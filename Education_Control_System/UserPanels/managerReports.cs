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
    public partial class managerReports : userPanelSliderNormal
    {
        static string conString = "server=localhost;user id=root;database=nibm_ecs";
        MySqlConnection con = new MySqlConnection(conString);
        string viewStr;
        DataTable dt;

        public managerReports(Form owner) :base (owner)
        {
            InitializeComponent();
        }

        private void mtCouPay_Click(object sender, EventArgs e)
        {
            mtCouDeatails.Visible = false;
            mtStaffSalary.Visible = false;
            mtCouPay.Enabled = false;

            viewStr = "SELECT * FROM Student_payment";

            MySqlDataAdapter adp = new MySqlDataAdapter(viewStr, con);
            dt=new DataTable();

            try
            {
                con.Open();
                adp.Fill(dt);
                con.Close();
            }
            catch (MySqlException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Contact the Admin\nDo you Want to See the Problem", "Hmm......Somethings Wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                con.Dispose();
            }
            metroGrid1.DataSource = dt;
            metroGrid1.Visible = true;


        }

        private void mtStaffSalary_Click(object sender, EventArgs e)
        {
            mtCouDeatails.Visible = false;
            mtStaffSalary.Visible = false;
            mtCouPay.Enabled = false;
            mtCouPay.Text = "Staff Salary Deatails";

            viewStr = "SELECT * FROM staffsalary";
            MySqlDataAdapter adp = new MySqlDataAdapter(viewStr, con);
            dt = new DataTable();

            try
            {
                con.Open();
                adp.Fill(dt);
                con.Close();
            }
            catch (MySqlException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Contact the Admin\nDo you Want to See the Problem", "Hmm......Somethings Wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                con.Dispose();
            }
            metroGrid1.DataSource = dt;
            metroGrid1.Visible = true;
        }

        private void mtCouDeatails_Click(object sender, EventArgs e)
        {
            mtCouDeatails.Visible = false;
            mtStaffSalary.Visible = false;
            mtCouPay.Enabled = false;
            mtCouPay.Text = "Courese Details";

            viewStr = "SELECT * FROM course";
            MySqlDataAdapter adp = new MySqlDataAdapter(viewStr, con);
            dt = new DataTable();

            try
            {
                con.Open();
                adp.Fill(dt);
                con.Close();
            }
            catch (MySqlException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Contact the Admin\nDo you Want to See the Problem", "Hmm......Somethings Wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                con.Dispose();
            }
            metroGrid1.DataSource = dt;
            metroGrid1.Visible = true;
        }

        private void mtlinkExit_Click(object sender, EventArgs e)
        {
            metroGrid1.Visible = false;
            mtCouDeatails.Visible = true;
            mtStaffSalary.Visible = true;
            mtCouPay.Enabled = true;
            mtCouPay.Text = "Courese Payment\n Details";

        }

        private void mtlinkBack_Click(object sender, EventArgs e)
        {
            swipe(false);
        }
    }
}
