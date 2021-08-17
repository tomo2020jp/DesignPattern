using System;
using System.Collections.Generic;
using System.IO;

namespace AbstractFactory.Factories
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected IList<Item> content = new List<Item>();
        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item)
        {
            content.Add(item);
        }

        public void Output()
        {
            try
            {
                string filename = $"{title}.html";
                using var writer = File.CreateText(filename);
                writer.Write(this.MakeHTML());
                writer.Close();
                Console.WriteLine($"{filename}を作成しました。");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public abstract string MakeHTML();
    }
}
