using System;
using System.Text;
using AbstractFactory.Factories;

namespace AbstractFactory.ListFactories
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append($"<html><head><title>{title}</title></head>\n");
            buffer.Append($"<body>\n");
            buffer.Append($"<h1>{title}</h1>\n");
            buffer.Append("<ul>\n");
            var it = content.GetEnumerator();
            while (it.MoveNext())
            {
                buffer.Append(it.Current.MakeHTML());
            }
            buffer.Append("</ul>\n");
            buffer.Append($"<hr><address>{author}</address>\n");
            buffer.Append($"</body></html>\n");
            return buffer.ToString();
        }
    }
}
