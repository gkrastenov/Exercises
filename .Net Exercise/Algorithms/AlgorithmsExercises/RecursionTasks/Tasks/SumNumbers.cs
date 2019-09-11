using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    /*
    Test Data :
    How many numbers to sum : 10
    Expected Output :
    The sum of first 10 natural numbers is : 55
     */
    public class SumNumbers
    {
        public void RunTask()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(n));
        }
        private int Sum(int n)
        {
            if (n==0)
            {
                return 0;
            }
            return Sum(n - 1) + n;
        }

    }
}
