namespace GA_Constructors_Mikal
{
    // Mikal Johnson
    // Constructors purpose is to create and initialize
    // objects. It ensure that it is setup properly

    internal class Program
    {
        static void Main(string[] args)
        {
            // Book newBook = new Book(); // <--- This is a default constructor
            Book bookAuthorAndName = new Book("Night Watch", "Terry Pratchett");
            Book bookNameOnly = new Book("Wyrd Sisters");

            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("The Hobbit");

            Console.WriteLine(book1);
        }
    }
}