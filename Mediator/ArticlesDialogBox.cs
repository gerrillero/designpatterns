using System;

namespace Mediator
{
    public class ArticlesDialogBox
    {
        private ListBox articlesListbox = new ListBox();
        private TextBox titleTexbox = new TextBox();
        private Button saveButton = new Button();

        public ArticlesDialogBox()
        {

        }


        public void SimulateUserInteraction()
        {
            articlesListbox.Selection = "Artivle 1";
            //titleTexbox.Content = "";
            //titleTexbox.Content = "Article 2";
            Console.WriteLine("TextBox: " + titleTexbox.Content);
            Console.WriteLine("Button: " + saveButton.IsEnabled);
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
