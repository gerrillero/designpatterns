using System;

namespace StrategyMosh.Exercise
{
    public class AesEncryptStrategy : IEncryptStrategy
    {
        public void Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using AES");
            Console.WriteLine(message);
        }
    }
}
