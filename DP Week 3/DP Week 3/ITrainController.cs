using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week_3
{
    public interface ITrainController
    {
        //
        void NextStation();
        //
        void CreateNew(ITrainDisplay trainDisplay);
    }
}
