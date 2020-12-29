using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new DataSource();
            dataSource.AddObserver(new Chart(dataSource));
            dataSource.AddObserver(new SpreadSheet(dataSource));

            dataSource.Value = 5;
            dataSource.Value = 3;

            Console.ReadKey();
        }
    }
}
