/*
 * Write a program in C# Sharp to generate a cartesian product of three sets.
 * 
 * Expected Output :
 * 
 * The cartesian product are :
 * { letter = X, number = 1, colour = Green }
 * { letter = X, number = 1, colour = Orange }
 * { letter = X, number = 2, colour = Green }
 * { letter = X, number = 2, colour = Orange }
 * { letter = X, number = 3, colour = Green }
 * { letter = X, number = 3, colour = Orange }
 * { letter = Y, number = 1, colour = Green }
 * { letter = Y, number = 1, colour = Orange }
 */

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> listChar = new List<char>();
            List<int> listInt = new List<int>();
            List<string> listString = new List<string>();

            listChar.Add('X');
            listChar.Add('Y');

            listInt.Add(1);
            listInt.Add(2);

            listString.Add("Green");
            listString.Add("Orange");

            var _list = from c in listChar
                        from i in listInt
                        from s in listString
                        select (c, i, s);

            foreach (var (c, i, s) in _list) Console.WriteLine($"letter = {c}, number = {i}, color = {s}");
        }
    }
}
