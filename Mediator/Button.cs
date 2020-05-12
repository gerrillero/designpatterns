namespace Mediator
{
    public class Button : UIControl
    {
        private bool isEnabled;
        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                isEnabled = value;
                owner.Changed(this);
            }
        }

        public Button(DialogBox owner)
            : base(owner)
        {

        }
    }
}
