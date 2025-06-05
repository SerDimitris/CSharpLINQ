/*
 * Write a program in C# Sharp to display the list of items
 * in the array according to the length of the string then
 * by name in ascending order.
 * 
 * Expected Output :
 * Here is the arranged list :
 * ROME
 * PARIS
 * LONDON
 * ZURICH
 * NAIROBI
 * ABU DHABI
 * AMSTERDAM
 * NEW DELHI
 * CALIFORNIA
 */

namespace ConsoleApp28
{
    public class City
    {
        public string? Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> listOfCities = new List<City>
            {
                new City { Name = "ZURICH" },
                new City { Name = "ROME" },
                new City { Name = "NAIROBI" },
                new City { Name = "CALIFORNIA" },
                new City { Name = "ABU DHABI" },
                new City { Name = "PARIS" },
                new City { Name = "LONDON" },
                new City { Name = "AMSTERDAM" },
                new City { Name = "NEW DELHI" }
            };

            var _list = listOfCities
                .OrderBy(city => city.Name?.Length)
                .ThenBy(city => city.Name);

            foreach (var city in _list) Console.WriteLine(city.Name);
        }
    }
}
