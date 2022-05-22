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
            int crystalPrice = 4;

            Console.WriteLine("сколько у вас монет");
            int allUserGold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" сколько кристаллов вы хотите купить по цене " + crystalPrice + "?");
            int needUserCristall = Convert.ToInt32(Console.ReadLine());

            int userCristall = allUserGold / crystalPrice;
            int userGoldRemainder = allUserGold % crystalPrice;
            
            string enter = "купил кристаллов " + userCristall + " осталось золота " + userGoldRemainder;
            Console.WriteLine(enter);
        }
    }
}
