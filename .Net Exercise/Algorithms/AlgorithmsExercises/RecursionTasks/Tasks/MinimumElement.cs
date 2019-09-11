using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class MinimumElement
    {
        int minElement = 0;
        public void RunTask()
        {
            int[] array = null;
            array = Console
             .ReadLine()
             .Split()
             .Select(int.Parse).ToArray();
            minElement = array[0];
            Console.WriteLine(SearchMinElement(array, minElement, 0));
        }
        private int SearchMinElement(int[] elements, int minElement,int index)
        {
            if (index>elements.Length-1)
            {
                return minElement;
            }
            if (minElement>elements[index])
            {
                minElement = elements[index];
            }
            return SearchMinElement(elements, minElement, index + 1);

        }
    }
}
