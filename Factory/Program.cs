using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory();
            var connection = factory.GetConnection(Engine.MSSQL);
            connection.Connect();

            connection = factory.GetConnection(Engine.MongoDB);
            connection.Connect();

            Console.ReadLine();
        }
    }
}
