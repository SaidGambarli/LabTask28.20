using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Librarian : Person
    {
        //HireDate(Ise goturulme tarixi)
        public DateTime HireDate { get; set; }

        public Librarian(string name, DateTime hireDate) : base(name) 
        {
            HireDate = hireDate;
        }
    }
}
