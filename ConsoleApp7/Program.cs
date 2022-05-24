using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var crystalPrice = 4;

            Console.WriteLine("сколько у вас монет");
            var allUserGold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" сколько кристаллов вы хотите купить по цене " + crystalPrice + "?");
            var needUserCristall = Convert.ToInt32(Console.ReadLine());
            var amountСrystals = needUserCristall * crystalPrice;

            var userGoldRemainder = allUserGold - amountСrystals;
            var enter = "купил кристаллов " + needUserCristall + " осталось золота " + userGoldRemainder;
            Console.WriteLine(enter);
        }
    }
}
