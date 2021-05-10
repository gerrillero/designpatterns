using System;

namespace Factory
{
    internal class MongoDBConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connect to MongoDB");
        }
    }
}