using System;

namespace myFC_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease enter your name");
            var name  = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello , {name} on {date:d} and {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
