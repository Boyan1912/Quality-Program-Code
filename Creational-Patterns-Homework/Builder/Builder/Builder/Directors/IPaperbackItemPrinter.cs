using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public interface IPaperbackItemPrinter
    {
        void Print(PaperBackItemBuilder paperBackItemBuilder);
    }
}
