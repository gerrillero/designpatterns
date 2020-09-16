namespace State.Exercise
{
    public class DirectionService
    {
        public ITravelState CurrentTravelState { get; set; }


        public DirectionService(ITravelState currentTravelState)
        {
            CurrentTravelState = currentTravelState;
        }

        public int GetEta()
        {
            return CurrentTravelState.GetEta();

        }

        public int GetDirection()
        {
            return CurrentTravelState.GetDiretion();
        }

    }

}
