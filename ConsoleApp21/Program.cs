/*
 * Write a program in C# Sharp to remove a range of
 * items from a list by passing the start index and
 * number of elements to remove.
 * 
 * Test Data :
 * Here is the list of items :
 * Char: m
 * Char: n
 * Char: o
 * Char: p
 * Char: q
 * 
 * Expected Output:
 * Here is the list after removing the three items
 * starting from the item index 1 from the list :
 * Char: m
 * Char: q
 */

using System.Runtime.InteropServices;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> chars = new List<char>();

            chars.Add('m');
            chars.Add('n');
            chars.Add('o');
            chars.Add('p');
            chars.Add('q');


            Console.WriteLine("This is the original list:");
            foreach (char c in chars) Console.WriteLine(c);

            chars.RemoveRange(1, 3);

            Console.WriteLine("\nThis is the list after removing the requested indexes:");
            foreach (char z in chars) Console.WriteLine(z);
        }
    }
}
