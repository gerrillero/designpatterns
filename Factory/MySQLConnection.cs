using System;

namespace Factory
{
    internal class MySqlConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connect to MySQL");
        }
    }
}