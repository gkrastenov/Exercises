using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionTasks.Tasks
{
   public class Palindrome
   {
        public void RunTask()
        {
            char[] symbols = Console.ReadLine().ToCharArray();
            Console.WriteLine(IsPalindrome(symbols, 0, symbols.Length - 1));
        }
        private bool IsPalindrome(char[] symbols, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return true;
            }
            if (symbols[startIndex]==symbols[endIndex])
            {
                return IsPalindrome(symbols, startIndex + 1, endIndex - 1);
            }
            else
            {
                return false;
            }
        }
        private bool IsPalindromeRecursion2(string str)
        {
            // str is char[] elements
            if (str.Length == 1 || (str.Length == 2 && str[0] == str[1]))
            {
                return true;
            }
            else if (str.Length > 1)
            {
                if (str[0] != str[str.Length - 1])
                {
                    return false;
                }

                return IsPalindromeRecursion2(str.Substring(1, str.Length - 2));
            }

            return false;
        }

    }
}
