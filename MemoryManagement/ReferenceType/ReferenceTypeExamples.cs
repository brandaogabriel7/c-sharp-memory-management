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
            Console.WriteLine($"\tperson: {person}");
            Console.WriteLine($"\tperson2: {person2}");
            person2.Email = "aaa@aaa.aaa";
            Console.WriteLine($"\tperson: {person}");
            Console.WriteLine($"\tperson2: {person2}");
            // When a Reference type variable is assigned to another, the data itself is not copied, only the address in memory.
            // So, the two Reference type variables hold references to the same object.
        }

        public static void PassingParametersByValue()
        {
            Console.WriteLine("ReferenceTypeExamples - PassingParametersByValue");
            var person = new Person("aaa@aaa.com", false);
            Console.WriteLine($"\tperson: {person}");
            TurnEighteen(person);
            Console.WriteLine($"\tperson: {person}");
            // What happens in this case is that the person variable doesn't store the person itself, it stores
            // a reference to it. This way, the person parameter of the TurnEighteen method receives a copy of the
            // address for the Person object. So, both the local person variable and the parameter person point to
            // the same object in the heap. That's why, even though the parameter is passed by value, the method is
            // still able to change the same object that the local variable references.
        }

        public static void PassingParametersByReference()
        {
            Console.WriteLine("ReferenceTypeExamples - PassingParametersByReference");
            var person = new Person("eu@opa.com", false);
            Console.WriteLine($"\tperson: {person}");
            TurnEighteenByRef(ref person);
            if (!(person is null))
            {
                Console.WriteLine($"\tperson: {person}");
            }
            else
            {
                Console.WriteLine("NullReference");
            }
            // When a reference type is passed as a parameter by reference, the pointer is not just copied, the pointer
            // inside the method is the same. Because of that, setting the reference variable to null inside the method
            // does the same outside.

            Console.WriteLine();
            GetAnEmailByOut(out person); // I know it is null but out parameters don't need to be initialized.
            Console.WriteLine($"\tperson: {person}");

            Console.WriteLine();
            TurnEighteenByIn(person); // in keyword is optional here
            Console.WriteLine($"\tperson: {person}");
        }

        private static void TurnEighteen(Person person)
        {
            Console.WriteLine($"\tTurnEighteen - person: {person}");
            person.IsOldEnoughToDrink = true;
            Console.WriteLine($"\tTurnEighteen - person: {person}");
        }

        private static void TurnEighteenByRef(ref Person person)
        {
            Console.WriteLine($"\tTurnEighteenByRef - person: {person}");
            person.IsOldEnoughToDrink = true;
            Console.WriteLine($"\tTurnEighteenByRef - person: {person}");
            person = null;
        }

        private static void GetAnEmailByOut(out Person person)
        {
            person = new Person();
            person.Email = "anemail@aaa.net";
            Console.WriteLine($"\tGetAnEmailByOut - person: {person}");
        }

        private static void TurnEighteenByIn(in Person person)
        {
            Console.WriteLine($"\tTurnEighteenByIn - person: {person}");
            var newPerson = new Person(person.Email, person.IsOldEnoughToDrink);
            Console.WriteLine($"\tTurnEighteenByIn - newPerson: {newPerson}");
            newPerson.IsOldEnoughToDrink = true;
            Console.WriteLine($"\tTurnEighteenByIn - person: {person}");
            Console.WriteLine($"\tTurnEighteenByIn - newPerson: {newPerson}");
        }
    }
}