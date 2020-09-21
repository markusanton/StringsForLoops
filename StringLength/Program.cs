using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            int stringLength = userName.Length;
            Console.WriteLine($"Your name is {stringLength} characters long.");
           
        }
    }
}
