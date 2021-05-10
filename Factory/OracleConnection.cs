using System;

namespace Factory
{
    internal class OracleConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connect to Oracle");
        }
    }
}