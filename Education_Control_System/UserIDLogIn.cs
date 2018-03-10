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
using Transitions;
using MySql.Data.MySqlClient;

namespace Education_Control_System
{
    public partial class UserIDLogIn : MetroFramework.Forms.MetroForm
    {
        static string conString = "Server=localhost; Database=nibm_ecs; Uid=root; Pwd=";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;

        Timer timer = new Timer();
        Timer timer1 = new Timer();

        bool status;
        string role = null;

        public UserIDLogIn()
        {
            InitializeComponent();            
            this.StyleManager = metroStyleManagerLoginForm;
        }

        private void setAndStartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        static int count = 0;

        void timer_Tick(object sender, EventArgs e)
        {
            count += 2;

            if (count == 40)
            {
                status=loginValidation();               
                count = 0;
                setAndStartTimer1();
                timer.Stop();
            }

                        
        }

        private void setAndStartTimer1()
        {
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        static int count1 = 0;

        void timer1_Tick(object sender, EventArgs e)
        {
            count1 += 2;
            

            if (count1 == 40)
            {
                if (status)
                {
                    //var tempForm = Form.ActiveForm as MainForm;
                    //tempForm.userView();
                    this.Close();
                    Program.mf.userView(role);
                    
                    
                    
                }
                count1 = 0;
                timer1.Stop();
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)4;
            metroProgressSpinner1.Visible = true;
            lblInfocheck.Visible = true;
            //lblInfocheck.ForeColor = System.Drawing.Color.Blue;
            lblInfocheck.Text = "Checking Information...";
            setAndStartTimer();
            
        }

        bool loginValidation()
        {
            bool login;
            string password=null,desi=null;
            if (txtUserID.Text.Substring(0, 7) == "KUADMIN" || txtUserID.Text.Substring(0, 6) == "KUDEAN" || txtUserID.Text.Substring(0, 7) == "KUSTMEM" || txtUserID.Text.Substring(0, 7) == "KUSEC00" || txtUserID.Text.Substring(0, 7) == "KUCLE00" || txtUserID.Text.Substring(0, 7)=="KUCLEMA")
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT StaffPassword,Designation FROM Staff WHERE StaffID='"+ txtUserID.Text+"'";
                //MessageBox.Show(txtUserID.Text.Substring(0, 7));
                

                try
                {
                    con.Open();
                    //password = cmd.ExecuteScalar().ToString();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        password = rdr.GetString(0);
                        desi = rdr.GetString(1);
                        
                    }
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
                if (txtPassword.Text == password)
                {
                    metroProgressSpinner1.Visible = false;
                    metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)5;
                    lblInfocheck.Text = desi + " Confirmed";
                    login = true;
                    role = desi;
                }
                else
                {
                    metroProgressSpinner1.Visible = false;
                    metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)13;
                    lblInfocheck.Text = "Oops..Somethings Wrong";
                    login = false;
                }
            }
            else if (txtUserID.Text.Substring(0, 5) == "KUMIS" || txtUserID.Text.Substring(0, 5) == "KUBME" || txtUserID.Text.Substring(0, 5) == "KULCN")
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT LPassword FROM Lecturer WHERE LID='" + txtUserID.Text+"'";

                try
                {
                    con.Open();
                    password = cmd.ExecuteScalar().ToString();
                    con.Close();
                }
                catch (MySqlException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Contact the Admin", "Hmm......Somethings Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Dispose();
                }

                if (txtPassword.Text == password)
                {
                    metroProgressSpinner1.Visible = false;
                    metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)5;
                    lblInfocheck.Text = "Lecturer Confirmed";
                    login = true;
                    role = "Lecturer";
                }
                else
                {
                    metroProgressSpinner1.Visible = false;
                    metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)13;
                    lblInfocheck.Text = "Oops..Somethings Wrong";
                    login = false;
                }
            }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT StuPassword FROM Student WHERE StuID='" + txtUserID.Text+"'";

                try
                {
                    con.Open();
                    password = cmd.ExecuteScalar().ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Contact the Admin\n"+ex.Message, "Hmm......Somethings Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Dispose();
                }
                if (txtPassword.Text == password)
                {
                    metroProgressSpinner1.Visible = false;
                    metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)5;
                    lblInfocheck.Text = "Student Confirmed";
                    login = true;
                    role = "Student";
                }
                else
                {
                    metroProgressSpinner1.Visible = false;
                    metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)13;
                    lblInfocheck.Text = "Oops..Somethings Wrong";
                    login = false;
                }
            }
            /*if (txtUserID.Text == "Devin" && txtPassword.Text == "1234")
            {
                metroProgressSpinner1.Visible = false;
                metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)5;
                //lblInfocheck.ForeColor = System.Drawing.Color.Green;
                lblInfocheck.Text = "Admin Confirmed";
                login = true;
            }
            else if (txtUserID.Text == "Staff" && txtPassword.Text == "1234")
            {
                metroProgressSpinner1.Visible = false;
                metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)5;
                //lblInfocheck.ForeColor = System.Drawing.Color.Green;
                lblInfocheck.Text = "Staff Member Confirmed";
                login = true;
            }
            else if (txtUserID.Text == "Lecturer" && txtPassword.Text == "1234")
            {
                metroProgressSpinner1.Visible = false;
                metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)5;
                //lblInfocheck.ForeColor = System.Drawing.Color.Green;
                lblInfocheck.Text = "Lecturer Confirmed";
                login = true;
            }
            else if (txtUserID.Text == "Student" && txtPassword.Text == "1234")
            {
                metroProgressSpinner1.Visible = false;
                metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)5;
                //lblInfocheck.ForeColor = System.Drawing.Color.Green;
                lblInfocheck.Text = "Student Confirmed";
                login = true;
            }
            else
            {
                metroProgressSpinner1.Visible = false;
                metroStyleManagerLoginForm.Style = (MetroFramework.MetroColorStyle)13;
                //lblInfocheck.ForeColor = System.Drawing.Color.Red;
                lblInfocheck.Text = "Oops..Somethings Wrong";
                login = false;
            }*/
            return login;
        }
    }
}
