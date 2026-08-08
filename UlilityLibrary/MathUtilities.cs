using System.Diagnostics.CodeAnalysis;

namespace UlilityLibrary
{
    public class MathUtilities
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double AddDouble(double a, double b)
        { 
            return a + b; 
        }

        public int AddTriple(int a, int b, int c)
        { 
            return a + b + c; 
        }

        public double Average(params int[] numbers)
        {
            int suma = 0;
            foreach (int number in numbers)
            {
                suma += number;
            }
            return suma/numbers.Length;
        }
    }
}
