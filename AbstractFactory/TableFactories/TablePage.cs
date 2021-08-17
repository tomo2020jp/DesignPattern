using System;
using System.Text;
using AbstractFactory.Factories;

namespace AbstractFactory.TableFactories
{
    public class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append($"<html><head><title>{title}</title></head>\n");
            buffer.Append($"<body>\n");
            buffer.Append($"<h1>{title}</h1>\n");
            buffer.Append("<table width=\"80%\" border=\"3\">\n");
            var it = content.GetEnumerator();
            while (it.MoveNext())
            {
                buffer.Append($"<tr>{it.Current.MakeHTML()}</tr>");
            }
            buffer.Append("</table>\n");
            buffer.Append($"<hr><address>{author}</address>\n");
            buffer.Append($"</body></html>\n");
            return buffer.ToString();
        }
    }
}
