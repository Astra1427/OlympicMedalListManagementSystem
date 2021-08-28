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
    public partial class ManageAthletesForm : Form1
    {
        public Country CurrentCountry { get; set; }
        public ManageAthletesForm(int cid)
        {
            InitializeComponent();
            CurrentCountry = Uti.db.Countries.FirstOrDefault(a=>a.ID == cid);
            lTitle.Text = $"Manage Athletes - {CurrentCountry.Name}";
        }

        public void Init()
        {
            Search(txtCountryName.Text);
            dgvDatas.CellContentClick += DgvDatas_CellContentClick;
        }

        private void DgvDatas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Are you sure remove this?", "Tips", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int aid = (int)dgvDatas.Rows[e.RowIndex].Cells[0].Value;
                        Uti.db.Athletes.Remove(Uti.db.Athletes.Find(aid));
                        Uti.db.SaveChanges();
                        MessageBox.Show("Success!");
                        Search("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed!");
                    }

                }
                
            }
        }

        private void AddAthlete_Click(object sender, EventArgs e)
        {
            new AddAthletesForm(CurrentCountry.ID) { Owner = this }.Show();
        }

        public void Search(string name)
        {
            name = name.ToLower();
            var athletes = Uti.db.Athletes.ToList().Where(a => a.Name.ToLower().Contains(name) && a.CountryID == CurrentCountry.ID).Select(a => new
            {
                a.ID,
                a.PortraitImg,
                a.Name,
                Sex = a.Sex ? "Male" : "Female",
                Birthdate = a.Birthdate.ToString("yyyy-MM-dd"),
                Country = a.Country.Name,
                Remove = "Remove"
            }).ToList() ;

            dgvDatas.Columns.Clear();
            dgvDatas.DataSource = athletes;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Portrait";
            imageColumn.DataPropertyName = "PortraitImg";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.DisplayIndex = 1;
            dgvDatas.Columns.Add(imageColumn);

            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.DataPropertyName = "Remove";
            linkColumn.HeaderText = linkColumn.DataPropertyName;
            linkColumn.ActiveLinkColor = Color.Red;
            linkColumn.LinkColor = Color.Red;
            linkColumn.VisitedLinkColor = Color.Red;
            linkColumn.DefaultCellStyle.ForeColor = Color.Red;
            dgvDatas.Columns.Add(linkColumn);

            dgvDatas.Columns[1].Visible = false;
            dgvDatas.Columns[6].Visible = false;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtCountryName.Text);
        }

        private void txtCountryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCountryName.Text .Trim() =="")
            {
                Search("");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "csv file|*.csv";
            if (openFile.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    var lines = File.ReadAllLines(openFile.FileName);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        //lines[i].
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read file failed!\nPlease try again!");
                }
            }
        }

        public void LocationLastRow()
        {
            dgvDatas.Rows[dgvDatas.RowCount - 1].Selected = true;
        }

        private void ManageAthletesForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnEditAthlete_Click(object sender, EventArgs e)
        {
            if (dgvDatas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row!");
                return;
            }

            int aid = (int)dgvDatas.CurrentRow.Cells[0].Value;
            new EditAthleteForm(aid) { Owner = this }.Show();

            
        }
    }
}
