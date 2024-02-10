using System;

namespace Adapter.ThirdPartFilters
{
    public class Caramel
    {
        public void Init()
        {
            // Method intentionally left empty.
        }

        public void Render(Image image)
        {
            Console.WriteLine("Caramel filter applied!");
        }
    }
}
