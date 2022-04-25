using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal abstract class Player
    {
        private int _people;

        public int People
        {
            get { return _people; }
            set { _people = value; }
        }

        private string _order;

        public string Order
        {
            get { return _order; }
            set { _order = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private bool _isUsePrivilege;

        public bool IsUsePrivilege
        {
            get { return _isUsePrivilege; }
            set { _isUsePrivilege = value; }
        }

        /// <summary>
        /// 輸入命令
        /// </summary>
        public abstract void CommandLine();

        /// <summary>
        /// 抽卡
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public abstract Card DrawCard(Player player);

        /// <summary>
        /// 交換卡牌
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public abstract Card ExchangeHands(Card card);

    }
}
