using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class GenerateCombinations
    {
        public void RunTask()
        {
            var array = Console
            .ReadLine()
            .Split()
            .Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] vector = new int[k];
            GenerateComb(array,vector,0,0);
        }
        private void GenerateComb(int[] set,int[] vector,int index,int border)
        {
            if (index==vector.Length)
            {
                Console.WriteLine(string.Join(" ",vector));
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenerateComb(set, vector, index + 1, i + 1);
                }
            }
        }
    }
}
