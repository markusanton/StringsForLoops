using System;

namespace StringsForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";
            Console.WriteLine(helloWorld[0]);
            Console.WriteLine(helloWorld[6]);

            int stringLength = helloWorld.Length;
            Console.WriteLine($"Your string contains: {stringLength} characters.");

            char searchCriteria = 'o';
            int i = 0;

            foreach(char letter in helloWorld)
            {
                if (letter == searchCriteria)
                {
                    i++; 
                }
            }
            Console.WriteLine($"There are {i} Os in your string.");
        }
    }
}
