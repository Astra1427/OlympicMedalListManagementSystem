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
    public partial class EditCountryForm : Form1
    {
        public EditCountryForm(int cid,int rindex)
        {
            InitializeComponent();
            lTitle.Text = "Edit";
            CurrentCountry = Uti.db.Countries.FirstOrDefault(a=>a.ID == cid);
            IsNoTips = false;
            this.rindex = rindex;
        }

        public Country CurrentCountry { get; set; }
        public int rindex { get; set; }
        public void Init()
        {
            txtCountryName.Text = CurrentCountry.Name;
            txtFlag.Text = CurrentCountry.Flag;
            if (CurrentCountry.FlagImg != null)
            {
                using (MemoryStream ms = new MemoryStream(CurrentCountry.FlagImg))
                {
                    pbFlag.Image = Image.FromStream(ms);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCountryName.Text.Trim() =="")
            {
                MessageBox.Show("Please input the Country Name!");
                return;
            }
            try
            {
                CurrentCountry.Name = txtCountryName.Text;
                CurrentCountry.Flag = txtFlag.Text;
                using (MemoryStream ms = new MemoryStream())
                {
                    Bitmap bitmap = new Bitmap(pbFlag.Image);
                    bitmap.Save(ms, pbFlag.Image.RawFormat);
                    CurrentCountry.FlagImg = ms.ToArray();
                }
                Uti.db.SaveChanges();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit Failed!\nPlease check all data and try again!");
            }
            if (Owner is ManageCountryForm mcf)
            {
                mcf.Search("");
                mcf.LocationRow(rindex);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture|*.png;*.jpg;*.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtFlag.Text = openFile.FileName;
                pbFlag.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void EditCountryForm_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
