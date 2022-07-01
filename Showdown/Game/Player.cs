using Showdown.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal abstract class Player
    {
        public abstract string Name { get; set; }

        public abstract int Point { get; set; }

        public int Count { get; set; } = 0;

        public Showdown Showdown { get; set; }

        public Hands Hands { get; set; }


        /// <summary>
        /// 取名字
        /// </summary>
        public abstract void NameHimSelf(int order);

        /// <summary>
        /// 取得回合
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public abstract Card TakeATurn(Card card);

        /// <summary>
        /// 交換卡牌
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public abstract bool UseExchangeHands();

        /// <summary>
        /// 展示卡牌
        /// </summary>
        /// <returns></returns>
        public abstract Card Show();

        /// <summary>
        /// 取得分數
        /// </summary>
        public abstract void GetPoint();

    }
}
