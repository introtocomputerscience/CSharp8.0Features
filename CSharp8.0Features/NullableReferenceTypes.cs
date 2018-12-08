using System;

namespace CSharp8._0Features
{
    class NullableReferenceTypes
    {
        internal static void Example()
        {
            string? s = null;
            if (s != null) Console.WriteLine($"The first letter of {s} is {s[0]}");

            Console.WriteLine($"The first letter of {s} is {s?[0] ?? null}");
        }
    }
}
