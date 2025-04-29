/*
 * Write a program in C# Sharp to display the name of the days of the week.
 */

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            var days = from day in daysOfWeek
                       select day;

            foreach (var day in days) Console.WriteLine(day);
        }
    }
}