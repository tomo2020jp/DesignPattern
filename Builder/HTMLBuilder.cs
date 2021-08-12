using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Builder
{
    public class HTMLBuilder : Builder
    {
        private string filename;
        private StreamWriter writer;

        public override void Close()
        {
            using var writer = new StreamWriter(filename, true, Encoding.UTF8);
            writer.WriteLine($"</body></html>");
            writer.Close();
        }

        public override void MakeItems(IEnumerable<string> items)
        {
            using var writer = new StreamWriter(filename, true, Encoding.UTF8);
            writer.WriteLine("<ul>");
            foreach (var item in items)
            {
                writer.WriteLine($"<li>{item}</li>");
            }
            writer.WriteLine("</ul>");
        }

        public override void MakeString(string str)
        {
            using var writer = new StreamWriter(filename, true, Encoding.UTF8);
            writer.WriteLine($"<p>{str}</p>");
        }

        public override void MakeTitle(string title)
        {
            filename = $"{title}.html";
            using var writer = File.CreateText(filename);
            this.writer = writer;
            writer.WriteLine($"<html><head><title>{title}</title></head><body>");
            writer.WriteLine($"<h1>{title}</h1>");
        }

        public string GetResult()
        {
            return filename;
        }
    }
}
