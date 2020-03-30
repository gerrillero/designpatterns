using System;

namespace StrategyMosh
{
    public class JpgCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compress {fileName} to jpg.");
        }
    }
}
