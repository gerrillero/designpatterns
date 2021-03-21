using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new NotificationServer();
            var connection = server.Connect("0.0.0.0");
            var authentification = server.Authecticate("appID", "key");
            var message = new Message("message content");
            server.Send(authentification, message, "target1");
            connection.Disconnect();

        }
    }
}
