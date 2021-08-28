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
    public partial class AddMedalForm : Form1
    {
        public Athlete CurrentAthlete { get; set; }
        public AddMedalForm(int aid)
        {
            InitializeComponent();
            CurrentAthlete = Uti.db.Athletes.Find(aid);
        }

        public Athlete[] CurrentAthletes { get; set; }
        public AddMedalForm(int[] aids)
        {
            InitializeComponent();
            CurrentAthletes = new Athlete[aids.Length];
            for (int i = 0; i < aids.Length; i++)
            {
                CurrentAthletes[i] = Uti.db.Athletes.Find(aids[i]);
            }
        }

        public void Init()
        {
            
            lAthleteName.Text  = CurrentAthlete.Name;
            using (MemoryStream ms = new MemoryStream(CurrentAthlete.PortraitImg))
            {
                pbPortrait.Image = Image.FromStream(ms);
            }

            cbSport.DataSource = Uti.db.Sports.ToList();
            cbSport.DisplayMember = "Name";
            cbSport.ValueMember = "ID";

            cbMedalType.SelectedIndex = 0;
            


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentAthlete != null)
                {
                    Uti.db.MedalLists.Add(new MedalList
                    {
                        MedalType = cbMedalType.SelectedIndex + 1,
                        SportID = (int)cbSport.SelectedValue,
                        AthleteID = CurrentAthlete.ID,
                        ConfirmTime = dtpTime.Value,
                    });
                    Uti.db.SaveChanges();
                    MessageBox.Show("Success!");
                    return;
                }

                for (int i = 0; i < CurrentAthletes.Length; i++)
                {
                    Uti.db.MedalLists.Add(new MedalList
                    {
                        MedalType = cbMedalType.SelectedIndex + 1,
                        SportID = (int)cbSport.SelectedValue,
                        AthleteID = CurrentAthletes[i].ID,
                        ConfirmTime = dtpTime.Value,
                    });
                }
                Uti.db.SaveChanges();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Failed!");
            }

        }

        private void AddMedalForm_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
