using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, i, j = 1;
            Console.WriteLine("Enter a number greater than zero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
             for (i = 1; i <= num1; i++)
                {
                    j = i * j;
                }
                Console.WriteLine($"Factorial of {num1} is: {j}");
            }
    }
}
