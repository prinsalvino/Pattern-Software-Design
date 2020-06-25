using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Superman : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Superman is flying...");
        }

        public void Land()
        {
            Console.WriteLine("Superman is landing...");
        }

        public void LiftOff()
        {
            Console.WriteLine("Superman is lifting off...");
        }
    }
}
