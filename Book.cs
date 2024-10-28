using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : LibraryItem
    {
        public BookGenre Genre { get; set; }
        public LibraryLocation Location { get; set; }

        public Book(string title, int publicationYear, BookGenre genre, LibraryLocation location) : base(title, publicationYear)
        {
            Genre = genre;
            Location = location;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Genre: {Genre}, Year: {PublicationYear}, Location: Aisle {Location.Aisle}, Shelf {Location.Shelf}");
        }
    }
}
