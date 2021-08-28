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
    public partial class AddAthletesForm : Form1
    {
        public Country CurrentCountry { get; set; }
        public AddAthletesForm(int cid)
        {
            InitializeComponent();
            CurrentCountry = Uti.db.Countries.Find(cid);
            this.lTitle.Text = "Add Athlete";
            IsNoTips = false;
        }
        public void Init()
        {
            lCountryName.Text = CurrentCountry.Name;
            using (MemoryStream ms = new MemoryStream(CurrentCountry.FlagImg))
            {
                pbFlag.Image = Image.FromStream(ms);
            }
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture|*.png;*.jpg;*.gif";
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
                MessageBox.Show("Please input the Athelte Name");
                return;
            }

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbPortrait.Image.Save(ms, pbPortrait.Image.RawFormat);

                    Uti.db.Athletes.Add(new Athlete
                    {
                        Name = txtAthleteName.Text,
                        Sex = rbMale.Checked,
                        CountryID = CurrentCountry.ID,
                        Portrait = txtPortrait.Text,
                        PortraitImg = ms.ToArray(),
                        Birthdate = dtpBirthdate.Value

                    });
                    Uti.db.SaveChanges();
                }
                //MessageBox.Show("Success!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faile!\nPlease check all data and try again!");
            }

            if (this.Owner is ManageAthletesForm maf)
            {
                maf.Search("");
                maf.LocationLastRow();
            }

        }

        private void AddAthletesForm_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
