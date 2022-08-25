using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagementSystemMVC
{
    public partial class LoginForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\88697\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void TB_DocName_Enter(object sender, EventArgs e)
        {
            if (TB_DocName.Text.Trim() == "請輸入醫師名稱")
            {
                TB_DocName.Text = "";
                
            }
        }

        private void TB_DocName_Leave(object sender, EventArgs e)
        {
            if (TB_DocName.Text.Trim().Length == 0)
            {
                TB_DocName.PasswordChar = '\0';
                TB_DocName.Text = "請輸入醫師名稱";
            }
        }

        private void TB_DoctorPassword_Enter(object sender, EventArgs e)
        {
            if (TB_DoctorPassword.Text.Trim() == "請輸入密碼")
            {
                TB_DoctorPassword.Text = "";
                TB_DoctorPassword.PasswordChar = '*';
            }
        }

        private void TB_DoctorPassword_Leave(object sender, EventArgs e)
        {
            if (TB_DoctorPassword.Text.Trim().Length == 0)
            {
                TB_DoctorPassword.PasswordChar = '\0';
                TB_DoctorPassword.Text = "  請輸入密碼";
            }
        }

        private void LB_Leave_Click(object sender, EventArgs e)
        {
            TB_DocName.Text = "請輸入醫師名稱";
            TB_DoctorPassword.Text = "  請輸入密碼";
        }

        private void BtnLongin_Click(object sender, EventArgs e)
        {
            if (TB_DocName.Text == "請輸入醫師名稱" ||
               TB_DoctorPassword.Text == "  請輸入密碼")
            {
                MessageBox.Show("請輸入醫師名稱與密碼");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda=new SqlDataAdapter("select Count(*) from DoctorTable where DocName='"+
                                                       TB_DocName.Text + "' and DocPass='" + 
                                                       TB_DoctorPassword.Text + "'"
                                                      ,Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home _home = new Home();
                    _home.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("帳號密碼錯誤");
                }
                Con.Close();

            }

        }

        private void PBLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
