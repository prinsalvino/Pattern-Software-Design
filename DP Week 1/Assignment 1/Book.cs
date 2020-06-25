using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Book : BookStoreItem
    {
        string Author { get; set; }
        public Book(string title, float price, int nrofitems, string author) : base(title,price,nrofitems)
        {
            Author = author;
        }
        public override string ToString()
        {
            return string.Format($"[Book] {Author} - {Title}, {Price} ({NumberOfItems}x)");
        } 
    }
}
