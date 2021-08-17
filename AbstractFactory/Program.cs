using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.WriteLine("Usage: dotnet AbstractFactory class.name.of.ConcreteFactory");
                Console.WriteLine("Example 1: dotnet AbstractFactory listfactory.ListFactory");
                Console.WriteLine("Example 2: dotnet AbstractFactory tablefactory.TableFactory");
                Environment.Exit(0);
            }

            Factory factory = Factory.GetFactory(args[0]);

            Link asahi = factory.CreateLink("朝日新聞", "https://www.asahi.com/");
            Link yomiuri = factory.CreateLink("読売新聞", "https://www.yomiuri.co.jp/");
            Link us_yahoo = factory.CreateLink("Yahoo!", "https://www.yahoo.com/");
            Link jp_yahoo = factory.CreateLink("Yahoo!Japan", "https://www.yahoo.co.jp/");
            Link excite = factory.CreateLink("Excite", "https://www.excite.co.jp/");
            Link google = factory.CreateLink("Google", "https://www.google.co.jp/");

            Tray traynews = factory.CreateTray("新聞");
            traynews.Add(asahi);
            traynews.Add(yomiuri);

            Tray trayyahoo = factory.CreateTray("Yahoo!");
            trayyahoo.Add(us_yahoo);
            trayyahoo.Add(jp_yahoo);

            Tray traysearch = factory.CreateTray("サーチエンジン");
            traysearch.Add(excite);
            traysearch.Add(google);

            Page page = factory.CreatePage("LinkPage", "結城 浩");
            page.Add(traynews);
            page.Add(trayyahoo);
            page.Add(traysearch);
            page.Output();
        }
    }
}
