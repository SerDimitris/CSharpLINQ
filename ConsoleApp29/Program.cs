/*
 * Write a program in C# Sharp to split a collection of strings into some groups.
 * 
 * Expected Output.
 * Here is the group of cities :
 * 
 * ROME; LONDON; NAIROBI
 * -- here is a group of cities --
 * 
 * CALIFORNIA; ZURICH; NEW DELHI
 * -- here is a group of cities --
 * 
 * AMSTERDAM; ABU DHABI; PARIS
 * -- here is a group of cities --
 * 
 * NEW YORK
 * -- here is a group of cities --
 */

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = {"Rome", "London", "Nairobi",
                "California", "Zurich", "New Delhi",
                "Amsterdam", "Adu Dhabi", "Paris", "New York"};

            var groupedCities = from c in Enumerable.Range(0, cities.Length)
                                group cities[c] by c / 3;
            Console.WriteLine("Here is the group of cities:");
            foreach (var c in groupedCities) Console.WriteLine("{0}\n-----------", string.Join(' ', c.ToArray()));
        }
    }
}
