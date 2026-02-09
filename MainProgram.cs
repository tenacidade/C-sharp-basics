using C_sharp_basics.Math; //importing the Math namespace to use the Calculator class
using C_sharp_basics.Vehicle;
using Conditionals;
using System.ComponentModel.Design; //importing the Conditionals namespace to use the Season enum

namespace C_sharp_basics
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            var number1 = 10;
            if (number1 > 5)
            {
                Console.WriteLine("var number1 which equals to " + number1 + " is greater than 5");
            }
            else
            {
                Console.WriteLine("var number1 which equals to " + number1 + "is less than or equal to 5");
            }

            bool isRaining = true;
            if (isRaining)
            {
                Console.WriteLine("It is raining outside. Don't forget to take an umbrella!");
            }
            else
            {
                Console.WriteLine("It is not raining outside. Enjoy your day!");
            }

            bool isGolden = true;
            float price;
            if (isGolden)
                price = 1000.50f;
            else
                price = 500.25f;
            Console.WriteLine(price);

            //using ternary operator to assign value to price2 based on the condition of isGolden
            float price2 = isGolden ? 1000.50f : 500.25f;
            Console.WriteLine(price2);

            //Now we'll use Season enum here to play with "switch"
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's a beautiful Season: Autumn");
                    break;

                case Season.Summer:
                    Console.WriteLine("U ready to carnival and get a nice color?");
                    break;

                case Season.Winter:
                case Season.Spring:
                    Console.WriteLine("You can also use two options to return the same value!");
                    break;

                default:
                    Console.WriteLine("I don't understand the reason");
                    break;

            }

            //Doing the exercises now

            //Makes the user writes a valid number between 1 and 10, if the user writes an invalid number, it will show an error message
            Console.WriteLine("Please enter a number between 1 and 10:");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int validInputNumber) && validInputNumber >= 1 && validInputNumber <= 10)
            {
                Console.WriteLine("Thank you for entering a valid number: " + validInputNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }

            //Takes two numbers from the user and shows the result of addition:
            Console.WriteLine("Please enter the first number:");
            string firstInput = Console.ReadLine();
            int convertedFirstInput = Convert.ToInt32(firstInput);
            Console.WriteLine("Please enter the second number:");
            string secondInput = Console.ReadLine();
            int convertedSecondInput = Convert.ToInt32(secondInput);
            Console.WriteLine("The sum is: " + (convertedFirstInput + convertedSecondInput));

            //Ask the user to enter the width and height of an image. Then tell if the image is a landscape or portrait

            Console.WriteLine("To tell if the image is a landscape or portrait, Please, enter the width:");
            string userWidthInput = Console.ReadLine();
            int convertedWidth = Convert.ToInt32(userWidthInput);
            Console.WriteLine("Now, inserte the height:");
            string userHeightInput = Console.ReadLine();
            int convertedHeight = Convert.ToInt32(userHeightInput);

            if (convertedWidth > convertedHeight)
            {
                Console.WriteLine("The image is a landscape");

            }
            else if (convertedWidth < convertedHeight)
            {
                Console.WriteLine("The image is a portrait");
            }
            else
            { Console.WriteLine("This is a square image. Not a landscape neither a portrait.");
            }

            //Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            //Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
            //If the user enters a value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of demerit points.
            //For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            //If the number of demerit points is above 12, the program should display License Suspended.

            Console.WriteLine("Please, enter the speed limit in this range of the road:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The speed limit is " + speedLimit + "kilometers per hour. Ok, now please insert the speed of the car:");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int excessSpeed = carSpeed - speedLimit;
                int demeritPoints = excessSpeed / 5;

                Console.WriteLine("Demerit points: " + demeritPoints);

                if (demeritPoints >=12)
                    {
                    Console.WriteLine("Perdeu playboy, passa a carteira");
                    }
            }
           


        }
    }
}
