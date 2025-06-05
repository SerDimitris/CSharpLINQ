/*
 * Write a program in C# Sharp to generate a cartesian product of two sets.
 * 
 * Expected Output :
 * The cartesian product are :
 * { letterList = X, numberList = 1 }
 * { letterList = X, numberList = 2 }
 * { letterList = X, numberList = 3 }
 * { letterList = X, numberList = 4 }
 */

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> listChar = new List<char>();
            List<int> numbers = new List<int>();

            listChar.Add('X');

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            var _list = from c in listChar
                        from n in numbers
                        select (c, n);

            foreach (var (c, n) in _list) Console.WriteLine($"The letter is: {c} and the number is: {n}");
        }
    }
}
