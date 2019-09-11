using System;
using System.Diagnostics;

namespace Exercise2
{
    class Program
    {
        private static string expression;

        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string correctInput = CheckForDot(input);
            if (correctInput == "Invalid input!")
            {
                Console.WriteLine(correctInput);
            }
            else
            {
                var tokens = new Tokenizer(expression).Tokenize();
                Stopwatch stopwatch = Stopwatch.StartNew();
                var parser = new Parser(tokens);
                stopwatch.Stop();
                parser.CodeExecute = stopwatch.Elapsed;
                var result = parser.Parse();
                
                Console.WriteLine(result.ToString());
                Console.Write("Time for execude code : ");
                Console.WriteLine(parser.CodeExecute);
                
            }
        }
        static string CheckForDot(string newInput)
        {
            char lastSymbol = newInput[newInput.Length - 1];
            if (lastSymbol == '.')
            {
                // remove dot from last word in input
               expression = newInput.Remove(newInput.Length - 1, 1);
                return "Correct input!";
            }
            else
            {
                return "Invalid input!";
            }
        }
    }
}
