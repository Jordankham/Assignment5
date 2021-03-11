using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Infrastructure;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment5.Pages
{
    public class BuyModel : PageModel
    {
        private IBookRepository repository;
        //Constructor
        public BuyModel(IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            
        }


        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Bookstore bookstore = repository.Bookstores.FirstOrDefault(b => b.BookID == bookId);

            

            Cart.AddItem(bookstore, 1);

           

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Bookstore bookstore = repository.Bookstores.FirstOrDefault(b => b.BookID == bookId);

          

            Cart.RemoveLine(bookstore);

           

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
