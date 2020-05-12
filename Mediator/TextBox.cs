namespace Mediator
{
    public class TextBox : UIControl
    {
        private string content;

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                owner.Changed(this);
            }
        }

        public TextBox(DialogBox owner)
            : base(owner)
        {

        }
    }
}
