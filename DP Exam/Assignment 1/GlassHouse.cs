using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class GlassHouse : BaseHouse
    {
        public override void BuildRoof()
        {
            Console.WriteLine("Building Glass Roof...");
        }

        public override void BuildWalls()
        {
            Console.WriteLine("Building Glass Walls...");
        }
    }
}
