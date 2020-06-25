using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static 
        void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
            Console.ReadKey();
        }
        void Start()
        {
            PrintHeader("[Wooden House]");
            BaseHouse house1 = new WoodenHouse();
            house1.BuildHouse();

            PrintHeader("[Glass House]");
            BaseHouse house2 = new GlassHouse();
            house2.BuildHouse();

            PrintHeader("[Concrete House]");
            BaseHouse house3 = new ConcreteHouse();
            house3.BuildHouse();            
        }
        void PrintHeader(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name);
            Console.ResetColor();
        }
    }
}
