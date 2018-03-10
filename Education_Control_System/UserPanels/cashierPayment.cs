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
    public partial class cashierPayment : userPanelSliderNormal
    {
        static string conString = "server=localhost;user id=root;database=nibm_ecs";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;

        bool status;
        string paydate,paymethod;

        public cashierPayment(Form owner) : base (owner)
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string viewStr="SELECT StuID as Student_ID,StuFName as First_Name,StuLName as Last_Name,CID FROM Student";
            MySqlDataAdapter adp = new MySqlDataAdapter(viewStr, con);
            DataTable dt=new DataTable();
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
            txtCID.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();

            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT CFee FROM Course WHERE CID='" + txtCID.Text + "'";

            try
            {
                con.Open();
                txtCFee.Text = cmd.ExecuteScalar().ToString();
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
        }

        private void txtPay_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPay.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPay, "Cannot be Empty");
                status = false;
            }
            else if (txtPay.Text.Any(Char.IsLetter))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPay, "Cannot be Letters");
                status = false;
            }
            else
            {
                errorProvider1.Clear();
                status = true;

                double remain = Convert.ToDouble(txtCFee.Text) - Convert.ToDouble(txtPay.Text);
                remain=Math.Round(remain,2);
                txtRemain.Text = remain.ToString();
            }
        }

        private void mrbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbCash.Checked)
            {
                paymethod = "Cash";
            }

        }

        private void mrbCard_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbCard.Checked)
            {
                paymethod = "Card";
            }
        }

        private void metroDateTime1_Leave(object sender, EventArgs e)
        {
            metroDateTime1.Format = DateTimePickerFormat.Custom;
            metroDateTime1.CustomFormat = "dd/MM/yyyy";
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (status)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO student_payment values ('" + txtStuID.Text + "','" + txtStuID.Text.Substring(5, 7) + "','" + metroDateTime1.Text + "'," + txtPay.Text + "," + txtRemain.Text + ",'" + paymethod + "')";

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MetroFramework.MetroMessageBox.Show(this, "Transaction Completed for Student ID :" + txtStuID.Text, "Transaction Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MetroFramework.MetroMessageBox.Show(this,"Cannot Complete the Transaction" , "Sorry...Unable To Due the Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtlinkBack_Click(object sender, EventArgs e)
        {
            swipe(false);
        }
    }
}
