using SuperFizzBuzz;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var outputList = FizzBuzz.GetRange(Tuple.Create(1, 100));
            var tokenList = new List<(int, string)>
                              {
                                  (3, "Fizz"),
                                  (5, "Buzz")
                              };

            foreach (int x in outputList)
            {
                Console.WriteLine(x.FizzBuzzCheck(tokenList));
            }




            FizzBuzz fb = new FizzBuzz((1, 100), tokenList);




            Console.WriteLine("Console App 1 Complete! Press any key to exit...");
            Console.ReadKey();
        }
    }
}
