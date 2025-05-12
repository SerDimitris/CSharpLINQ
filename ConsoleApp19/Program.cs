/*
 * Write a program in C# Sharp to remove
 * items from list by passing filters.
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
 * Here is the list after removing item 'q' from the list :
 * Char: m
 * Char: n
 * Char: o
 * Char: p
 */

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Char> chars = new List<char>();
            chars.Add('m');
            chars.Add('n');
            chars.Add('o');
            chars.Add('p');
            chars.Add('q');
            chars.Add('o');

            chars.RemoveAll(en => en == 'o');

            var _list = from z in chars
                        select z;

            foreach (var z in _list) Console.WriteLine(z);
        }
    }
}