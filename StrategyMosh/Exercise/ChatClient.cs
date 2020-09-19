using System;

namespace StrategyMosh.Exercise
{
    public class ChatClient
    {

        public void Send(String message, IEncryptStrategy encryptStrategy)
        {
            encryptStrategy.Encrypt(message);
            Console.WriteLine("Sending the encrypted message...");
        }
    }

}
