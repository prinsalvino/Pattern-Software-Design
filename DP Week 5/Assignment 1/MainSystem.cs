using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class MainSystem
    {
        Logger logger = Logger.GetInstance();
        SubSystem subSystem;
        public MainSystem()
        {
            subSystem = new SubSystem();
        }
 
        public void DoSomeMainWork()
        {
            logger.Log("Main System", "doing some main work");
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }
    }
}
