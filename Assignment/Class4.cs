using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// C# Sharp program to swap two numbers. 
namespace Assignment
{
    internal class Class4
    {
        public static void Main5(String[] args)
        {
            int a = 4;
            int b = 6;

            Console.WriteLine("Before Swap a is {0} and b is {1}", a, b);
            swap(ref a, ref b);
            Console.WriteLine("After Swap a is {0} and b is {1}", a, b);
        }

        public static void swap(ref int a , ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
