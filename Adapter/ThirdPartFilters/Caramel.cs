using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ThirdPartFilters
{
    public class Caramel
    {
        public void Init()
        {

        }

        public void Render(Image image)
        {
            Console.WriteLine("Caramel filter applied!");
        }
    }
}
