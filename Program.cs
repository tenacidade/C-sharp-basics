namespace C_sharp_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! These are my first steps with C# into .NET");

            // Data types and variables

            var number = 12;
            var count = 29;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Gabriel";
            var isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine();

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //this shows us the range of a byte
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); //this show us the range of a float

            const float Pi = 3.14f;
            Console.WriteLine(Pi);


        }
    }
}
