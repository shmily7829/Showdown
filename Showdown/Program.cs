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
            Console.WriteLine("輸入玩家數量1 - 4");
            string strPlayerCount = Console.ReadLine();
            if (string.IsNullOrEmpty(strPlayerCount) || !int.TryParse(strPlayerCount, out int count))
            {
                Console.WriteLine(strPlayerCount + "為非法字元，請輸入數字");
                Console.Read();
                return;
            }

            int palyerCount = Convert.ToInt16(strPlayerCount);

            if (palyerCount < 1 || palyerCount > 4)
            {
                Console.WriteLine($"玩家數量為1-4人，您輸入的是{strPlayerCount}人");
                Console.Read();
                return;
            }

            HumanPlayer human = new HumanPlayer();
            AiPlayer ai = new AiPlayer();

            //StartGame
            Console.WriteLine("StartGame");
            Console.Read();
        }
    }
}
