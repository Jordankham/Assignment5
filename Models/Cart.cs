using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Bookstore book, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Bookstore.BookID == book.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Bookstore = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public void RemoveLine(Bookstore book) =>
            Lines.RemoveAll(x => x.Bookstore.BookID == book.BookID);

        public void Clear() => Lines.Clear();

        public double ComputeTotalSum() => Lines.Sum(e => e.Bookstore.Price * e.Quantity);

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Bookstore Bookstore { get; set; }
            public int Quantity { get; set; }
        }

    }
}
