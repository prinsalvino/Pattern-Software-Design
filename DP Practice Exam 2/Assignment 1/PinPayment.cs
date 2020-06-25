using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class PINPayment : Payment
    {
        public override void Process()
        {
            Console.WriteLine("Processing PIN Payment...");
        }
    }
}
