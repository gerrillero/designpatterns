using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Group
    {
        public List<Shape> Shapes { get; set; }

        public void Render()
        {
            foreach (var shape in Shapes)
                shape.Render();
        }
    }
}
