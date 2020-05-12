using System;

namespace Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox articlesListbox;
        private TextBox titleTexbox;
        private Button saveButton;

        public ArticlesDialogBox()
        {
            articlesListbox = new ListBox(this);
            titleTexbox = new TextBox(this);
            saveButton = new Button(this);
        }


        public void SimulateUserInteraction()
        {
            articlesListbox.Selection = "Artivle 1";
            //titleTexbox.Content = "";
            //titleTexbox.Content = "Article 2";
            Console.WriteLine("TextBox: " + titleTexbox.Content);
            Console.WriteLine("Button: " + saveButton.IsEnabled);
        }

        public override void Changed(UIControl control)
        {
            if (control == articlesListbox)
                ArticleSelected();
            else if (control == titleTexbox)
                TitleSelected();
        }

        private void TitleSelected()
        {
            var content = titleTexbox.Content;
            var isEmpty = string.IsNullOrEmpty(content);
            saveButton.IsEnabled = !isEmpty;

        }

        private void ArticleSelected()
        {
            titleTexbox.Content = articlesListbox.Selection;
            saveButton.IsEnabled = true;
        }
    }
}
