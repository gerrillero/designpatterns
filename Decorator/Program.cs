using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new EncriptCloudStream(new CompressDataStream(new CloudStream()));

            storedCreditCard(stream);

            Console.Read();
        }

        private static void storedCreditCard(IStream stream)
        {
            stream.Write("123-456-789");
        }
    }
}
