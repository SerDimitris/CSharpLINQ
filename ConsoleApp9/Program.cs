/*
 * Write a program in C# Sharp to create a list
 * of numbers and display numbers greater than 80.
 * 
 * Test Data:
 * The members of the list are: 55 200 740 76 230 482 95
 * 
 * Expected Output :
 * The numbers greater than 80 are:
 * 200
 * 740
 * 230
 * 482
 * 95
 */

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 55, 200, 740, 76, 230, 482, 95 };

            var number = from n in array
                         where n > 80
                         select n;

            foreach (var n in number) Console.WriteLine(n);
        }
    }
}
