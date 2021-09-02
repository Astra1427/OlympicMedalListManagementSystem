using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
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
    public partial class PublishNewsForm : Form1
    {
        public PublishNewsForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Please input the title!");
                return;
            }
            if (txtContent.Text.Trim() == "")
            {
                MessageBox.Show("Please input the content!");
                return;
            }
            if (ChosenSport == null)
            {
                MessageBox.Show("Please Choose Sport!");
                return;
            }

            try
            {
                Uti.db.News.Add(new News
                {
                    Title = txtTitle.Text,
                    NewsContent = txtContent.Rtf,
                    NewsContentPreview = (txtContent.Text.Length > 30 ? txtContent.Text.Substring(0, 30) : txtContent.Text) + "...",
                    PublishTime = DateTime.Now,
                    AuthorID = Uti.LoggedAccount.ID,
                    SportID = ChosenSport.ID,
                    GoldNews = cbGoldNews.Checked
                    
                });
                Uti.db.SaveChanges();

                //var hubConnection = new HubConnection("http://localhost:57601/");
                //var chat = hubConnection.CreateHubProxy("notificationHub");
                //chat.On<string, string>("addNewMessageToPage",(name,message)=> {
                //    MessageBox.Show(message,name);
                //});

                //hubConnection.Start().Wait();
                //chat.Invoke("notificationMessage","New ID",Uti.db.News.ToList().LastOrDefault().ID.ToString());

                try
                {
                    //Notification all client
                    SignalRHelper signal = new SignalRHelper();
                    string json  = JsonConvert.SerializeObject(Uti.db.News.ToList().LastOrDefault());
                    signal.SendMessage(cbGoldNews.Checked ? 1 : 0, json);
                }
                catch (Exception ex)
                {

                }

                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Publish Failed!");
            }


            if (this.Owner is NewsListForm nlf)
            {
                nlf.Search("","");
                nlf.LocationLastRow();
            }
        }


        public Sport ChosenSport { get; set; }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            var chooseSportForm = new ChooseSportForm() { Owner = this };
            if (chooseSportForm.ShowDialog() == DialogResult.OK)
            {
                ChosenSport = Uti.db.Sports.Find(chooseSportForm.ReturnID);
                if (ChosenSport == null)
                {
                    MessageBox.Show("The Sport is Undefind!\nPlease rechoose!");
                    return;
                }
                if (!lSportName.Visible)
                {
                    lSportName.Visible = true;
                    pbSportIcon.Visible = true;
                }

                lSportName.Text = ChosenSport.Name;
                using (MemoryStream ms = new MemoryStream(ChosenSport.SportIcon))
                {
                    pbSportIcon.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
