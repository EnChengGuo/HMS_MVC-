using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystemMVC
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int starpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starpoint += 5;
            progressBar1.Value = starpoint;

            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                LoginForm _loginForm = new LoginForm();
                _loginForm.Show();
                this.Hide();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();    
        }
    }
}
