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
    public partial class LecturerRegistration : userPanelSliderNormal
    {
        bool status;
        char gender;

        static string conString = "server=localhost;user id=root;database=nibm_ecs";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;

        public LecturerRegistration(Form owner):base(owner)
        {
            InitializeComponent();
        }

        private void txtLecFName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLecFName.Text))
            {
                errorProviderLecturer.Clear();
                errorProviderLecturer.SetError(txtLecFName, "Name Cannot be Empty");
                status = false;
                
            }
            else if (txtLecFName.Text.Any(Char.IsDigit))
            {
                errorProviderLecturer.Clear();
                errorProviderLecturer.SetError(txtLecFName, "Name Cannot Contain Digits");
                status = false;
            }
            else
            {
                errorProviderLecturer.Clear();
                status = true;
            }
        }
       
        private void txtLecLName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLecLName.Text))
            {
                errorProviderLecturer.Clear();
                errorProviderLecturer.SetError(txtLecLName, "Last Name Cannot be Empty");
                status = false;

            }
            else if (txtLecLName.Text.Any(Char.IsDigit))
            {
                errorProviderLecturer.Clear();
                errorProviderLecturer.SetError(txtLecLName, "Name Cannot Contain Digits");
                status = false;
            }
            else
            {
                errorProviderLecturer.Clear();
                status = true;
            }
        }

        private void mtlinkBackLecReg2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Continue", "Possible Registration Data Loss", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                swipe(false);
            }
        }

        private void txtLecAddress_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLecAddress.Text))
            {
                errorProviderLecturer.Clear();
                errorProviderLecturer.SetError(txtLecAddress, "Address Cannot be Empty");
                status = false;
            }
            else
            {
                errorProviderLecturer.Clear();
                status = true;
            }
        }

        private void txtLecPhno_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLecPhno.Text))
            {
                errorProviderLecturer.Clear();
                errorProviderLecturer.SetError(txtLecPhno, "Contact Number Cannot be Empty");
                status = false;
            }
            else if (txtLecPhno.Text.Any(Char.IsLetter))
            {
                errorProviderLecturer.Clear();
                errorProviderLecturer.SetError(txtLecPhno, "Contact Number Cannot be Letter");
                status = false;
            }            
            else
            {
                errorProviderLecturer.Clear();
                status = true;
            }
        }

        private void mrbMIS_CheckedChanged(object sender, EventArgs e)
        {
            txtLecID_City.Text = "KU";
            txtLecID_Division.Text = "MIS";
        }

        private void mrbBM_CheckedChanged(object sender, EventArgs e)
        {
            txtLecID_City.Text = "KU";
            txtLecID_Division.Text = "BME";
        }

        private void mrbLC_CheckedChanged(object sender, EventArgs e)
        {
            txtLecID_City.Text = "KU";
            txtLecID_Division.Text = "LCN";
        }

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (mrbLecMale.Checked || mbrLecFemale.Checked)
                {
                    if (mrbMIS.Checked || mrbBM.Checked || mrbLC.Checked)
                    {
                        if (!String.IsNullOrEmpty(cbxLecID_PerTemp.Text) && !String.IsNullOrEmpty(cbxLecID_digit.Text))
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandText="INSERT INTO Lecturer (LID,LFName,LLName,Gender,DOB,LAddress,LPhNo,LPassword) VALUES ('"+txtLecID_City.Text+txtLecID_Division.Text+cbxLecID_PerTemp.Text+cbxLecID_digit.Text+"','"+txtLecFName.Text+"','"+txtLecLName.Text+"','"+gender+"','"+mdtLecDob.Text+"','"+txtLecAddress.Text+"',"+txtLecPhno.Text+",'"+txtLecTempPassword+"')";

                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MetroFramework.MetroMessageBox.Show(this, "Lecturer added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Cannot Continue, Please Fill all the Fields", "Hmm......Some fields are missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Cannot Continue, Please Fill all the Fields", "Hmm......Some fields are missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Cannot Continue, Please Fill all the Fields", "Hmm......Some fields are missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Cannot Continue, Please Fill all the Fields", "Hmm......Some fields are missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mrbLecMale_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLecMale.Checked)
            {
                gender = 'M';
            }
        }

        private void mbrLecFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (mbrLecFemale.Checked)
            {
                gender = 'F';
            }
        }

        private void txtLecTempPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLecTempPassword.Text))
            {
                errorProviderLecturer.Clear();
                errorProviderLecturer.SetError(txtLecTempPassword, "Password Cannot be Empty");
                status = false;
            }
            else
            {
                errorProviderLecturer.Clear();
                status = true;
            }
        }

        private void mdtLecDob_Leave(object sender, EventArgs e)
        {
            mdtLecDob.Format = DateTimePickerFormat.Custom;
            mdtLecDob.CustomFormat = "dd/MM/yyyy";
        }

        
    }
}
