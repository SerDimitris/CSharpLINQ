/*
 * Write a program in C# Sharp to display the number
 * and frequency of a given number from an array.
 */

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 3, 4, 5, 6, 6, 7, 5, 7, 7, 2, 1, 1, 1, 1, 4, 5, 3, 2 };

            Console.WriteLine("Please insert number to count.");
            int target = int.Parse(Console.ReadLine());

            var frequency = from n in numbers
                            group n by n into y
                            where y.Key == target
                            select new { Number = y.Key, Count = y.Count() };

            foreach (var item in frequency) Console.WriteLine($"{item.Number} appears {item.Count} times.");
        }
    }
}