/*
 * Write a program in C# Sharp to show how
 * the three parts of a query operation execute.
 * 
 * Expected Output:
 * The numbers which produce the remainder 0 after divided by 2 are: 0 2 4 6 8
 */
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var updatedNums = DividedByTwo(nums);

            Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are: ");
            foreach (int i in updatedNums) Console.Write(i + " ");
        }

        public static int[] DividedByTwo(int[] nums)
        {
            return nums.Where(x => x % 2 == 0).ToArray();
        }
    }
}