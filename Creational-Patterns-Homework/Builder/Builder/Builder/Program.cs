using Builder.Builders;
using Builder.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaperbackItemPrinter printer = new PaperbackItemPrinter();

            PaperBackItemBuilder builder = new BookBuilder();
            printer.Print(builder);
            builder.Item.DisplayInfo();

            builder = new NewspaperBuilder();
            printer.Print(builder);
            builder.Item.DisplayInfo();

            builder = new MagazineBuilder();
            printer.Print(builder);
            builder.Item.DisplayInfo();

        }
    }
}
