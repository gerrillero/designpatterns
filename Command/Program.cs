using Command.editor;
using Command.fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Command pattern
            /*var customerService = new CustomeService();
            var command = new AddCustomerCommand(customerService);
            var button = new Button(command);
            button.Click();*/

            // Composite Command pattern
            /*var composite = new CompositeCommand();
            composite.Commands.Add(new ResizeCommand());
            composite.Commands.Add(new BlackAndWhiteCommand());
            composite.Execute();*/

            // Undoable Command pattern
            var history = new History();
            var document = new HtmlDocument();
            document.Content = "Hello World";

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();

            Console.WriteLine(document.Content);

            //boldCommand.Unexecute();
            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();

            Console.WriteLine(document.Content);
        }
    }
}
 