using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var browserHistory = new BrowserHistory();
            browserHistory.Push("a");
            browserHistory.Push("b");
            browserHistory.Push("c");
            browserHistory.Push("d");
            browserHistory.Pop();

            var iterator = browserHistory.CreateIterator();

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }


        }
    }
}
