namespace Observer
{
    public interface IDataSource
    {
        int Value { get; set; }
    }
    public class DataSource : Subject, IDataSource
    {
        private int value;

        public int Value
        {
            get { return value; }
            set
            {
                this.value = value;
                NotifyObservers();
            }
        }

    }
}
