using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class BigDataLoader
    {
        public void ETL()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL Process-Started]");
            Console.ResetColor();
            Extract();
            Transform();
            Load();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("[ETL Process-Finished]");
            Console.ResetColor();

            Console.WriteLine();
        }
        public abstract void Extract();

        public abstract void Transform();

        public abstract void Load();
    
    }
}
