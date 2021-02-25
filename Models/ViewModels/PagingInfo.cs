using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models.ViewModels
{
    //setting up the class for page info for dynamically creating links to the number of pages 
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage {get;set;}
        public int CurrentPage { get; set; }
        public int TotalPages => (int) (Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));

    }
}
