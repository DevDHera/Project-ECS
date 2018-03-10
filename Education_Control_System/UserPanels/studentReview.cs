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
    public partial class studentReview : userPanelSliderNormal
    {
        static string conString = "server=localhost;user id=root;database=nibm_ecs";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        
        public studentReview(Form owner) :base (owner)
        {
            InitializeComponent();
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblAtten.Text = metroTrackBar1.Value + " %";
        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            lblDispli.Text = metroTrackBar2.Value + " %";
        }

        private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            lblKnow.Text = metroTrackBar3.Value + " %";
        }

        private void metroTrackBar4_Scroll(object sender, ScrollEventArgs e)
        {
            lblTutor.Text = metroTrackBar4.Value + " %";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string viewStr = "SELECT StuID ,StuFName,StuLName,CID FROM Student";
            MySqlDataAdapter adp = new MySqlDataAdapter(viewStr, con);
            DataTable dt = new DataTable();

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
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtStuID.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txtStuName.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();

           

            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT StuAtten,StuDiscp,StuKnow,StuTutor FROM student_review WHERE StuID='"+txtStuID.Text+"'";

            try
            {
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    metroTrackBar1.Value = Convert.ToInt32(rdr.GetValue(0));
                    metroTrackBar2.Value = Convert.ToInt32(rdr.GetValue(1));
                    metroTrackBar3.Value = Convert.ToInt32(rdr.GetValue(2));
                    metroTrackBar4.Value = Convert.ToInt32(rdr.GetValue(3));
                }
                con.Close();
                lblAtten.Text = metroTrackBar1.Value + " %";
                lblDispli.Text = metroTrackBar2.Value + " %";
                lblKnow.Text = metroTrackBar3.Value + " %";
                lblTutor.Text = metroTrackBar4.Value + " %";

            }
            catch(Exception)
            {
                metroTrackBar1.Value = 0;
                metroTrackBar2.Value = 0;
                metroTrackBar3.Value = 0;
                metroTrackBar4.Value = 0;
            }
            finally 
            {
                con.Dispose();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO student_review VALUES ('" + txtStuID.Text + "'," + metroTrackBar1.Value + "," + metroTrackBar2.Value + "," + metroTrackBar3.Value + "," + metroTrackBar4.Value + ")";

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroFramework.MetroMessageBox.Show(this, "You Have Successfully Updated the Review", "Review Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void mtUpdate_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE student_review SET StuAtten=" + metroTrackBar1.Value + ",StuDiscp=" + metroTrackBar2.Value + ",StuKnow=" + metroTrackBar3.Value + ",StuTutor=" + metroTrackBar4.Value + " WHERE StuID='" + txtStuID.Text + "'";

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroFramework.MetroMessageBox.Show(this, "You Have Successfully Updated the Review", "Review Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void mtlinkBack1_Click(object sender, EventArgs e)
        {
            swipe(false);
        }
    }
}
