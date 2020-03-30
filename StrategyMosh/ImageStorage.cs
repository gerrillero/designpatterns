namespace StrategyMosh
{
    public class ImageStorage
    {
        public void Store(ICompressor compressor, IFilter filter, string fileName)
        {
            compressor.Compress(fileName);
            filter.ApplyFilter(fileName);
        }
    }
}
