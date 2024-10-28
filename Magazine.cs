using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Magazine : LibraryItem
    {
        public string Issue {  get; set; }

        public Magazine(string title, int publictionYear, string issue) : base(title, publictionYear) 
        {
            Issue = issue;
        }

        public Magazine(string title, int publicationYear) : base(title, publicationYear)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Issue: {Issue}, Year: {PublicationYear}");
        }
    }
}
