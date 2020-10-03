namespace MemoryManagement.ReferenceType
{
    public class Person
    {
        public Person() { }

        public Person(string email, bool isOldEnoughToDrink)
        {
            Email = email;
            IsOldEnoughToDrink = isOldEnoughToDrink;
        }

        public string Email;
        public bool IsOldEnoughToDrink;

        public override string ToString()
        {
            return $"Email: {Email}, IsOldEnoughToDrink: {IsOldEnoughToDrink}";
        }
    }
}