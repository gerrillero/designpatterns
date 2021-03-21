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
            var notificationService = new NotificationService();
            notificationService.Send("Message content", "Target 1");

            Console.ReadLine();
        }
    }
}
