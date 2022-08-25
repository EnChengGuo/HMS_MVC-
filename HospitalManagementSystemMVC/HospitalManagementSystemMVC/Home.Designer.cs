
namespace HospitalManagementSystemMVC
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.PB_Doctor = new System.Windows.Forms.PictureBox();
            this.LBDoctor = new System.Windows.Forms.Label();
            this.LBPatient = new System.Windows.Forms.Label();
            this.PB_Patient = new System.Windows.Forms.PictureBox();
            this.LBDignosis = new System.Windows.Forms.Label();
            this.PB_Diagnosis = new System.Windows.Forms.PictureBox();
            this.PB_Logout = new System.Windows.Forms.PictureBox();
            this.PBLeave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Doctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Diagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "醫院管理系統";
            // 
            // PB_Doctor
            // 
            this.PB_Doctor.Image = ((System.Drawing.Image)(resources.GetObject("PB_Doctor.Image")));
            this.PB_Doctor.Location = new System.Drawing.Point(23, 171);
            this.PB_Doctor.Name = "PB_Doctor";
            this.PB_Doctor.Size = new System.Drawing.Size(100, 102);
            this.PB_Doctor.TabIndex = 1;
            this.PB_Doctor.TabStop = false;
            this.PB_Doctor.Click += new System.EventHandler(this.PB_Doctor_Click);
            // 
            // LBDoctor
            // 
            this.LBDoctor.AutoSize = true;
            this.LBDoctor.Font = new System.Drawing.Font("華康雅風體W3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBDoctor.Location = new System.Drawing.Point(40, 137);
            this.LBDoctor.Name = "LBDoctor";
            this.LBDoctor.Size = new System.Drawing.Size(73, 29);
            this.LBDoctor.TabIndex = 4;
            this.LBDoctor.Text = "醫生";
            // 
            // LBPatient
            // 
            this.LBPatient.AutoSize = true;
            this.LBPatient.Font = new System.Drawing.Font("華康雅風體W3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBPatient.Location = new System.Drawing.Point(430, 137);
            this.LBPatient.Name = "LBPatient";
            this.LBPatient.Size = new System.Drawing.Size(73, 29);
            this.LBPatient.TabIndex = 6;
            this.LBPatient.Text = "病患";
            // 
            // PB_Patient
            // 
            this.PB_Patient.Image = ((System.Drawing.Image)(resources.GetObject("PB_Patient.Image")));
            this.PB_Patient.Location = new System.Drawing.Point(415, 171);
            this.PB_Patient.Name = "PB_Patient";
            this.PB_Patient.Size = new System.Drawing.Size(100, 102);
            this.PB_Patient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Patient.TabIndex = 5;
            this.PB_Patient.TabStop = false;
            this.PB_Patient.Click += new System.EventHandler(this.PB_Patient_Click);
            // 
            // LBDignosis
            // 
            this.LBDignosis.AutoSize = true;
            this.LBDignosis.Font = new System.Drawing.Font("華康雅風體W3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBDignosis.Location = new System.Drawing.Point(229, 128);
            this.LBDignosis.Name = "LBDignosis";
            this.LBDignosis.Size = new System.Drawing.Size(103, 29);
            this.LBDignosis.TabIndex = 8;
            this.LBDignosis.Text = "診斷書";
            // 
            // PB_Diagnosis
            // 
            this.PB_Diagnosis.Image = ((System.Drawing.Image)(resources.GetObject("PB_Diagnosis.Image")));
            this.PB_Diagnosis.Location = new System.Drawing.Point(232, 171);
            this.PB_Diagnosis.Name = "PB_Diagnosis";
            this.PB_Diagnosis.Size = new System.Drawing.Size(100, 102);
            this.PB_Diagnosis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Diagnosis.TabIndex = 7;
            this.PB_Diagnosis.TabStop = false;
            this.PB_Diagnosis.Click += new System.EventHandler(this.PB_Diagnosis_Click);
            // 
            // PB_Logout
            // 
            this.PB_Logout.Image = ((System.Drawing.Image)(resources.GetObject("PB_Logout.Image")));
            this.PB_Logout.Location = new System.Drawing.Point(264, 300);
            this.PB_Logout.Name = "PB_Logout";
            this.PB_Logout.Size = new System.Drawing.Size(31, 33);
            this.PB_Logout.TabIndex = 9;
            this.PB_Logout.TabStop = false;
            this.PB_Logout.Click += new System.EventHandler(this.PB_Logout_Click);
            // 
            // PBLeave
            // 
            this.PBLeave.Image = ((System.Drawing.Image)(resources.GetObject("PBLeave.Image")));
            this.PBLeave.Location = new System.Drawing.Point(529, 2);
            this.PBLeave.Name = "PBLeave";
            this.PBLeave.Size = new System.Drawing.Size(44, 43);
            this.PBLeave.TabIndex = 10;
            this.PBLeave.TabStop = false;
            this.PBLeave.Click += new System.EventHandler(this.PBLeave_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(579, 360);
            this.Controls.Add(this.PBLeave);
            this.Controls.Add(this.PB_Logout);
            this.Controls.Add(this.LBDignosis);
            this.Controls.Add(this.PB_Diagnosis);
            this.Controls.Add(this.LBPatient);
            this.Controls.Add(this.PB_Patient);
            this.Controls.Add(this.LBDoctor);
            this.Controls.Add(this.PB_Doctor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Doctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Diagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_Doctor;
        private System.Windows.Forms.Label LBDoctor;
        private System.Windows.Forms.Label LBPatient;
        private System.Windows.Forms.PictureBox PB_Patient;
        private System.Windows.Forms.Label LBDignosis;
        private System.Windows.Forms.PictureBox PB_Diagnosis;
        private System.Windows.Forms.PictureBox PB_Logout;
        private System.Windows.Forms.PictureBox PBLeave;
    }
}