using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class TextBuilder : Builder
    {
        private StringBuilder buffer = new StringBuilder();

        public override void Close()
        {
            buffer.Append("===================================\n");
        }

        public override void MakeItems(IEnumerable<string> items)
        {
            foreach(var item in items)
            {
                buffer.Append($" ・{item}\n");
            }
            buffer.Append("\n");
        }

        public override void MakeString(string str)
        {
            buffer.Append($"■{str}\n");
            buffer.Append("\n");
        }

        public override void MakeTitle(string title)
        {
            buffer.Append("===================================\n");
            buffer.Append($" 『{title}』 \n");
            buffer.Append("\n");
        }

        public string GetResult()
        {
            return buffer.ToString();
        }
    }
}
