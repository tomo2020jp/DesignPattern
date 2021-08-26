using System;
using System.IO;

namespace Facade
{
    public class HtmlWriter
    {
        private StreamWriter writer;
        public HtmlWriter(StreamWriter writer)
        {
            this.writer = writer;
        }

        public void Title(string title)
        {
            writer.Write("<html>");
            writer.Write("<head>");
            writer.Write($"<title>{title}</title>");
            writer.Write("</head>");
            writer.Write("<body>\n");
            writer.Write($"<h1>{title}</h1>");
        }

        public void Paragraph(string msg)
        {
            writer.Write($"<p>{msg}</p>\n");
        }

        public void Link(string href, string caption)
        {
            Paragraph($"<a href=\"{href}\">{caption}</a>");
        }

        public void MailTo(string mailaddr, string username)
        {
            Link($"mailto:{mailaddr}", username);
        }

        public void Close()
        {
            writer.Write("</body>");
            writer.Write("</html>\n");
            writer.Close();
        }
    }
}
