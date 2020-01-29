using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class WordApplication : Application
    {
        public WordApplication(IApplicationBehavior applicationBehavior) : base(applicationBehavior)
        {
        }
    }
}
