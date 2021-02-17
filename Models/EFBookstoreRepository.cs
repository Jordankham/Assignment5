using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFBookstoreRepository : IBookRepository
    {
        private BookstoreDBContext _context;

        //Constructor
        public EFBookstoreRepository (BookstoreDBContext context)
        {
            _context = context;
        }
        public IQueryable<Bookstore> Bookstores => _context.Bookstores;
    }
}
