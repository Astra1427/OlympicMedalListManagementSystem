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
    public partial class PublishNewsForm : Form1
    {
        public PublishNewsForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Please input the title!");
                return;
            }
            if (txtContent.Text.Trim() == "")
            {
                MessageBox.Show("Please input the content!");
                return;
            }

            try
            {
                Uti.db.News.Add(new News
                {
                    Title = txtTitle.Text,
                    NewsContent = txtContent.Rtf,
                    PublishTime = DateTime.Now,
                    AuthorID = Uti.LoggedAccount.ID
                });
                Uti.db.SaveChanges();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Publish Failed!");
            }

            if (this.Owner is NewsListForm nlf)
            {
                nlf.Search("","");
                nlf.LocationLastRow();
            }
        }
    }
}
