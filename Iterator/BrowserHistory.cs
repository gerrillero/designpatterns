using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public class BrowserHistory
    {
        private List<string> Urls { get; set; }

        public BrowserHistory()
        {
            Urls = new List<string>();
        }

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public string Pop()
        {
            var lastUrl = Urls.LastOrDefault();
            Urls.Remove(lastUrl);

            return lastUrl;
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }


        public class ListIterator : IIterator<string>
        {
            private readonly BrowserHistory browserHistory;
            private int index;

            public ListIterator(BrowserHistory browserHistory)
            {
                this.browserHistory = browserHistory;
            }

            public string Current()
            {
                return browserHistory.Urls.ElementAt(index);
            }

            public bool HasNext()
            {
                return (index < browserHistory.Urls.Count);
            }

            public void Next()
            {
                index++;
            }
        }


    }
}
