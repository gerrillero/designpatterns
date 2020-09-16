using System;

namespace State.Exercise
{
    public class TransitState : ITravelState
    {
        public int GetDiretion()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }
    }
}
