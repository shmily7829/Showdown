using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal class HumanPlayer : Player
    {
        public override void CommandLine()
        {
            throw new NotImplementedException();
        }

        public override Card DrawCard(Player player)
        {
            Card card = new Card();
            Console.WriteLine($"{player.Order} draw a new {card}");
            return card;
        }

        public override Card ExchangeHands(Card card)
        {
            throw new NotImplementedException();
        }
    }
}
