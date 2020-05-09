using Command.fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CompositeCommand : ICommand
    {
        public List<ICommand> Commands { get; set; }

        public CompositeCommand()
        {
            Commands = new List<ICommand>();
        }

        public void Execute()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
