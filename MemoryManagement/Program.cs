using System;
using MemoryManagement.ValueType;
using MemoryManagement.ReferenceType;

namespace MemoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            ValueTypeExamples.Copying();
            Console.WriteLine();
            ReferenceTypeExamples.Copying();
        }
    }
}
