
namespace IDKMaybe
{
    partial class LoginSignUp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pgeLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pgeSign = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SignUpPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SignUpUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.pgeLogin.SuspendLayout();
            this.pgeSign.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pgeLogin);
            this.tabControl1.Controls.Add(this.pgeSign);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(29, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(207, 191);
            this.tabControl1.TabIndex = 0;
            // 
            // pgeLogin
            // 
            this.pgeLogin.BackColor = System.Drawing.Color.Black;
            this.pgeLogin.Controls.Add(this.btnLogin);
            this.pgeLogin.Controls.Add(this.LoginPassword);
            this.pgeLogin.Controls.Add(this.LoginUsername);
            this.pgeLogin.Controls.Add(this.label2);
            this.pgeLogin.Controls.Add(this.label1);
            this.pgeLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pgeLogin.Location = new System.Drawing.Point(4, 22);
            this.pgeLogin.Name = "pgeLogin";
            this.pgeLogin.Padding = new System.Windows.Forms.Padding(3);
            this.pgeLogin.Size = new System.Drawing.Size(199, 165);
            this.pgeLogin.TabIndex = 0;
            this.pgeLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnLogin.Location = new System.Drawing.Point(50, 123);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(50, 77);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(100, 20);
            this.LoginPassword.TabIndex = 3;
            // 
            // LoginUsername
            // 
            this.LoginUsername.Location = new System.Drawing.Point(50, 29);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(100, 20);
            this.LoginUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(74, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(72, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // pgeSign
            // 
            this.pgeSign.BackColor = System.Drawing.Color.Black;
            this.pgeSign.Controls.Add(this.btnDelete);
            this.pgeSign.Controls.Add(this.btnCreate);
            this.pgeSign.Controls.Add(this.SignUpPassword);
            this.pgeSign.Controls.Add(this.label4);
            this.pgeSign.Controls.Add(this.SignUpUsername);
            this.pgeSign.Controls.Add(this.label3);
            this.pgeSign.Location = new System.Drawing.Point(4, 22);
            this.pgeSign.Name = "pgeSign";
            this.pgeSign.Padding = new System.Windows.Forms.Padding(3);
            this.pgeSign.Size = new System.Drawing.Size(199, 165);
            this.pgeSign.TabIndex = 1;
            this.pgeSign.Text = "Sign Up";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCreate.Location = new System.Drawing.Point(30, 124);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(56, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // SignUpPassword
            // 
            this.SignUpPassword.Location = new System.Drawing.Point(48, 81);
            this.SignUpPassword.Name = "SignUpPassword";
            this.SignUpPassword.Size = new System.Drawing.Size(100, 20);
            this.SignUpPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(46, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Create Password";
            // 
            // SignUpUsername
            // 
            this.SignUpUsername.Location = new System.Drawing.Point(48, 28);
            this.SignUpUsername.Name = "SignUpUsername";
            this.SignUpUsername.Size = new System.Drawing.Size(100, 20);
            this.SignUpUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(45, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Create User Name";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnExit.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Orange;
            this.btnExit.Location = new System.Drawing.Point(-1, 188);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnDelete.Location = new System.Drawing.Point(99, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LoginSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(278, 215);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginSignUp";
            this.Text = "Login/Sign Up";
            this.tabControl1.ResumeLayout(false);
            this.pgeLogin.ResumeLayout(false);
            this.pgeLogin.PerformLayout();
            this.pgeSign.ResumeLayout(false);
            this.pgeSign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pgeLogin;
        private System.Windows.Forms.TabPage pgeSign;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.TextBox LoginUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox SignUpUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SignUpPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
    }
}

