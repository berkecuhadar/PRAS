namespace PRAS.App
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
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            txt_pNID = new TextBox();
            label4 = new Label();
            btn_findP = new Button();
            dgv_appointment = new DataGridView();
            tabPage1 = new TabPage();
            btn_pdf = new Button();
            btn_m = new Button();
            txt_pmail = new TextBox();
            btn_diag = new Button();
            btn_lab = new Button();
            btn_cc = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_lab = new RichTextBox();
            txt_diag = new RichTextBox();
            txt_cc = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 422);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txt_pNID);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(btn_findP);
            tabPage3.Controls.Add(dgv_appointment);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(692, 394);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Past Appointments";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_pNID
            // 
            txt_pNID.Location = new Point(296, 52);
            txt_pNID.Name = "txt_pNID";
            txt_pNID.Size = new Size(85, 23);
            txt_pNID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 12);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 3;
            label4.Text = "Patient National ID:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_findP
            // 
            btn_findP.Location = new Point(296, 111);
            btn_findP.Name = "btn_findP";
            btn_findP.Size = new Size(85, 22);
            btn_findP.TabIndex = 2;
            btn_findP.Text = "Find Patient";
            btn_findP.UseVisualStyleBackColor = true;
            btn_findP.Click += btn_findP_Click;
            // 
            // dgv_appointment
            // 
            dgv_appointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_appointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointment.Location = new Point(4, 138);
            dgv_appointment.Name = "dgv_appointment";
            dgv_appointment.RowHeadersWidth = 51;
            dgv_appointment.RowTemplate.Height = 24;
            dgv_appointment.Size = new Size(684, 249);
            dgv_appointment.TabIndex = 0;
            dgv_appointment.RowHeaderMouseDoubleClick += dgv_appointment_RowHeaderMouseDoubleClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_pdf);
            tabPage1.Controls.Add(btn_m);
            tabPage1.Controls.Add(txt_pmail);
            tabPage1.Controls.Add(btn_diag);
            tabPage1.Controls.Add(btn_lab);
            tabPage1.Controls.Add(btn_cc);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txt_lab);
            tabPage1.Controls.Add(txt_diag);
            tabPage1.Controls.Add(txt_cc);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(692, 394);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Chief Complaint";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_pdf
            // 
            btn_pdf.Location = new Point(302, 347);
            btn_pdf.Name = "btn_pdf";
            btn_pdf.Size = new Size(259, 22);
            btn_pdf.TabIndex = 5;
            btn_pdf.Text = "SAVE AS A PDF";
            btn_pdf.UseVisualStyleBackColor = true;
            btn_pdf.Click += btn_exportPdf_Click;
            // 
            // btn_m
            // 
            btn_m.Enabled = false;
            btn_m.Location = new Point(470, 279);
            btn_m.Name = "btn_m";
            btn_m.Size = new Size(91, 22);
            btn_m.TabIndex = 4;
            btn_m.Text = "SEND E-MAIL";
            btn_m.UseVisualStyleBackColor = true;
            btn_m.Click += btn_mail_Click;
            // 
            // txt_pmail
            // 
            txt_pmail.Location = new Point(302, 281);
            txt_pmail.Name = "txt_pmail";
            txt_pmail.Size = new Size(153, 23);
            txt_pmail.TabIndex = 3;
            // 
            // btn_diag
            // 
            btn_diag.Location = new Point(402, 179);
            btn_diag.Name = "btn_diag";
            btn_diag.Size = new Size(66, 22);
            btn_diag.TabIndex = 2;
            btn_diag.Text = "SAVE";
            btn_diag.UseVisualStyleBackColor = true;
            btn_diag.Click += btn_saveDiagnosis_Click;
            // 
            // btn_lab
            // 
            btn_lab.Location = new Point(94, 370);
            btn_lab.Name = "btn_lab";
            btn_lab.Size = new Size(66, 22);
            btn_lab.TabIndex = 2;
            btn_lab.Text = "SAVE";
            btn_lab.UseVisualStyleBackColor = true;
            btn_lab.Click += btn_saveLabResults_Click;
            // 
            // btn_cc
            // 
            btn_cc.Location = new Point(94, 179);
            btn_cc.Name = "btn_cc";
            btn_cc.Size = new Size(66, 22);
            btn_cc.TabIndex = 2;
            btn_cc.Text = "SAVE";
            btn_cc.UseVisualStyleBackColor = true;
            btn_cc.Click += btn_saveChiefComplaint_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(342, 241);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 1;
            label5.Text = "Patient's E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 24);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 1;
            label3.Text = "Doctor's Diagnosis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 220);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Lab Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Chief Complaint";
            // 
            // txt_lab
            // 
            txt_lab.Location = new Point(7, 238);
            txt_lab.Name = "txt_lab";
            txt_lab.Size = new Size(260, 132);
            txt_lab.TabIndex = 0;
            txt_lab.Text = "";
            // 
            // txt_diag
            // 
            txt_diag.Location = new Point(302, 42);
            txt_diag.Name = "txt_diag";
            txt_diag.Size = new Size(260, 132);
            txt_diag.TabIndex = 0;
            txt_diag.Text = "";
            // 
            // txt_cc
            // 
            txt_cc.Location = new Point(7, 42);
            txt_cc.Name = "txt_cc";
            txt_cc.Size = new Size(260, 132);
            txt_cc.TabIndex = 0;
            txt_cc.Text = "";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DoctorForm";
            Text = "PRAS - Doctor Form";
            HelpButtonClicked += DoctorForm_HelpButtonClicked;
            FormClosed += DoctorForm_FormClosed;
            Load += DoctorForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_lab;
        private System.Windows.Forms.RichTextBox txt_diag;
        private System.Windows.Forms.RichTextBox txt_cc;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button btn_m;
        private System.Windows.Forms.TextBox txt_pmail;
        private System.Windows.Forms.Button btn_diag;
        private System.Windows.Forms.Button btn_lab;
        private System.Windows.Forms.Button btn_cc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_pNID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_findP;
        private System.Windows.Forms.DataGridView dgv_appointment;
        private System.Windows.Forms.Label label5;
    }
}