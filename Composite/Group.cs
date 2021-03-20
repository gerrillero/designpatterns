using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Group : IComponent
    {
        public List<IComponent> Components { get; set; }

        public Group()
        {
            Components = new List<IComponent>();
        }

        public void Render()
        {
            foreach (var shape in Components)
            {
                shape.Render();
            }
        }

        public void Move()
        {
            foreach (var shape in Components)
            {
                shape.Move();
            }
        }
    }
}
