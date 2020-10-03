namespace MemoryManagement.ReferenceType
{
    public class Person
    {
        public string Email;
        public bool IsOldEnoughToDrink;

        public override string ToString()
        {
            return $"Email: {Email}, IsOldEnoughToDrink: {IsOldEnoughToDrink}";
        }
    }
}