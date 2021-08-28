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
    public partial class AddCountryForm : Form1
    {
        public AddCountryForm()
        {
            InitializeComponent();
            lTitle.Text = "Add Country";
            IsNoTips = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCountryName.Text.Trim() =="")
            {
                MessageBox.Show("Plase input the country name!");
                return;
            }
            try
            {

                using (MemoryStream ms = new MemoryStream())
                {
                    pbFlag.Image.Save(ms, pbFlag.Image.RawFormat);
                    Uti.db.Countries.Add(new Country
                    {
                        Name = txtCountryName.Text,
                        Flag = txtFlag.Text,
                        FlagImg = ms.ToArray()
                    });
                    Uti.db.SaveChanges();

                }
                //MessageBox.Show("Success!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Failed!\n Please check data and try again!");
            }

            if (this.Owner is ManageCountryForm mcf)
            {
                mcf.Search("");
                mcf.LocationLastRow();
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
    }
}
