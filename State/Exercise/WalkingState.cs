using System;

namespace State.Exercise
{
    public class WalkingState : ITravelState
    {
        public int GetDiretion()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return 4;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating Direction (walking)");
            return 4;
        }
    }
}
