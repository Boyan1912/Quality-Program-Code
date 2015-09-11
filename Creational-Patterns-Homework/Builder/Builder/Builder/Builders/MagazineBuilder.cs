using Builder.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class MagazineBuilder : PaperBackItemBuilder
    {
        public MagazineBuilder()
        {
            this.Item = new PaperbackItem("Magazine");
            this.Item.Coloured = true;
        }

        public override void SetLanguage()
        {
            this.Item["Language"] = "English";
        }

        public override void DeterminePageSize()
        {
            this.Item["Page size"] = "4";
        }

        public override void DetermineFont()
        {
            this.Item["Font"] = "Some cool font";
        }

        
    }
}
