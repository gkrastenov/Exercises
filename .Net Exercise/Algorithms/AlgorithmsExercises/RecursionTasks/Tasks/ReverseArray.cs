using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class ReverseArray
    {
        static int[] array = null;
        public void RunTask()
        {
            Console.WriteLine("Starting task now ......");
            Console.WriteLine("Write N numbers : ");
             array = Console
             .ReadLine()
             .Split()
             .Select(int.Parse).ToArray();
            Reverse(array,0,array.Length-1);
            EndTask(array);
            
        }
        private void Reverse(int[] array, int first, int last)
        {
            if (first < last)
            {
                var number = array[first];
                array[first] = array[last];
                array[last] = number;
                Reverse(array, first + 1, last - 1);
            }
        }
        public void EndTask(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("End task ......");
            Console.ReadKey();
        }
    }
}
