using Adapter.ThirdPartFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CaramelFilterAdapter : IFilter
    {
        private Caramel _caramel;

        public CaramelFilterAdapter(Caramel caramel)
        {
            _caramel = caramel;
        }

        public void Apply(Image image)
        {
            _caramel.Init();
            _caramel.Render(image);
        }
    }
}
