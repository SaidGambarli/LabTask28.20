namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
            {

            var librarian = new Librarian("Alice", DateTime.Now);
            var member = new LibraryMember("Bob", DateTime.Now);

            var location = new LibraryLocation(1, 2);
            var book = new Book("The Great Gatsby", 1925, BookGenre.Fiction, location);
            var magazine = new Magazine("Time", 2022);
            var dvd = new DVD("Inception", 2010);

            var catalog = new LibraryCatalog();
            catalog.AddItem(1001, book);
            catalog.AddItem(1002, magazine);
            catalog.AddItem(1003, dvd);

            try
            {
                var retrievedBook = catalog[1001];
                retrievedBook.DisplayInfo();
                Console.WriteLine($"Age of the book: {retrievedBook.CalculateAge()} years");
                Console.WriteLine($"Title in title case: {retrievedBook.ToTitleCase()}");
            }
            catch (CustomBookError ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
       
    }
}
