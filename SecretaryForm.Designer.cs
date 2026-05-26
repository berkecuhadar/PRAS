namespace PRAS.App
{
    partial class SecretaryForm
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
            tabPage1 = new TabPage();
            txt_sID = new TextBox();
            label6 = new Label();
            txt_sPN = new TextBox();
            txt_sEmail = new TextBox();
            txt_sSurname = new TextBox();
            txt_sName = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_rmvS = new Button();
            btn_S = new Button();
            dgv_S = new DataGridView();
            tabPage2 = new TabPage();
            cb_field = new ComboBox();
            txt_dID = new TextBox();
            label4 = new Label();
            txt_dPN = new TextBox();
            txt_dEmail = new TextBox();
            txt_dSurname = new TextBox();
            label20 = new Label();
            txt_dName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btn_rmvD = new Button();
            btn_D = new Button();
            dgv_doctor = new DataGridView();
            tabPage3 = new TabPage();
            btn_P = new Button();
            txt_pID = new TextBox();
            label11 = new Label();
            txt_pPN = new TextBox();
            txt_pNID = new TextBox();
            txt_pSurname = new TextBox();
            label16 = new Label();
            txt_pName = new TextBox();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            btn_rmvP = new Button();
            dgv_P = new DataGridView();
            tabPage4 = new TabPage();
            dgv_appointment2 = new DataGridView();
            label19 = new Label();
            dtp_appointment = new DateTimePicker();
            label18 = new Label();
            btn_appointment = new Button();
            cb_poli = new ComboBox();
            label17 = new Label();
            rs_9 = new RadioButton();
            rs_9h = new RadioButton();
            rs_10 = new RadioButton();
            rs_15h = new RadioButton();
            rs_15 = new RadioButton();
            rs_14h = new RadioButton();
            rs_14 = new RadioButton();
            rs_13h = new RadioButton();
            rs_12 = new RadioButton();
            rs_11h = new RadioButton();
            rs_11 = new RadioButton();
            rs_10h = new RadioButton();
            dgv_appointment1 = new DataGridView();
            btn_findP = new Button();
            txt_findP = new TextBox();
            label13 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_S).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_doctor).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_P).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(684, 331);
            tabControl1.TabIndex = 1;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txt_sID);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txt_sPN);
            tabPage1.Controls.Add(txt_sEmail);
            tabPage1.Controls.Add(txt_sSurname);
            tabPage1.Controls.Add(txt_sName);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btn_rmvS);
            tabPage1.Controls.Add(btn_S);
            tabPage1.Controls.Add(dgv_S);
            tabPage1.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(676, 302);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SECRETARY";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_sID
            // 
            txt_sID.Location = new Point(472, 234);
            txt_sID.Name = "txt_sID";
            txt_sID.Size = new Size(85, 19);
            txt_sID.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(468, 206);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 17;
            label6.Text = "Sekreter ID";
            // 
            // txt_sPN
            // 
            txt_sPN.Location = new Point(150, 239);
            txt_sPN.Name = "txt_sPN";
            txt_sPN.Size = new Size(181, 19);
            txt_sPN.TabIndex = 13;
            // 
            // txt_sEmail
            // 
            txt_sEmail.Location = new Point(150, 218);
            txt_sEmail.Name = "txt_sEmail";
            txt_sEmail.Size = new Size(181, 19);
            txt_sEmail.TabIndex = 14;
            // 
            // txt_sSurname
            // 
            txt_sSurname.Location = new Point(150, 198);
            txt_sSurname.Name = "txt_sSurname";
            txt_sSurname.Size = new Size(181, 19);
            txt_sSurname.TabIndex = 15;
            // 
            // txt_sName
            // 
            txt_sName.Location = new Point(150, 177);
            txt_sName.Name = "txt_sName";
            txt_sName.Size = new Size(181, 19);
            txt_sName.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(8, 239);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 9;
            label5.Text = "PHONE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(8, 218);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 10;
            label3.Text = "E-MAIL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(8, 198);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 11;
            label2.Text = "SURNAME:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(8, 177);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 12;
            label1.Text = "NAME:";
            // 
            // btn_rmvS
            // 
            btn_rmvS.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_rmvS.Location = new Point(472, 262);
            btn_rmvS.Name = "btn_rmvS";
            btn_rmvS.Size = new Size(85, 37);
            btn_rmvS.TabIndex = 7;
            btn_rmvS.Text = "REMOVE";
            btn_rmvS.UseVisualStyleBackColor = true;
            btn_rmvS.Click += btn_rmvS_Click;
            // 
            // btn_S
            // 
            btn_S.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_S.Location = new Point(191, 262);
            btn_S.Name = "btn_S";
            btn_S.Size = new Size(103, 37);
            btn_S.TabIndex = 8;
            btn_S.Text = "ADD/UPDATE";
            btn_S.UseVisualStyleBackColor = true;
            btn_S.Click += btn_S_Click;
            // 
            // dgv_S
            // 
            dgv_S.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_S.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_S.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_S.Location = new Point(0, 1);
            dgv_S.MultiSelect = false;
            dgv_S.Name = "dgv_S";
            dgv_S.ReadOnly = true;
            dgv_S.RowHeadersWidth = 51;
            dgv_S.RowTemplate.Height = 24;
            dgv_S.Size = new Size(677, 170);
            dgv_S.TabIndex = 6;
            dgv_S.RowHeaderMouseDoubleClick += dgv_S_RowHeaderMouseDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cb_field);
            tabPage2.Controls.Add(txt_dID);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txt_dPN);
            tabPage2.Controls.Add(txt_dEmail);
            tabPage2.Controls.Add(txt_dSurname);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(txt_dName);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(btn_rmvD);
            tabPage2.Controls.Add(btn_D);
            tabPage2.Controls.Add(dgv_doctor);
            tabPage2.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(676, 302);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "DOCTOR";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_field
            // 
            cb_field.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_field.FormattingEnabled = true;
            cb_field.Items.AddRange(new object[] { "Cardiology", "General Surgery", "Psychiatry", "Otolaryngology", "Gynecology", "Obstetrics", "Urology", "Internal Medicine", "Pediatrics" });
            cb_field.Location = new Point(150, 259);
            cb_field.MaxDropDownItems = 10;
            cb_field.Name = "cb_field";
            cb_field.Size = new Size(181, 20);
            cb_field.TabIndex = 19;
            cb_field.Tag = "";
            // 
            // txt_dID
            // 
            txt_dID.Location = new Point(528, 233);
            txt_dID.Name = "txt_dID";
            txt_dID.Size = new Size(85, 19);
            txt_dID.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(532, 205);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 17;
            label4.Text = "Doctor ID";
            // 
            // txt_dPN
            // 
            txt_dPN.Location = new Point(150, 239);
            txt_dPN.Name = "txt_dPN";
            txt_dPN.Size = new Size(181, 19);
            txt_dPN.TabIndex = 13;
            // 
            // txt_dEmail
            // 
            txt_dEmail.Location = new Point(150, 218);
            txt_dEmail.Name = "txt_dEmail";
            txt_dEmail.Size = new Size(181, 19);
            txt_dEmail.TabIndex = 14;
            // 
            // txt_dSurname
            // 
            txt_dSurname.Location = new Point(150, 198);
            txt_dSurname.Name = "txt_dSurname";
            txt_dSurname.Size = new Size(181, 19);
            txt_dSurname.TabIndex = 15;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label20.Location = new Point(8, 260);
            label20.Name = "label20";
            label20.Size = new Size(42, 19);
            label20.TabIndex = 9;
            label20.Text = "Field:";
            // 
            // txt_dName
            // 
            txt_dName.Location = new Point(150, 177);
            txt_dName.Name = "txt_dName";
            txt_dName.Size = new Size(181, 19);
            txt_dName.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(8, 239);
            label7.Name = "label7";
            label7.Size = new Size(50, 19);
            label7.TabIndex = 9;
            label7.Text = "Phone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(8, 218);
            label8.Name = "label8";
            label8.Size = new Size(54, 19);
            label8.TabIndex = 10;
            label8.Text = "E-Mail:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(8, 198);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 11;
            label9.Text = "Surname:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(8, 177);
            label10.Name = "label10";
            label10.Size = new Size(49, 19);
            label10.TabIndex = 12;
            label10.Text = "Name:";
            // 
            // btn_rmvD
            // 
            btn_rmvD.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_rmvD.Location = new Point(528, 262);
            btn_rmvD.Name = "btn_rmvD";
            btn_rmvD.Size = new Size(85, 37);
            btn_rmvD.TabIndex = 7;
            btn_rmvD.Text = "Remove";
            btn_rmvD.UseVisualStyleBackColor = true;
            btn_rmvD.Click += btn_rmvD_Click;
            // 
            // btn_D
            // 
            btn_D.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_D.Location = new Point(336, 176);
            btn_D.Name = "btn_D";
            btn_D.Size = new Size(100, 104);
            btn_D.TabIndex = 8;
            btn_D.Text = "ADD/UPDATE";
            btn_D.UseVisualStyleBackColor = true;
            btn_D.Click += btn_D_Click;
            // 
            // dgv_doctor
            // 
            dgv_doctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_doctor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_doctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_doctor.Location = new Point(0, 1);
            dgv_doctor.MultiSelect = false;
            dgv_doctor.Name = "dgv_doctor";
            dgv_doctor.ReadOnly = true;
            dgv_doctor.RowHeadersWidth = 51;
            dgv_doctor.RowTemplate.Height = 24;
            dgv_doctor.Size = new Size(677, 170);
            dgv_doctor.TabIndex = 6;
            dgv_doctor.RowHeaderMouseDoubleClick += dgv_doctor_RowHeaderMouseDoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_P);
            tabPage3.Controls.Add(txt_pID);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(txt_pPN);
            tabPage3.Controls.Add(txt_pNID);
            tabPage3.Controls.Add(txt_pSurname);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(txt_pName);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(btn_rmvP);
            tabPage3.Controls.Add(dgv_P);
            tabPage3.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage3.Location = new Point(4, 25);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(676, 302);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PATIENT";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_P
            // 
            btn_P.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_P.Location = new Point(191, 262);
            btn_P.Name = "btn_P";
            btn_P.Size = new Size(103, 37);
            btn_P.TabIndex = 19;
            btn_P.Text = "ADD/UPDATE";
            btn_P.UseVisualStyleBackColor = true;
            btn_P.Click += btn_P_Click;
            // 
            // txt_pID
            // 
            txt_pID.Location = new Point(472, 234);
            txt_pID.Name = "txt_pID";
            txt_pID.Size = new Size(85, 19);
            txt_pID.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(477, 206);
            label11.Name = "label11";
            label11.Size = new Size(73, 19);
            label11.TabIndex = 17;
            label11.Text = "Patient ID:";
            // 
            // txt_pPN
            // 
            txt_pPN.Location = new Point(150, 239);
            txt_pPN.Name = "txt_pPN";
            txt_pPN.Size = new Size(181, 19);
            txt_pPN.TabIndex = 13;
            // 
            // txt_pNID
            // 
            txt_pNID.Location = new Point(150, 218);
            txt_pNID.Name = "txt_pNID";
            txt_pNID.Size = new Size(181, 19);
            txt_pNID.TabIndex = 13;
            // 
            // txt_pSurname
            // 
            txt_pSurname.Location = new Point(150, 198);
            txt_pSurname.Name = "txt_pSurname";
            txt_pSurname.Size = new Size(181, 19);
            txt_pSurname.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label16.Location = new Point(8, 239);
            label16.Name = "label16";
            label16.Size = new Size(50, 19);
            label16.TabIndex = 9;
            label16.Text = "Phone:";
            // 
            // txt_pName
            // 
            txt_pName.Location = new Point(150, 177);
            txt_pName.Name = "txt_pName";
            txt_pName.Size = new Size(181, 19);
            txt_pName.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.Location = new Point(8, 218);
            label12.Name = "label12";
            label12.Size = new Size(110, 19);
            label12.TabIndex = 9;
            label12.Text = "NATIONAL ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label14.Location = new Point(8, 198);
            label14.Name = "label14";
            label14.Size = new Size(65, 19);
            label14.TabIndex = 11;
            label14.Text = "Surname:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label15.Location = new Point(8, 177);
            label15.Name = "label15";
            label15.Size = new Size(49, 19);
            label15.TabIndex = 12;
            label15.Text = "Name:";
            // 
            // btn_rmvP
            // 
            btn_rmvP.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_rmvP.Location = new Point(472, 262);
            btn_rmvP.Name = "btn_rmvP";
            btn_rmvP.Size = new Size(85, 37);
            btn_rmvP.TabIndex = 7;
            btn_rmvP.Text = "Remove";
            btn_rmvP.UseVisualStyleBackColor = true;
            btn_rmvP.Click += btn_rmvP_Click;
            // 
            // dgv_P
            // 
            dgv_P.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_P.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_P.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_P.Location = new Point(0, 1);
            dgv_P.MultiSelect = false;
            dgv_P.Name = "dgv_P";
            dgv_P.ReadOnly = true;
            dgv_P.RowHeadersWidth = 51;
            dgv_P.RowTemplate.Height = 24;
            dgv_P.Size = new Size(677, 170);
            dgv_P.TabIndex = 6;
            dgv_P.RowHeaderMouseDoubleClick += dgv_P_RowHeaderMouseDoubleClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgv_appointment2);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(dtp_appointment);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(btn_appointment);
            tabPage4.Controls.Add(cb_poli);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(rs_9);
            tabPage4.Controls.Add(rs_9h);
            tabPage4.Controls.Add(rs_10);
            tabPage4.Controls.Add(rs_15h);
            tabPage4.Controls.Add(rs_15);
            tabPage4.Controls.Add(rs_14h);
            tabPage4.Controls.Add(rs_14);
            tabPage4.Controls.Add(rs_13h);
            tabPage4.Controls.Add(rs_12);
            tabPage4.Controls.Add(rs_11h);
            tabPage4.Controls.Add(rs_11);
            tabPage4.Controls.Add(rs_10h);
            tabPage4.Controls.Add(dgv_appointment1);
            tabPage4.Controls.Add(btn_findP);
            tabPage4.Controls.Add(txt_findP);
            tabPage4.Controls.Add(label13);
            tabPage4.Location = new Point(4, 25);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(676, 302);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Add Appointment";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_appointment2
            // 
            dgv_appointment2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointment2.Location = new Point(346, 105);
            dgv_appointment2.Name = "dgv_appointment2";
            dgv_appointment2.RowHeadersWidth = 51;
            dgv_appointment2.RowTemplate.Height = 24;
            dgv_appointment2.Size = new Size(325, 188);
            dgv_appointment2.TabIndex = 11;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label19.Location = new Point(114, 116);
            label19.Name = "label19";
            label19.Size = new Size(120, 19);
            label19.TabIndex = 10;
            label19.Text = "Appointment Time";
            // 
            // dtp_appointment
            // 
            dtp_appointment.Location = new Point(155, 71);
            dtp_appointment.Name = "dtp_appointment";
            dtp_appointment.Size = new Size(176, 23);
            dtp_appointment.TabIndex = 12;
            dtp_appointment.ValueChanged += dtp_appointment_ValueChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label18.Location = new Point(3, 73);
            label18.Name = "label18";
            label18.Size = new Size(123, 19);
            label18.TabIndex = 9;
            label18.Text = "Appointment Date:";
            // 
            // btn_appointment
            // 
            btn_appointment.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_appointment.Location = new Point(93, 249);
            btn_appointment.Name = "btn_appointment";
            btn_appointment.Size = new Size(158, 46);
            btn_appointment.TabIndex = 7;
            btn_appointment.Text = "Appointment";
            btn_appointment.UseVisualStyleBackColor = true;
            btn_appointment.Click += btn_appointment_Click;
            // 
            // cb_poli
            // 
            cb_poli.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_poli.FormattingEnabled = true;
            cb_poli.Items.AddRange(new object[] { "Cardiology", "General Surgery", "Psychiatry", "Otolaryngology", "Gynecology", "Obstetrics", "Urology", "Internal Medicine", "Pediatrics" });
            cb_poli.Location = new Point(127, 41);
            cb_poli.Name = "cb_poli";
            cb_poli.Size = new Size(212, 24);
            cb_poli.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label17.Location = new Point(3, 41);
            label17.Name = "label17";
            label17.Size = new Size(46, 19);
            label17.TabIndex = 5;
            label17.Text = "Clinic:";
            // 
            // rs_9
            // 
            rs_9.AutoSize = true;
            rs_9.Location = new Point(11, 140);
            rs_9.Name = "rs_9";
            rs_9.Size = new Size(56, 20);
            rs_9.TabIndex = 4;
            rs_9.TabStop = true;
            rs_9.Text = "09:00";
            rs_9.UseVisualStyleBackColor = true;
            // 
            // rs_9h
            // 
            rs_9h.AutoSize = true;
            rs_9h.Location = new Point(140, 140);
            rs_9h.Name = "rs_9h";
            rs_9h.Size = new Size(56, 20);
            rs_9h.TabIndex = 4;
            rs_9h.TabStop = true;
            rs_9h.Text = "09:30";
            rs_9h.UseVisualStyleBackColor = true;
            // 
            // rs_10
            // 
            rs_10.AutoSize = true;
            rs_10.Location = new Point(276, 140);
            rs_10.Name = "rs_10";
            rs_10.Size = new Size(56, 20);
            rs_10.TabIndex = 4;
            rs_10.TabStop = true;
            rs_10.Text = "10:00";
            rs_10.UseVisualStyleBackColor = true;
            // 
            // rs_15h
            // 
            rs_15h.AutoSize = true;
            rs_15h.Location = new Point(276, 221);
            rs_15h.Name = "rs_15h";
            rs_15h.Size = new Size(56, 20);
            rs_15h.TabIndex = 4;
            rs_15h.TabStop = true;
            rs_15h.Text = "15:30";
            rs_15h.UseVisualStyleBackColor = true;
            // 
            // rs_15
            // 
            rs_15.AutoSize = true;
            rs_15.Location = new Point(140, 221);
            rs_15.Name = "rs_15";
            rs_15.Size = new Size(56, 20);
            rs_15.TabIndex = 4;
            rs_15.TabStop = true;
            rs_15.Text = "15:00";
            rs_15.UseVisualStyleBackColor = true;
            // 
            // rs_14h
            // 
            rs_14h.AutoSize = true;
            rs_14h.Location = new Point(11, 221);
            rs_14h.Name = "rs_14h";
            rs_14h.Size = new Size(56, 20);
            rs_14h.TabIndex = 4;
            rs_14h.TabStop = true;
            rs_14h.Text = "14:30";
            rs_14h.UseVisualStyleBackColor = true;
            // 
            // rs_14
            // 
            rs_14.AutoSize = true;
            rs_14.Location = new Point(276, 194);
            rs_14.Name = "rs_14";
            rs_14.Size = new Size(56, 20);
            rs_14.TabIndex = 4;
            rs_14.TabStop = true;
            rs_14.Text = "14:00";
            rs_14.UseVisualStyleBackColor = true;
            // 
            // rs_13h
            // 
            rs_13h.AutoSize = true;
            rs_13h.Location = new Point(140, 194);
            rs_13h.Name = "rs_13h";
            rs_13h.Size = new Size(56, 20);
            rs_13h.TabIndex = 4;
            rs_13h.TabStop = true;
            rs_13h.Text = "13:30";
            rs_13h.UseVisualStyleBackColor = true;
            // 
            // rs_12
            // 
            rs_12.AutoSize = true;
            rs_12.Location = new Point(11, 194);
            rs_12.Name = "rs_12";
            rs_12.Size = new Size(56, 20);
            rs_12.TabIndex = 4;
            rs_12.TabStop = true;
            rs_12.Text = "12:00";
            rs_12.UseVisualStyleBackColor = true;
            // 
            // rs_11h
            // 
            rs_11h.AutoSize = true;
            rs_11h.Location = new Point(276, 167);
            rs_11h.Name = "rs_11h";
            rs_11h.Size = new Size(55, 20);
            rs_11h.TabIndex = 4;
            rs_11h.TabStop = true;
            rs_11h.Text = "11:30";
            rs_11h.UseVisualStyleBackColor = true;
            // 
            // rs_11
            // 
            rs_11.AutoSize = true;
            rs_11.Location = new Point(140, 167);
            rs_11.Name = "rs_11";
            rs_11.Size = new Size(55, 20);
            rs_11.TabIndex = 4;
            rs_11.TabStop = true;
            rs_11.Text = "11:00";
            rs_11.UseVisualStyleBackColor = true;
            // 
            // rs_10h
            // 
            rs_10h.AutoSize = true;
            rs_10h.Location = new Point(11, 167);
            rs_10h.Name = "rs_10h";
            rs_10h.Size = new Size(56, 20);
            rs_10h.TabIndex = 4;
            rs_10h.TabStop = true;
            rs_10h.Text = "10:30";
            rs_10h.UseVisualStyleBackColor = true;
            // 
            // dgv_appointment1
            // 
            dgv_appointment1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_appointment1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_appointment1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointment1.Location = new Point(346, 3);
            dgv_appointment1.MultiSelect = false;
            dgv_appointment1.Name = "dgv_appointment1";
            dgv_appointment1.ReadOnly = true;
            dgv_appointment1.RowHeadersWidth = 51;
            dgv_appointment1.RowTemplate.Height = 24;
            dgv_appointment1.Size = new Size(325, 96);
            dgv_appointment1.TabIndex = 3;
            // 
            // btn_findP
            // 
            btn_findP.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_findP.Location = new Point(256, 4);
            btn_findP.Name = "btn_findP";
            btn_findP.Size = new Size(84, 25);
            btn_findP.TabIndex = 2;
            btn_findP.Text = "FIND PATIENT";
            btn_findP.UseVisualStyleBackColor = true;
            btn_findP.Click += btn_findP_Click;
            // 
            // txt_findP
            // 
            txt_findP.Location = new Point(127, 4);
            txt_findP.Name = "txt_findP";
            txt_findP.Size = new Size(125, 23);
            txt_findP.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.Location = new Point(3, 6);
            label13.Name = "label13";
            label13.Size = new Size(172, 19);
            label13.TabIndex = 0;
            label13.Text = "PATIENT NATIONAL ID";
            // 
            // SecretaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 331);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SecretaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRAS Secretary";
            FormClosed += SecretaryForm_FormClosed;
            Load += SecretaryForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_S).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_doctor).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_P).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_sID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sPN;
        private System.Windows.Forms.TextBox txt_sEmail;
        private System.Windows.Forms.TextBox txt_sSurname;
        private System.Windows.Forms.TextBox txt_sName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rmvS;
        private System.Windows.Forms.Button btn_S;
        private System.Windows.Forms.DataGridView dgv_S;
        private System.Windows.Forms.TextBox txt_dID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dPN;
        private System.Windows.Forms.TextBox txt_dEmail;
        private System.Windows.Forms.TextBox txt_dSurname;
        private System.Windows.Forms.TextBox txt_dName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_rmvD;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.DataGridView dgv_doctor;
        private System.Windows.Forms.TextBox txt_pID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_pNID;
        private System.Windows.Forms.TextBox txt_pSurname;
        private System.Windows.Forms.TextBox txt_pName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_rmvP;
        private System.Windows.Forms.DataGridView dgv_P;
        private System.Windows.Forms.Button btn_P;
        private System.Windows.Forms.TextBox txt_pPN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv_appointment2;
        private System.Windows.Forms.Button btn_findP;
        private System.Windows.Forms.TextBox txt_findP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtp_appointment;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_appointment;
        private System.Windows.Forms.ComboBox cb_poli;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rs_9;
        private System.Windows.Forms.RadioButton rs_9h;
        private System.Windows.Forms.RadioButton rs_10;
        private System.Windows.Forms.RadioButton rs_15h;
        private System.Windows.Forms.RadioButton rs_15;
        private System.Windows.Forms.RadioButton rs_14h;
        private System.Windows.Forms.RadioButton rs_14;
        private System.Windows.Forms.RadioButton rs_13h;
        private System.Windows.Forms.RadioButton rs_12;
        private System.Windows.Forms.RadioButton rs_11h;
        private System.Windows.Forms.RadioButton rs_11;
        private System.Windows.Forms.RadioButton rs_10h;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cb_field;
        private System.Windows.Forms.DataGridView dgv_appointment1;
    }
}
