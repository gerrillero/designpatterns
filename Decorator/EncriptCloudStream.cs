using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EncriptCloudStream : IStream
    {
        private IStream _stream;

        public EncriptCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var encryptedtData = encriptData(data);
            _stream.Write(encryptedtData);
        }

        private string encriptData(string data)
        {
            return "!@#@$#%$^$%$%&2342sgsgs";
        }
    }
}
