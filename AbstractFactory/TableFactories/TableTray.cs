using System;
using System.Text;
using AbstractFactory.Factories;

namespace AbstractFactory.TableFactories
{
    public class TableTray : Tray
    {
        public TableTray(string caption) : base(caption)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<td>");
            buffer.Append("<table width=\"100%\" border=\"1\"><tr>");
            buffer.Append($"<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"{tray.Count}\"><b>{caption}</b></td>");
            buffer.Append("</tr>\n");
            buffer.Append("<tr>\n");
            var it = tray.GetEnumerator();
            while (it.MoveNext())
            {
                buffer.Append(it.Current.MakeHTML());
            }
            buffer.Append("</tr></table>");
            buffer.Append("</td>");
            return buffer.ToString();
        }
    }
}
