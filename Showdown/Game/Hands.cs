using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown.Game
{
    internal class Hands
    {
        public List<Card> Cards = new List<Card>();

        public void AddCard(Card card)
        {
            if (Cards.Count <= 13)
            {
                Cards.Add(card);
            }
        }


        public void RemoveCard(int index)
        {
            Cards.RemoveAt(index);
        }
    }
}
