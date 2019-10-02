using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.TravelStrategies
{
    public class Car : TravelStrategy
    {
        public Car()
        {
            kilometerCost = 20;
        }

        public override decimal Drive(int kilometers)
        {
            return kilometerCost * kilometers;
        }
    }
}
