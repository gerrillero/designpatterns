using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behaviors
{
    public class WordStrategyBehavior : IApplicationBehavior
    {
        public void Close()
        {
            Console.WriteLine("Closing Word application");
        }

        public void Open()
        {
            Console.WriteLine("Opening Word application");
        }
    }
}
