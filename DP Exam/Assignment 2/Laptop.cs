using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    abstract class Laptop : IProcessor
    {
        public IProcessor Processor { get; set; }
        public Laptop()
        {

        }
        public void Execute(string v)
        {
            Processor.Execute(v);
        }
      
    }
}
