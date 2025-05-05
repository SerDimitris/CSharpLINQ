/*
 * Write a program in C# Sharp to accept list members through
 * the keyboard and display them more than a specific value.
 * 
 * Test Data:
 * Input the number of members on the List : 5
 * Member 0 : 10
 * Member 1 : 48
 * Member 2 : 52
 * Member 3 : 94
 * Member 4 : 63
 * 
 * Input the value above you want to display the members of the List: 59
 * 
 * Expected Output:
 * The numbers greater than 59 are :
 * 94
 * 63
 */

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert the number of members for the list.");
                bool input = int.TryParse(Console.ReadLine(), out int number);

                if (input && number > 0)
                {
                    int[] array = new int[number];

                    for (int i = 0; i < array.Length; i++)
                    {
                        while (true)
                        {
                            Console.WriteLine($"Please insert the #{i} value.");
                            bool arrayInput = int.TryParse(Console.ReadLine(), out int numberArray);

                            if (arrayInput)
                            {
                                array[i] = numberArray;
                                break;
                            }
                            else Console.WriteLine("Invalid value. try again.");
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("Input the number to display the rest numbers above it.");
                        bool inputNumber = int.TryParse(Console.ReadLine(),out int numberToCompare);

                        if (inputNumber)
                        {
                            var numbers = from n in array
                                          where n > numberToCompare
                                          select n;

                            Console.WriteLine($"The numbers greater than {numberToCompare} are:");

                            foreach (int n in numbers)
                            {
                                Console.WriteLine($"{n}");
                            }
                            break;
                        } else Console.WriteLine("Invalid number to compare, try again.");
                    }
                    
                }
            }
        }
    }
}
