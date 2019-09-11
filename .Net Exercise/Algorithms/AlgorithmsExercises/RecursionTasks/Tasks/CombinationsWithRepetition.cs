using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class CombinationsWithRepetition
    {
        public void RunTask()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            Generate(0, arr, n);
        }
        public void Generate(int index, int[] arr, int n)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
                for (int i = 1; i <= n; i++)
                {
                    arr[index] = i;
                    Generate(index + 1, arr, n);
                }
        }
    }
}
