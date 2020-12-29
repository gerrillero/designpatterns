using System;

namespace Observer
{
    public class Chart : IObserver
    {
        private readonly IDataSource _dataSource;

        public Chart(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Chart got updated, DataSource value: " + _dataSource.Value); ;
        }
    }
}
