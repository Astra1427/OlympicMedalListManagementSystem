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

namespace OlympicMedalListManagementSystem.Administrator
{
    public partial class EditAthleteForm : Form1
    {
        public Athlete CurrentAthlete { get; set; }
        public EditAthleteForm(int aid)
        {
            InitializeComponent();
            CurrentAthlete = Uti.db.Athletes.Find(aid);

        }

        public void Init()
        {
            lCountryName.Text = CurrentAthlete.Country.Name;
            txtAthleteName.Text = CurrentAthlete.Name;
            rbMale.Checked = CurrentAthlete.Sex;
            rbFemale.Checked = !CurrentAthlete.Sex;

            dtpBirthdate.Value = CurrentAthlete.Birthdate;
            txtPortrait.Text = CurrentAthlete.Portrait;
            using (MemoryStream ms = new MemoryStream(CurrentAthlete.PortraitImg))
            {
                pbPortrait.Image = Image.FromStream(ms);
                
            }

            using (MemoryStream ms = new MemoryStream(CurrentAthlete.Country.FlagImg))
            {
                pbFlag.Image = Image.FromStream(ms) ;
            }
        }

        private void EditAthleteForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog() { Filter = "Picture|*.jpg;*.png;*.gif" };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtPortrait.Text = openFile.FileName;
                pbPortrait.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAthleteName.Text.Trim() == "")
            {
                MessageBox.Show("Please input the Athlete Name!");
                return;
            }

            if ((DateTime.Now - dtpBirthdate.Value).TotalDays/365 <= 1d)
            {
                MessageBox.Show("The age of athlete must more than 1");
                return;
            }
            try
            {
                CurrentAthlete.Name = txtAthleteName.Text;
                CurrentAthlete.Sex = rbMale.Checked;
                CurrentAthlete.Birthdate = dtpBirthdate.Value;
                CurrentAthlete.Portrait = txtPortrait.Text;
                using (MemoryStream ms = new MemoryStream())
                {
                    
                    Bitmap img = new Bitmap(pbPortrait.Image);
                    img.Save(ms, pbPortrait.Image.RawFormat);
                    CurrentAthlete.PortraitImg = ms.ToArray();
                }
                Uti.db.SaveChanges();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!\nPlease check all data and try again!");
            }

            if (this.Owner is ManageAthletesForm maf)
            {
                maf.Search("");
                maf.LocationLastRow();
            }
        }
    }
}
