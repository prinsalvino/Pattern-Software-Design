using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BookStore
    {
        private List<BookStoreItem> bookStores;
        public BookStore()
        {
            bookStores = new List<BookStoreItem>();
        }
        public void Add(BookStoreItem b)
        {
            bookStores.Add(b);
        }
        public void PrintAllItems()
        {
            foreach (BookStoreItem item in bookStores)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
