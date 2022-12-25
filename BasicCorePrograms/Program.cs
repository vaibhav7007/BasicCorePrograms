using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //UC2 Leap Year check
            LeapYear leapYear = new LeapYear();
            leapYear.FindLeap();
            Console.ReadLine();
        }
    }
}