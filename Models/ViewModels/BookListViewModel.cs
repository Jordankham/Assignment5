using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models.ViewModels
{
    //taking in paginginfo and creating the viewmodel to go with the cshtml page 
    public class BookListViewModel
    {
        public IEnumerable<Bookstore>Bookstores { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
