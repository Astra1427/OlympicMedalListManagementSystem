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

namespace OlympicMedalListManagementSystem.Employee
{
    public partial class MainForm : Form1
    {
        public MainForm()
        {
            InitializeComponent();

        }
        public void Init()
        {
            IsExit = true;
            lWelcome.Text = $"Welcome,{Uti.LoggedAccount.Name}!";
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnMedalList_Click(object sender, EventArgs e)
        {
            new MedalListForm() { Owner = this }.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            IsExit = false;
            if (MessageBox.Show("Are you sure logout?", "Tips", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                IsNoTips = true;
                Uti.LoggedAccount = null;
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewsList_Click(object sender, EventArgs e)
        {
            new NewsListForm() { Owner = this }.Show();
            this.Hide();
        }
    }
}
