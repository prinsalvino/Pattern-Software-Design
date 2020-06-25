using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class BaseHouse
    {
        void BuildFoundation()
        {
            Console.WriteLine("Building foundation...");
        }
        public abstract void BuildWalls();
        public abstract void BuildRoof();
        void PlaceWindows()
        {
            Console.WriteLine("Placing windows...");
        }
        public void BuildHouse()
        {
            BuildFoundation();
            BuildWalls();
            BuildRoof();
            PlaceWindows();
        }
    }
}
