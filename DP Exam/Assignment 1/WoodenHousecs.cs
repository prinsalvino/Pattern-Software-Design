using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class WoodenHouse : BaseHouse
    {
        public override void BuildRoof()
        {
            Console.WriteLine("Building Wooden Roof...");
        }

        public override void BuildWalls()
        {
            Console.WriteLine("Building Wooden Walls...");
        }
    }
}
