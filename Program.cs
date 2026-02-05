using C_sharp_basics.Math;
using C_sharp_basics.Vehicle;
using System.Security.Cryptography.X509Certificates;

namespace C_sharp_basics
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World! These are my first steps with C# into .NET");

    //        // Data types and variables

    //        var number = 12;
    //        var count = 29;
    //        var totalPrice = 20.95f;
    //        var character = 'A';
    //        var firstName = "Gabriel";
    //        var isWorking = true;
    //        Console.WriteLine(number);
    //        Console.WriteLine(count);
    //        Console.WriteLine(totalPrice);
    //        Console.WriteLine(character);
    //        Console.WriteLine(firstName);
    //        Console.WriteLine(isWorking);
    //        Console.WriteLine();

    //        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //this shows us the range of a byte
    //        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); //this show us the range of a float

    //        const float Pi = 3.14f;
    //        Console.WriteLine(Pi);

    //        // Type conversion

    //        byte b = 1;
    //        int i = b; // implicit conversion from byte to int
    //        Console.WriteLine(b);
    //        Console.WriteLine(i);

    //        int x = 1;
    //        //byte y = x; ... this won't compile because it's a narrowing conversion
    //        byte y = (byte)x; // i'm saying to C# that this is a explicit conversion from int to byte

    //        float f = 1.1f;
    //        byte z = (byte)f; // explicit conversion from float to byte

    //        string str = "1234";
    //        int w = Convert.ToInt32(str); // converting string to int, can't use explicit conversion here, string and int are not compatible types;.

    //        var myNumber = "2026";
    //        Console.WriteLine(myNumber);
    //        int myNumberConverted = Convert.ToInt32(myNumber);
    //        Console.WriteLine(myNumberConverted);

    //        int myBigNumber = 5000;

    //        byte myByte = (byte)myBigNumber;
    //        Console.WriteLine(myByte); //results to 136 because it looses a lot of when converting.

    //        //What if I want to use Convert here instead using a explicit conversion?

    //        //int mySecondBigNumber = 10000;
    //        //byte mySecondByte = Convert.ToByte(mySecondBigNumber);
    //        //Console.WriteLine(mySecondByte); //We'll get an unhandled exception.

    //        //Dealing with undandled exceptions, preveting the application to crash:

    //        try
    //        {
    //            int myThirdBigNumber = 10000;
    //            byte myThirdByte = Convert.ToByte(myThirdBigNumber);
    //            Console.WriteLine(myThirdByte);
    //        }
    //        catch (Exception)
    //        {
    //            {
    //                Console.WriteLine("The number can not be converted from int to byte");
    //            }
    //        }

    //        try
    //        {
    //            string myString = "true";
    //            bool myBoolean = Convert.ToBoolean(myString);
    //            Console.WriteLine(myBoolean);
    //        }
    //        catch (Exception)
    //        {
    //            {
    //                Console.WriteLine("The string couldn't be converted to a boolean");
    //            }
    //        }

    //        // Using Operators
    //        /* Multiline comment start
    //       bool isGraduated = false;
    //       bool hasFiveYearsExperience = false;
    //       //change the values to play around
    //       bool isEligible = isGraduated || hasFiveYearsExperience;
    //       Console.WriteLine("is Eligible? " + isEligible);




    //       var x = 10;
    //       var y = 90;
    //       var z = 23;
    //       Console.WriteLine(x + y);
    //       Console.WriteLine(x - y);
    //       Console.WriteLine(x * y);
    //       Console.WriteLine(x / y);
    //       Console.WriteLine(x % y);
    //       Console.WriteLine((float)x / (float)y);
    //       Console.WriteLine(x > y);
    //       Console.WriteLine(x < y);
    //       Console.WriteLine(x == y);
    //       Console.WriteLine(x != y);
    //       Console.WriteLine(!(x != y)); // with ! before the expression, we are negating it (It is false that x is not equal to y)
    //       Console.WriteLine(x < y && x < z);
    //       Console.WriteLine(x > y || x < z);

    //       Multiline comment ends*/

    //      //  var x = true;

    //       // var y = false;

    //       // var z = true && false;
    //       // Console.WriteLine(z);

//    Person mosh = new Person(); //classic way to instantiate an object (not simplified)
//    mosh.FirstName = "Mosh";
//            mosh.LastName = "Hamedani";
//            mosh.Introduce();

//            var rich = new Person(); //one more way to instantiate an object
//    rich.FirstName = "Richard";
//            rich.LastName = "Bleyer";
//            rich.Introduce();

//            var gab = new Person //another way to instantiate an object
//            {
//                FirstName = "Gabriel",
//                LastName = "Duarte"
//            };
//    gab.Introduce();

//            var plainSum = new Calculator(); //instantiating the Calculator class from the Math namespace
//    plainSum.x = 10;
//            plainSum.y = 20;
//            plainSum.z = 30;
//            plainSum.SumPlainValues();


//            var addThreeValues = new Calculator(); //instantiating another Calculator object in a 'better way'
//    var threeValuesResult = addThreeValues.Add(40, 50, 60);
//    Console.WriteLine("The sum of the three values, in a 'better' logic is equal to " + threeValuesResult);

//            var showCorollaCar = new Car
//            { //instantiating the Car class from the Vehicles namespace
//                Make = "Toyota",
//                Model = "Corolla",
//                Year = 2020
//            };
//    showCorollaCar.ShowCar();

//            //array example 1
//            var numbers = new int[3] { 1, 2, 3 };
//    Console.WriteLine(numbers[1]); //prints the second position of the array (2)

//            //array example 2
//            var flags = new[] { "US", "UK", "FR", "DE" }; //type inferred array
//    Console.WriteLine(flags[3]);

//            //array example 3
//            var people = new[] { "Mosh", "Gab", "Rich" };
//    Console.WriteLine(people[0]);

//            //let's play with strings

//            //var aNumber = 1;
//            var firstName = "Matheus"; //equals to string firstName = "Matheus";
//    String lastName = "Duarte"; //also equals to string/var lastName = "Duarte";
//    var fullName = firstName + " " + lastName; //string concatenation... this is not the best way to do it
//    Console.WriteLine(fullName);
//            var interpolatedFullName = $"My brother's full name is {firstName} {lastName}."; //string interpolation... this is better way to visualize it
//    Console.WriteLine(interpolatedFullName);
//            var myBrotherFullName = string.Format("My brother's full name is {0} {1}.", firstName, lastName); //another way to format strings
//    Console.WriteLine(myBrotherFullName);

//            //remember the flags array? Let's use it here
//            var formattedFlags = string.Join(",", flags); //joining all the array elements into a single string, this is useful for CSV files for example
//    Console.WriteLine(formattedFlags);

//            var textZ = "Hi there, reader \nThis is a new line. \n\tThis is a tab. And to find a file, you can look into the following folder: \nc:\\folder1\\folder2"; //escape sequences
//    Console.WriteLine(textZ);

//            //Very hard to read, right? So let's use verbatim strings
//            var verbatimText = @"Hi there, reader
//This is a new line
//    This is a tab and new line as you can see. And to find a file, you can look into the following folder:
//c:\folder1\folder2";
//    Console.WriteLine(verbatimText);


    //    }
    //}

}
