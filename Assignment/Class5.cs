using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. 
namespace Assignment
{

    internal class Class5
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[3];
            for(int i=1; i < 4; i++)
            {
                Console.Write("Enter number {0} :", i);
                arr[i - 1] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("{0} * {1} * {2} = {3}", arr[0] , arr[1], arr[2] ,(arr[0] * arr[1] * arr[2]));
        }
    }
}
