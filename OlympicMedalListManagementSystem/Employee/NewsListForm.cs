using OlympicMedalListManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace OlympicMedalListManagementSystem.Employee
{
    public partial class NewsListForm : Form1
    {
        public NewsListForm()
        {
            InitializeComponent();
        }

        public void Init()
        {
            //Uti.db.News;
            Search("","");
            dgvDatas.CellContentClick += DgvDatas_CellContentClick;
        }

        private void DgvDatas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == 7)
            {
                //Remove News
                if (MessageBox.Show("Are you sure Remove this news?", "Tips", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {

                        int nid = (int)dgvDatas.Rows[e.RowIndex].Cells[1].Value;
                        Uti.db.News.Remove(Uti.db.News.Find(nid));
                        Uti.db.SaveChanges();
                        MessageBox.Show("Success!");
                        Search("","");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed!");
                    }
                }
            }
        }

        /// <summary>
        /// Search News
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        public void Search(string title,string content)
        {
            title = title.ToLower();
            content = content.ToLower();
            dgvDatas.Columns.Clear();
            var news = Uti.db.News.ToList().Where(a=>a.Title.ToLower().Contains(title) && Uti.RtfToPlainText(a.NewsContent).ToLower().Contains(content)).Select(a=>new { 
                
                a.AuthorID,
                a.ID,
                a.Title,
                Content = a.NewsContentPreview.Length > 15 ? a.NewsContentPreview.Substring(0,15) : a.NewsContentPreview,
                a.PublishTime,
                Author = a.Account.Name,
                Remove = "Remove"
            }).ToList();

            dgvDatas.DataSource = news;

            dgvDatas.Columns[0].Visible = false;
            dgvDatas.Columns[1].Visible = false;

            dgvDatas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Remove";
            linkColumn.DataPropertyName = "Remove";
            linkColumn.ActiveLinkColor = Color.Red;
            linkColumn.LinkColor = Color.Red;
            linkColumn.VisitedLinkColor = Color.Red;
            linkColumn.DefaultCellStyle.ForeColor = Color.Red;

            dgvDatas.Columns.Add(linkColumn);
            dgvDatas.Columns[6].Visible = false;

            for (int i = 0; i < dgvDatas.Columns.Count; i++)
            {
                dgvDatas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new PublishNewsForm { Owner = this }.Show();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtTitle.Text,txtContent.Text);
        }


        public void LocationLastRow()
        {
            dgvDatas.Rows[dgvDatas.RowCount - 1].Selected = true;
        }

        private void NewsListForm_Load(object sender, EventArgs e)
        {
            Init();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDatas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row!");
                return;
            }
            int nid = (int)dgvDatas.CurrentRow.Cells[1].Value;
            new EditNewsForm(nid) { Owner = this }.Show();

        }
    }
}
