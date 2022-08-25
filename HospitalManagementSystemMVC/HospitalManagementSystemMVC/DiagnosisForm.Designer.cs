
namespace HospitalManagementSystemMVC
{
    partial class DiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBLeave = new System.Windows.Forms.PictureBox();
            this.TB_DiagnosisID = new System.Windows.Forms.TextBox();
            this.CBPatienID = new System.Windows.Forms.ComboBox();
            this.TBPatientName = new System.Windows.Forms.TextBox();
            this.TBSymptons = new System.Windows.Forms.TextBox();
            this.TBDiagnosis = new System.Windows.Forms.TextBox();
            this.TBMedicines = new System.Windows.Forms.TextBox();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVDiagnosis = new System.Windows.Forms.DataGridView();
            this.PaDiagnosis = new System.Windows.Forms.Panel();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.LBMedicines = new System.Windows.Forms.Label();
            this.LBSymptoms = new System.Windows.Forms.Label();
            this.LBDiagnosis = new System.Windows.Forms.Label();
            this.LBPatientName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBDiagnosisResult = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnosis)).BeginInit();
            this.PaDiagnosis.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(119, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "診斷書";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(57, 9);
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
            this.panel1.Size = new System.Drawing.Size(388, 100);
            this.panel1.TabIndex = 2;
            // 
            // PBLeave
            // 
            this.PBLeave.Image = ((System.Drawing.Image)(resources.GetObject("PBLeave.Image")));
            this.PBLeave.Location = new System.Drawing.Point(340, 3);
            this.PBLeave.Name = "PBLeave";
            this.PBLeave.Size = new System.Drawing.Size(44, 43);
            this.PBLeave.TabIndex = 3;
            this.PBLeave.TabStop = false;
            this.PBLeave.Click += new System.EventHandler(this.PBLeave_Click);
            // 
            // TB_DiagnosisID
            // 
            this.TB_DiagnosisID.Location = new System.Drawing.Point(28, 120);
            this.TB_DiagnosisID.Name = "TB_DiagnosisID";
            this.TB_DiagnosisID.Size = new System.Drawing.Size(112, 23);
            this.TB_DiagnosisID.TabIndex = 6;
            this.TB_DiagnosisID.Text = "請輸入診斷書編號";
            // 
            // CBPatienID
            // 
            this.CBPatienID.FormattingEnabled = true;
            this.CBPatienID.Items.AddRange(new object[] {
            "男",
            "女"});
            this.CBPatienID.Location = new System.Drawing.Point(28, 174);
            this.CBPatienID.Name = "CBPatienID";
            this.CBPatienID.Size = new System.Drawing.Size(112, 23);
            this.CBPatienID.TabIndex = 11;
            this.CBPatienID.Text = "病患ID";
            this.CBPatienID.SelectionChangeCommitted += new System.EventHandler(this.CBPatienID_SelectionChangeCommitted);
            // 
            // TBPatientName
            // 
            this.TBPatientName.Location = new System.Drawing.Point(28, 223);
            this.TBPatientName.Name = "TBPatientName";
            this.TBPatientName.Size = new System.Drawing.Size(112, 23);
            this.TBPatientName.TabIndex = 12;
            this.TBPatientName.Text = "病患姓名";
            // 
            // TBSymptons
            // 
            this.TBSymptons.Location = new System.Drawing.Point(28, 273);
            this.TBSymptons.Name = "TBSymptons";
            this.TBSymptons.Size = new System.Drawing.Size(112, 23);
            this.TBSymptons.TabIndex = 13;
            this.TBSymptons.Text = "症狀";
            // 
            // TBDiagnosis
            // 
            this.TBDiagnosis.Location = new System.Drawing.Point(28, 327);
            this.TBDiagnosis.Name = "TBDiagnosis";
            this.TBDiagnosis.Size = new System.Drawing.Size(112, 23);
            this.TBDiagnosis.TabIndex = 14;
            this.TBDiagnosis.Text = "診斷";
            // 
            // TBMedicines
            // 
            this.TBMedicines.Location = new System.Drawing.Point(28, 376);
            this.TBMedicines.Name = "TBMedicines";
            this.TBMedicines.Size = new System.Drawing.Size(112, 23);
            this.TBMedicines.TabIndex = 15;
            this.TBMedicines.Text = "藥方";
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Purple;
            this.BtnHome.Location = new System.Drawing.Point(146, 362);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 37);
            this.BtnHome.TabIndex = 19;
            this.BtnHome.Text = "返回";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Purple;
            this.BtnDelete.Location = new System.Drawing.Point(146, 293);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 37);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "移除";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Purple;
            this.BtnUpdate.Location = new System.Drawing.Point(146, 197);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 37);
            this.BtnUpdate.TabIndex = 17;
            this.BtnUpdate.Text = "更新";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Purple;
            this.BtnAdd.Location = new System.Drawing.Point(146, 120);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 37);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "新增";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(109, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "診斷清單";
            // 
            // DGVDiagnosis
            // 
            this.DGVDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDiagnosis.Location = new System.Drawing.Point(28, 476);
            this.DGVDiagnosis.Name = "DGVDiagnosis";
            this.DGVDiagnosis.RowTemplate.Height = 25;
            this.DGVDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDiagnosis.Size = new System.Drawing.Size(342, 189);
            this.DGVDiagnosis.TabIndex = 21;
            this.DGVDiagnosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDiagnosis_CellContentClick);
            // 
            // PaDiagnosis
            // 
            this.PaDiagnosis.Controls.Add(this.BtnPrint);
            this.PaDiagnosis.Controls.Add(this.LBMedicines);
            this.PaDiagnosis.Controls.Add(this.LBSymptoms);
            this.PaDiagnosis.Controls.Add(this.LBDiagnosis);
            this.PaDiagnosis.Controls.Add(this.LBPatientName);
            this.PaDiagnosis.Controls.Add(this.label5);
            this.PaDiagnosis.Controls.Add(this.LBDiagnosisResult);
            this.PaDiagnosis.Location = new System.Drawing.Point(227, 111);
            this.PaDiagnosis.Name = "PaDiagnosis";
            this.PaDiagnosis.Size = new System.Drawing.Size(157, 310);
            this.PaDiagnosis.TabIndex = 22;
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Purple;
            this.BtnPrint.Location = new System.Drawing.Point(53, 278);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(48, 29);
            this.BtnPrint.TabIndex = 23;
            this.BtnPrint.Text = "列印";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // LBMedicines
            // 
            this.LBMedicines.AutoSize = true;
            this.LBMedicines.Font = new System.Drawing.Font("華康雅風體W3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBMedicines.ForeColor = System.Drawing.Color.Purple;
            this.LBMedicines.Location = new System.Drawing.Point(53, 247);
            this.LBMedicines.Name = "LBMedicines";
            this.LBMedicines.Size = new System.Drawing.Size(51, 19);
            this.LBMedicines.TabIndex = 8;
            this.LBMedicines.Text = "藥方";
            // 
            // LBSymptoms
            // 
            this.LBSymptoms.AutoSize = true;
            this.LBSymptoms.Font = new System.Drawing.Font("華康雅風體W3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBSymptoms.ForeColor = System.Drawing.Color.Purple;
            this.LBSymptoms.Location = new System.Drawing.Point(53, 190);
            this.LBSymptoms.Name = "LBSymptoms";
            this.LBSymptoms.Size = new System.Drawing.Size(51, 19);
            this.LBSymptoms.TabIndex = 7;
            this.LBSymptoms.Text = "診斷";
            // 
            // LBDiagnosis
            // 
            this.LBDiagnosis.AutoSize = true;
            this.LBDiagnosis.Font = new System.Drawing.Font("華康雅風體W3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBDiagnosis.ForeColor = System.Drawing.Color.Purple;
            this.LBDiagnosis.Location = new System.Drawing.Point(53, 128);
            this.LBDiagnosis.Name = "LBDiagnosis";
            this.LBDiagnosis.Size = new System.Drawing.Size(51, 19);
            this.LBDiagnosis.TabIndex = 6;
            this.LBDiagnosis.Text = "症狀";
            // 
            // LBPatientName
            // 
            this.LBPatientName.AutoSize = true;
            this.LBPatientName.Font = new System.Drawing.Font("華康雅風體W3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBPatientName.ForeColor = System.Drawing.Color.Purple;
            this.LBPatientName.Location = new System.Drawing.Point(50, 69);
            this.LBPatientName.Name = "LBPatientName";
            this.LBPatientName.Size = new System.Drawing.Size(72, 19);
            this.LBPatientName.TabIndex = 5;
            this.LBPatientName.Text = "病患名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("華康雅風體W3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(377, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 4;
            // 
            // LBDiagnosisResult
            // 
            this.LBDiagnosisResult.AutoSize = true;
            this.LBDiagnosisResult.Font = new System.Drawing.Font("華康雅風體W3", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBDiagnosisResult.ForeColor = System.Drawing.Color.Purple;
            this.LBDiagnosisResult.Location = new System.Drawing.Point(17, 9);
            this.LBDiagnosisResult.Name = "LBDiagnosisResult";
            this.LBDiagnosisResult.Size = new System.Drawing.Size(134, 37);
            this.LBDiagnosisResult.TabIndex = 3;
            this.LBDiagnosisResult.Text = "診斷書";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 677);
            this.Controls.Add(this.PaDiagnosis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVDiagnosis);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TBMedicines);
            this.Controls.Add(this.TBDiagnosis);
            this.Controls.Add(this.TBSymptons);
            this.Controls.Add(this.TBPatientName);
            this.Controls.Add(this.CBPatienID);
            this.Controls.Add(this.TB_DiagnosisID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.Text = "diagnosis";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnosis)).EndInit();
            this.PaDiagnosis.ResumeLayout(false);
            this.PaDiagnosis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_DiagnosisID;
        private System.Windows.Forms.ComboBox CBPatienID;
        private System.Windows.Forms.TextBox TBPatientName;
        private System.Windows.Forms.TextBox TBSymptons;
        private System.Windows.Forms.TextBox TBDiagnosis;
        private System.Windows.Forms.TextBox TBMedicines;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVDiagnosis;
        private System.Windows.Forms.Panel PaDiagnosis;
        private System.Windows.Forms.Label LBMedicines;
        private System.Windows.Forms.Label LBSymptoms;
        private System.Windows.Forms.Label LBDiagnosis;
        private System.Windows.Forms.Label LBPatientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBDiagnosisResult;
        private System.Windows.Forms.Button BtnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox PBLeave;
    }
}