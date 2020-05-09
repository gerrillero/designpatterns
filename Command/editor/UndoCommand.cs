using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.editor
{
    public class UndoCommand : IActionCommand
    {
        private readonly History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if (history.Size() > 0)
                history.Pop().Unexecute();
        }
    }
}
