using System;
namespace Strategy
{
    public class ProbStrategy : IStrategy
    {
        private Random random;
        private HANDVALUE prebHandValue;
        private HANDVALUE currentHandValue;
        private int[,] history =
        {
            {1,1,1, },
            {1,1,1, },
            {1,1,1, },
        };
        public ProbStrategy(int seed)
        {
            random = new Random(seed);
        }

        public Hand NextHand()
        {
            int bet = random.Next(GetSum((int)currentHandValue));
            HANDVALUE handvalue;
            if (bet < history[(int)currentHandValue, 0])
            {
                handvalue = HANDVALUE.GUU;
            }
            else if (bet < history[(int)currentHandValue, 0] + history[(int)currentHandValue, 1])
            {
                handvalue = HANDVALUE.CHOKI;
            }
            else
            {
                handvalue = HANDVALUE.PAA;
            }
            prebHandValue = currentHandValue;
            currentHandValue = handvalue;
            return Hand.GetHand(handvalue);
        }

        public void Study(bool win)
        {
            if (win)
            {
                history[(int)prebHandValue, (int)currentHandValue]++;
            }
            else
            {
                history[(int)prebHandValue, ((int)currentHandValue + 1) % 3]++;
                history[(int)prebHandValue, ((int)currentHandValue + 2) % 3]++;
            }
        }

        private int GetSum(int hv)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += history[hv, i];
            }
            return sum;
        }
    }
}
