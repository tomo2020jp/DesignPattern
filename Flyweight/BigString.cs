using System;
namespace Flyweight
{
    public class BigString
    {
        private BigChar[] bigChars;
        public BigString(string str)
        {
            bigChars = new BigChar[str.Length];
            BigCharFactory factory = BigCharFactory.GetInstance();
            for (int i = 0; i < bigChars.Length; i++)
            {
                bigChars[i] = factory.GetBigChar(str[i]);
            }
        }

        public void Print()
        {
            for(int i = 0; i < bigChars.Length; i++)
            {
                bigChars[i].Print();
            }
        }
    }
}
