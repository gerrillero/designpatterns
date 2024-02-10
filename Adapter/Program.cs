using System;

namespace Adapter
{
    static class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView(new VividFilter());
            imageView.Apply(new Image());

            var imageView2 = new ImageView(new CaramelFilterAdapter(new ThirdPartFilters.Caramel()));
            imageView2.Apply(new Image());

            Console.Read();
        }
    }
}
