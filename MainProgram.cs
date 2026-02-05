using C_sharp_basics.Math; //importing the Math namespace to use the Calculator class
using C_sharp_basics.Vehicle; //importing the Vehicle namespace to use the Car struct

namespace C_sharp_basics
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            //see the diference between value types and reference types:
            var a = 10; //a is a value type (int);
            var b = a; //b is a copy of a, they are two different variables in memory
            b++; //incrementing b does not affect a, because they are two different variables in memory
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //a: 10, b: 11
            var c = b++; //c is a copy of b, but b is incremented after the assignment, so c is 11 and b is 12
            Console.WriteLine(string.Format("b: {0}, c: {1}", b, c)); //b: 12, c: 11

            var array1 = new int[3] { 1, 2, 3 }; //array1 is a reference type (array);
            var array2 = array1; //array2 is a reference to the same array in memory as array1, they are not two different variables in memory
            Console.WriteLine(array2[0]); //1
            array2[0] = 0; //modifying array2 also modifies array1, because they are references to the same array in memory
            Console.WriteLine(array1[0]); //0

            //have you ever heard of enums? Let's see how they work:

            var shippingMethod = ShippingMethod.Express; //using the ShippingMethod enum
            Console.WriteLine((int)shippingMethod); //using casting to get the integer value of the enum (3 in this case)
            //very useful when you want to store the enum value in a database for example: 
            //you can store the integer value and then cast it back to the enum when you retrieve it from the database, see:
            var methodId = 3; //imagine this value comes from a database
            Console.WriteLine((ShippingMethod)methodId); //casting the integer value back to the enum

        }

        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }
    }
}
