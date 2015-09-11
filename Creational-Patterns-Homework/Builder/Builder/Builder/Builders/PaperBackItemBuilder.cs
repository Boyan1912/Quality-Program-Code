using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Directors
{
    public abstract class PaperBackItemBuilder
    {

        public PaperbackItem Item { get; set; }

        public abstract void SetLanguage();

        public abstract void DeterminePageSize();

        public abstract void DetermineFont();

        

    }
}
