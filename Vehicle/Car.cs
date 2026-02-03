namespace C_sharp_basics.Vehicle
{
    public struct Car
    //this is a structure, not a class
    //it's good to use when you have a small group of related variables
    //structs are generally faster than classes
    //structs are useful for small data structures like points, rectangles, etc.
    {
        public string Make;
        public string Model;
        public int Year;
        public void ShowCar()
        {
            Console.WriteLine("This is a " + Make + " " + Model + " from " + Year);
        }
    }
}
