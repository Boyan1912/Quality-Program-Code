using Builder.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class NewspaperBuilder : PaperBackItemBuilder
    {
        public NewspaperBuilder()
        {
            this.Item = new PaperbackItem("Newspaper");
            this.Item.Coloured = false;
        }

        public override void SetLanguage()
        {
            this.Item["Language"] = "Rude";
        }

        public override void DeterminePageSize()
        {
            this.Item["Page size"] = "5";
        }

        public override void DetermineFont()
        {
            this.Item["Font"] = "undefined :)";
        }

    }
}
