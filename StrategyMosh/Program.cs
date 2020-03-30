namespace StrategyMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageStorage = new ImageStorage();
            imageStorage.Store(new JpgCompressor(), new BlackAndWhiteFilter(), "image 1");
            imageStorage.Store(new PngCompressor(), new ColorFiler(), "image 2");
        }
    }
}
