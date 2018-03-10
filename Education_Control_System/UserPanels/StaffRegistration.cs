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
    public partial class StaffRegistration : userPanelSliderNormal
    {
        bool status;
        char gender;
        string depID;

        static string conString = "server=localhost;user id=root;database=nibm_ecs";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;

        public StaffRegistration(Form owner) :base(owner)
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

        private void txtStaffFName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStaffFName.Text))
            {
                errorProviderStaff.Clear();
                errorProviderStaff.SetError(txtStaffFName, "Name Cannot be Empty");
                status = false;
            }
            else if (txtStaffFName.Text.Any(Char.IsDigit))
            {
                errorProviderStaff.Clear();
                errorProviderStaff.SetError(txtStaffFName, "Name Cannot Contain Digits");
                status = false;
            }
            else
            {
                errorProviderStaff.Clear();
                status = true;
            }
        }

        private void txtStaffLName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStaffLName.Text))
            {
                errorProviderStaff.Clear();
                errorProviderStaff.SetError(txtStaffLName, "Name Cannot be Empty");
                status = false;
            }
            else if (txtStaffLName.Text.Any(Char.IsDigit))
            {
                errorProviderStaff.Clear();
                errorProviderStaff.SetError(txtStaffLName, "Name Cannot Contain Digits");
                status = false;
            }
            else
            {
                errorProviderStaff.Clear();
                status = true;
            }
        }

        private void mrbStaffMale_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStaffMale.Checked)
            {
                gender = 'M';
            }
        }

        private void mrbStaffFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStaffFemale.Checked)
            {
                gender = 'F';
            }
        }

        private void txtStaffAddress_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStaffAddress.Text))
            {
                errorProviderStaff.Clear();
                errorProviderStaff.SetError(txtStaffAddress, "Address Cannot be Empty");
                status = false;
            }
            else
            {
                errorProviderStaff.Clear();
                status = true;
            }
        }

        private void txtStaffPhNo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStaffPhNo.Text))
            {
                errorProviderStaff.Clear();
                errorProviderStaff.SetError(txtStaffPhNo, "Contact details cannot be Empty");
                status = false;
            }
            else if (txtStaffPhNo.Text.Any(Char.IsLetter))
            {
                errorProviderStaff.Clear();
                errorProviderStaff.SetError(txtStaffPhNo, "Cannot contain Letters");
                status = false;
            }
            else
            {
                errorProviderStaff.Clear();
                status = true;
            }
        }

        private void mrbStaffFO_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbStaffFO.Checked)
            {
                cbxStaffDesi.Items.Clear();
                cbxStaffDesi.Items.Add("Staff");
                cbxStaffDesi.Items.Add("Manager");
                cbxStaffDesi.Items.Add("Cashier");
                depID = "KUFO";
            }
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            cbxStaffDesi.Items.Clear();
            cbxStaffDesi.Items.Add("Security Officer");
            depID = "KUSE";
            
        }

        private void mrbStaffC_CheckedChanged(object sender, EventArgs e)
        {
            cbxStaffDesi.Items.Clear();
            cbxStaffDesi.Items.Add("Cleaner");
            cbxStaffDesi.Items.Add("Cleaning Manager");
            depID = "KUCL";
        }

        private void cbxStaffDesi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxStaffDesi.Text))
            {
                errorProviderStaff.Clear();
                errorProviderStaff.SetError(cbxStaffDesi, "Cannot be Empty");
                status = false;
            }
            else
            {
                errorProviderStaff.Clear();
                status = true;
                if (mrbStaffFO.Checked)
                {
                    switch (cbxStaffDesi.SelectedIndex)
                    {
                        case 0:
                            txtStaffID.Text="KUSTMEM";
                            break;

                        case 1:
                            txtStaffID.Text="KUSTMAN";
                            break;

                        case 2:
                            txtStaffID.Text="KUSTCAS";
                            break;
                    }

                }
                else if(metroRadioButton5.Checked)
                {
                    txtStaffID.Text="KUSEC00";
                }
                else if(mrbStaffC.Checked)
                {
                    switch(cbxStaffDesi.SelectedIndex)
                    {
                        case 0:
                            txtStaffID.Text="KUCLE00";
                            break;

                        case 1:
                            txtStaffID.Text="KUCLEMA";
                            break;
                    }
                }
                    
            }
        }

        private void btnStaffSubmit_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (mrbStaffMale.Checked || mrbStaffFemale.Checked)
                {
                    if (mrbStaffFO.Checked || mrbStaffC.Checked || metroRadioButton5.Checked)
                    {
                        cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT INTO Staff (StaffID,StaffFName,StaffLName,Gender,StaffAddress,StaffPhNo,DeptID,Designation,StaffPassword) VALUES ('" + txtStaffID.Text + "','" + txtStaffFName.Text + "','" + txtStaffLName.Text + "','" + gender + "','" + txtStaffAddress.Text + "'," + txtStaffPhNo.Text + ",'" + depID + "','" + cbxStaffDesi.Text + "','" + txtStaffTempPassword.Text + "')";
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MetroFramework.MetroMessageBox.Show(this, "Student added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
