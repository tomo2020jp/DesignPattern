using System;
namespace Strategy
{
    public enum HANDVALUE
    {
        GUU,
        CHOKI,
        PAA,
    }

    public enum VICTORY_DEFEAT
    {
        LOSE = -1,
        DRAW = 0,
        WIN = 1,
    }

    public class Hand
    {
        public static readonly Hand[] Hands =
        {
            new Hand(HANDVALUE.GUU),
            new Hand(HANDVALUE.CHOKI),
            new Hand(HANDVALUE.PAA),
        };
        private static readonly string[] names = { "グー", "チョキ", "パー" };
        private HANDVALUE handvalue;
        private Hand(HANDVALUE handvalue)
        {
            this.handvalue = handvalue;
        }

        public static Hand GetHand(HANDVALUE handvalue)
        {
            return Hands[(int)handvalue];
        }

        public bool IsStrongerTan(Hand hand)
        {
            return Fight(hand) == VICTORY_DEFEAT.WIN;
        }

        public bool IsWeakerThan(Hand hand)
        {
            return Fight(hand) == VICTORY_DEFEAT.LOSE;
        }

        private VICTORY_DEFEAT Fight(Hand hand)
        {
            if (this == hand)
            {
                return VICTORY_DEFEAT.DRAW;
            }
            else if ((((int)this.handvalue) + 1) % 3 == (int)hand.handvalue)
            {
                return VICTORY_DEFEAT.WIN;
            }
            else
            {
                return VICTORY_DEFEAT.LOSE;
            }
        }

        public override string ToString()
        {
            return names[(int)handvalue];
        }
    }
}
