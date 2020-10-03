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
            Console.WriteLine($"\tfirstInteger: {firstInteger}");
            Console.WriteLine($"\tsecondInteger: {secondInteger}");
            // Both variables hold the same value (7).

            firstInteger++;
            Console.WriteLine($"\tfirstInteger: {firstInteger}");
            Console.WriteLine($"\tsecondInteger: {secondInteger}");
            // When the firstInteger value changes, the second integer value does not.
        }

        public static void PassingParametersByValue()
        {
            Console.WriteLine("ValueTypeExamples: PassingParametersByValue");
            var number = 7d;
            Console.WriteLine($"\tnumber: {number}");
            Square(number);
            Console.WriteLine($"\tnumber: {number}");
            // When number is passed as a parameter to the Square method, the value is only copied.
            // The number variable inside the Square method scope is only a copy of the original number,
            // so local number variable value doesn't change at all.
        }

        public static void PassingParametersByReference()
        {
            Console.WriteLine("ValueTypeExamples: PassingParametersByReference");
            var number = 7d;
            // Must be initialized.
            Console.WriteLine($"\tnumber: {number}");
            SquareByRef(ref number);
            Console.WriteLine($"\tnumber: {number}");

            Console.WriteLine();
            // It could be initialized but it wouldn't make any difference.
            GetPiOut(out var pi);
            Console.WriteLine($"\tpi: {pi}");

            Console.WriteLine();
            number = 7d;
            Console.WriteLine($"\tnumber: {number}");
            // The value cannot be altered by the method.
            SquareByIn(in number); // in keyword is optional here
            Console.WriteLine($"\tnumber: {number}");
        }

        private static void Square(double number)
        {
            Console.WriteLine($"\tSquare method - number: {number}");
            number = Math.Pow(number, 2);
            Console.WriteLine($"\tSquare method - number: {number}");
        }

        private static void SquareByRef(ref double number)
        {
            Console.WriteLine($"\tSquareByRef method - number: {number}");
            number = Math.Pow(number, 2);
            Console.WriteLine($"\tSquareByRef method - number: {number}");
        }

        private static void SquareByIn(in double number)
        {
            Console.WriteLine($"\tSquareByRef method - number: {number}");
            var newNumber = Math.Pow(number, 2);
            Console.WriteLine($"\tSquareByRef method - number: {number}");
            Console.WriteLine($"\tSquareByRef method - newNumber: {newNumber}");
        }

        private static void GetPiOut(out double pi)
        {
            pi = Math.PI;
            Console.WriteLine($"\tGetPiOut method - pi: {pi}");
        }
    }
}