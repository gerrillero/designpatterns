using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.editor
{
    public class BoldCommand : IUndoableActionCommand
    {
        private string prevContent;
        private HtmlDocument document;
        private History history;

        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void Execute()
        {
            prevContent = document.Content;
            document.MakeBold();
            history.Push(this);
        }

        public void Unexecute()
        {
            document.Content = prevContent;
        }
    }
}
