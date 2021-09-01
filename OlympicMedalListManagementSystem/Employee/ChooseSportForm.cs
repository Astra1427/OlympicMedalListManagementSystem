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
    public partial class ChooseSportForm : Form1
    {
        public ChooseSportForm()
        {
            InitializeComponent();
            this.lTitle.Text = "Choose Sport Item";
            IsNoTips = true;
        }

        private void ChooseSportForm_Load(object sender, EventArgs e)
        {
            var sports = Uti.db.Sports.ToList();
            Label[] lSports = new Label[sports.Count];
            for (int i = 0; i < sports.Count; i++)
            {
                using (MemoryStream ms = new MemoryStream(sports[i].SportIcon))
                {
                    lSports[i] = new Label {
                        Text = sports[i].Name, 
                        Image = Image.FromStream(ms), 
                        AutoSize = false, Width = lDemo.Width, Height = lDemo.Height, 
                        TextAlign = ContentAlignment.BottomCenter, ImageAlign = ContentAlignment.TopCenter,
                        Cursor = Cursors.Hand,
                        Tag = sports[i].ID
                    };
                    lSports[i].Click += lSport_Clicked;
                }
            }


            flpSports.SuspendLayout();
            flpSports.Controls.AddRange(lSports);
            flpSports.ResumeLayout();
        }

        public int ReturnID { get; set; }

        public void lSport_Clicked(object sender,EventArgs e)
        {
            if (sender is Label sport)
            {
                ReturnID = (int)sport.Tag;
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
