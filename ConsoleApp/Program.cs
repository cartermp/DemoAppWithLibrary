using System;
using ClassLibrary;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Library.GetGreeting(args[0]));
        }
    }
}
