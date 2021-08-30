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
    public partial class MedalListForm : Form1
    {
        public MedalListForm()
        {
            InitializeComponent();
            this.lTitle.Text = "Medal List";
        }

        public void Init()
        {
            SearchCountries(txtCountryName.Text);
            SearchAthletes(txtAthlete.Text);

            dgvCountries.SelectionChanged += DgvCountries_SelectionChanged;

            pMiddleLine.SendToBack();
        }

        private void DgvCountries_SelectionChanged(object sender, EventArgs e)
        {
            if (!IsLimit)
            {
                return;
            }
            if (dgvCountries.SelectedRows.Count == 0)
            {
                return;
            }

            SearchAthletes(txtAthlete.Text, (int)dgvCountries.CurrentRow.Cells[0].Value);
        }

        public void SearchCountries(string name = "")
        {
            name = name.ToLower();
            dgvCountries.Columns.Clear();
            var countries = Uti.db.Countries.ToList().Where(a => a.Name.ToLower().Contains(name)).Select(a=>new { 
                a.ID,
                a.Name,
                a.FlagImg,
                Gold = a.Athletes.Sum(x=>x.MedalLists.Count(m=>m.MedalType == 1)),
                Silver = a.Athletes.Sum(x=>x.MedalLists.Count(m=>m.MedalType == 2)),
                Bronze = a.Athletes.Sum(x=>x.MedalLists.Count(m=>m.MedalType == 3)),
                //MedalCount = a.Athletes.Sum(x=>x.MedalLists.Count())
            }).ToList();

            dgvCountries.DataSource = countries;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Flag";
            imageColumn.DataPropertyName = "FlagImg";
            imageColumn.DisplayIndex = 2;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvCountries.Columns.Add(imageColumn);
            dgvCountries.Columns[2].Visible = false;
            for (int i = 0; i < dgvCountries.ColumnCount; i++)
            {
                dgvCountries.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }
        public void SearchAthletes(string name = "",int countryID = 0)
        {
            name = name.ToLower();
            dgvAthletes.Columns.Clear();
            dgvAthletes.Columns.Clear();

            var athletes = Uti.db.Athletes.ToList().Where(a => a.Name.ToLower().Contains(name) && (countryID == 0 ? true : (a.CountryID == countryID))).Select(a => new {
                a.ID,
                a.Name,
                a.PortraitImg,
                Gold = a.MedalLists.Count(x=>x.MedalType == 1),
                Silver = a.MedalLists.Count(x=>x.MedalType == 2),
                Bronze = a.MedalLists.Count(x=>x.MedalType == 3),
                //MedalCount = a.MedalLists.Count
            }).ToList();

            dgvAthletes.DataSource = athletes;
            lTotalNumbersAthletes.Text = $"The total numbers of athletes is {athletes.Count}";

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Portrait";
            imageColumn.DataPropertyName = "PortraitImg";
            imageColumn.DisplayIndex = 2;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvAthletes.Columns.Add(imageColumn);
            dgvAthletes.Columns[2].Visible = false;

            for (int i = 0; i < dgvAthletes.ColumnCount; i++)
            {
                dgvAthletes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            
        }




        private void btnSearchCountry_Click(object sender, EventArgs e)
        {
            SearchCountries(txtCountryName.Text);
        }

        private void btnSearchAthlete_Click(object sender, EventArgs e)
        {
            SearchAthletes(txtAthlete.Text,IsLimit ? ((int)dgvCountries.CurrentRow.Cells[0].Value):0);
        }

        private void MedalListForm_Load(object sender, EventArgs e)
        {
            Init();
        }


        public bool IsLimit = false;
        private void btnLimitSwitch_Click(object sender, EventArgs e)
        {
            IsLimit = !IsLimit;
            if (IsLimit)
            {
                btnLimitSwitch.BackColor = Color.LightBlue;

                if (dgvCountries.SelectedRows.Count == 0)
                {
                    return;
                }
                SearchAthletes(txtAthlete.Text,(int)dgvCountries.CurrentRow.Cells[0].Value);
            }
            else
            {
                btnLimitSwitch.BackColor = Color.White;
                SearchAthletes(txtAthlete.Text);
            }
        }

        private void txtCountryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCountryName.Text.Trim() == "")
            {
                SearchCountries();
            }
        }

        private void txtAthlete_TextChanged(object sender, EventArgs e)
        {
            if (txtAthlete.Text.Trim() == "")
            {
                SearchAthletes();
            }
        }

        private void btnAddMedal_Click(object sender, EventArgs e)
        {
            if (dgvAthletes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a  athlete!");
                return;
            }

            if (dgvAthletes.SelectedRows .Count == 1)
            {
                new AddMedalForm((int)dgvAthletes.CurrentRow.Cells[0].Value) { Owner = this }.Show();
            }
            else
            {

                int[] aids = new int[dgvAthletes.SelectedRows.Count];
                for (int i = 0; i < dgvAthletes.SelectedRows.Count; i++)
                {
                    aids[i] = (int)dgvAthletes.SelectedRows[i].Cells[0].Value;
                }
                new AddMedalForm(aids) { Owner = this }.Show();
            }
        }
    }
}
