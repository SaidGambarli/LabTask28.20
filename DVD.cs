using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class DVD : LibraryItem
    {
        private static int publicationYear;

        public int Duration { get; set; }

        public DVD(string title, int publictionYear, int duration) : base(title, publicationYear) 
        {
            Duration = duration;
        }

        public DVD(string title, int publicationYear) : base(title, publicationYear)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Duration: {Duration} min, Year: {PublicationYear}");
        }
    }
}
