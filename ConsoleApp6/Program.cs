using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPictures;
            int photoInRow = 3;

            Console.WriteLine("количество картинок");
            numberPictures = Convert.ToInt32(Console.ReadLine());
            
            int rows = numberPictures / photoInRow;
            int remainderPhoto = numberPictures % photoInRow;
            string enter = " количество рядов- " + rows + " сверх меры- " + remainderPhoto + " картинка";

            Console.WriteLine(enter);
        }

         
    
    }

}
