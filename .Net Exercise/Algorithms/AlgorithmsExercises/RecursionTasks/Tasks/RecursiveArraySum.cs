using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionTasks.Tasks
{
   // This exercise is only to test recursion logic. 
    public class RecursiveArraySum
    {
        public void RunTask()
        {
            int[] array = null;
            array = Console
             .ReadLine()
             .Split()
             .Select(int.Parse).ToArray();
            Console.WriteLine(SumElements(array, array.Length-1));
            Console.WriteLine();
        }
        private int SumElements(int[] arr, int index)
        {
            if (index<0)
            {
                return 0;
            }
            return arr[index] + SumElements(arr, index - 1) ;
        }
    }
}
