using C_sharp_basics.Math; //importing the Math namespace to use the Calculator class
using C_sharp_basics.Vehicle; //importing the Vehicle namespace to use the Car struct

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

            float price2 = isGolden ? 1000.50f : 500.25f; //using ternary operator to assign value to price2 based on the condition of isGolden
            Console.WriteLine(price2);
        }
    }
}
