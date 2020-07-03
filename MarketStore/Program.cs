using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {

            Bronze bronze = new Bronze(0, 150);
            bronze.Print();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Silver silver = new Silver(600, 850);
            silver.Print();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Gold gold = new Gold(1500, 1300);
            gold.Print();
        }
    }
}
