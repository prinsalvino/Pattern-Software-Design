using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class HPLaptop : Laptop
    {
        public HPLaptop(string name)
        {
            Processor = new AMD();
        }

     
    }
}
