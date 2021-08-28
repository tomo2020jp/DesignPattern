using System;
using System.Collections.Generic;

namespace Memento
{
    public class Gamer
    {
        public int Money { get; private set; }
        private IList<string> fruits = new List<string>();
        private Random random = new Random();
        private static string[] fruitsName =
        {
            "リンゴ", "ぶどう", "バナナ", "みかん"
        };

        public Gamer(int money)
        {
            Money = money;
        }

        public void Bet()
        {
            int dice = random.Next(6) + 1;
            if (dice == 1)
            {
                Money += 100;
                Console.WriteLine("所持金が増えました。");
            }
            else if (dice == 2)
            {
                Money /= 2;
                Console.WriteLine("所持金が半分になりました。");
            }
            else if (dice == 6)
            {
                string f = GetFruit();
                Console.WriteLine($"フルーツ({f})をもらいました。");
                fruits.Add(f);
            }
            else
            {
                Console.WriteLine("何も起こりませんでした");
            }
        }

        public Memento CreateMemento()
        {
            var m = new Memento(Money);
            var it = fruits.GetEnumerator();
            while (it.MoveNext())
            {
                var f = it.Current;
                if (f.StartsWith("おいしい"))
                {
                    m.AddFruit(f);
                }
            }
            return m;
        }

        public void RestoreMemento(Memento memento)
        {
            Money = memento.Money;
            fruits = memento.GetFruits();
        }

        public override string ToString()
        {
            return $"[money = {Money}, fruits = [{string.Join(",", fruits)}]]";
        }

        private string GetFruit()
        {
            string prefix = "";
            if (random.Next(100) <= 50)
            {
                prefix = "おいしい";
            }
            return $"{prefix}{fruitsName[random.Next(fruitsName.Length)]}";
        }
    }
}
