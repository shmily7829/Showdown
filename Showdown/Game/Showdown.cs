using Showdown.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal class Showdown
    {
        public int Round { get; set; } = 13;

        private Deck _deck;

        private List<Player> _players;

        public Showdown(Deck deck, List<Player> players)
        {
            this._deck = deck;
            this._players = players;
        }

        /// <summary>
        /// 遊戲開始
        /// </summary>
        public void GameStart()
        {
            //玩家命名
            this.NamePlayers();
            //洗牌
            this._deck.Shuffle();
            //玩家抽牌(發牌直到發完)

            //回合開始

            //是否使用交換手牌(每個玩家每局遊戲只能用一次，三回合後手牌交換回來)

            //出牌(Show)

            //比大小勝者分數加一
            this.GameOver();
        }

        /// <summary>
        /// 取名
        /// </summary>
        private void NamePlayers()
        {
            for (int i = 0; i < _players.Count; i++)
            {
               _players[i].NameHimSelf(i + 1);
            }
        }

        /// <summary>
        /// 遊戲結束
        /// </summary>
        public void GameOver()
        {

        }

    }
}
