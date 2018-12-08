using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8._0Features
{
    class RangesAndIndices
    {
        internal static void Example()
        {
            foreach(var fruit in GetFruits())
            {
                Console.WriteLine(fruit);
            }
        }

        private static IEnumerable<object> GetFruits()
        {
            var range = 1..2;
            string[] fruits = { "Apple", "Banana", "Orange", "Mango" };
            foreach(var fruit in fruits[range])
            {
                yield return fruit;
            }
        }
    }
}
