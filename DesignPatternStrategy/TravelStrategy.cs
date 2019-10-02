using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy
{
    public abstract class TravelStrategy
    {
        public int kilometerCost;
        public abstract decimal Drive(int kilometers);
    }
}
