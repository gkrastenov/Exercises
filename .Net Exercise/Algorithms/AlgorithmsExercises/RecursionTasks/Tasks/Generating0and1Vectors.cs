using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class Generating0and1Vectors
    {
        public void RunTask()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            GeneratinVectors(n,arr,0);
        }
        private void GeneratinVectors(int n,int[] arr,int index)
        {
            if (n <= 0)
            {
               Console.WriteLine(string.Join(" ",arr));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    arr[index] = i;
                    GeneratinVectors(n - 1, arr, index + 1);

                }
            }

        }
    }
}
