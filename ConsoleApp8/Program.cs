/*
 * Write a program in C# Sharp to find a string
 * that starts and ends with a specific character.
 * 
 * Test Data :
 * The cities are: 'ROME','LONDON','NAIROBI', 'CALIFORNIA',
 * 'ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
 * 
 * Input starting character for the string : A
 * Input ending character for the string : M
 * 
 * Expected Output :
 * The city starting with A and ending with M is: AMSTERDAM
 */

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS" };

            Console.WriteLine("Insert first and last letter.");
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());

            var city = from c in cities
                       where c.StartsWith(firstLetter)
                       where c.EndsWith(secondLetter)
                       select c;

            foreach (var item in city)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
