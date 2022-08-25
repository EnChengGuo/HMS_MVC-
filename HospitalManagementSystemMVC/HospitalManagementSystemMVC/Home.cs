using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystemMVC
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void PB_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm _longinForm = new LoginForm();
            _longinForm.Show();
        }

        private void PBLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PB_Doctor_Click(object sender, EventArgs e)
        {
            DoctorForm _doctorForm = new DoctorForm();
            _doctorForm.Show();
            this.Hide();

        }

        private void PB_Diagnosis_Click(object sender, EventArgs e)
        {
            DiagnosisForm _diagnosisForm = new DiagnosisForm();
            _diagnosisForm.Show();
            this.Hide();
        }

        private void PB_Patient_Click(object sender, EventArgs e)
        {
            PatientForm _patientForm = new PatientForm();
            _patientForm.Show();
            this.Hide();
        }
    }
}
