using System;

namespace State.Exercise.States
{
    public class DrivingState : ITravelState
    {
        public int GetDiretion()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }
    }
}
