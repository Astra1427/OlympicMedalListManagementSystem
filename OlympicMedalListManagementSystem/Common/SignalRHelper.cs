using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicMedalListManagementSystem.Common
{
    public class SignalRHelper
    {
        public const string NotificationMessage = "notificationMessage";
        public const string NotificationProxy = "notificationHub";

        private HubConnection Hub { get; set; }
        private IHubProxy Chat { get; set; }
        public SignalRHelper(string address = "http://localhost:56443/")
        {
            Hub = new HubConnection(address);
            Chat = Hub.CreateHubProxy(NotificationProxy);
            Hub.Start().Wait();
        }

        public void SendMessage(string name,string message)
        {
            Chat.On<string, string>("addNewMessageToPage",(n,m)=> {
                //Do something...
            });
            Chat.Invoke(NotificationMessage,name,message);
        }

    }
}
