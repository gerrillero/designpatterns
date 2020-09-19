using System;

namespace StrategyMosh.Exercise
{
    public class DesEncryptStrategy : IEncryptStrategy
    {
        public void Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using DES");
            Console.WriteLine(message);
        }
    }
}
