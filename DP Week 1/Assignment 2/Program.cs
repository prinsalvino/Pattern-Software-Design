using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
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
            IFlyable s = new Superman();
            IFlyable a = new Airplane();

            MakeFlight(s);
            Console.WriteLine();
            MakeFlight(a);
            Console.ReadKey();

        }
        void MakeFlight(IFlyable flying)
        {
            flying.LiftOff();
            flying.Fly();
            flying.Fly();
            flying.Fly();
            flying.Land();

        }
    }
}
