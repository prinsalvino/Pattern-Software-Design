using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week_3
{
    public interface ITrainJourney
    {
        void AddObserver(ITrainDisplay traindisplay);
        void RemoveObserver(ITrainDisplay traindisplay);
        void NextStation();
    }
}
