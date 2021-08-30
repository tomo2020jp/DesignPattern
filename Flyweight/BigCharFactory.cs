using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class BigCharFactory
    {
        private IDictionary<char, BigChar> pool = new Dictionary<char, BigChar>();
        private static BigCharFactory singleton = new BigCharFactory();
        private BigCharFactory()
        {
        }

        public static BigCharFactory GetInstance()
        {
            return singleton;
        }

        public BigChar GetBigChar(char charname)
        {
            BigChar bc;
            try
            {
                bc = pool[charname];
            }
            catch (KeyNotFoundException ex)
            {
                bc = new BigChar(charname);
                pool.Add(charname, bc);
            }
            return bc;
        }
    }
}
