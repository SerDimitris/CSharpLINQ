/*
 * Write a program in C# Sharp to remove items from
 * list using remove function by passing the object.
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
 * Here is the list after removing the item 'o' from the list :
 * Char: m
 * Char: n
 * Char: p
 * Char: q
 */

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItemManager itemManager = new ItemManager();

            while (true)
            {
                Console.WriteLine("Please insert a char to store. Press 0 to exit.");

                if (Char.TryParse(Console.ReadLine(), out char result))
                {
                    if (result == '0') break;
                    itemManager.AddChar(result);
                } else Console.WriteLine("Invalid input, try again.");
            }

            Console.WriteLine("Insert a char to remove.");
            Char.TryParse(Console.ReadLine(), out char charToDelete);
            itemManager.RemoveChar(charToDelete);
            itemManager.PrintChar();
           
        }

        public class ItemManager()
        {
            List<Char> characters = new List<Char>();

            public void AddChar(Char ch)
            {
                characters.Add(ch);
            }

            public bool RemoveChar(Char ch)
            {
                return characters.Remove(ch);
            }

            public void PrintChar()
            {
                Console.WriteLine("The updated list is:");
                foreach (char ch in characters) Console.WriteLine(ch);
            }
        }

    }
}
