using System;
using System.Collections.Generic;
using System.Linq;

namespace SolarPowerEngineering
{
    public static class CommonValues
    {
        public static IEnumerable<int> FindCommonValues(int[] array1, int[] array2)
        {
            return array1.Intersect(array2);
        }
    }
}
