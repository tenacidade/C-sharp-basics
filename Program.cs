namespace C_sharp_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! These are my first steps with C# into .NET");

            //// Data types and variables

            //var number = 12;
            //var count = 29;
            //var totalPrice = 20.95f;
            //var character = 'A';
            //var firstName = "Gabriel";
            //var isWorking = true;
            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);
            //Console.WriteLine();

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //this shows us the range of a byte
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); //this show us the range of a float

            //const float Pi = 3.14f;
            //Console.WriteLine(Pi);

            //// Type conversion

            //byte b = 1;
            //int i = b; // implicit conversion from byte to int
            //Console.WriteLine(b);
            //Console.WriteLine(i);

            //int x = 1;
            ////byte y = x; ... this won't compile because it's a narrowing conversion
            //byte y = (byte)x; // i'm saying to C# that this is a explicit conversion from int to byte

            //float f = 1.1f;
            //byte z = (byte)f; // explicit conversion from float to byte

            //string str = "1234";
            //int w = Convert.ToInt32(str); // converting string to int, can't use explicit conversion here, string and int are not compatible types;.

            //var myNumber = "2026";
            //Console.WriteLine(myNumber);
            //int myNumberConverted = Convert.ToInt32(myNumber);
            //Console.WriteLine(myNumberConverted);

            //int myBigNumber = 5000;

            //byte myByte = (byte)myBigNumber;
            //Console.WriteLine(myByte); //results to 136 because it looses a lot of when converting.

            ////What if I want to use Convert here instead using a explicit conversion?

            ////int mySecondBigNumber = 10000;
            ////byte mySecondByte = Convert.ToByte(mySecondBigNumber);
            ////Console.WriteLine(mySecondByte); //We'll get an unhandled exception.

            ////Dealing with undandled exceptions, preveting the application to crash:

            //try
            //{
            //    int myThirdBigNumber = 10000;
            //    byte myThirdByte = Convert.ToByte(myThirdBigNumber);
            //    Console.WriteLine(myThirdByte);
            //}
            //catch (Exception)
            //{
            //    {
            //        Console.WriteLine("The number can not be converted from int to byte");
            //    }
            //}

            //try
            //{
            //    string myString = "true";
            //    bool myBoolean = Convert.ToBoolean(myString);
            //    Console.WriteLine(myBoolean);
            //}
            //catch (Exception)
            //{
            //    {
            //        Console.WriteLine("The string couldn't be converted to a boolean");
            //    }
            //}

            // Using Operators
            /* Multiline comment start
           bool isGraduated = false;
           bool hasFiveYearsExperience = false;
           //change the values to play around
           bool isEligible = isGraduated || hasFiveYearsExperience;
           Console.WriteLine("is Eligible? " + isEligible);




           var x = 10;
           var y = 90;
           var z = 23;
           Console.WriteLine(x + y);
           Console.WriteLine(x - y);
           Console.WriteLine(x * y);
           Console.WriteLine(x / y);
           Console.WriteLine(x % y);
           Console.WriteLine((float)x / (float)y);
           Console.WriteLine(x > y);
           Console.WriteLine(x < y);
           Console.WriteLine(x == y);
           Console.WriteLine(x != y);
           Console.WriteLine(!(x != y)); // with ! before the expression, we are negating it (It is false that x is not equal to y)
           Console.WriteLine(x < y && x < z);
           Console.WriteLine(x > y || x < z);

           Multiline comment ends*/

            var x = true;

            var y = false;

            var z = true && false;
            Console.WriteLine(z);

        }
    }
}
