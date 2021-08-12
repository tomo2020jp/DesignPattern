using System;
using System.Collections.Generic;

namespace Builder
{
    public class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.MakeTitle("Greeting");
            builder.MakeString("朝から昼にかけて");
            builder.MakeItems(new List<string>
            {
                "おはようございます。",
                "こんにちは。"
            });
            builder.MakeString("夜に");
            builder.MakeItems(new List<string> {
                "こんばんは。",
                "おやすみなさい。",
                "さようなら。",
            });
            builder.Close();
        }
    }
}
