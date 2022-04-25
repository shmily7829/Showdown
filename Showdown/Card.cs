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

        private int _point;

        /// <summary>
        /// 分數
        /// </summary>
        public int Point
        {
            get { return _point; }
            set { _point = value; }
        }

        public void CompareCard(Card cardA, Card cardB)
        {
            if (cardA.Suit.CompareTo(cardB.Suit) > 0)
            {
                if (cardA.Rank.CompareTo(cardB.Rank) > 0)
                    cardA.Point++;
            }
            else
            {
                if (cardB.Rank.CompareTo(cardA.Rank) > 0)
                    cardB.Point++;
            }
        }
    }
}
