using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer:");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number > 0)
                {
                    int sum = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"The sum of all numbers from 1 to {number} is: {sum}");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
