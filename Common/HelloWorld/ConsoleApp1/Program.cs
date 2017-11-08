using System;
using TheAnsweringMachine;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine($"The answer is: {TheMachine.GetTheAnswer("Give it to me")}");
            Console.WriteLine("Thats good to know!");
        }
    }
}
