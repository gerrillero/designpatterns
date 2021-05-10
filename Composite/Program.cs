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
            group1.Shapes.Add(new Shape());
            group1.Shapes.Add(new Shape());

            var group2 = new Group();
            group2.Shapes.Add(new Shape());
            group2.Shapes.Add(new Shape());


        }
    }
}
