using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showdown
{
    internal class ExchnageHands
    {
        public int CountDownTimes { get; set; } = 3;

        public void CountDown()
        {
            CountDownTimes--;
        }
    }
}
