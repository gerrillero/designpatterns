using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("0.0.0.0");
            var authentification = server.Authecticate("appID", "key");

            server.Send(authentification, new Message(message), target);
            connection.Disconnect();
        }
    }
}
