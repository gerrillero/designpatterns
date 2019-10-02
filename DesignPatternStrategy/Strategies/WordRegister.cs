using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Strategies
{
    public class WordRegister : IRegister
    {
        public void Close()
        {
            Console.WriteLine("Closing Word");
        }
    }
}
