﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will execute if no other case is evaluated.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hope you are ready to work!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry we are closed");
                    break;
            }

            //-- Challenge
            // Ask the user how they are feeling on a scale of 1-5. Capture their input and run it through a switch statement. Output a different response for each value. If they respond out of range, let them know.

            Console.WriteLine("On a scale of 1-5, how are you feeling?");
            string feeling = Console.ReadLine();
            int rating = int.Parse(feeling);
            switch (rating)
            {
                case 1:
                    Console.WriteLine("Why so blue?");
                    break;
                case 2:
                    Console.WriteLine("Case of the Mondays?");
                    break;
                case 3:
                    Console.WriteLine("Feeling just average?");
                    break;
                case 4:
                    Console.WriteLine("Yay! Today is great!");
                    break;
                case 5:
                    Console.WriteLine("WOW, You feel Amazing!!!!!");
                    break;
                default:
                    Console.WriteLine("You did not enter a valid number");
                    break;

            }
            Console.ReadKey();
        }
    }
}
