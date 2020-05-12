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
                owner.Changed(this);
            }
        }


        public ListBox(DialogBox owner)
            : base(owner)
        {

        }
    }
}
