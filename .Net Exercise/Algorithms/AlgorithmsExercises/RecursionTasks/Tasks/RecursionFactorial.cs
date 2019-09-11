using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class RecursionFactorial
    {
        public void RunTask()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fatorial(n));
        }
        private int Fatorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return Fatorial(n - 1) * n;
        }
    }
}
