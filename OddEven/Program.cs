/* Author: Arjun Chopra
 * Date: September 14 2018
 * Program Name: OddEven
 * Program Description: This program tells whether a number is Even or Odd
 * 
 * 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables

            int number;     //input
            bool isNumber;  //Validation: if input is a whole number
            int remainder;  //Store the remainder of the devision

            // Name of the Program

            Console.Title = "ICE 2 - Even Odd Number";


            // Prompt for a whole number

            Console.Write("Enter a whole number: ");
            isNumber = int.TryParse(Console.ReadLine(),out number);

            // If not a whole number, display an error message
            if (isNumber == false) // test if both sides are equal
            {
                // Write an error message
                Console.WriteLine("Invalid input.");
            }
            // It is a whole number

            else
            {
                //Check if number is even or odd

                //If number is divisible by 2,It's even,otherwise it's odd.

                //Divide the number by 2 and store the remainder in a variable
                remainder = number % 2;


                if (remainder == 0)
                {
                    // Write number is even
                    Console.WriteLine(number + " is an even number");

                }
                else
                {
                    // Write number is odd
                    Console.WriteLine(number + " is an odd number");

                }

            }


            // Ask for any key to be pressed

            Console.Write("\nPress any key to exit..");
            Console.ReadKey();
        }
    }
}
