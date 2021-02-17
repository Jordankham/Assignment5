using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookstoreDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookstoreDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Bookstores.Any())
            {
                context.Bookstores.AddRange(
                    new Bookstore
                    { 
                    Title = "Les Miserables",
                    AuthorFname = "Victor",
                    AuthorLname = " Hugo",
                    Publisher = "Signet",
                    ISBN = "978-0451419439",
                    Classification = "Fiction",
                    Category = "Classic",
                    Price = 9.95
                    },

                    new Bookstore
                    {
                        Title = "Team of Rivals",
                        AuthorFname = "Doris Kearns",
                        AuthorLname = " Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58
                    },

                    new Bookstore
                    {
                        Title = "The Snowball",
                        AuthorFname = "Alice",
                        AuthorLname = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54
                    },

                     new Bookstore
                     {
                        Title = "American Ulysses",
                        AuthorFname = "Ronald C.",
                        AuthorLname = " White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61
                      },

                    new Bookstore
                    {
                        Title = "Unbroken",
                        AuthorFname = "Laura",
                        AuthorLname = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = " Non-Fiction", 
                        Category = "Historical",
                        Price = 13.33
                    },

                    new Bookstore
                    {
                        Title = "The Great Robbery",
                        AuthorFname = "Michael",
                        AuthorLname = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95
                    },

                    new Bookstore
                    {
                        Title = "Deep Work",
                        AuthorFname = "Cal",
                        AuthorLname = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction", 
                        Category= "Self-Help",
                        Price = 14.99
                    },

                    new Bookstore
                    {
                        Title = "It's Your Ship",
                        AuthorFname = "Michael",
                        AuthorLname= "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66
                    },

                    new Bookstore
                    {
                        Title = "The Virgin Way",
                        AuthorFname = "Richard",
                        AuthorLname = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction", 
                        Category = "Business",
                        Price = 15.03
                    },

                    new Bookstore
                    {
                        Title = "Sycamore Row",
                        AuthorFname = "John",
                        AuthorLname= "Grisham",
                        Publisher = "Batnam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction", 
                        Category = "Thrillers",
                        Price = 15.03
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
