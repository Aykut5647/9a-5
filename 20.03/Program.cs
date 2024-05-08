using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine("Izhod 6:");
            for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                    Console.WriteLine(nums[i]);
                    }
                }

            //Izhod 7
            //List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int start=int.Parse(Console.ReadLine());
            //int length=int.Parse(Console.ReadLine());
            //for (int j = 0;j<list.Count; j++)
            //{
            //    for (int k = j;k<n-1-j; k++)
            //        if (start == length)
            //        {
            //            int bestStart=start++;
            //            int bestLength = length++;
            //        }
            //        else
            //        { 

            //        }
            //    for (int k = 0;k<n-1-j; k++)
            //}

            
        }
    }
}
