using OlympicMedalListManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympicMedalListManagementSystem
{
    public partial class LoginForm : Form1
    {
        public LoginForm()
        {
            InitializeComponent();
            //IsExit = true;
            //Olympic Medal List Management System
            this.lTitle.Text = "Olympic Medal List Management System";
        }



        int LoginErrorCount = 0;
        public bool IsVerify {
            set {
                lVerify.Visible = value;
                txtVerify.Visible = value;
                btnVerify.Visible = value;
            } 
        }


        public void Init()
        {
            if (UserSetting.Default.LastLoginTime!= null && (DateTime.Now - UserSetting.Default.LastLoginTime).TotalDays>=7)
            {
                MessageBox.Show("Account Information Expired!\nPlease re-enter your acccount information!");
                return;
            }
            if (UserSetting.Default.IsRememberMe)
            {
                txtID.Text = UserSetting.Default.UserID;
                txtPwd.Text = UserSetting.Default.UserPassword;
                cbRememberMe.Checked = true;
            }
            if (UserSetting.Default.IsAutoLogin)
            {
                cbAutoLogin.Checked = true;
                btnLogin_Click(null, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "" || txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("Please input the ID and Password!");
                return;
            }
            if (btnVerify.Visible && txtVerify.Text.ToUpper() != btnVerify.Text)
            {
                MessageBox.Show("Verification Code Error!");
                return;
            }
            var md5Pwd = Uti.db.Database.SqlQuery<string>($"SELECT CONVERT(varchar,HASHBYTES('MD5',CAST('{txtPwd.Text}' AS varchar)),2)").FirstOrDefault();

            //md5Pwd = (e == null ? UserSetting.Default.UserPassword : md5Pwd);
            var account = Uti.db.Accounts.FirstOrDefault(a=>a.ID.ToString() == txtID.Text && a.Password == md5Pwd);
            if (account == null)
            {
                if (++LoginErrorCount >= 3)
                {
                    IsVerify = true;
                }
                MessageBox.Show("Login failed!please check the ID or Password!");
                return;
            }

            //Login Success
            Uti.LoggedAccount = account;

            if (cbAutoLogin.Checked || cbRememberMe.Checked)
            {
                UserSetting.Default.UserID = account.ID.ToString();
                UserSetting.Default.UserPassword = txtPwd.Text;
            }
            UserSetting.Default.IsRememberMe = cbRememberMe.Checked;
            UserSetting.Default.IsAutoLogin = cbAutoLogin.Checked; 


            if (sender != null && e != null)
            {
                UserSetting.Default.LastLoginTime = DateTime.Now;
            }
            UserSetting.Default.Save();

            IsVerify = false;
            LoginErrorCount = 0;

            if (account.Role==1)
            {
                new Administrator.MainForm() { Owner = this }.Show();
            }
            else
            {
                new Employee.MainForm() { Owner = this }.Show();
            }
            this.Hide();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            btnVerify.Text = Uti.GetVerificationCode(4);
        }

        private void cbAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoLogin.Checked)
            {
                cbRememberMe.Checked = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            Init();

        }
    }
}
