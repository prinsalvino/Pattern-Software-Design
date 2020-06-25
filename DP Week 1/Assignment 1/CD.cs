using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class CD : BookStoreItem
    {
        string Artist { get; set; }
        public CD(string title, float price, int nrofitems, string artist) : base(title, price, nrofitems)
        {
            Artist = artist;
        }
        public override string ToString()
        {
            return string.Format($"[CD] {Artist} - {Title}, {Price} ({NumberOfItems}x)");
        }
    }
}
