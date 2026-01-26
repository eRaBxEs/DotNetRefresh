using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // N.B : Note that using var can hurt the readability of your code many atimes
            // Whole Numbers
            //int age = 23;
            var age = 23;
            Console.WriteLine(age);

            //long bigNumber = 190000000L;
            var bigNumber = 900000L;
            Console.WriteLine(bigNumber);
            
            // Decimals
            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.000001F;
            Console.WriteLine(precision);
            
            var money = 14.99M;
            Console.WriteLine(money);

            var name = "Henry";
            Console.WriteLine(name);

            var letter = 'a';
            Console.WriteLine(letter);
            

            Console.ReadLine();
        }
    }
}
