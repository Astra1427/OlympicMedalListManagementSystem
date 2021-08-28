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
    public partial class AddSportForm : Form1
    {
        public AddSportForm()
        {
            InitializeComponent();

        }
        public Sport CurrentSport { get; set; }
        public AddSportForm(int aid)
        {
            InitializeComponent();
            CurrentSport = Uti.db.Sports.Find(aid);
        }

        public void Init()
        {
            if (CurrentSport == null)
            {
                //Add
                this.lTitle.Text = "Add Sport";
                return;
            }
            //Edit

            txtSportName.Text = CurrentSport.Name;
            using (MemoryStream ms = new MemoryStream(CurrentSport.SportIcon))
            {
                pbIcon.Image = Image.FromStream(ms);
            }
            txtIcon.Visible = false;
            btnAdd.Text = "Save";
            this.lTitle.Text = "Edit Sport";

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture|*.png;*.jpg;*.gif";
            if (openFile.ShowDialog () == DialogResult.OK)
            {

                pbIcon.Image = Image.FromFile(openFile.FileName);
                txtIcon.Text = openFile.FileName;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSportName.Text.Trim() == "")
            {
                MessageBox.Show("Please input the Sport name");
                return;
            }

            if (CurrentSport == null)
            {
                Add();
            }
            else
            {
                Edit();
            }

            if (this.Owner is ManageSportEventForm msef)
            {
                msef.Search("");
                msef.LocationLastRow();
            }

        }

        public void Add()
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {

                    Bitmap bitmap = new Bitmap(pbIcon.Image);
                    bitmap.Save(ms, pbIcon.Image.RawFormat);
                    Uti.db.Sports.Add(new Sport
                    {
                        Name = txtSportName.Text,
                        SportIcon = ms.ToArray(),
                    });
                }
                Uti.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!");
            }
        }

        public void Edit()
        {
            try
            {
                CurrentSport.Name = txtSportName.Text;
                using (MemoryStream ms = new MemoryStream())
                {

                    Bitmap bitmap = new Bitmap(pbIcon.Image);
                    bitmap.Save(ms, pbIcon.Image.RawFormat);
                    CurrentSport.SportIcon = ms.ToArray();
                }
                Uti.db.SaveChanges();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!");
            }
        }

        private void AddSportForm_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
