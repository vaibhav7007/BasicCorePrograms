using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FlipCoin flipCoin = new FlipCoin();
            flipCoin.FindPercentage();
            Console.ReadLine();
        }
    }
}