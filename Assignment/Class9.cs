using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. 
namespace Assignment
{
    internal class Class9
    {
        public static void Main10(String[] args)
        {
            Console.Write("Enter frst number :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number :");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}", x, y, x, ((x + y) * z), (x * y + y * z));
        }
    }
}
