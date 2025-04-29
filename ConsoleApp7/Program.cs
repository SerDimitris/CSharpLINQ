/*
 * Write a program in C# Sharp to display numbers,
 * multiplication of numbers with frequency and
 * the frequency of a number in an array.
 * 
 * Test Data :
 * The numbers in the array are:
 * 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
 * 
 * Expected Output :
 * Number Number*Frequency Frequency
 * ------------------------------------------------
 * 5 15 3
 * 1 1 1
 * 9 9 1
 * 2 4 2
 */

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            foreach (int i in array)
            {
                var number = from n in array
                             group n by n into g
                             where g.Key == i
                             select new { Number = g.Key, Count = g.Count(), Multpl = g.Key * g.Count(), };

                foreach (var n in number) Console.WriteLine($"{n.Number}\t::\t{n.Multpl}\t::\t{n.Count}");
            }
        }
    }
}
