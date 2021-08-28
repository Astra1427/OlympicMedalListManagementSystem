
namespace OlympicMedalListManagementSystem
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbAutoLogin = new System.Windows.Forms.CheckBox();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lVerify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14F);
            this.btnLogin.Location = new System.Drawing.Point(230, 267);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 33);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 14F);
            this.txtID.Location = new System.Drawing.Point(267, 112);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(234, 29);
            this.txtID.TabIndex = 2;
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Font = new System.Drawing.Font("Arial", 14F);
            this.cbRememberMe.Location = new System.Drawing.Point(256, 223);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(156, 26);
            this.cbRememberMe.TabIndex = 3;
            this.cbRememberMe.Text = "Remember Me";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(226, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(162, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Arial", 14F);
            this.txtPwd.Location = new System.Drawing.Point(267, 154);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(234, 29);
            this.txtPwd.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(391, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbAutoLogin
            // 
            this.cbAutoLogin.AutoSize = true;
            this.cbAutoLogin.Font = new System.Drawing.Font("Arial", 14F);
            this.cbAutoLogin.Location = new System.Drawing.Point(407, 223);
            this.cbAutoLogin.Name = "cbAutoLogin";
            this.cbAutoLogin.Size = new System.Drawing.Size(120, 26);
            this.cbAutoLogin.TabIndex = 3;
            this.cbAutoLogin.Text = "Auto Login";
            this.cbAutoLogin.UseVisualStyleBackColor = true;
            this.cbAutoLogin.CheckedChanged += new System.EventHandler(this.cbAutoLogin_CheckedChanged);
            // 
            // txtVerify
            // 
            this.txtVerify.Font = new System.Drawing.Font("Arial", 14F);
            this.txtVerify.Location = new System.Drawing.Point(267, 193);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(120, 29);
            this.txtVerify.TabIndex = 2;
            this.txtVerify.Text = " ";
            this.txtVerify.Visible = false;
            // 
            // btnVerify
            // 
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerify.Font = new System.Drawing.Font("Arial", 14F);
            this.btnVerify.Location = new System.Drawing.Point(407, 186);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(94, 33);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "r12f";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Visible = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lVerify
            // 
            this.lVerify.AutoSize = true;
            this.lVerify.Font = new System.Drawing.Font("Arial", 14F);
            this.lVerify.Location = new System.Drawing.Point(101, 196);
            this.lVerify.Name = "lVerify";
            this.lVerify.Size = new System.Drawing.Size(160, 22);
            this.lVerify.TabIndex = 0;
            this.lVerify.Text = "Verification Code:";
            this.lVerify.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 371);
            this.Controls.Add(this.cbAutoLogin);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lVerify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.btnVerify, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lVerify, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtPwd, 0);
            this.Controls.SetChildIndex(this.txtVerify, 0);
            this.Controls.SetChildIndex(this.cbRememberMe, 0);
            this.Controls.SetChildIndex(this.cbAutoLogin, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbAutoLogin;
        private System.Windows.Forms.TextBox txtVerify;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lVerify;
    }
}