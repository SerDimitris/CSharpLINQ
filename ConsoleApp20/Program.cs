/*
 * Write a program in C# Sharp to remove items from list by passing the item index.
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
 * Here is the list after removing item index 3 from the list :
 * Char: m
 * Char: n
 * Char: o
 * Char: q
 */

using System.ComponentModel.Design;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();

            list.Add('m');
            list.Add('n');
            list.Add('o');
            list.Add('p');
            list.Add('q');

            while (true)
            {
                Console.WriteLine("Please provide an index (int).");
                bool input = int.TryParse(Console.ReadLine(), out int index);

                if (input)
                {
                    list.RemoveAt(index);
                    var _list = from z in list
                                select z;
                    foreach (var z in _list) Console.WriteLine(z);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
            }
        }
    }
}
