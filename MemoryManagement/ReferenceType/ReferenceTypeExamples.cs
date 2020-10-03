using System;

namespace MemoryManagement.ReferenceType
{
    public static class ReferenceTypeExamples
    {
        public static void Copying()
        {
            Console.WriteLine("ReferenceTypeExamples - Copying");
            // Reference types variables contain pointers to the real data. The real data is always stored in the heap.
            // Reference types are: class, interface, delegate, string, object, dynamic, arrays

            Person person;
            // When a reference type variable is created, no space is allocated in the heap at all.
            // This variable stays in the stack and it starts as undefined.

            new Person();
            // The new keyword is responsible for allocating the necessay space in the heap for the reference type data.
            // When a Person object is instatiated, enough space in the heap is allocated to store all of it, including
            // its instance variables (Email and IsOldEnoughToDrink).
            // The Person class defines a bool instance variable called IsOldEnoughToDrink. Booleans are Value types
            // so they are usually stored in the stack, unless they are instance variables, like in this case.

            person = new Person();
            // When a reference type variable is assigned with value, it actually stores its address in memory.
            // So it is just a pointer to the real data.

            person.Email = "myemail@email.co";
            person.IsOldEnoughToDrink = true;
            Console.WriteLine(person.ToString());
            Console.WriteLine();

            var person2 = person;
            Console.WriteLine($"person: {person}");
            Console.WriteLine($"person2: {person2}");
            person2.Email = "aaa@aaa.aaa";
            Console.WriteLine($"person: {person}");
            Console.WriteLine($"person2: {person2}");
            // When a Reference type variable is assigned to another, the data itself is not copied, only the address in memory.
            // So, the two Reference type variables hold references to the same object.
        }
    }
}