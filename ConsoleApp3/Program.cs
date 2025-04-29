/*
 * Write a program in C# Sharp to find the number of an array
 * and the square of each number.
 * 
 * Expected Output:
 * { Number = 9, SqrNo = 81 }
 * { Number = 8, SqrNo = 64 }
 * { Number = 6, SqrNo = 36 }
 * { Number = 5, SqrNo = 25 }
 */

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 9, 2, 8, 6, 5 };

            var sqrdNumb = array.Select(n => new { n, sqNumb = n * n }).Where(x => x.sqNumb > 20);

            foreach (var i in sqrdNumb) Console.WriteLine(i + " ");
        }
    }
}
