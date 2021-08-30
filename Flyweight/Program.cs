using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Usage: dotnet Flyweight digits");
                Console.WriteLine("Example: dotnet Flyweight 1212123");
                Environment.Exit(0);
            }

            BigString bs = new BigString(args[0]);
            bs.Print();
        }
    }
}
