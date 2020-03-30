using System;

namespace StrategyMosh
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void ApplyFilter(string fileName)
        {
            Console.WriteLine($"Applying Black and White filter to {fileName}.");
        }
    }
}
