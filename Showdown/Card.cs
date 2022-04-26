using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal class Card
    {
        private int _count;

        /// <summary>
        /// 數量
        /// </summary>
        public int Count
        {
            get { return _count; }
            set { _count = 52; }
        }

        private CardRank _rank;

        /// <summary>
        /// 等級
        /// </summary>
        public CardRank Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        private CardSuit _suit;

        /// <summary>
        /// 花色
        /// </summary>
        public CardSuit Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        public Card CompareCard(Card cardA, Card cardB)
        {
            Card winCard = new Card();
            if (cardA.Rank > cardB.Rank)
            {
                if (cardA.Suit > cardB.Suit)
                {
                    winCard = cardA;
                }
            }

            if (cardA.Rank > cardB.Rank)
            {
                if (cardB.Suit > cardA.Suit)
                {
                    winCard = cardB;
                }
            }

            if (cardB.Rank > cardA.Rank)
            {
                if (cardB.Suit > cardA.Suit)
                {
                    return cardB;
                }
            }

            if (cardB.Rank > cardA.Rank)
            {
                if (cardA.Suit > cardB.Suit)
                {
                    return cardB;
                }
            }
            return winCard;
        }
    }
}
