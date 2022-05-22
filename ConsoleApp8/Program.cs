using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patientTime = 10;
            int minutesTotalTime = 60;
            

            Console.WriteLine("Сколько людей в очереди?");

            int numberOfPeople = Convert.ToInt32(Console.ReadLine());
            int receptionTime = patientTime * numberOfPeople;
            int hourWaiting = receptionTime / minutesTotalTime;
            int minutesWaiting = receptionTime % minutesTotalTime;
            
            string enter = " Вы должны отстоять в очереди " + hourWaiting + " часов "+ minutesWaiting + " минут";
            Console.WriteLine(enter);
        }




    }
}
