/*
 * Write a program in C# Sharp to display the characters
 * and frequency of each character in a given string.
 * 
 * Test Data:
 * 
 * Input the string: apple
 * 
 * Expected Output:
 * The frequency of the characters are:
 * Character a: 1 times
 * Character p: 2 times
 * Character l: 1 times
 * Character e: 1 times
 */

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "apple";

            var result = from c in example
                         group c by c into a
                         select new { Character = a.Key, Count = a.Count() };

            foreach (var item in result) Console.WriteLine($"{item.Character} :: {item.Count}");
        }
    }
}
