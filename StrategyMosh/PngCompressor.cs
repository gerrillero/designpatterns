using System;

namespace StrategyMosh
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compress {fileName} to png.");
        }
    }
}
