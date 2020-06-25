using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week_3
{
    public class Station
    {
        string name, arrivaltrack;
        DateTime arrivaltime,departuretime;
        public Station(string name, string arrivaltrack, DateTime atime, DateTime dtime)
        {
            this.name = name;
            this.arrivaltrack = arrivaltrack;
            this.arrivaltime = atime;
            this.departuretime = dtime;
        }
        public string Name { get { return name; } }
        public string Arrivaltrack { get { return arrivaltrack; } }
        public DateTime Arrivaltime { get { return arrivaltime; } }
        public DateTime Departuretime { get { return departuretime; } }

    }
}
