namespace PRAS.App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DPass = new System.Windows.Forms.TextBox();
            this.txt_DEmail = new System.Windows.Forms.TextBox();
            this.btn_DLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SPass = new System.Windows.Forms.TextBox();
            this.txt_SEmail = new System.Windows.Forms.TextBox();
            this.btn_SLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 95);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_DPass);
            this.splitContainer1.Panel1.Controls.Add(this.txt_DEmail);
            this.splitContainer1.Panel1.Controls.Add(this.btn_DLogin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txt_SPass);
            this.splitContainer1.Panel2.Controls.Add(this.txt_SEmail);
            this.splitContainer1.Panel2.Controls.Add(this.btn_SLogin);
            this.splitContainer1.Size = new System.Drawing.Size(582, 258);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(106, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Dsifre
            // 
            this.txt_DPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DPass.Location = new System.Drawing.Point(93, 124);
            this.txt_DPass.Name = "txt_DPass";
            this.txt_DPass.PasswordChar = '*';
            this.txt_DPass.Size = new System.Drawing.Size(157, 27);
            this.txt_DPass.TabIndex = 2;
            this.txt_DPass.Enter += new System.EventHandler(this.txt_DPass_Enter);
            this.txt_DPass.Leave += new System.EventHandler(this.txt_DPass_Leave);
            // 
            // txt_Deposta
            // 
            this.txt_DEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DEmail.Location = new System.Drawing.Point(93, 55);
            this.txt_DEmail.Name = "txt_DEmail";
            this.txt_DEmail.Size = new System.Drawing.Size(157, 27);
            this.txt_DEmail.TabIndex = 1;
            this.txt_DEmail.Enter += new System.EventHandler(this.txt_DEmail_Enter);
            this.txt_DEmail.Leave += new System.EventHandler(this.txt_DEmail_Leave);
            // 
            // btn_Dlogin
            // 
            this.btn_DLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_DLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DLogin.Location = new System.Drawing.Point(93, 176);
            this.btn_DLogin.Name = "btn_DLogin";
            this.btn_DLogin.Size = new System.Drawing.Size(157, 35);
            this.btn_DLogin.TabIndex = 3;
            this.btn_DLogin.Text = "Login as a Doctor";
            this.btn_DLogin.UseVisualStyleBackColor = false;
            this.btn_DLogin.Click += new System.EventHandler(this.btn_DLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightBlue;
            this.label3.Location = new System.Drawing.Point(66, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Secretary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Ssifre
            // 
            this.txt_SPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SPass.Location = new System.Drawing.Point(44, 124);
            this.txt_SPass.Name = "txt_SPass";
            this.txt_SPass.PasswordChar = '*';
            this.txt_SPass.Size = new System.Drawing.Size(157, 27);
            this.txt_SPass.TabIndex = 5;
            this.txt_SPass.Enter += new System.EventHandler(this.txt_SPass_Enter);
            this.txt_SPass.Leave += new System.EventHandler(this.ttxt_SPass_Leave);
            // 
            // txt_Seposta
            // 
            this.txt_SEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SEmail.Location = new System.Drawing.Point(44, 55);
            this.txt_SEmail.Name = "txt_SEmail";
            this.txt_SEmail.Size = new System.Drawing.Size(157, 27);
            this.txt_SEmail.TabIndex = 4;
            this.txt_SEmail.Enter += new System.EventHandler(this.txt_SEmail_Enter);
            this.txt_SEmail.Leave += new System.EventHandler(this.txt_SEmail_Leave);
            // 
            // btn_Slogin
            // 
            this.btn_SLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_SLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SLogin.Location = new System.Drawing.Point(44, 176);
            this.btn_SLogin.Name = "btn_SLogin";
            this.btn_SLogin.Size = new System.Drawing.Size(157, 35);
            this.btn_SLogin.TabIndex = 6;
            this.btn_SLogin.Text = "Login as a Secretary";
            this.btn_SLogin.UseVisualStyleBackColor = false;
            this.btn_SLogin.Click += new System.EventHandler(this.btn_SLogin_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_DPass;
        private System.Windows.Forms.TextBox txt_DEmail;
        private System.Windows.Forms.Button btn_DLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SPass;
        private System.Windows.Forms.TextBox txt_SEmail;
        private System.Windows.Forms.Button btn_SLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}