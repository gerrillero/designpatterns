using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ImageView
    {
        private IFilter _filter;

        public ImageView(IFilter filter)
        {
            _filter = filter;
        }

        public void Apply(Image image)
        {
            _filter.Apply(image);
        }
    }
}
