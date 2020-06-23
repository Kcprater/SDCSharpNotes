using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // strings
            string thisIsDeclaration;

            string declared;
            declared = "This is initialized.";

            string declarationAndInitialization = "This is both delcaring and initializing";

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            // concatenation
            string concatenatedFullName = firstName + " " + lastName;

            //composite
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            //interpolation
            string interpolatedFullName = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedFullName);

            // COLLECTIONS
            // array - set number of items can not add more to array
            string stringExample = "Hello World!";
            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample, "?" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);

            // list
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("First string of our list");
            listOfIntegers.Add(4242);
            listOfIntegers.Add(12345);
            Console.WriteLine(listOfIntegers[0]);

            // queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next!");
            string firstItem = firstInFirstOut.Dequeue(); //takes first item, saves it then moves on
            Console.WriteLine(firstItem);

            // dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "Agent");
            string valueSeven = keyAndValue[7]; //give key to get value assigned back
            Console.WriteLine(valueSeven);

            // other collection examples
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>(); //like dishes - last dish in sink is first washed

            // classes
            Random rng = new Random();

            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);

            Console.ReadKey();
        }
    }
}
