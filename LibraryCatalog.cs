using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class CustomBookError : Exception
    {
        public CustomBookError(string message) : base(message) { }
    }

    public class LibraryCatalog
    {
        private Hashtable _catalog = new Hashtable();

        public LibraryItem this[int id]
        {
            get
            {
                if (_catalog.ContainsKey(id))
                {
                    return (LibraryItem)_catalog[id];
                }
                throw new CustomBookError("Book with ID " + id + "Katalogda tapilmadi");
            }
            set { _catalog[id] = value; }
        }

        internal void AddItem(int v, Book book)
        {
            throw new NotImplementedException();
        }

        internal void AddItem(int v, DVD dvd)
        {
            throw new NotImplementedException();
        }

        internal void AddItem(int v, Magazine magazine)
        {
            throw new NotImplementedException();
        }
    }
}
