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
    public partial class NewsListForm : Form1
    {
        public NewsListForm()
        {
            InitializeComponent();
        }

        public void Init()
        {
             //Uti.db.News;
        }
        public void Search(string title,string content)
        {
            title = title.ToLower();
            content = content.ToLower();
            var news = Uti.db.News.ToList().Where(a=>a.Title.ToLower().Contains(title) && a.NewsContent.ToLower().Contains(content)).Select(a=>new { 
                
                a.AuthorID,
                a.ID,
                a.Title,
                Content = a.NewsContent,
                a.PublishTime,
                Author = a.Account.Name,
                Remove = "Remove"
            }).ToList();

            dgvDatas.DataSource = news;

            dgvDatas.Columns[0].Visible = false;
            dgvDatas.Columns[1].Visible = false;


            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Remove";
            linkColumn.DataPropertyName = "Remove";
            linkColumn.ActiveLinkColor = Color.Red;
            linkColumn.LinkColor = Color.Red;
            linkColumn.VisitedLinkColor = Color.Red;
            linkColumn.DefaultCellStyle.ForeColor = Color.Red;

            dgvDatas.Columns.Add(linkColumn);
            dgvDatas.Columns[7].Visible = false;

            for (int i = 0; i < news.Count; i++)
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
    }
}
