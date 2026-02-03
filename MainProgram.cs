using C_sharp_basics.Math; //importing the Math namespace to use the Calculator class
using C_sharp_basics.Vehicle; //importing the Vehicle namespace to use the Car struct

namespace C_sharp_basics
{
    public class  MainProgram
    {
        static void Main(string[] args)
        {
            Person mosh = new Person(); //classic way to instantiate an object (not simplified)
            mosh.FirstName = "Mosh";
            mosh.LastName = "Hamedani";
            mosh.Introduce();

            var rich = new Person(); //one more way to instantiate an object
            rich.FirstName = "Richard";
            rich.LastName = "Bleyer";
            rich.Introduce();

            var gab = new Person //another way to instantiate an object
            {
                FirstName = "Gabriel",
                LastName = "Duarte"
            }; 
            gab.Introduce();

            var plainSum = new Calculator(); //instantiating the Calculator class from the Math namespace
            plainSum.x = 10;
            plainSum.y = 20;
            plainSum.z = 30;
            plainSum.SumPlainValues();


            var addThreeValues = new Calculator(); //instantiating another Calculator object in a 'better way'
            var threeValuesResult = addThreeValues.Add(40, 50, 60);
            Console.WriteLine("The sum of the three values, in a 'better' logic is equal to " + threeValuesResult);

            var showCorollaCar = new Car { //instantiating the Car class from the Vehicles namespace
                Make = "Toyota",
                Model = "Corolla",
                Year = 2020
            };
            showCorollaCar.ShowCar();

            //array example 1
            var numbers = new int[3] { 1, 2, 3 };
            Console.WriteLine(numbers[1]); //prints the second position of the array (2)

            //array example 2
            var flags = new[] { "US", "UK", "FR", "DE" }; //type inferred array
            Console.WriteLine(flags[3]);

            //array example 3
            var people = new[] { "Mosh", "Gab", "Rich" };
            Console.WriteLine(people[0]);
        }
    }
}
