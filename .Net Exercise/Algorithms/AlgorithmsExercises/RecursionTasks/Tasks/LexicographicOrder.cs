using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    public class LexicographicOrder
    {
        public void RunTask()
        {
            String str = Console.ReadLine();
            powerSet(str);
        }
        // str : Stores input string 
        // n : Length of str. 
        // curr : Stores current permutation 
        // index : Index in current permutation, curr 
        private void permuteRec(String str, int n,
                               int index, String curr)
        {
            // base case 
            if (index == n)
            {
                return;
            }
            Console.WriteLine(curr);
            for (int i = index + 1; i < n; i++)
            {

                curr += str[i];
                permuteRec(str, n, i, curr);

                // backtracking 
                curr = curr.Substring(0, curr.Length - 1);
            }
            return;
        }

        // Generates power set in lexicographic 
        // order. 
        private void powerSet(String str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            permuteRec(new String(arr), str.Length, -1, "");
        }
    }
}
