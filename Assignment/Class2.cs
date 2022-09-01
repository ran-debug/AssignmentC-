using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# Sharp program to print the result of dividing two numbers. 
namespace Assignment
{
    internal class Class2
    {
        public static void Main3(String[] args)
        {
            int a = 20;
            int b = 0;

            if(b == 0)
            {
                throw new Exception("b can't be zero");
            }
            else
                Console.WriteLine("result is {0}", a / b);
        }
    }
}
