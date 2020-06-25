using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Airplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Airplane is flying...");
        }

        public void Land()
        {
            Console.WriteLine("Airplane is landing...");
        }

        public void LiftOff()
        {
            Console.WriteLine("Airplane is lifting off...");
        }
    }
}
