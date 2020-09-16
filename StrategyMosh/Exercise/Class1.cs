using System;

namespace StrategyMosh.Exercise
{
    public class ChatClient
    {
        private String encryptionAlgorithm;

        public ChatClient(String encryptionAlgorithm)
        {
            this.encryptionAlgorithm = encryptionAlgorithm;
        }

        public void send(String message)
        {
            if (encryptionAlgorithm == "DES")
                Console.WriteLine("Encrypting message using DES");
            else if (encryptionAlgorithm == "AES")
                Console.WriteLine("Encrypting message using AES");
            else
                throw new InvalidOperationException("Unsupported encryption algorithm");

            Console.WriteLine("Sending the encrypted message...");
        }
    }

}
