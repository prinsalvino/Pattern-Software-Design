using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week_3
{
    class TrainController : ITrainController
    {
        ITrainJourney trainJourney;
        public TrainController(ITrainJourney trainJourney)
        {
            this.trainJourney = trainJourney;
        }

        public void CreateNew(ITrainDisplay trainDisplay)
        {
            trainJourney.AddObserver(trainDisplay);
        }

        public void NextStation()
        {
            trainJourney.NextStation();
        }
    }
}
