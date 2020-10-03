using System;

namespace MemoryManagement.ValueType
{
    public static class ValueTypeExamples
    {
        public static void Copying()
        {
            Console.WriteLine("ValueTypeExamples - Copying");
            // Value types (also known as primitive types) holds its own data. They are usually stored in the stack.
            // Except when they are instance variables of a class.
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

        public static void PassingParametersByValue()
        {
            Console.WriteLine($"ValueTypeExamples: PassingParametersByValue");
            var number = 7d;
            Console.WriteLine($"number: {number}");
            Square(number);
            Console.WriteLine($"number: {number}");
            // When number is passed as a parameter to the Square method, the value is only copied.
            // The number variable inside the Square method scope is only a copy of the original number,
            // so local number variable value doesn't change at all.
        }

        private static void Square(double number)
        {
            Console.WriteLine($"Square method - number: {number}");
            number = Math.Pow(number, 2);
            Console.WriteLine($"Square method - number: {number}");
        }
    }
}