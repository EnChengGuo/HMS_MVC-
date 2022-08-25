
namespace HospitalManagementSystemMVC
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBLeave = new System.Windows.Forms.PictureBox();
            this.LBDoctor = new System.Windows.Forms.Label();
            this.LBHMS = new System.Windows.Forms.Label();
            this.TB_DoctorID = new System.Windows.Forms.TextBox();
            this.TB_DoctorName = new System.Windows.Forms.TextBox();
            this.TB_DoctorAge = new System.Windows.Forms.TextBox();
            this.TB_DoctorPassword = new System.Windows.Forms.TextBox();
            this.DGVDoctor = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.LBDoctorList = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.PBLeave);
            this.panel1.Controls.Add(this.LBDoctor);
            this.panel1.Controls.Add(this.LBHMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 100);
            this.panel1.TabIndex = 0;
            // 
            // PBLeave
            // 
            this.PBLeave.Image = ((System.Drawing.Image)(resources.GetObject("PBLeave.Image")));
            this.PBLeave.Location = new System.Drawing.Point(555, 3);
            this.PBLeave.Name = "PBLeave";
            this.PBLeave.Size = new System.Drawing.Size(44, 43);
            this.PBLeave.TabIndex = 10;
            this.PBLeave.TabStop = false;
            this.PBLeave.Click += new System.EventHandler(this.PBLeave_Click);
            // 
            // LBDoctor
            // 
            this.LBDoctor.AutoSize = true;
            this.LBDoctor.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBDoctor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBDoctor.Location = new System.Drawing.Point(257, 51);
            this.LBDoctor.Name = "LBDoctor";
            this.LBDoctor.Size = new System.Drawing.Size(95, 37);
            this.LBDoctor.TabIndex = 2;
            this.LBDoctor.Text = "醫生";
            // 
            // LBHMS
            // 
            this.LBHMS.AutoSize = true;
            this.LBHMS.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBHMS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBHMS.Location = new System.Drawing.Point(180, 3);
            this.LBHMS.Name = "LBHMS";
            this.LBHMS.Size = new System.Drawing.Size(251, 37);
            this.LBHMS.TabIndex = 1;
            this.LBHMS.Text = "醫院管理系統";
            // 
            // TB_DoctorID
            // 
            this.TB_DoctorID.Location = new System.Drawing.Point(12, 197);
            this.TB_DoctorID.Name = "TB_DoctorID";
            this.TB_DoctorID.Size = new System.Drawing.Size(112, 23);
            this.TB_DoctorID.TabIndex = 1;
            this.TB_DoctorID.Text = "請輸入醫師編號";
            this.TB_DoctorID.Enter += new System.EventHandler(this.TB_DoctorID_Enter);
            this.TB_DoctorID.Leave += new System.EventHandler(this.TB_DoctorID_Leave);
            // 
            // TB_DoctorName
            // 
            this.TB_DoctorName.Location = new System.Drawing.Point(12, 248);
            this.TB_DoctorName.Name = "TB_DoctorName";
            this.TB_DoctorName.Size = new System.Drawing.Size(112, 23);
            this.TB_DoctorName.TabIndex = 2;
            this.TB_DoctorName.Text = "請輸入醫師姓名";
            this.TB_DoctorName.Enter += new System.EventHandler(this.TBDocName_Enter);
            this.TB_DoctorName.Leave += new System.EventHandler(this.TBDocName_Leave);
            // 
            // TB_DoctorAge
            // 
            this.TB_DoctorAge.Location = new System.Drawing.Point(12, 299);
            this.TB_DoctorAge.Name = "TB_DoctorAge";
            this.TB_DoctorAge.Size = new System.Drawing.Size(112, 23);
            this.TB_DoctorAge.TabIndex = 3;
            this.TB_DoctorAge.Text = "請輸入醫齡";
            this.TB_DoctorAge.Enter += new System.EventHandler(this.TBDocAge_Enter);
            this.TB_DoctorAge.Leave += new System.EventHandler(this.TBDocAge_Leave);
            // 
            // TB_DoctorPassword
            // 
            this.TB_DoctorPassword.Location = new System.Drawing.Point(12, 348);
            this.TB_DoctorPassword.Name = "TB_DoctorPassword";
            this.TB_DoctorPassword.Size = new System.Drawing.Size(112, 23);
            this.TB_DoctorPassword.TabIndex = 4;
            this.TB_DoctorPassword.Text = "請輸入密碼";
            this.TB_DoctorPassword.Enter += new System.EventHandler(this.TBDocPassword_Enter);
            this.TB_DoctorPassword.Leave += new System.EventHandler(this.TBDocPassword_Leave);
            // 
            // DGVDoctor
            // 
            this.DGVDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDoctor.Location = new System.Drawing.Point(130, 170);
            this.DGVDoctor.Name = "DGVDoctor";
            this.DGVDoctor.RowTemplate.Height = 25;
            this.DGVDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDoctor.Size = new System.Drawing.Size(361, 360);
            this.DGVDoctor.TabIndex = 5;
            this.DGVDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDoctor_CellContentClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Purple;
            this.BtnAdd.Location = new System.Drawing.Point(513, 170);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 37);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "新增";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Purple;
            this.BtnUpdate.Location = new System.Drawing.Point(513, 232);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 37);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "更新";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Purple;
            this.BtnDelete.Location = new System.Drawing.Point(513, 290);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 37);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "移除";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Purple;
            this.BtnHome.Location = new System.Drawing.Point(513, 356);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 37);
            this.BtnHome.TabIndex = 9;
            this.BtnHome.Text = "返回";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // LBDoctorList
            // 
            this.LBDoctorList.AutoSize = true;
            this.LBDoctorList.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBDoctorList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBDoctorList.Location = new System.Drawing.Point(224, 119);
            this.LBDoctorList.Name = "LBDoctorList";
            this.LBDoctorList.Size = new System.Drawing.Size(173, 37);
            this.LBDoctorList.TabIndex = 3;
            this.LBDoctorList.Text = "醫生名單";
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 562);
            this.Controls.Add(this.LBDoctorList);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DGVDoctor);
            this.Controls.Add(this.TB_DoctorPassword);
            this.Controls.Add(this.TB_DoctorAge);
            this.Controls.Add(this.TB_DoctorName);
            this.Controls.Add(this.TB_DoctorID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBDoctor;
        private System.Windows.Forms.Label LBHMS;
        private System.Windows.Forms.TextBox TB_DoctorID;
        private System.Windows.Forms.TextBox TB_DoctorName;
        private System.Windows.Forms.TextBox TB_DoctorAge;
        private System.Windows.Forms.TextBox TB_DoctorPassword;
        private System.Windows.Forms.DataGridView DGVDoctor;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Label LBDoctorList;
        private System.Windows.Forms.PictureBox PBLeave;
    }
}