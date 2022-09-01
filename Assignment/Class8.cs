using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# Sharp program that takes four numbers as input to calculate and print the average. 
namespace Assignment
{
    internal class Class8
    {
        public static void Main9(String[] args)
        {
            int[] arr = new int[4];
            int sum = 0;
            Console.WriteLine("Enter 4 numbers");

            for(int i = 0; i < 4; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4}", arr[0] , arr[1] , arr[2] , arr[3] ,  (sum) / arr.Length);
        }
    }
}
