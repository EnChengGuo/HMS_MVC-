using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagementSystemMVC
{
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\88697\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public DoctorForm()
        {
            InitializeComponent();
            Populate();
        }
        void Populate()
        {
            Con.Open();
            string query = "select * from DoctorTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVDoctor.DataSource = ds.Tables[0];

            for (int i = 0; i < DGVDoctor.Columns.Count; i++)
            {
                DGVDoctor.Columns[i].Width = DGVDoctor.Size.Width / (DGVDoctor.Columns.Count);
            }

            Con.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TB_DoctorID.Text == "" || TB_DoctorName.Text == "" || TB_DoctorAge.Text == "" || TB_DoctorPassword.Text == ""||
                TB_DoctorID.Text == "請輸入醫師編號" || TB_DoctorName.Text == "請輸入醫師姓名" || TB_DoctorAge.Text == "請輸入醫齡" || TB_DoctorPassword.Text == "請輸入密碼")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else 
            {
                Con.Open();
                string query = "insert into DoctorTable values(" + TB_DoctorID.Text + ",'" + TB_DoctorName.Text + "'," + TB_DoctorAge.Text + ",'" + TB_DoctorPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Sucessfully Added");
                Con.Close();
                Populate();

            }

        }

        private string DefaultText(string text,string msg)
        {
            if (text == msg)
            {
                return "";
            }
            return text;
        }

        private string LeaveNullText(string text, string msg)
        {
            if (text == "")
            {
                return msg;
            }
            return text;
        }

        private void TB_DoctorID_Enter(object sender, EventArgs e)
        {
            TB_DoctorID.Text = DefaultText(TB_DoctorID.Text, "請輸入醫師編號");
        }

        private void TB_DoctorID_Leave(object sender, EventArgs e)
        {
            TB_DoctorID.Text = LeaveNullText(TB_DoctorID.Text, "請輸入醫師編號");

        }

        private void TBDocName_Enter(object sender, EventArgs e)
        {
            TB_DoctorName.Text= DefaultText(TB_DoctorName.Text, "請輸入醫師姓名");
        }

        private void TBDocName_Leave(object sender, EventArgs e)
        {
            TB_DoctorName.Text = LeaveNullText(TB_DoctorName.Text, "請輸入醫師姓名");
        }

        private void TBDocAge_Enter(object sender, EventArgs e)
        {
            TB_DoctorAge.Text = DefaultText(TB_DoctorAge.Text, "請輸入醫齡");

        }

        private void TBDocAge_Leave(object sender, EventArgs e)
        {
            TB_DoctorAge.Text = LeaveNullText(TB_DoctorAge.Text, "請輸入醫齡");
        }

        private void TBDocPassword_Enter(object sender, EventArgs e)
        {
            TB_DoctorPassword.Text = DefaultText(TB_DoctorPassword.Text, "請輸入密碼");
        }

        private void TBDocPassword_Leave(object sender, EventArgs e)
        {
            TB_DoctorPassword.Text = LeaveNullText(TB_DoctorPassword.Text, "請輸入密碼");
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TB_DoctorID.Text == "" || TB_DoctorID.Text == "請輸入醫師編號")
            {
                MessageBox.Show("Enter The Doctor ID");
            }
            else
            {
                Con.Open();
                string query = "delete from DoctorTable where DocID="+TB_DoctorID.Text+"";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                Con.Close();

                Populate();

            }
        }

        private void DGVDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TB_DoctorID.Text = DGVDoctor.SelectedRows[0].Cells[0].Value.ToString();
                TB_DoctorName.Text = DGVDoctor.SelectedRows[0].Cells[1].Value.ToString();
                TB_DoctorAge.Text = DGVDoctor.SelectedRows[0].Cells[2].Value.ToString();
                TB_DoctorPassword.Text = DGVDoctor.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch { }


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DoctorTable set DocName = '" + TB_DoctorName.Text + "'" +
                                                             ",DocExp= '"+ TB_DoctorAge.Text + "' " +
                                                             ",DocPass='"+TB_DoctorPassword.Text+"'" +
                                                             "where DocID="+TB_DoctorID.Text+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Successfully updated");
            Con.Close();
            Populate();

        }

        private void PBLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
