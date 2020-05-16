namespace Mediator
{
    public class ListBox : UIControl, IEventHandler
    {
        private string selection;

        public string Selection
        {
            get { return selection; }
            set
            {
                selection = value;
                NotityObservers();
            }
        }

        public void Handle()
        {
            
        }
    }
}
