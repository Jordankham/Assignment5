using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class BookstoreDBContext : DbContext
    {
        public BookstoreDBContext (DbContextOptions<BookstoreDBContext> options) : base (options)
        {

        }

        public DbSet<Bookstore> Bookstores { get; set; }
    }
}
