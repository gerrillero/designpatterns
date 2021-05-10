using System;

namespace Factory
{
    internal class MySQLConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connect to MySQL");
        }
    }
}