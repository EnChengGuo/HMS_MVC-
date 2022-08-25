
namespace HospitalManagementSystemMVC
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLongin = new System.Windows.Forms.Button();
            this.TB_DocName = new System.Windows.Forms.TextBox();
            this.TB_DoctorPassword = new System.Windows.Forms.TextBox();
            this.LB_Clear = new System.Windows.Forms.Label();
            this.PBLeave = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.PBLeave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "HMS";
            // 
            // BtnLongin
            // 
            this.BtnLongin.BackColor = System.Drawing.Color.Purple;
            this.BtnLongin.FlatAppearance.BorderSize = 0;
            this.BtnLongin.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLongin.ForeColor = System.Drawing.Color.White;
            this.BtnLongin.Location = new System.Drawing.Point(25, 308);
            this.BtnLongin.Name = "BtnLongin";
            this.BtnLongin.Size = new System.Drawing.Size(270, 55);
            this.BtnLongin.TabIndex = 1;
            this.BtnLongin.Text = "Login";
            this.BtnLongin.UseVisualStyleBackColor = false;
            this.BtnLongin.Click += new System.EventHandler(this.BtnLongin_Click);
            // 
            // TB_DocName
            // 
            this.TB_DocName.ForeColor = System.Drawing.Color.Purple;
            this.TB_DocName.Location = new System.Drawing.Point(36, 157);
            this.TB_DocName.Name = "TB_DocName";
            this.TB_DocName.Size = new System.Drawing.Size(245, 23);
            this.TB_DocName.TabIndex = 2;
            this.TB_DocName.Text = "請輸入醫師名稱";
            this.TB_DocName.Enter += new System.EventHandler(this.TB_DocName_Enter);
            this.TB_DocName.Leave += new System.EventHandler(this.TB_DocName_Leave);
            // 
            // TB_DoctorPassword
            // 
            this.TB_DoctorPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TB_DoctorPassword.ForeColor = System.Drawing.Color.Purple;
            this.TB_DoctorPassword.Location = new System.Drawing.Point(36, 230);
            this.TB_DoctorPassword.Name = "TB_DoctorPassword";
            this.TB_DoctorPassword.Size = new System.Drawing.Size(245, 23);
            this.TB_DoctorPassword.TabIndex = 3;
            this.TB_DoctorPassword.Text = "請輸入密碼";
            this.TB_DoctorPassword.Enter += new System.EventHandler(this.TB_DoctorPassword_Enter);
            this.TB_DoctorPassword.Leave += new System.EventHandler(this.TB_DoctorPassword_Leave);
            // 
            // LB_Clear
            // 
            this.LB_Clear.AutoSize = true;
            this.LB_Clear.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_Clear.ForeColor = System.Drawing.Color.Purple;
            this.LB_Clear.Location = new System.Drawing.Point(123, 381);
            this.LB_Clear.Name = "LB_Clear";
            this.LB_Clear.Size = new System.Drawing.Size(72, 37);
            this.LB_Clear.TabIndex = 2;
            this.LB_Clear.Text = "Clear";
            this.LB_Clear.Click += new System.EventHandler(this.LB_Leave_Click);
            // 
            // PBLeave
            // 
            this.PBLeave.Image = ((System.Drawing.Image)(resources.GetObject("PBLeave.Image")));
            this.PBLeave.Location = new System.Drawing.Point(271, 0);
            this.PBLeave.Name = "PBLeave";
            this.PBLeave.Size = new System.Drawing.Size(44, 43);
            this.PBLeave.TabIndex = 4;
            this.PBLeave.TabStop = false;
            this.PBLeave.Click += new System.EventHandler(this.PBLeave_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 446);
            this.Controls.Add(this.LB_Clear);
            this.Controls.Add(this.TB_DoctorPassword);
            this.Controls.Add(this.TB_DocName);
            this.Controls.Add(this.BtnLongin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLongin;
        private System.Windows.Forms.TextBox TB_DocName;
        private System.Windows.Forms.TextBox TB_DoctorPassword;
        private System.Windows.Forms.Label LB_Clear;
        private System.Windows.Forms.PictureBox PBLeave;
    }
}

