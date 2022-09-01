using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// C# Sharp program that takes a number as input and print its multiplication table. 
namespace Assignment
{
    internal class Class7
    {
        public static void Main8(String[] args)
        {
            Console.Write("Enter a Number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("table of {0} number is:", a);

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, (a * i));
            }
        }
    }
}
