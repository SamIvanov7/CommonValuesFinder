using System;

namespace SolarPowerEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            var commonValues = CommonValues.FindCommonValues(array1, array2);

            Console.WriteLine("Common values in both arrays:");
            foreach (var value in commonValues)
            {
                Console.WriteLine(value);
            }
        }
    }
}
