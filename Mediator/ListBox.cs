namespace Mediator
{
    public class ListBox : UIControl
    {
        private string selection;

        public string Selection
        {
            get { return selection; }
            set
            {
                selection = value;
                OnControlChanged();
            }
        }
    }
}
