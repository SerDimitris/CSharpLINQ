/*
 * Write a program in C# Sharp to remove items from
 * list by creating an object internally by filtering.
 * 
 * Test Data :
 * Here is the list of items :
 * Char: m
 * Char: n
 * Char: o
 * Char: p
 * Char: q
 * 
 * Expected Output :
 * Here is the list after removing the item 'p' from the list :
 * Char: m
 * Char: n
 * Char: o
 * Char: q
 */

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            list.Add('m');
            list.Add('o');
            list.Add('p');
            list.Add('q');

            Console.WriteLine("The original list.");
            foreach (char c in list) Console.WriteLine(c);

            char toRemove = 'p';

            var filtered = list.Where(ch => ch != toRemove);

            Console.WriteLine("The updated list.");
            foreach (char ch in filtered) Console.WriteLine(ch);
        }
    }
}