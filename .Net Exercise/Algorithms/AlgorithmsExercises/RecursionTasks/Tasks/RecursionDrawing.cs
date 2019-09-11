using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class RecursionDrawing
    {
        public void RunTask()
        {
            int n = int.Parse(Console.ReadLine());
            Drawing(n);
        }
        private void Drawing(int n)
        {
            if (n <= 0)
            {
                return;
            }
            Console.WriteLine(new string('*',n));
             Drawing(n - 1);
            Console.WriteLine(new string('#', n));

        }
    }
}
