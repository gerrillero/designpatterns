using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group();
            group1.Components.Add(new Shape());
            group1.Components.Add(new Shape());

            var group2 = new Group();
            group2.Components.Add(new Shape());
            group2.Components.Add(new Shape());

            var group3 = new Group();
            group3.Components.Add(group1);
            group3.Components.Add(group2);

            group3.Render();
            group3.Move();

            Console.Read();

        }
    }
}
