using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankTask.Task.Interview_Preparation_Kit.Arrays
{
    public class LeftRotation : BaseTask
    {
        public override void RunTask()
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] result = RotLeft(a, d);
 
        }
        private int[] RotLeft(int[] a, int index)
        {
            List<int> elements = new List<int>();
            for (int i = index; i < a.Length; i++)
            {
                elements.Add(a[i]);
            }
            for (int i = 0; i < index; i++)
            {
                elements.Add(a[i]);
            }
            return elements.ToArray();
      
        }
    }
}