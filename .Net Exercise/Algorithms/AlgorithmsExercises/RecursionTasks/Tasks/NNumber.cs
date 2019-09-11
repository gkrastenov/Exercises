using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class NNumber
    {
        int param = 0;
        /*
Ni = Ni-1 +2* Ni-2 - 2 * Ni-3
N1 = 1; N2 = 2; N3 = 3;
*/
        public void RunTask()
        {
            int number = int.Parse(Console.ReadLine());
            FuncRecursion(1,number);
        }
        private void  FuncIterative(int n)
        {
            for (int i = 1; i <=n; i++)
            {
                param = ((i - 1) + (2 * i - 2) - (2 * i - 3));
                Console.WriteLine(string.Concat("N"+i.ToString()+" = " + param.ToString()));
               
            }
        }
        private void FuncRecursion(int index,int n)
        {
            if (index>n)
            {
                return;
            }
            param = ((index - 1) + (2 * index - 2) - (2 * index - 3));
            Console.WriteLine(string.Concat("N" + index.ToString()+ " =  "+param.ToString()));
            FuncRecursion(index + 1,n);
        }
    }
}