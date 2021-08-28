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

namespace OlympicMedalListManagementSystem.Administrator
{
    public partial class MainForm : Form1
    {
        public MainForm()
        {
            InitializeComponent();
            IsNoTips = false;
            IsExit = true;
        }
        /// <summary>
        /// Init data and controls
        /// </summary>
        public void Init()
        {
            lWelcome.Text = $"Welcome,{Uti.LoggedAccount.Name}!";
        }

        private void btnManageCountry_Click(object sender, EventArgs e)
        {
            new ManageCountryForm() { Owner = this }.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure logout?", "Tips", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Uti.LoggedAccount = null;
                IsExit = false;
                IsNoTips = true;
                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnSportEventManage_Click(object sender, EventArgs e)
        {
            new ManageSportEventForm() { Owner = this }.Show();
            this.Hide();
        }
    }
}
