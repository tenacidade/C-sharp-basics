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
            //var number1 = 10;
            //if (number1 > 5)
            //{
            //    Console.WriteLine("var number1 which equals to " + number1 + " is greater than 5");
            //}
            //else
            //{
            //    Console.WriteLine("var number1 which equals to " + number1 + "is less than or equal to 5");
            //}

            //bool isRaining = true;
            //if (isRaining)
            //{
            //    Console.WriteLine("It is raining outside. Don't forget to take an umbrella!");
            //}
            //else
            //{
            //    Console.WriteLine("It is not raining outside. Enjoy your day!");
            //}

            //bool isGolden = true;
            //float price;
            //if (isGolden)
            //    price = 1000.50f;
            //else
            //    price = 500.25f;
            //Console.WriteLine(price);

            ////using ternary operator to assign value to price2 based on the condition of isGolden
            //float price2 = isGolden ? 1000.50f : 500.25f;
            //Console.WriteLine(price2);

            ////Now we'll use Season enum here to play with "switch"
            //var season = Season.Autumn;

            //switch (season)
            //{
            //    case Season.Autumn:
            //        Console.WriteLine("It's a beautiful Season: Autumn");
            //        break;

            //    case Season.Summer:
            //        Console.WriteLine("U ready to carnival and get a nice color?");
            //        break;

            //    case Season.Winter:
            //    case Season.Spring:
            //        Console.WriteLine("You can also use two options to return the same value!");
            //        break;

            //    default:
            //        Console.WriteLine("I don't understand the reason");
            //        break;

            //}

            ////Doing the exercises now

            ////Makes the user writes a valid number between 1 and 10, if the user writes an invalid number, it will show an error message
            //Console.WriteLine("Please enter a number between 1 and 10:");
            //string userInput = Console.ReadLine();
            //if (int.TryParse(userInput, out int validInputNumber) && validInputNumber >= 1 && validInputNumber <= 10)
            //{
            //    Console.WriteLine("Thank you for entering a valid number: " + validInputNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            //}

            ////Takes two numbers from the user and shows the result of addition:
            //Console.WriteLine("Please enter the first number:");
            //string firstInput = Console.ReadLine();
            //int convertedFirstInput = Convert.ToInt32(firstInput);
            //Console.WriteLine("Please enter the second number:");
            //string secondInput = Console.ReadLine();
            //int convertedSecondInput = Convert.ToInt32(secondInput);
            //Console.WriteLine("The sum is: " + (convertedFirstInput + convertedSecondInput));

            ////Ask the user to enter the width and height of an image. Then tell if the image is a landscape or portrait

            //Console.WriteLine("To tell if the image is a landscape or portrait, Please, enter the width:");
            //string userWidthInput = Console.ReadLine();
            //int convertedWidth = Convert.ToInt32(userWidthInput);
            //Console.WriteLine("Now, inserte the height:");
            //string userHeightInput = Console.ReadLine();
            //int convertedHeight = Convert.ToInt32(userHeightInput);

            //if (convertedWidth > convertedHeight)
            //{
            //    Console.WriteLine("The image is a landscape");

            //}
            //else if (convertedWidth < convertedHeight)
            //{
            //    Console.WriteLine("The image is a portrait");
            //}
            //else
            //{ Console.WriteLine("This is a square image. Not a landscape neither a portrait.");
            //}

            ////Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            ////Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
            ////If the user enters a value less than the speed limit, program should display Ok on the console.
            ////If the value is above the speed limit, the program should calculate the number of demerit points.
            ////For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            ////If the number of demerit points is above 12, the program should display License Suspended.

            //Console.WriteLine("Please, enter the speed limit in this range of the road:");
            //int speedLimit = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The speed limit is " + speedLimit + "kilometers per hour. Ok, now please insert the speed of the car:");
            //int carSpeed = Convert.ToInt32(Console.ReadLine());

            //if (carSpeed <= speedLimit)
            //{
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    int excessSpeed = carSpeed - speedLimit;
            //    int demeritPoints = excessSpeed / 5;

            //    Console.WriteLine("Demerit points: " + demeritPoints);

            //    if (demeritPoints >=12)
            //        {
            //        Console.WriteLine("Perdeu playboy, passa a carteira");
            //        }
            //}

            //Now let's play with loops

            for (var i = 1; i <= 10; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            for (var y = 10; y >= 1; y--)
                if (y % 2 == 0)
                {
                    Console.WriteLine(y);
                }

            //foreach is easier to understand, see:

            var name = "Brené Brown";

            for (var b = 0; b < name.Length; b++)
            {
                Console.WriteLine(name[b]);
            }

            //now with foreach ;)
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4, };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //while
            var w = 0;
            while (w <= 10)
            {
                if (w % 2 == 0) //there's no {} here

                    Console.WriteLine(w);
                w++;

            }

            //equal program:

            while (true)
            {
                Console.Write("Type your name: "); //uses Write so the cursor appear in the same line ;)
                var nameInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(nameInput)) //don't use ';' here or you're finishing the if statement
                    break;

                Console.WriteLine("@Echo: " + nameInput);
            }

            while (true)
            {
                Console.Write("Type your name2: "); //uses Write so the cursor appear in the same line ;)
                var nameInput2 = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(nameInput2))
                {
                    Console.WriteLine("@Echo: " + nameInput2);
                    continue; //use continue instead of break because you're negating the if statement now.
                }

                break;


            }

            //exercises :)

            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            var nmbr = 1;
            var count = 0;
            while (nmbr <= 100)
            {
                if (nmbr % 3 == 0)
                    count++;
                nmbr++;
            }
            Console.WriteLine(count);

            //Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.


            Console.WriteLine("Enter a number or write 'ok' to exit. All numbers typed will be summed and displayed in the console when you enter 'ok'");

            var sum = 0;

            while (true)
            {
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "ok")
                {
                    break;
                }

                int number;

                if (int.TryParse(userInput, out number))
                //try to convert the user input to a number, if it works, add it to the sum, if not, show an error message
                {
                    sum += number; //equals to sum = sum + number
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or 'ok' to exit.");
                }
            }
            Console.WriteLine("The sum of the values is " + sum);

            //Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.WriteLine("Enter a number. I'll compute the factorial of this number to you ;)");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int factorialNumber) && factorialNumber >= 0)
            {
                int factorial = 1;
                for (int i = 1; i <= factorialNumber; i++)
                {
                    factorial *= i; //equals to factorial = factorial * i
                }
                Console.WriteLine(factorialNumber + "! = " + factorial);
                //break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }

            //Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

            var random = new Random();
            int secretNumber = random.Next(1, 11); //generates a random number between 1 and 10
            Console.WriteLine("The secret number is: " + secretNumber); //display the secret number for testing purposes

            int attempts = 4;
            bool isGuessed = false;

            while (attempts > 0)
            {
                Console.WriteLine("Guess the number (between 1 and 10):");
                var guessInput = Console.ReadLine();

                if (int.TryParse(guessInput, out int guessedNumber) && guessedNumber >= 1 && guessedNumber <= 10)
                {
                    if (guessedNumber == secretNumber)
                    {
                        Console.WriteLine("You won!");
                        isGuessed = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess. Try again.");
                        attempts--;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                }
            }

            if (!isGuessed)
            {
                Console.WriteLine("You lost! The secret number was: " + secretNumber);
            }

            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter a series of numbers separated by comma:");

            var numbersInput = Console.ReadLine();
            //Receiving the whole user input as a string

            string[] numberStrings = numbersInput.Split(',');

            //string[] numberStrings = Console.ReadLine().Split(',');
            //Receiving the user input and breaking it into an array of strings using comma as a separator


            int maxNumber = int.MinValue;

            foreach (var numberString in numberStrings)
            {
                if (int.TryParse(numberString.Trim(), out int number)) //Converting each piece into a number and trimming any whitespace
                {
                    if (number > maxNumber) //if the current number is greater than maxNumber, update maxNumber
                    {
                        maxNumber = number;
                    }
                    //if statements to keep track of the maximum values among the numbers entered by the user
                }
                else
                {
                    Console.WriteLine("Invalid input: " + numberString + " is not a valid number.");
                }
            }
            Console.WriteLine("The max number between the numbers you typed is: " + maxNumber);
            
           
        }
    }
}
