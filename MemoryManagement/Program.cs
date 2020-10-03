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
            Console.WriteLine();
            ValueTypeExamples.PassingParametersByValue();
            Console.WriteLine();
            ReferenceTypeExamples.PassingParametersByValue();

            // Parameters passed by reference use the exact same storage location for the parameter values.
            // This way, the values are the same in and out of the method.
            // When we want to pass parameters by reference, they can of three types:
            // ref parameters: these need to be initialized before the method call. They are like in and out parameters.
            // out parameters: these don't need to be initialized as their values won't be used at all if they are already initialized.
            // in parameters: these need to be initialized and cannot be altered by the method at all.
            // (Why would we need in parameters? Performance reasons. I won't too much in depth here.)
            Console.WriteLine();
            ValueTypeExamples.PassingParametersByReference();
            // Console.WriteLine();
            // ReferenceTypeExamples.PassingParametersByReference();
        }
    }
}
