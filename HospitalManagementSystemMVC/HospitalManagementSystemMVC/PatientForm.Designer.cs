
namespace HospitalManagementSystemMVC
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBLeave = new System.Windows.Forms.PictureBox();
            this.TB_PatientPhone = new System.Windows.Forms.TextBox();
            this.TB_PatientAdress = new System.Windows.Forms.TextBox();
            this.TB_PatientName = new System.Windows.Forms.TextBox();
            this.TB_PatientID = new System.Windows.Forms.TextBox();
            this.TB_PatientAge = new System.Windows.Forms.TextBox();
            this.CBGender = new System.Windows.Forms.ComboBox();
            this.CBBlood = new System.Windows.Forms.ComboBox();
            this.TB_PatientDisease = new System.Windows.Forms.TextBox();
            this.DGVPatient = new System.Windows.Forms.DataGridView();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(247, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "病患";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(169, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "醫院管理系統";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.PBLeave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 100);
            this.panel1.TabIndex = 1;
            // 
            // PBLeave
            // 
            this.PBLeave.Image = ((System.Drawing.Image)(resources.GetObject("PBLeave.Image")));
            this.PBLeave.Location = new System.Drawing.Point(568, 3);
            this.PBLeave.Name = "PBLeave";
            this.PBLeave.Size = new System.Drawing.Size(44, 43);
            this.PBLeave.TabIndex = 4;
            this.PBLeave.TabStop = false;
            this.PBLeave.Click += new System.EventHandler(this.PBLeave_Click);
            // 
            // TB_PatientPhone
            // 
            this.TB_PatientPhone.Location = new System.Drawing.Point(12, 308);
            this.TB_PatientPhone.Name = "TB_PatientPhone";
            this.TB_PatientPhone.Size = new System.Drawing.Size(112, 23);
            this.TB_PatientPhone.TabIndex = 8;
            this.TB_PatientPhone.Text = "請輸入病患手機";
            this.TB_PatientPhone.Enter += new System.EventHandler(this.TB_PatientPhone_Enter);
            this.TB_PatientPhone.Leave += new System.EventHandler(this.TB_PatientPhone_Leave);
            // 
            // TB_PatientAdress
            // 
            this.TB_PatientAdress.Location = new System.Drawing.Point(12, 259);
            this.TB_PatientAdress.Name = "TB_PatientAdress";
            this.TB_PatientAdress.Size = new System.Drawing.Size(112, 23);
            this.TB_PatientAdress.TabIndex = 7;
            this.TB_PatientAdress.Text = "請輸入病患地址";
            this.TB_PatientAdress.Enter += new System.EventHandler(this.TB_PatientAdress_Enter);
            this.TB_PatientAdress.Leave += new System.EventHandler(this.TB_PatientAdress_Leave);
            // 
            // TB_PatientName
            // 
            this.TB_PatientName.Location = new System.Drawing.Point(12, 208);
            this.TB_PatientName.Name = "TB_PatientName";
            this.TB_PatientName.Size = new System.Drawing.Size(112, 23);
            this.TB_PatientName.TabIndex = 6;
            this.TB_PatientName.Text = "請輸入病患姓名";
            this.TB_PatientName.Enter += new System.EventHandler(this.TB_PatientName_Enter);
            this.TB_PatientName.Leave += new System.EventHandler(this.TB_PatientName_Leave);
            // 
            // TB_PatientID
            // 
            this.TB_PatientID.Location = new System.Drawing.Point(12, 157);
            this.TB_PatientID.Name = "TB_PatientID";
            this.TB_PatientID.Size = new System.Drawing.Size(112, 23);
            this.TB_PatientID.TabIndex = 5;
            this.TB_PatientID.Text = "請輸入病患編號";
            this.TB_PatientID.Enter += new System.EventHandler(this.TB_PaientID_Enter);
            this.TB_PatientID.Leave += new System.EventHandler(this.TB_PaientID_Leave);
            // 
            // TB_PatientAge
            // 
            this.TB_PatientAge.Location = new System.Drawing.Point(12, 353);
            this.TB_PatientAge.Name = "TB_PatientAge";
            this.TB_PatientAge.Size = new System.Drawing.Size(112, 23);
            this.TB_PatientAge.TabIndex = 9;
            this.TB_PatientAge.Text = "請輸入病患年齡";
            this.TB_PatientAge.Enter += new System.EventHandler(this.TB_PatientAge_Enter);
            this.TB_PatientAge.Leave += new System.EventHandler(this.TB_PatientAge_Leave);
            // 
            // CBGender
            // 
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "Boy",
            "Girl"});
            this.CBGender.Location = new System.Drawing.Point(12, 399);
            this.CBGender.Name = "CBGender";
            this.CBGender.Size = new System.Drawing.Size(112, 23);
            this.CBGender.TabIndex = 10;
            this.CBGender.Text = "性別";
            // 
            // CBBlood
            // 
            this.CBBlood.FormattingEnabled = true;
            this.CBBlood.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.CBBlood.Location = new System.Drawing.Point(12, 446);
            this.CBBlood.Name = "CBBlood";
            this.CBBlood.Size = new System.Drawing.Size(112, 23);
            this.CBBlood.TabIndex = 11;
            this.CBBlood.Text = "血型";
            // 
            // TB_PatientDisease
            // 
            this.TB_PatientDisease.Location = new System.Drawing.Point(12, 492);
            this.TB_PatientDisease.Name = "TB_PatientDisease";
            this.TB_PatientDisease.Size = new System.Drawing.Size(112, 23);
            this.TB_PatientDisease.TabIndex = 12;
            this.TB_PatientDisease.Text = "請輸入病名";
            this.TB_PatientDisease.Enter += new System.EventHandler(this.TB_PatientDisease_Enter);
            this.TB_PatientDisease.Leave += new System.EventHandler(this.TB_PatientDisease_Leave);
            // 
            // DGVPatient
            // 
            this.DGVPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatient.Location = new System.Drawing.Point(154, 157);
            this.DGVPatient.Name = "DGVPatient";
            this.DGVPatient.RowTemplate.Height = 25;
            this.DGVPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPatient.Size = new System.Drawing.Size(361, 360);
            this.DGVPatient.TabIndex = 13;
            this.DGVPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPatient_CellContentClick);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Purple;
            this.BtnHome.Location = new System.Drawing.Point(521, 338);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 37);
            this.BtnHome.TabIndex = 17;
            this.BtnHome.Text = "返回";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Purple;
            this.BtnDelete.Location = new System.Drawing.Point(521, 277);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 37);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "移除";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Purple;
            this.BtnUpdate.Location = new System.Drawing.Point(521, 215);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 37);
            this.BtnUpdate.TabIndex = 15;
            this.BtnUpdate.Text = "更新";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Purple;
            this.BtnAdd.Location = new System.Drawing.Point(521, 157);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 37);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "新增";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(247, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "病患清單";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DGVPatient);
            this.Controls.Add(this.TB_PatientDisease);
            this.Controls.Add(this.CBBlood);
            this.Controls.Add(this.CBGender);
            this.Controls.Add(this.TB_PatientAge);
            this.Controls.Add(this.TB_PatientPhone);
            this.Controls.Add(this.TB_PatientAdress);
            this.Controls.Add(this.TB_PatientName);
            this.Controls.Add(this.TB_PatientID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_PatientPhone;
        private System.Windows.Forms.TextBox TB_PatientAdress;
        private System.Windows.Forms.TextBox TB_PatientName;
        private System.Windows.Forms.TextBox TB_PatientID;
        private System.Windows.Forms.TextBox TB_PatientAge;
        private System.Windows.Forms.ComboBox CBGender;
        private System.Windows.Forms.ComboBox CBBlood;
        private System.Windows.Forms.TextBox TB_PatientDisease;
        private System.Windows.Forms.DataGridView DGVPatient;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PBLeave;
    }
}