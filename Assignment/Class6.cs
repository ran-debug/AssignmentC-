using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 
namespace Assignment
{
    internal class Class6
    {
        public static void Main7(String[] args)
        {
            Console.Write("Enter first Number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second Number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a , b , (a + b) );
            Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
            Console.WriteLine("{0} * {1} = {2}", a, b, (a * b));
            Console.WriteLine("{0} / {1} = {2}", a, b, (a / b));
            Console.WriteLine("{0} mod {1} = {2}", a, b, (a % b));
        }
    }
}
