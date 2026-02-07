using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            Console.Write("Value of "+ numberA + " x "+ numberB+ " : ");
            string answerInput = Console.ReadLine();
            int finalInput = Convert.ToInt32(answerInput);

            if (answer == finalInput)
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine("Close but it was wrong!");
            }


           Console.ReadLine();
        }
    }
}
