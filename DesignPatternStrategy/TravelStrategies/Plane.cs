using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.TravelStrategies
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            kilometerCost = 100;
        }

        public override decimal Drive(int kilometers)
        {
            if (kilometers > 100)
            {
                kilometerCost = 80;
            }

            return kilometerCost * kilometers;
        }
    }
}
