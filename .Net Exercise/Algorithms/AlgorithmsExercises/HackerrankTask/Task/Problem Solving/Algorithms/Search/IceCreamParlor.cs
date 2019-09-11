using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankTask.Task.Problem_Solving.Algorithms.Search
{
    public class IceCreamParlor : BaseTask
    {
        public override void RunTask()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int m = Convert.ToInt32(Console.ReadLine());

                int n = Convert.ToInt32(Console.ReadLine()); // length of flavors
                // arr contains all flavors 
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                int[] result = icecreamParlor(m, arr);
                Console.WriteLine(string.Join(" ",result));
            }
        }
        private int[] icecreamParlor(int m, int[] arr)
        {
            int sum = m;
            int currFlavor = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                currFlavor = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i==j)
                    {
                        continue;
                    }
                    else
                    {
                        if ((currFlavor + arr[j]) == sum)
                        {
                            var firstIndex = i + 1;
                            var lastIndex = j + 1;
                            list.Add(firstIndex);
                        }
                    }
                   
                }
            }
            return list.ToArray();
        }
    }
}
