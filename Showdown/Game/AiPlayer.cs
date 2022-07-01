using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal class AiPlayer : Player
    {
        public override string Name { get; set; }

        public override int Point { get; set; }

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
            return true;
        }

        public override void GetPoint()
        {
            Point++;
        }

        public override void NameHimSelf(int order)
        {
            this.Name = $"AiPlayer{order}";
        }
    }
}
