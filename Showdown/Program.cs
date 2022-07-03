using Showdown.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //初始化卡牌
            Deck deck = new Deck();

            //開啟新牌局
            List<Player> players = new List<Player>()
            { new HumanPlayer(),
                new AiPlayer(),
                new AiPlayer(),
                new AiPlayer()
            };

            Showdown showdown = new Showdown(deck, players);
            showdown.GameStart();

            Console.Read();
        }
    }
}
