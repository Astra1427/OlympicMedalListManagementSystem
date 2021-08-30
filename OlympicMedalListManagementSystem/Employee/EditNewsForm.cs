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
    public partial class EditNewsForm : Form1
    {
        public News CurrentNews { get; set; }
        public EditNewsForm(int nid)
        {
            InitializeComponent();
            CurrentNews = Uti.db.News.Find(nid);
            this.lTitle.Text = "Edit News";
        }

        public void Init()
        {
            txtTitle.Text = CurrentNews.Title;
            txtContent.Rtf = CurrentNews.NewsContent;
            txtContent.AllowDrop = true;
            MessageBox.Show(Uti.RtfToPlainText(CurrentNews.NewsContent));
            //txtContent.drop

        }

        private void EditNewsForm_Load(object sender, EventArgs e)
        {
            //Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                CurrentNews.Title = txtTitle.Text;
                CurrentNews.NewsContent = txtContent.Rtf;
                CurrentNews.NewsContentPreview = (txtContent.Text.Length > 30 ? txtContent.Text.Substring(0, 30) : txtContent.Text) + "...";
                Uti.db.SaveChanges();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Failed!");
            }

            if (Owner is NewsListForm nlf)
            {
                nlf.Search("","");
                nlf.LocationLastRow();
            }
        }

        private void EditNewsForm_Shown(object sender, EventArgs e)
        {
            Init();
        }
    }
}
