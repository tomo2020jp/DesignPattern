using System;
namespace Visitor
{
    public class ListVisitor : Visitor
    {
        private string currentdir = "";

        public override void Visit(File file)
        {
            Console.WriteLine($"{currentdir}/{file}");
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine($"{currentdir}/{directory}");
            string savefir = currentdir;
            currentdir = $"{currentdir}/{directory.GetName()}";
            var it = directory.Iterator();
            while (it.MoveNext())
            {
                it.Current.Accept(this);
            }
            currentdir = savefir;
        }
    }
}
