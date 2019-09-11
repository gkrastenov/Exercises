using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTasks.Tasks
{
    /*
           Input : s1 = "hello"
                   s2 = "geeksforgeeks"
           Output : s2 = "hello"

           Input :  s1 = "geeksforgeeks"
                    s2 = ""
           Output : s2 = "geeksforgeeks"
*/ 
    public class CopyString
    {
        public void RunTask()
        {
            char[] s1 = Console.ReadLine().ToCharArray();
            char[] s2 = Console.ReadLine().ToCharArray();
            s2=StringCopy(s1, s2,0,s1.Length-1);  // This method don't get/set length from s1
            Console.WriteLine(string.Join("",s2));
            
        }
        private char[] StringCopy(char[] string1, char[] string2,int index,int endIndex)
        {
            if (index>endIndex)
            {
                if (string1.Length<string2.Length)
                {
                    for (int i = index; i < string2.Length; i++)
                    {
                        string2[index] = ' ';
                    }
                }
                return string2;
            }
            else
            {
                string2[index] = string1[index];
                return StringCopy(string1, string2, index + 1, endIndex);
            }
        }
    }
}
