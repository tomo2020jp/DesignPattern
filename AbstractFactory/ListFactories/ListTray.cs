using System;
using System.Text;
using AbstractFactory.Factories;

namespace AbstractFactory.ListFactories
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<li>\n");
            buffer.Append($"{caption}\n");
            buffer.Append("<ul>\n");
            var it = tray.GetEnumerator();
            while (it.MoveNext())
            {
                buffer.Append(it.Current.MakeHTML());
            }
            buffer.Append("</ul>\n");
            buffer.Append("</li>\n");
            return buffer.ToString();
        }
    }
}
