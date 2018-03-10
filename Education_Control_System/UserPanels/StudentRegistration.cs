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
    public partial class StudentRegistration : userPanelSliderNormal
    {
        bool status;
        char gender;

        static string conString = "server=localhost;user id=root;database=nibm_ecs";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;

        public StudentRegistration(Form owner) :base (owner)
        {
            InitializeComponent();
        }

        private void mtlinkBack1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Continue", "Possible Registration Data Loss", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                swipe(false);
            }
        }

        private void mtlinkBack2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Continue", "Possible Registration Data Loss", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                swipe(false);
            }
        }

        private void txtStuFName_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtStuFName.Text))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuFName,"Name Cannot be Empty");
                status=false;
            }
            else if (txtStuFName.Text.Any(Char.IsDigit))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuFName, "Name Cannot contain Digits");
                status = false;
            }
            else
            {
                errorProviderStudent.Clear();
                status = true;
            }
        }

        private void txtStuLName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStuLName.Text))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuLName, "Name Cannot be Empty");
                status = false;
            }
            else if (txtStuLName.Text.Any(Char.IsDigit))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuLName, "Name Cannot contain Digits");
                status = false;
            }
            else
            {
                errorProviderStudent.Clear();
                status = true;
            }
        }

        private void mrbStuMale_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStuMale.Checked)
            {
                gender = 'M';
            }
        }

        private void mrbStuFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStuFemale.Checked)
            {
                gender = 'F';
            }
        }

        private void txtStuAddress_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStuAddress.Text))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuAddress, "Address Cannot be Empty");
                status = false;
            }
            else
            {
                errorProviderStudent.Clear();
                status = true;
            }
        }

        private void txtStuOLYear_Leave(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtStuOLYear.Text))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuOLYear, "O Level Year Cannot be Empty");
                status = false;
            }
            else if (txtStuOLYear.Text.Any(Char.IsLetter))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuOLYear, "Year cannot contain letters");
                status = false;
            }
            else
            {
                int olYear = Convert.ToInt32(txtStuOLYear.Text);
                if (olYear >= 2000 && olYear <= 2017)
                {
                    errorProviderStudent.Clear();
                    status = true;
                }
                else
                {
                    errorProviderStudent.Clear();
                    errorProviderStudent.SetError(txtStuOLYear, "Year should be between 2000 and 2017");
                    status = false;
                }
            }
        }

        private void txtStuLandPhNo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStuLandPhNo.Text))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuLandPhNo, "Contact Number Cannot be Empty");
                status = false;
            }
            else if (txtStuLandPhNo.Text.Any(Char.IsLetter))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuLandPhNo, "Contact Number Cannot contain Letters");
                status = false;
            }
            else
            {
                errorProviderStudent.Clear();
                status = true;
            }
        }

        private void txtStuMobNo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStuMobNo.Text))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuMobNo, "Contact Number Cannot be Empty");
                status = false;
            }
            else if (txtStuLandPhNo.Text.Any(Char.IsLetter))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuMobNo, "Contact Number Cannot contain Letters");
                status = false;
            }
            else
            {
                errorProviderStudent.Clear();
                status = true;
            }
        }

        private void mrbStuMIS_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStuMIS.Checked)
            {
                cbxStuCourse.Items.Clear();
                cbxStuCourse.Items.Add("HDCB");
                cbxStuCourse.Items.Add("HDSE");
                cbxStuCourse.Items.Add("DCSD");
                cbxStuCourse.Items.Add("DSE");
                cbxStuCourse.Items.Add("CCS");
                cbxStuCourse.Items.Add("CSE");
            }
        }

        private void mrbStuBM_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStuBM.Checked)
            {
                cbxStuCourse.Items.Clear();
                cbxStuCourse.Items.Add("ADBM");
                cbxStuCourse.Items.Add("HDBM");
                cbxStuCourse.Items.Add("CCBM");
                
            }
        }

        private void mrbStuLC_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStuLC.Checked)
            {
                cbxStuCourse.Items.Clear();
                cbxStuCourse.Items.Add("CCE");
                cbxStuCourse.Items.Add("ACCE");
                cbxStuCourse.Items.Add("DE");
            }
        }

        private void cbxStuCourse_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxStuCourse.Text)) 
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(cbxStuCourse, "Cannot be Empty");
                status = false;
            }
            else
            {
                status=true;
                errorProviderStudent.Clear();
                txtStuCID.Text = cbxStuCourse.Text;
            }
        }

        private void mrbStuPermanent_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStuPermanent.Checked)
            {
                txtStuCID.AppendText("F");
            }
        }

        private void mrbStuTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStuTemp.Checked)
            {
                txtStuCID.AppendText("P");
            }
        }

        private void cbxStuBatch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxStuBatch.Text))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(cbxStuBatch, "Cannot be Empty");
                status = false;
            }
            else
            {
                status = true;
                txtStuID.Text = "KU" + cbxStuCourse.Text;
                switch (cbxStuBatch.Text)
                {
                    case "17.1":
                        txtStuID.AppendText("171");
                        break;

                    case "17.2":
                        txtStuID.AppendText("172");
                        break;

                    case "18.1":
                        txtStuID.AppendText("181");
                        break;
                }
                if (mrbStuPermanent.Checked)
                {
                    txtStuID.AppendText("F");
                }
                else if (mrbStuTemp.Checked)
                {
                    txtStuID.AppendText("P");
                }
            }
        }

        private void txtStuTempPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStuTempPassword.Text))
            {
                errorProviderStudent.Clear();
                errorProviderStudent.SetError(txtStuTempPassword, "Password Cannot be Empty");
                status = false;
            }
            else
            {
                status = true;
            }
        }

        private void btnStuSubmit_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (mrbStuMale.Checked || mrbStuFemale.Checked)
                {
                    if (mrbStuMIS.Checked || mrbStuBM.Checked || mrbStuLC.Checked)
                    {
                        if (mrbStuPermanent.Checked || mrbStuTemp.Checked)
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandText = "INSERT INTO Student (StuID,StuFName,StuLName,CID,Gender,DOB,StuAddress,StuMobNo,StuLandNo,OLevelY,StuPassword) VALUES ('" + txtStuID.Text + "','" + txtStuFName.Text + "','" + txtStuLName.Text + "','" + txtStuCID.Text + "','" + gender + "','" + mdtStuDob.Text + "','" + txtStuAddress.Text + "'," + txtStuMobNo.Text + "," + txtStuLandPhNo.Text + ",'" + txtStuOLYear.Text + "','" + txtStuTempPassword + "')";

                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MetroFramework.MetroMessageBox.Show(this, "Student added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (MySqlException ex)
                            {
                                DialogResult dr=MetroFramework.MetroMessageBox.Show(this, "Please Contact the Admin\nDo you Want to See the Problem", "Hmm......Somethings Wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if(dr==DialogResult.Yes)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            finally
                            {
                                con.Dispose();
                            }
                            //MetroFramework.MetroMessageBox.Show(this, "Student added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void mdtStuDob_Leave(object sender, EventArgs e)
        {
            mdtStuDob.Format = DateTimePickerFormat.Custom;
            mdtStuDob.CustomFormat = "dd/MM/yyyy";
        }

        
    }
}
