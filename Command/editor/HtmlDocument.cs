using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.editor
{
    public class HtmlDocument
    {
        public String Content { get; set; }

        public void MakeBold()
        {
            Content = "<b>" + Content + "/b>";
        }
    }
}
