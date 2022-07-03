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
        private int Round = 13;

        private int Turn = 0;

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

            //發牌
            this.DrawHands();

            //回合開始
            PlayRounds();
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
                //Console.WriteLine(_players[i].Name);
            }

        }

        /// <summary>
        /// 抽手牌
        /// </summary>
        private void DrawHands()
        {
            int totalCards = this._deck.CardStack.Count;
            int cardIndex = 0;

            for (int i = 0; i < _players.Count; i++)
            {
                for (int k = cardIndex; k < totalCards; k++)
                {
                    if (_players[i].Hands.Cards.Count == 13)
                    {
                        break;
                    }
                    _players[i].AddHands(this._deck.CardStack[k]);
                    cardIndex++;
                    Console.WriteLine($"{_players[i].Name}取得第{_players[i].Hands.Cards.Count}張手牌:{this._deck.CardStack[k].Suit} {this._deck.CardStack[k].Rank}");
                }
            }
        }

        /// <summary>
        /// 遊戲回合
        /// </summary>
        private void PlayRounds()
        {
            //P1~P4 輪流(Takes a turn) 依序執行以下：
            //1.決定要不要使用 * **「交換手牌(Exchange Hands)」***特權，參見需求 5。
            //2.出(Show) 一張牌（此步驟彼此皆無法知曉彼此出的牌）。
            //2.顯示 P1~P4 各出的牌的內容。
            //3.將 P1~P4 出的牌進行* 比大小決勝負*，將最勝者的分數(Point)加一。

            for (int i = 0; i < this.Round; i++)
            {
                //取得回合
                foreach (var player in this._players)
                {
                    this.TakeTurn(player);
                    player.UsedExchangeFlag = player.UseExchangeHands();

                }

                //得分
            }
        }

        private void TakeTurn(Player player)
        {
            Console.WriteLine($"{player.Name}的回合");
            //player.Show();
        }

        /// <summary>
        /// 比牌
        /// </summary>
        private void ShowdownCompareCard()
        {

        }

        /// <summary>
        /// 遊戲結束
        /// </summary>
        public void GameOver()
        {

        }

    }
}
