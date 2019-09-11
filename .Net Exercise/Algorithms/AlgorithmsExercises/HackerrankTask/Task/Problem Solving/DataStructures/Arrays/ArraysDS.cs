using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankTask.Task.Problem_Solving.DataStructures
{
    public class ArraysDS : BaseTask
    {
        public override void RunTask()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] res = reverseArray(arr,0,arr.Length-1);
            Console.WriteLine(string.Join(" ",res));
        }
        private int[] reverseArray(int[] a,int startIndex, int endIndex)
        {
            // Recursion
            if (startIndex > endIndex)
            {
                return a;
            }
            else
            {
                var help = a[endIndex];
                a[endIndex] = a[startIndex];
                a[startIndex] = help;
                return reverseArray(a, startIndex + 1, endIndex - 1);
            }
        }
    }
}
