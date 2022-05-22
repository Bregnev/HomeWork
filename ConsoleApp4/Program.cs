using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя");
            string firstName  =  Console.ReadLine();

            Console.WriteLine("Ваша фамилия");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("сколько вам лет");
            string age = Console.ReadLine();

            string finalText = " вас зовут " + firstName + " ваша фамилия " + lastName + " и прожили вы " + age + " года ";
            Console.WriteLine(finalText);
        }
    }
}
