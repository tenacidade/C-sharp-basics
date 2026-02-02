namespace C_sharp_basics
{
  
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("Hi, I'm " + FirstName + " " + LastName);
        }
    }
}
