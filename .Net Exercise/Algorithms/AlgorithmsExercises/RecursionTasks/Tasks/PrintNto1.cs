using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class PrintNto1
    {
        /*
        Test Data :
        How many numbers to print : 10
        Expected Output :
        10 9 8 7 6 5 4 3 2 1
        */
        public void RunTask()
        {
            int n = int.Parse(Console.ReadLine());
            PrintNumbers(n, n);
            Console.WriteLine();
        }
        private int PrintNumbers(int n, int index)
        {
            if (0 == n)
            {
                return index;
            }
            Console.Write(index + " ");
            return PrintNumbers(n - 1, index - 1);
        }

    }
}
