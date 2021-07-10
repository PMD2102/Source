using System.Threading;
using System;

namespace Source
{
    class Program
    {
        static void DoSomeThing(int seconds, string mgs)
        {
            Thread.Sleep(5000);
        }
        static void Main(string[] args)
        {
            DoSomeThing(0, "abc");
            Console.WriteLine("Hello World!");
        }
    }
}
