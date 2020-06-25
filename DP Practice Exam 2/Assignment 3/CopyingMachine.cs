using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class CopyingMachine
    {
        static CopyingMachine copyingMachine;
        int totalnumberofcopies;
        public int Totalnumberofcopies { get { return totalnumberofcopies; } set { totalnumberofcopies = value; } }
        private CopyingMachine()
        {

        }
        public static CopyingMachine GetMachine()
        {
            if (copyingMachine == null)
            {
                copyingMachine = new CopyingMachine();
            }
            return copyingMachine;
        }
        public void Copy(int number)
        {
            Console.WriteLine($"Copying, {number}x");
            Totalnumberofcopies += number;
            Console.WriteLine($"total number of copies = {Totalnumberofcopies}x");

        }
    }
}
