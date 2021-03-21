using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class NotificationServer
    {
        //connect() -> Connection
        // authenticate(appID, key) -> AuthToken
        // send(authToken, message, target)
        // conn.Disconect()

        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authecticate(string appID, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine("Sended!");

        }
         
    }
}
