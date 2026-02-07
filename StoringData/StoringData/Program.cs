using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringData
{
    internal class Program
    {
        /**
            1. Define a variable to hold your name
            2. Define a variable to hold your phone number
            3. Define a vatriable to hold your age
            4. Print variables line by line to the screen
            5. Extras: define variables using the var keyword
         **/
        static void Main(string[] args)
        {
            var name = "Henry";
            var number = "0123456789";
            var age = 23;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
