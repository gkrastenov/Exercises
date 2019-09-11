using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HackerrankTask.Task
{
    public class _2DArrayDS : BaseTask
    {
        
        public override void RunTask()
        {  
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
            Console.WriteLine(result);
        }
        private int hourglassSum(int[][] arr)
        {
            List<int> listOfSum = new List<int>();
            var sum = 0;
            for (int i = 0; i <4; i++)
            {
                for (int j = 0; j <4; j++)
                {
                    // upper
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    // mid
                    sum += arr[i + 1][j + 1];
                    // down
                    sum += arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    listOfSum.Add(sum);
                    sum = 0;
                }
            }
            return listOfSum.OrderByDescending(item => item).First();
        }
    }
}
