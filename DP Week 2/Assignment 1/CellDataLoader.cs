using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class CellDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting cell data");
        }

        public override void Load()
        {
            Console.WriteLine("Loading cell data");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming cell data");
        }
    }
}
