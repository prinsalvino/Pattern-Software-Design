using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week_3
{
    class TrainJourney : ITrainJourney
    {
        List<Station> stations;
        public Station currentstation;
        List<ITrainDisplay> trainDisplays = new List<ITrainDisplay>();
        int index;
        public TrainJourney()
        {
            stations = new List<Station>();
            AddStation();           
        }

        public void AddObserver(ITrainDisplay traindisplay)
        {
            trainDisplays.Add(traindisplay);
            UpdateObserver();
        }

        public void RemoveObserver(ITrainDisplay traindisplay)
        {
            trainDisplays.Remove(traindisplay);
        }

        private void UpdateObserver()
        {
            foreach (ITrainDisplay train in trainDisplays)
            {
                train.Update(currentstation);
            }
        }
        private void AddStation()
        {
            index = 0;
            Station Amsterdam = new Station("Amsterdam","1A",DateTime.Parse("12:35"), DateTime.Parse("13:00"));
            Station Nijmegen = new Station("Nijmegen","2A", DateTime.Parse("13:35"), DateTime.Parse("14:00"));
            Station Rotterdam = new Station("Rotterdam", "3A", DateTime.Parse("14:55"), DateTime.Parse("15:00"));

            stations.Add(Amsterdam);
            stations.Add(Nijmegen);
            stations.Add(Rotterdam);

            currentstation = stations[index];
           // UpdateObserver();
     
        }
        public void NextStation()
        {
            if (index == stations.Count)
            {
                index--;
            }
            else if (index < stations.Count)
            {
                index++;
            }
                 
            currentstation = stations[index];
            UpdateObserver();
        }
    
    }
}
