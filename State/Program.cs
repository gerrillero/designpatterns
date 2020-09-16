using State.Exercise;
using State.Exercise.States;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //var canvas = new Canvas();
            //canvas.CurrentTool = new BrushTool();
            //canvas.MouseDown();
            //canvas.MouseUp();

            //canvas.CurrentTool = new EraserTool();
            //canvas.MouseDown();
            //canvas.MouseUp();

            var directionService = new DirectionService(new WalkingState());
            Console.WriteLine(directionService.CurrentTravelState);
            directionService.GetEta();
            directionService.GetDirection();
            directionService.CurrentTravelState = new BicyclingState();
            Console.WriteLine(directionService.CurrentTravelState);
            directionService.GetEta();
            directionService.GetDirection();
        }
    }
}
