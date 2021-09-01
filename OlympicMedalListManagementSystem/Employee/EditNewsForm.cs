using OlympicMedalListManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            using (MemoryStream ms = new MemoryStream(CurrentNews.Sport.SportIcon))
            {
                pbSportIcon.Image = Image.FromStream(ms);
            }
            lSportName.Text = CurrentNews.Sport.Name;
            cbGoldNews.Checked = CurrentNews.GoldNews;




            //MessageBox.Show(Uti.RtfToPlainText(CurrentNews.NewsContent));

            //txtContent.drop

        }

        private void EditNewsForm_Load(object sender, EventArgs e)
        {
            //Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChosenSport == null)
            {
                MessageBox.Show("Please Choose Sport!");
                return;
            }
            try
            {

                CurrentNews.Title = txtTitle.Text;
                CurrentNews.NewsContent = txtContent.Rtf;
                CurrentNews.NewsContentPreview = (txtContent.Text.Length > 30 ? txtContent.Text.Substring(0, 30) : txtContent.Text) + "...";
                CurrentNews.GoldNews = cbGoldNews.Checked;
                CurrentNews.SportID = ChosenSport.ID;
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

        public Sport ChosenSport { get; set; }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            var chooseSportForm = new ChooseSportForm();
            if (chooseSportForm.ShowDialog() == DialogResult.OK)
            {
                ChosenSport = Uti.db.Sports.Find(chooseSportForm.ReturnID);
                if (ChosenSport == null)
                {
                    MessageBox.Show("The Sport is Undefind!\nPlease rechoose!");
                    return;
                }
                if (!lSportName.Visible)
                {
                    lSportName.Visible = true;
                    pbSportIcon.Visible = true;
                }

                lSportName.Text = ChosenSport.Name;
                using (MemoryStream ms = new MemoryStream(ChosenSport.SportIcon))
                {
                    pbSportIcon.Image = Image.FromStream(ms);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string rtfStr = File.ReadAllText(openfile.FileName);
                string imageDataHex = Uti.ExtractImgHex(rtfStr);
                byte[] imageBuffer = Uti.ToBinary(imageDataHex);
                using (MemoryStream ms = new MemoryStream(imageBuffer))
                {
                    pbSportIcon.Image = Image.FromStream(ms);

                }
            }
        }
    }
}
