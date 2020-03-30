using System;

namespace StrategyMosh
{
    public class ColorFiler : IFilter
    {
        public void ApplyFilter(string fileName)
        {
            Console.WriteLine($"Applying Color filter to {fileName}.");
        }
    }
}
