using Strategy.Behaviors;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = new WordApplication(new WordStrategyBehavior());

            application.PerformOpen();
            application.PerformClose();

            var application2 = new ExcelApplication(new ExcelStartegyBehavior());

            application2.PerformOpen();
            application2.PerformClose();
        }
    }
}
