using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            BookStore bookStore = new BookStore();

            Book book1 = new Book("Dracula", 15f, 5, "Bram Stokker");
            Book book2 = new Book("Joe Speedbot", 12.50f, 3, "Tommy Wirenga");
            Magazine magazine1 = new Magazine("Time", 3.90f, 10, DayOfWeek.Friday);
            Magazine magazine2 = new Magazine("Donald Duck", 2.50f, 15, DayOfWeek.Thursday);
            CD cD = new CD("Title", 3.90f, 5, "Seventeen Seconds");

            bookStore.Add(book1);
            bookStore.Add(book2);
            bookStore.Add(magazine1);
            bookStore.Add(magazine2);
            bookStore.Add(cD);

            bookStore.PrintAllItems();

            Console.ReadKey();
        }
    }
}
