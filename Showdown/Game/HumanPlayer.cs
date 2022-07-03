using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal class HumanPlayer : Player
    {
        public override string Name { get; set; }
        public override int Point { get; set; }
        public override bool UsedExchangeFlag { get; set; } = false;

        public override void NameHimSelf(int order)
        {
            Console.WriteLine("請命名：");
            string CommandName = Console.ReadLine();
            if (!string.IsNullOrEmpty(CommandName))
            {
                this.Name = $"{CommandName}";
            }
            else
            {
                this.Name = $"HumanPlayer{order}";
            }

        }

        public override Card Show()
        {
            throw new NotImplementedException();
        }

        public override Card TakeATurn(Card card)
        {
            throw new NotImplementedException();
        }

        public override bool UseExchangeHands()
        {
            if (!UsedExchangeFlag)
            {
                Console.WriteLine("是否使用交換手牌？Y/N");
                string Command = Console.ReadLine();
                if (Command == "Y".ToUpper())
                {
                    Console.WriteLine($"{this.Name}使用了交換手牌");
                }
                UsedExchangeFlag = true;
            }
            return UsedExchangeFlag;
        }

        public override void GetPoint()
        {
            Point++;
        }

    }
}
