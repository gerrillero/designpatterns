using DesignPatternStrategy.Strategies;
using DesignPatternStrategy.TravelStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var travelPlaner = new TravelPlanner();
            travelPlaner.SetTravelStrategy(new Car());
            travelPlaner.Drive(20);

            var register = new RegisterContext(new ExcelRegister());
            register.Close();

            register.SetRegister(new WordRegister());
            register.Close();

            // test

            // master


            Console.ReadKey();
        }
    }
}
