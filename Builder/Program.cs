using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Usage();
                Environment.Exit(0);
            }

            if (args[0].Equals("plain"))
            {
                TextBuilder textBuilder = new TextBuilder();
                Director director = new Director(textBuilder);
                director.Construct();
                var result = textBuilder.GetResult();
                Console.WriteLine(result);
            }
            else if (args[0].Equals("html"))
            {
                HTMLBuilder htmlBuilder = new HTMLBuilder();
                Director director = new Director(htmlBuilder);
                director.Construct();
                var filname = htmlBuilder.GetResult();
                Console.WriteLine($"{filname}が作成されました。");
            }
            else
            {
                Usage();
                Environment.Exit(0);
            }
        }

        public static void Usage()
        {
            Console.WriteLine("Usage: dotnet plain     プレーンテキストで文書作成");
            Console.WriteLine("Usage: dotnet html     HTMLファイルで文書作成");
        }
    }
}
