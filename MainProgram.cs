using C_sharp_basics.Math; //importing the Math namespace to use the Calculator class

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


            var addThreeValues = new Calculator(); //instantiating another Calculator object
            var threeValuesResult = addThreeValues.Add(40, 50, 60);
            Console.WriteLine("The sum of the three values, in a 'better' logic is equal to " + threeValuesResult);

        }
    }
}
