using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class CalculatePower
    {
       /*Test Data :
         Input the base value : 5
         Input the exponent : 3
         Expected Output :
         The value of 5 to the power of 3 is : 125*/

        public void RunTask()
        {
            int value = int.Parse(Console.ReadLine());
            int exponent  = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(value, exponent));

        }
        private int Power(int value,int exponet)
        {
            if (exponet==0)
            {
                return 1;
            }
            return Power(value, exponet - 1) * value;
        }
    }
}
