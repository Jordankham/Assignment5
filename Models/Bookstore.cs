using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Bookstore
    {
        [Required]
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFname { get; set; }
        [Required]
        public string AuthorLname { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]

        [RegularExpression(@"^(?=(?:\D*\d){3}(?:(?:\D*\d){10})?$)[\d-]+$",
            ErrorMessage ="ISBN is not in the required format of ###-##########")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
