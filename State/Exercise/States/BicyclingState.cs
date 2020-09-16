using System;

namespace State.Exercise.States
{
    public class BicyclingState : ITravelState
    {
        public int GetDiretion()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }
    }
}
