using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    /*
      Test Data :
      How many numbers to print : 10
      Expected Output :
      1 2 3 4 5 6 7 8 9 10
    */
    public class FirstNNaturalNumber
    {
        private List<int> numbers = new List<int>();

        public void RunTask()
        {
            int n = int.Parse(Console.ReadLine());
            // PrintNumbers(n);
            PrintNumbers2(n, 1);
            Console.WriteLine();
        }
        private void PrintNumbers(int n)
        {
            if (n<=0)
            {
                foreach (var item in numbers)
                {
                    Console.Write(numbers[item-1]+ " ");
                }
            }
            else
            {
                numbers.Add(n);
                PrintNumbers(n - 1);
            }

        }
        private int PrintNumbers2(int n, int index)
        {
            if(0==n)
            {
                return index;
            }
            Console.Write(index + " ");
            return PrintNumbers2(n-1, index + 1);
        }
    }
    

}
