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
    public partial class ManageSportEventForm : Form1
    {
        public ManageSportEventForm()
        {
            InitializeComponent();
            this.lTitle.Text = "Sport Event";
        }


        public void Init()
        {
            Search(txtSportName.Text);
            dgvDatas.CellContentClick += DgvDatas_CellContentClick;
            dgvDatas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void DgvDatas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                //Remove
                if (MessageBox.Show("Are you sure remove this?", "Tips", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int sid = (int)dgvDatas.Rows[e.RowIndex].Cells[0].Value;
                        var sport = Uti.db.Sports.Find(sid);
                        Uti.db.MedalLists.RemoveRange(sport.MedalLists);
                        Uti.db.Sports.Remove(sport);
                        Uti.db.SaveChanges();
                        Search(txtSportName.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed!");
                    }
                }
            }
        }

        public void Search(string name)
        {
            dgvDatas.Columns.Clear();
            name = name.ToLower();
            var sports = Uti.db.Sports.ToList().Where(a => a.Name.ToLower().Contains(name)).Select(a => new {
                a.ID,
                a.Name,
                a.SportIcon,
                Remove = "Remove"
            }).ToList();
            dgvDatas.DataSource = sports;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.HeaderText = "SportIcon";
            imageColumn.DataPropertyName = imageColumn.HeaderText;
            imageColumn.DisplayIndex = 2;
            dgvDatas.Columns.Add(imageColumn);


            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Remove";
            linkColumn.DataPropertyName = linkColumn.HeaderText;
            linkColumn.ActiveLinkColor = Color.Red;
            linkColumn.LinkColor = Color.Red;
            linkColumn.VisitedLinkColor = Color.Red;
            linkColumn.DefaultCellStyle.ForeColor = Color.Red;
            dgvDatas.Columns.Add(linkColumn);


            dgvDatas.Columns[2].Visible = false;
            dgvDatas.Columns[3].Visible = false;

            
        }

        internal void LocationLastRow()
        {
            dgvDatas.Rows[dgvDatas.RowCount - 1].Selected = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtSportName.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddSportForm() { Owner = this }.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDatas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row!");
                return;

            }


            int aid = (int)dgvDatas.CurrentRow.Cells[0].Value;
            new AddSportForm(aid) { Owner = this }.Show();
        }

        private void ManageSportEventForm_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
