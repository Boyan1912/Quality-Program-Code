using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    class PaperbackItemPrinter : IPaperbackItemPrinter
    {
        public void Print(PaperBackItemBuilder paperBackItemBuilder)
        {
            paperBackItemBuilder.SetLanguage();
            paperBackItemBuilder.DeterminePageSize();
            paperBackItemBuilder.DetermineFont();
        }
    }
}
