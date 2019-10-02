using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Strategies
{
    public class ExcelRegister : IRegister
    {
        public void Close()
        {
            Console.WriteLine("Closing Excel");
        }
    }
}
