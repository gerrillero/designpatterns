using System;

namespace Observer
{
    public class SpreadSheet : IObserver
    {
        private readonly IDataSource _dataSource;

        public SpreadSheet(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("SpreadSheet Updated! DataSource value: " + _dataSource.Value);
        }
    }
}
