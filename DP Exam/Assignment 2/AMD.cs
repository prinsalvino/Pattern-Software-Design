using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class AMD : IProcessor
    {
        public void Execute(string v)
        {
            Console.WriteLine($"Executing program '{v}' with processor AMD Ryzen 3");
        }
    }
}
