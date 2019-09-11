using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankTask.Task.Problem_Solving.DataStructures
{
   public class SparseArrays : BaseTask
    {
        public override void RunTask()
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            int[] res = matchingStrings(strings, queries);
            Console.WriteLine(string.Join(" ",res));
        }
        private int[] matchingStrings(string[] strings, string[] queries)
        {
            List<int> result = new List<int>();
            var br = 0;
            for (int i = 0; i < queries.Length; i++)
            {
                for (int j = 0; j < strings.Length; j++)
                {
                    if (queries[i]==strings[j])
                    {
                        br++;
                    }
                }
                result.Add(br);
                br = 0;
            }
            return result.ToArray();
        }
    }
}
