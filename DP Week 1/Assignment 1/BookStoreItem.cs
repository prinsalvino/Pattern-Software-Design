using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class BookStoreItem
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int NumberOfItems { get; set; }
        public BookStoreItem(string title, float price, int nrofitems)
        {
            Title = title;
            Price = price;
            NumberOfItems = nrofitems;
        }
    }
}
