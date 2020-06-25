using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class Payment
    {
        void EnterInfo()
        {
            Console.WriteLine("Entering information...");
        }
        public abstract void Process();
        void Confirm()
        {
            Console.WriteLine("Sending Confirmation Mail...");
        }
        public void Execute()
        {
            EnterInfo();
            Process();
            Confirm();
        }
    }
}
