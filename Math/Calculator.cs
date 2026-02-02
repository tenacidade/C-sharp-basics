using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_basics.Math
{
    public class Calculator //make it public so you can access it from other namespaces
    {
        public int x; 
        public int y; 
        public int z;

        public void SumPlainValues() //method to sum the values of a, b and c that I've created
        {
            Console.WriteLine("The sum of the values is equal to: "+ (x + y + z));
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
