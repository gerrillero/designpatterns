using System;

namespace Strategy.Behaviors
{
    public class ExcelStartegyBehavior : IApplicationBehavior
    {
        public void Close()
        {
            Console.WriteLine("Closing Excel application");
        }

        public void Open()
        {
            Console.WriteLine("Opening Excel application");
        }
    }
}
