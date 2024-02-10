namespace Adapter
{
    public class ImageView
    {
        private readonly IFilter _filter;

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
