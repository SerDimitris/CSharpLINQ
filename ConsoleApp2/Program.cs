/*
 * Write a program in C# Sharp to find the positive numbers from
 * a list of numbers and less than 12 using two where conditions in LINQ Query.
 * 
 * Expected Output:
 * The numbers within the range of 1 to 11 are: 1 3 6 9 10
 */

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var posNums = PositiveNumbers(array);

            Console.WriteLine("The positive numbers under 12 are:");
            foreach (int i in posNums) Console.Write(i + " ");
        }

        public static int[] PositiveNumbers(int[] numbers)
        {
            return numbers.Where(x => x > 0).Where(x => x < 12).ToArray();
        }
    }
}