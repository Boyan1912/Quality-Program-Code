using Builder.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class BookBuilder : PaperBackItemBuilder
    {
        public BookBuilder()
        {
            this.Item = new PaperbackItem("Book");
            this.Item.Coloured = false;
        }

        public override void SetLanguage()
        {
            this.Item["Language"] = "Bulgarian";
        }

        public override void DeterminePageSize()
        {
            this.Item["Page size"] = "3";
        }

        public override void DetermineFont()
        {
            this.Item["Font"] = "Times New Roman";
        }

        
    }
}
