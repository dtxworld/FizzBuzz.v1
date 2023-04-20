using SuperFizzBuzz;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var outputList = FizzBuzz.GetRange(Tuple.Create(-12, 145));
            var tokenList = new List<(int, string)>
                              {
                                  (3, "Fizz"),
                                  (7, "Buzz"),
                                  (38, "Bazz")
                              };

            foreach (int x in outputList)
            {
                Console.WriteLine(x.FizzBuzzCheck(tokenList));
            }

            Console.WriteLine("Console App 2 Complete! Press any key to exit...");
            Console.ReadKey();
        }
    }
}