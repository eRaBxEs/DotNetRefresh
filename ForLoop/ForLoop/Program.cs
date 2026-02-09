using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi");
            //Console.WriteLine("Hi");
            //Console.WriteLine("Hi");
            //Console.WriteLine("Hi");
            //Console.WriteLine("Hi");
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Hi");
            }

            Console.WriteLine("======== Even numbers below =======");

            for (int i = 0; i <= 10; i += 2) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("======== Odd numbers below =======");

            for (int i = 1; i <= 10; i += 2) 
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
