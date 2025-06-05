/*
 * Write a program in C# Sharp to find the strings for a specific minimum length.
 * 
 * Test Data :
 * Input number of strings to store in the array :4
 * Input 4 strings for the array:
 * Element[0] : this
 * Element[1] : is
 * Element[2] : a
 * Element[3] : string
 * Element[4] : awesome
 * 
 * Input the minimum length of the item you want to find : 5
 * 
 * Expected Output:
 * The items of minimum 5 characters are :
 * Item: string
 */

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("this");
            listOfStrings.Add("is");
            listOfStrings.Add("a");
            listOfStrings.Add("string");
            listOfStrings.Add("awesome");

            var _list = from s in listOfStrings
                        where s.Length >= 5
                        select s;

            foreach (var s in _list) Console.WriteLine(s);
        }
    }
}
