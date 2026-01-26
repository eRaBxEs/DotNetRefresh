using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 77;

            age++;
            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);

            // +, -, * /
            age += 10;
            Console.WriteLine(age);

            age -= 10;
            Console.WriteLine(age);

            age /= 10;
            Console.WriteLine(age);

            age *= 10;
            Console.WriteLine(age);

            // using + for a string and a char
            string name = "Henry";
            name += " is great at programming";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++); // post-increment

            int j = 0;
            Console.WriteLine(++j);// pre-increment

            Console.ReadLine();
        }
    }
}
