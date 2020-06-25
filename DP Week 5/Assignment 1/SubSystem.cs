using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class SubSystem
    {
        Logger logger = Logger.GetInstance();
        public SubSystem()
        {

        }
        public void DoSomeWork()
        {
            logger.Log("Sub System", "doing some work");

        }
        public void DoSomeMoreWork()
        {
            logger.Log("Sub System", "doing some more work");

        }

    }
}
