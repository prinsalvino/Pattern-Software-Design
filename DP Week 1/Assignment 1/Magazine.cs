using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Magazine : BookStoreItem
    {
        string Title { get; set; }
        float Price { get; set; }
        int NumberOfItems { get; set; }
        DayOfWeek Releaseday { get; set; }
        public Magazine(string title, float price, int nrofitems, DayOfWeek releaseday) : base(title, price, nrofitems)
        {
            Title = title;
            Price = price;
            NumberOfItems = nrofitems;
            Releaseday = releaseday;
        }
        public override string ToString()
        {
            return string.Format($"[Magazine] {Title} - {Releaseday}, {Price} ({NumberOfItems}x)");
        }
    }
}
