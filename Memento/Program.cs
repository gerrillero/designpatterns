using System;

namespace Memento
{
    public class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            editor.FontName = "Verdana";
            editor.FontSize = "12";
            history.Push(editor.CreateState());

            Console.WriteLine($"{editor.Content} {editor.FontSize} {editor.FontName}");

            editor.Content = "b";
            editor.FontName = "Verdana";
            editor.FontSize = "14";
            history.Push(editor.CreateState());

            Console.WriteLine($"{editor.Content} {editor.FontSize} {editor.FontName}");

            editor.Content = "c";
            editor.FontName = "Arial";
            editor.FontSize = "16";
            editor.RestoreState(history.Pop());

            Console.WriteLine($"{editor.Content} {editor.FontSize} {editor.FontName}");
            editor.RestoreState(history.Pop());

            Console.WriteLine($"{editor.Content} {editor.FontSize} {editor.FontName}");
        }
    }
}
