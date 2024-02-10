using Adapter.ThirdPartFilters;

namespace Adapter
{
    public class CaramelFilterAdapter : IFilter
    {
        private readonly Caramel _caramel;

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
