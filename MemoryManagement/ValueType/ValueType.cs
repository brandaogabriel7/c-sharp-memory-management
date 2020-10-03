using System;

namespace MemoryManagement.ValueType
{
    public static class ValueTypeExamples
    {
        public static void Copying()
        {
            Console.WriteLine("ValueTypeExamples - Copying");
            // Value types (also known as primitive types) holds its own data.
            // These are value types: int, long, uint, ulong, ushort, double, float, decimal, enum and struct.

            //When you assign a value type variable to another, the value is copied directly.

            var firstInteger = 7;
            var secondInteger = firstInteger;
            Console.WriteLine($"firstInteger: {firstInteger}");
            Console.WriteLine($"secondInteger: {secondInteger}");
            // Both variables hold the same value (7).

            firstInteger++;
            Console.WriteLine($"firstInteger: {firstInteger}");
            Console.WriteLine($"secondInteger: {secondInteger}");
            // When the firstInteger value changes, the second integer value does not.
        }
    }
}