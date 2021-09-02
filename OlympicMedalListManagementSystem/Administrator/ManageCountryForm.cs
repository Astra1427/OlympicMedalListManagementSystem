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
    public partial class ManageCountryForm : Form1
    {
        public ManageCountryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Init data and controls
        /// </summary>
        public void Init()
        {
            dgvDatas.SelectionChanged += DgvDatas_SelectionChanged;
            Search(txtCountryName.Text);
            dgvDatas.CellContentClick += DgvDatas_CellContentClick;
        }

        private void DgvDatas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 6)
            {
                //Remove
                if (MessageBox.Show("Are you sure remove this?","Tips",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int cid = (int)dgvDatas.Rows[e.RowIndex].Cells[0].Value;
                        var country = Uti.db.Countries.Find(cid);
                        Uti.db.Athletes.RemoveRange(country.Athletes);
                        Uti.db.Countries.Remove(country);
                        Uti.db.SaveChanges();
                        Search(txtCountryName.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed!");
                    }
                }
            }
        }

        private void DgvDatas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatas.SelectedRows.Count != 0)
            {
                btnMangeAthlete.Visible = true;

                btnMangeAthlete.Text = $"Add athletes for {dgvDatas.SelectedRows[0].Cells[2].Value}";

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtCountryName.Text);
        }

        public void Search(string countryName)
        {
            if (countryName.Trim() =="")
            {
                //Search All
            }

            dgvDatas.Columns.Clear();

            //Search by filter

            var countries = Uti.db.Countries.Where(a => a.Name.ToLower().Contains(countryName)).Select(a=>new { 
                a.ID,
                a.FlagImg,
                CountryName = a.Name,
                AthleteCount = a.Athletes.Count,
                Remove="Remove"
            }).ToList();

            dgvDatas.DataSource = countries;

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imgColumn.DataPropertyName = "FlagImg";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgColumn.HeaderText = "Flag";
            imgColumn.DisplayIndex = 1;
            dgvDatas.Columns.Add(imgColumn);

            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Remove";
            linkColumn.DataPropertyName = "Remove" ;
            linkColumn.DefaultCellStyle.ForeColor = Color.Red;
            linkColumn.ActiveLinkColor = Color.Red;
            linkColumn.LinkColor = Color.Red;
            linkColumn.VisitedLinkColor = Color.Red;
            dgvDatas.Columns.Add(linkColumn);


            dgvDatas.Columns[1].Visible = false;
            dgvDatas.Columns[4].Visible= false;

            //dgvDatas.RowTemplate.Resizable = DataGridViewTriState.True;
            //dgvDatas.RowTemplate.Height = 100;
            for (int i = 0; i < dgvDatas.ColumnCount; i++)
            {
                dgvDatas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvDatas.Columns[2].HeaderText = "Country Name";
            dgvDatas.Columns[3].HeaderText = "Total number of athletes";
        }

        public void LocationLastRow()
        {
            dgvDatas.ClearSelection();
            dgvDatas.Rows[dgvDatas.RowCount - 1].Selected = true;
        }
        public void LocationRow(int index)
        {
            dgvDatas.ClearSelection();
            dgvDatas.Rows[index].Selected = true;
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            new AddCountryForm() { Owner = this }.Show();
        }

        private void txtCountryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCountryName.Text.Trim() == "")
            {
                Search(txtCountryName.Text);
            }
        }

        private void ManageCountryForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnEditCountry_Click(object sender, EventArgs e)
        {
            if (dgvDatas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a country!");
                return;
            }
            int cid = (int)dgvDatas.SelectedRows[0].Cells[0].Value;

            new EditCountryForm(cid, dgvDatas.CurrentRow.Index) { Owner = this }.Show();
        }

        private void btnMangeAthlete_Click(object sender, EventArgs e)
        {
            if (dgvDatas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a country!");
                return;
            }
            int cid = (int)dgvDatas.SelectedRows[0].Cells[0].Value;
            new ManageAthletesForm(cid) { Owner = this }.Show();
            this.Hide();
        }
    }
}
