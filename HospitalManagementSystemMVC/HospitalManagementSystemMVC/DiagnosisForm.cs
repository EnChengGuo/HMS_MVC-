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
    public partial class DiagnosisForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\88697\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public DiagnosisForm()
        {
            InitializeComponent();
        }

        void PopulateCombo()
        {
            string sql = "select * from PatientTable";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;

            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatID", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CBPatienID.ValueMember = "PatID";
                CBPatienID.DataSource = dt;
                Con.Close();
            }
            catch 
            {

            }
        }
        void Populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVDiagnosis.DataSource = ds.Tables[0];
            Con.Close();
        }

        string patname;
        void FetchPatientName()
        {
            Con.Open();
            string mysql = "select * from PatientTable where PatID ="+CBPatienID.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(mysql,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                TBPatientName.Text = patname;
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

            if (TB_DiagnosisID.Text == "請輸入診斷書編號" ||
                CBPatienID.SelectedItem.ToString() == "病患ID" ||
                TBPatientName.Text == "病患姓名" ||
                TBSymptons.Text == "症狀" ||
                TBDiagnosis.Text == "診斷" ||
                TBMedicines.Text == "藥方" )
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {

                Con.Open();
                string query = "insert into DiagnosisTable values(" + TB_DiagnosisID.Text + "," +
                                                               "" + CBPatienID.SelectedValue.ToString() + "," +
                                                               "'" + TBPatientName.Text + "'," +
                                                               "'" + TBSymptons.Text + "'," +
                                                               "'" + TBDiagnosis.Text + "'," +
                                                               "'" + TBMedicines.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Sucessfully Added");
                Con.Close();
                Populate();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DiagnosisTable set PatID = " + CBPatienID.SelectedValue.ToString() + " " +
                                                             ",PatName= '" + TBPatientName.Text + "' " +
                                                             ",Symptoms='" + TBSymptons.Text + "'" +
                                                             ",Diagnosis='" + TBDiagnosis.Text + "'" +
                                                             ",Medicines='" + TBMedicines.Text + "'" +
                                                             "where DiagID=" + TB_DiagnosisID.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Successfully updated");
            Con.Close();
            Populate();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TB_DiagnosisID.Text == "" || TB_DiagnosisID.Text == "請輸入診斷書編號")
            {
                MessageBox.Show("Enter The Diagonis ID");
            }
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTable where DiagID=" + TB_DiagnosisID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted");
                Con.Close();

                Populate();

            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            PopulateCombo();
            Populate();
        }

        private void CBPatienID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchPatientName();
        }

        private void DGVDiagnosis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_DiagnosisID.Text = DGVDiagnosis.SelectedRows[0].Cells[0].Value.ToString();
            CBPatienID.SelectedItem = DGVDiagnosis.SelectedRows[0].Cells[1].Value.ToString();
            TBPatientName.Text = DGVDiagnosis.SelectedRows[0].Cells[2].Value.ToString();
            TBSymptons.Text = DGVDiagnosis.SelectedRows[0].Cells[3].Value.ToString();
            TBDiagnosis.Text = DGVDiagnosis.SelectedRows[0].Cells[4].Value.ToString();
            TBMedicines.Text = DGVDiagnosis.SelectedRows[0].Cells[5].Value.ToString();

            LBPatientName.Text = DGVDiagnosis.SelectedRows[0].Cells[2].Value.ToString();
            LBDiagnosis.Text = DGVDiagnosis.SelectedRows[0].Cells[4].Value.ToString();
            LBSymptoms.Text = DGVDiagnosis.SelectedRows[0].Cells[3].Value.ToString();
            LBMedicines.Text = DGVDiagnosis.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(LBDiagnosisResult.Text +
                                  "\n\n\n\n\n\n\n\n\n",
                                  new Font("Century Gothic",25,FontStyle.Bold),
                                  Brushes.Black,
                                  new Point(230));

            e.Graphics.DrawString(LBPatientName.Text +"\n"+
                                  LBDiagnosis.Text + "\n"+
                                  LBSymptoms.Text + "\n" +
                                  LBMedicines.Text + "\n" ,
                                  new Font("Century Gothic", 12, FontStyle.Regular),
                                  Brushes.Black,
                                  new Point(230,150));

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            
            }
        }

        private void PBLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
