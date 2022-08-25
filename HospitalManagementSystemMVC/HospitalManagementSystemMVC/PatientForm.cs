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
    public partial class PatientForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\88697\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public PatientForm()
        {
            InitializeComponent();
            Populate();
        }

        void Populate()
        {
            Con.Open();
            string query = "select * from PatientTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVPatient.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Show();
            this.Hide();
        }

        private string DefaultText(string text, string msg)
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

        private void TB_PaientID_Enter(object sender, EventArgs e)
        {
            TB_PatientID.Text = DefaultText(TB_PatientID.Text, "請輸入病患編號");

        }

        private void TB_PaientID_Leave(object sender, EventArgs e)
        {
            TB_PatientID.Text = LeaveNullText(TB_PatientID.Text, "請輸入病患編號");
        }

        private void TB_PatientName_Enter(object sender, EventArgs e)
        {
            TB_PatientName.Text = DefaultText(TB_PatientName.Text, "請輸入病患姓名");
        }

        private void TB_PatientName_Leave(object sender, EventArgs e)
        {
            TB_PatientName.Text = LeaveNullText(TB_PatientName.Text, "請輸入病患姓名");

        }

        private void TB_PatientAdress_Enter(object sender, EventArgs e)
        {
            TB_PatientAdress.Text = DefaultText(TB_PatientAdress.Text, "請輸入病患地址");
        }

        private void TB_PatientAdress_Leave(object sender, EventArgs e)
        {
            TB_PatientAdress.Text = LeaveNullText(TB_PatientAdress.Text, "請輸入病患地址");
        }

        private void TB_PatientPhone_Enter(object sender, EventArgs e)
        {
            TB_PatientPhone.Text = DefaultText(TB_PatientPhone.Text, "請輸入病患手機");
        }

        private void TB_PatientPhone_Leave(object sender, EventArgs e)
        {
            TB_PatientPhone.Text = LeaveNullText(TB_PatientPhone.Text, "請輸入病患手機");
        }

        private void TB_PatientAge_Enter(object sender, EventArgs e)
        {
            TB_PatientAge.Text = DefaultText(TB_PatientAge.Text, "請輸入病患年齡");
        }

        private void TB_PatientAge_Leave(object sender, EventArgs e)
        {
            TB_PatientAge.Text = LeaveNullText(TB_PatientAge.Text, "請輸入病患年齡");
        }

        private void TB_PatientDisease_Enter(object sender, EventArgs e)
        {
            TB_PatientDisease.Text = DefaultText(TB_PatientDisease.Text, "請輸入病名");
        }

        private void TB_PatientDisease_Leave(object sender, EventArgs e)
        {
            TB_PatientDisease.Text = LeaveNullText(TB_PatientDisease.Text, "請輸入病名");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TB_PatientID.Text == "請輸入病患編號" ||
                TB_PatientName.Text == "請輸入病患姓名" ||
                TB_PatientAdress.Text == "請輸入病患地址" ||
                TB_PatientPhone.Text == "請輸入病患手機" ||
                TB_PatientAge.Text == "請輸入病患年齡" ||
                TB_PatientDisease.Text == "請輸入病名" ||
                CBGender.SelectedItem == null ||
                CBBlood.SelectedItem == null)
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {

                Con.Open();
                string query = "insert into PatientTable values(" + TB_PatientID.Text + "," +
                                                               "'" + TB_PatientName.Text + "'," +
                                                               "'" + TB_PatientAdress.Text + "'," +
                                                               "'" + TB_PatientPhone.Text + "',"+
                                                               "" + TB_PatientAge.Text + ","+
                                                               "'" + CBGender.SelectedItem.ToString() + "',"+
                                                               "'" + CBBlood.SelectedItem.ToString() + "'," +
                                                               "'" + TB_PatientDisease.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Sucessfully Added");
                Con.Close();
                Populate();



            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTable set PatName =  '" + TB_PatientName.Text + "'" +
                                                             ",PatAddress= '" + TB_PatientAdress.Text + "' " +
                                                             ",PatPhone='" + TB_PatientPhone.Text + "'" +
                                                             ",PatAge='" + TB_PatientAge.Text + "'" +
                                                             ",PatGender='" + CBGender.SelectedItem.ToString() + "'" +
                                                             ",PatBlood='" + CBBlood.SelectedItem.ToString() + "'" +
                                                             ",PatDisease='" + TB_PatientDisease.Text + "'" +
                                                             "where PatID=" + TB_PatientID.Text + "";


            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Successfully updated");
            Con.Close();
            Populate();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TB_PatientID.Text == "" || TB_PatientID.Text == "請輸入病患編號")
            {
                MessageBox.Show("Enter The Doctor ID");
            }
            else
            {
                Con.Open();
                string query = "delete from PatientTable where PatID=" + TB_PatientID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                Con.Close();

                Populate();

            }
        }

        private void DGVPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_PatientID.Text = DGVPatient.SelectedRows[0].Cells[0].Value.ToString();
            TB_PatientName.Text = DGVPatient.SelectedRows[0].Cells[1].Value.ToString();
            TB_PatientAdress.Text = DGVPatient.SelectedRows[0].Cells[2].Value.ToString();
            TB_PatientPhone.Text = DGVPatient.SelectedRows[0].Cells[3].Value.ToString();
            TB_PatientAge.Text = DGVPatient.SelectedRows[0].Cells[4].Value.ToString();
            CBGender.SelectedItem= DGVPatient.SelectedRows[0].Cells[5].Value.ToString();
            CBBlood.SelectedItem = DGVPatient.SelectedRows[0].Cells[6].Value.ToString();
            TB_PatientDisease.Text = DGVPatient.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void PBLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
