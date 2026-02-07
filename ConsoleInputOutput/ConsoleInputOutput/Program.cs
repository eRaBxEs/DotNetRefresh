using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);


            Console.WriteLine("Your name is "+name+ " and your age is "+age);

            // ==, >, >= , <, <= , !=, ||, &&
                        
            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25.");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 or older");
                }
            }

                Console.ReadLine();
        }
    }
}
