using System;

namespace TestEntretien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting..");
            TestAlgo.Test2();
            char myChar = TestLinq.FindCharWithMaxOccurence();

            Console.WriteLine("complete");
            Console.ReadLine();
        }
    }
}
