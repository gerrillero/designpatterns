using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CompressDataStream : IStream
    {
        private IStream _stream;

        public CompressDataStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var compressedData = compressData(data);
            _stream.Write(compressedData);
        }

        private string compressData(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
