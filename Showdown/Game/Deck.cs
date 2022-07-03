using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown.Game
{
    internal class Deck
    {
        public Card Card { get; set; }

        public List<Card> CardStack { get; set; } = new List<Card>();

        public Deck()
        {
            this.InitDeck();
        }

        public void InitDeck()
        {

            for (int i = 0; i < Enum.GetValues(typeof(Suit)).Length; i++)
            {
                for (int k = 0; k < Enum.GetValues(typeof(Rank)).Length; k++)
                {
                    CardStack.Add(new Card()
                    {
                        Suit = (Suit)i,
                        Rank = (Rank)k
                    });
                }
            }
        }

        /// <summary>
        /// 洗牌
        /// </summary>
        public void Shuffle()
        {
            int randIndex;
            Random r = new Random();
            List<Card> temp = new List<Card>();

            while (CardStack.Count > 0)
            {
                randIndex = r.Next(0, CardStack.Count);
                temp.Add(CardStack[randIndex]);
                CardStack.RemoveAt(randIndex);
            }

            CardStack = temp;

            for (int i = 0; i < CardStack.Count; i++)
            {
                Console.WriteLine($"第{i + 1}張牌是：{CardStack[i].Suit} {CardStack[i].Rank}");
            }
        }

        public Card DrawCard()
        {
            return Card;
        }
    }
}
