using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ConcreteHouse : BaseHouse
    {
        public override void BuildRoof()
        {
            Console.WriteLine("Building Concrete Roof...");

        }

        public override void BuildWalls()
        {
            Console.WriteLine("Building Concrete Walls...");
        }
    }
}
