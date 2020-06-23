using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndV_alueTypes
{
    enum PastryType { Cake, Cupcake, Croissant, Donut, Cookie, Danish, Scone};
    class Program
    {
        static void Main(string[] args)
        {
            // booleans
            bool isDeclared;
            isDeclared = true;

            bool isDelcaredAndInitialized = false;
            isDelcaredAndInitialized = true;

            // must be only 1 character and must use single quotes
            char character = 'a';
            char symbol = '&';
            char number = '5';
            char space = ' ';
            char specialCharacter = '\n';

            // whole numbers
            byte byteExample = 255; //highest a byte can go - unsigned integer is 0 or positive (not negative)
            sbyte sByteExample = -128; // signed integer is negative, 0, or positive
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 7;
            int b = -7000;

            byte age = 104;

            // decimals
            float floatExample = 1.045231f; //must have f in order to be a float otherwise it is a double
            double doubleExample = 1.789053278907036d; // double is defauklt type with decimal (d is not necessary)
            decimal decimalExample = 1.2578907289045789789789789787897m;
            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);


            Console.ReadKey();

            // enums
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Donut;

            // structs
            Int32 num = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1805,11,24);
            DateTime test = new DateTime();
        }
    }
}
