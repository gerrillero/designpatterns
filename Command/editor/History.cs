using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.editor
{
    public class History
    {
        private Stack<IUndoableActionCommand> commands = new Stack<IUndoableActionCommand>();

        public void Push(IUndoableActionCommand command)
        {
            commands.Push(command);
        }

        public IUndoableActionCommand Pop()
        {
            return commands.Pop();
        }

        public int Size()
        {
            return commands.Count;
        }
    }
}
