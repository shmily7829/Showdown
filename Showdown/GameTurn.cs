using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal class GameTurn
    {
        private int _rounds;

        public int Rounds
        {
            get { return _rounds; }
            set { _rounds = 13; }
        }

        public string TakeATurn(int round)
        {

            if (Rounds == 0)

                return "Game Over";
            round--;
            return $"距離遊戲結束還有 {round} 回合";
        }

    }
}
